namespace KDP_GUI
{
    partial class FormCrtNewModel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBrowseFileTest = new System.Windows.Forms.Button();
            this.btnCloseNewMdl = new System.Windows.Forms.Button();
            this.txtBoxFilePathModelTest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuildMdl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStatusCsvFile = new System.Windows.Forms.Label();
            this.btnBrowseFileTrain = new System.Windows.Forms.Button();
            this.txtBoxFilePathModelTrain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowseFileTest
            // 
            this.btnBrowseFileTest.Location = new System.Drawing.Point(200, 224);
            this.btnBrowseFileTest.Name = "btnBrowseFileTest";
            this.btnBrowseFileTest.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFileTest.TabIndex = 0;
            this.btnBrowseFileTest.Text = "Browse";
            this.btnBrowseFileTest.UseVisualStyleBackColor = true;
            this.btnBrowseFileTest.Click += new System.EventHandler(this.BtnBrowseFile_Click);
            // 
            // btnCloseNewMdl
            // 
            this.btnCloseNewMdl.Location = new System.Drawing.Point(484, 271);
            this.btnCloseNewMdl.Name = "btnCloseNewMdl";
            this.btnCloseNewMdl.Size = new System.Drawing.Size(75, 23);
            this.btnCloseNewMdl.TabIndex = 1;
            this.btnCloseNewMdl.Text = "Close";
            this.btnCloseNewMdl.UseVisualStyleBackColor = true;
            this.btnCloseNewMdl.Click += new System.EventHandler(this.BtnCloseNewMdl_Click);
            // 
            // txtBoxFilePathModelTest
            // 
            this.txtBoxFilePathModelTest.Location = new System.Drawing.Point(200, 182);
            this.txtBoxFilePathModelTest.Name = "txtBoxFilePathModelTest";
            this.txtBoxFilePathModelTest.Size = new System.Drawing.Size(359, 20);
            this.txtBoxFilePathModelTest.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Test data csv file:";
            // 
            // btnBuildMdl
            // 
            this.btnBuildMdl.Location = new System.Drawing.Point(370, 271);
            this.btnBuildMdl.Name = "btnBuildMdl";
            this.btnBuildMdl.Size = new System.Drawing.Size(75, 23);
            this.btnBuildMdl.TabIndex = 4;
            this.btnBuildMdl.Text = "Build";
            this.btnBuildMdl.UseVisualStyleBackColor = true;
            this.btnBuildMdl.Click += new System.EventHandler(this.BtnBuildMdl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status: ";
            // 
            // lbStatusCsvFile
            // 
            this.lbStatusCsvFile.AutoSize = true;
            this.lbStatusCsvFile.Location = new System.Drawing.Point(86, 276);
            this.lbStatusCsvFile.Name = "lbStatusCsvFile";
            this.lbStatusCsvFile.Size = new System.Drawing.Size(33, 13);
            this.lbStatusCsvFile.TabIndex = 5;
            this.lbStatusCsvFile.Text = "None";
            // 
            // btnBrowseFileTrain
            // 
            this.btnBrowseFileTrain.Location = new System.Drawing.Point(200, 129);
            this.btnBrowseFileTrain.Name = "btnBrowseFileTrain";
            this.btnBrowseFileTrain.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFileTrain.TabIndex = 0;
            this.btnBrowseFileTrain.Text = "Browse";
            this.btnBrowseFileTrain.UseVisualStyleBackColor = true;
            this.btnBrowseFileTrain.Click += new System.EventHandler(this.BtnBrowseFileTrain);
            // 
            // txtBoxFilePathModelTrain
            // 
            this.txtBoxFilePathModelTrain.Location = new System.Drawing.Point(200, 81);
            this.txtBoxFilePathModelTrain.Name = "txtBoxFilePathModelTrain";
            this.txtBoxFilePathModelTrain.Size = new System.Drawing.Size(359, 20);
            this.txtBoxFilePathModelTrain.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Training data csv file:";
            // 
            // FormCrtNewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 332);
            this.Controls.Add(this.lbStatusCsvFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuildMdl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxFilePathModelTrain);
            this.Controls.Add(this.txtBoxFilePathModelTest);
            this.Controls.Add(this.btnBrowseFileTrain);
            this.Controls.Add(this.btnCloseNewMdl);
            this.Controls.Add(this.btnBrowseFileTest);
            this.Name = "FormCrtNewModel";
            this.Text = "KDP - Create new Machie Learnig Model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseFileTest;
        private System.Windows.Forms.Button btnCloseNewMdl;
        private System.Windows.Forms.TextBox txtBoxFilePathModelTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuildMdl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStatusCsvFile;
        private System.Windows.Forms.TextBox txtBoxFilePathModelTrain;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button btnBrowseFileTrain;
    }
}