﻿using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.Data.DataView;
using Microsoft.ML.Data;
using static Microsoft.ML.Transforms.NormalizingEstimator;
using KDP_GUI.DataStructures;
using KDP_GUI.CONTROLLER;
using CsvHelper;

namespace KDP_GUI
{
    
    class ModelPopulation
    {
        private MLContext mlContext;
        private static string pathDataTrain = @"";
        private static string pathDataTest = @"";
        private static string ModelPath = $"C:/Users/userr/source/repos/KDP_GUI/KDP_GUI/KinneretMLmodel.zip";


        public void BuildTrainEvaluateAndSaveModel(MLContext mlContext)
        {
            
        }
        private static ITransformer BuildTrainEvaluteAndSaveModel(MLContext mLContext)
        {
            TextLoader textLoader1 = mLContext.Data.CreateTextLoader(new[]
            {
                new TextLoader.Column("temperature", DataKind.Single, 0),
                new TextLoader.Column("floor1", DataKind.Single, 1),
                new TextLoader.Column("floor2", DataKind.Single, 2),
                new TextLoader.Column("floor3", DataKind.Single, 3),
                new TextLoader.Column("floor4", DataKind.Single, 4),
                new TextLoader.Column("areaEvaluated", DataKind.Single, 5)

            }
            , hasHeader: true,
            separatorChar: ','
            );
            IDataView baseTrainingDataView = textLoader1.Load(pathDataTrain);
            IDataView testDataView = textLoader1.Load(pathDataTest);
            var cnt = baseTrainingDataView.GetColumn<float>(mLContext, "areaEvaluated").Count();
            IDataView trainingDataView = mLContext.Data.FilterRowsByColumn(baseTrainingDataView, "areaEvaluated", lowerBound: 150, upperBound: 350);
            var cnt2 = trainingDataView.GetColumn<float>(mLContext, "areaEvaluated").Count();

            var dataProcessPipeline = mLContext.Transforms.CopyColumns("Label", "areaEvaluated")
                                .Append(mLContext.Transforms.Normalize(outputColumnName: "temperature", inputColumnName: "temperature", mode: NormalizerMode.MeanVariance))
                                .Append(mLContext.Transforms.Normalize(outputColumnName: "floor1", inputColumnName: "floor1", mode: NormalizerMode.MeanVariance))
                                .Append(mLContext.Transforms.Normalize(outputColumnName: "floor2", inputColumnName: "floor2", mode: NormalizerMode.MeanVariance))
                                .Append(mLContext.Transforms.Normalize(outputColumnName: "floor3", inputColumnName: "floor3", mode: NormalizerMode.MeanVariance))
                                .Append(mLContext.Transforms.Normalize(outputColumnName: "floor4", inputColumnName: "floor4", mode: NormalizerMode.MeanVariance))
                                .Append(mLContext.Transforms.Concatenate("Features", "temperature", "floor1", "floor2", "floor3", "floor4")
                                );

            var trainer = mLContext.Regression.Trainers.StochasticDualCoordinateAscent(labelColumnName: "Label", featureColumnName: "Features");
            var trainingPipeline = dataProcessPipeline.Append(trainer);


            MessageBox.Show("Well phase1");
            //System.Console.WriteLine("training the model");
            var trainedModel = trainingPipeline.Fit(trainingDataView);

            //System.Console.WriteLine("Testing model");
            MessageBox.Show("Well phase2");
            IDataView predictions = trainedModel.Transform(testDataView);
            var metrics = mLContext.Regression.Evaluate(predictions, label: "Label", score: "Score");

            using (var fs = File.Create(ModelPath))
                trainedModel.SaveTo(mLContext, fs);

            //System.Console.WriteLine("the model is saved to {0}", ModelPath);
            MessageBox.Show("fin saved");

            return trainedModel;


        }
        public float TestSinglePrediction(float valTemp, float valFloor1, float valFloor2, float valFloor3, float valFloor4)
        {
            //1 hay q definir el MLContext ? cuando se pasa de from a form?
            //hay q decidir como se carga el modelo>?
            var areaCalcSample = new AreaCalc()
            {
                //21,70,58,55,59,167
                temperature = valTemp,
                floor1 = valFloor1,
                floor2 = valFloor2,
                floor3 = valFloor3,
                floor4 = valFloor4,
                areaEvaluated = 0
            };
            ITransformer trainedModel;
            using (var stream = new FileStream(ModelPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                trainedModel = mlContext.Model.Load(stream);
            }

            var predEngine = trainedModel.CreatePredictionEngine<AreaCalc, AreaCalcPrediction>(mlContext);

            var resultprediction = predEngine.Predict(areaCalcSample);
            //System.Console.WriteLine($"+++++Predicted Area population amount {resultprediction.AreaCalcAmount:0}+++ Actual fare: ? +++++++++++++++++++++++++++");
            return (resultprediction.AreaCalcAmount);
        }

        public void AccurateDataFilter()
        {

        }
    }
    class MlPrediction
    {
        public MlPrediction(MLContext myContext)
        {
        }
    }
    public class AreaPredictionCSVReaderGraphRecords
    {

        public void GetDataFromCsv(ModelDs myData, int numMaxRecords)
        {

        }
    }
    public class ModelDs
    {
        private static string pathDataTrain;
        private static string pathDataTest;
        private string[] csvFiles = { pathDataTrain, pathDataTest };

        private static string pathFilesAfterChecked;
        //private static string ModelPath = $"KinneretMLmodel{DateTime.Now:yyyy-MM-dd_hh-mm-ss-fff}.zip";
        private static string BaseModelPath = @".";
        private MLContext myModelContext;

        public ModelDs(string BaseDataSetLocation, string TrainDataPath, string TestDataPath, string BaseModelsPath, string ModelPath)
        {

        }
        public ModelDs(string datatraingPath, string dataTestPath, MLContext myContext)
        {
            pathDataTest = dataTestPath;
            pathDataTrain = datatraingPath;
            myModelContext = myContext;
                

        }
        //temperature,floor1,floor2,floor3,floor4,areaEvaluated
        //https://blog.bitscry.com/2018/01/26/checking-for-csv-column-headers-in-c/

        public Boolean CheckData()
        {

            foreach ( string  file in csvFiles)
            {
                CsvReader csv = new CsvReader(File.OpenText(file));
                csv.Read();
                csv.ReadHeader();
                List<string> headers = csv.Context.HeaderRecord.ToList();
                if (!headers.Exists(x => x == "temperature"))
                {
                    throw new CsvNotReadyException();

                }
                else if (!headers.Exists(x => x == "floor1"))
                {
                    throw new CsvNotReadyException();
                }
                else if (!headers.Exists(x => x == "floor2"))
                {
                    throw new CsvNotReadyException();
                }
                else if (!headers.Exists(x => x == "floor3"))
                {
                    throw new CsvNotReadyException();
                }
                else if (!headers.Exists(x => x == "floor4"))
                {
                    throw new CsvNotReadyException();
                }
                else if (!headers.Exists(x => x == "areaEvaluated"))
                {
                    throw new CsvNotReadyException();
                }
            }
            

            return true;
        }
        public void CopyFileToData()
        {
            foreach (string file in csvFiles)
            {
                File.Copy(file, pathFilesAfterChecked);
            }
        }

}//Done 
    public class PlotPreToScreen
    {
       public void PlotRegressionChart(MLContext mLContext, AreaPredictionCSVReaderGraphRecords myrecords)
        {

        }
        public void MakePrediction()
        {

        }
    }
    

}

