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
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnCloseNewMdl = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuildMdl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStatusCsvFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(119, 271);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFile.TabIndex = 0;
            this.btnBrowseFile.Text = "Browse";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            // 
            // btnCloseNewMdl
            // 
            this.btnCloseNewMdl.Location = new System.Drawing.Point(484, 271);
            this.btnCloseNewMdl.Name = "btnCloseNewMdl";
            this.btnCloseNewMdl.Size = new System.Drawing.Size(75, 23);
            this.btnCloseNewMdl.TabIndex = 1;
            this.btnCloseNewMdl.Text = "Close";
            this.btnCloseNewMdl.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CSV File path:";
            // 
            // btnBuildMdl
            // 
            this.btnBuildMdl.Location = new System.Drawing.Point(310, 271);
            this.btnBuildMdl.Name = "btnBuildMdl";
            this.btnBuildMdl.Size = new System.Drawing.Size(75, 23);
            this.btnBuildMdl.TabIndex = 4;
            this.btnBuildMdl.Text = "Build";
            this.btnBuildMdl.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status: ";
            // 
            // lbStatusCsvFile
            // 
            this.lbStatusCsvFile.AutoSize = true;
            this.lbStatusCsvFile.Location = new System.Drawing.Point(293, 197);
            this.lbStatusCsvFile.Name = "lbStatusCsvFile";
            this.lbStatusCsvFile.Size = new System.Drawing.Size(33, 13);
            this.lbStatusCsvFile.TabIndex = 5;
            this.lbStatusCsvFile.Text = "None";
            // 
            // FormCrtNewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 332);
            this.Controls.Add(this.lbStatusCsvFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuildMdl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCloseNewMdl);
            this.Controls.Add(this.btnBrowseFile);
            this.Name = "FormCrtNewModel";
            this.Text = "KDP - Create new Machie Learnig Model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnCloseNewMdl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuildMdl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStatusCsvFile;
    }
}