namespace KDP_GUI
{
    partial class FormExistingModel
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewMdl = new System.Windows.Forms.Button();
            this.btnCloseMdl = new System.Windows.Forms.Button();
            this.btnDelMdl = new System.Windows.Forms.Button();
            this.listViewModels = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select model:";
            // 
            // btnNewMdl
            // 
            this.btnNewMdl.Location = new System.Drawing.Point(59, 339);
            this.btnNewMdl.Name = "btnNewMdl";
            this.btnNewMdl.Size = new System.Drawing.Size(75, 23);
            this.btnNewMdl.TabIndex = 2;
            this.btnNewMdl.Text = "New";
            this.btnNewMdl.UseVisualStyleBackColor = true;
            // 
            // btnCloseMdl
            // 
            this.btnCloseMdl.Location = new System.Drawing.Point(311, 339);
            this.btnCloseMdl.Name = "btnCloseMdl";
            this.btnCloseMdl.Size = new System.Drawing.Size(75, 23);
            this.btnCloseMdl.TabIndex = 3;
            this.btnCloseMdl.Text = "Close";
            this.btnCloseMdl.UseVisualStyleBackColor = true;
            this.btnCloseMdl.Click += new System.EventHandler(this.BtnCloseMdl_Click);
            // 
            // btnDelMdl
            // 
            this.btnDelMdl.Location = new System.Drawing.Point(185, 339);
            this.btnDelMdl.Name = "btnDelMdl";
            this.btnDelMdl.Size = new System.Drawing.Size(75, 23);
            this.btnDelMdl.TabIndex = 2;
            this.btnDelMdl.Text = "Delete";
            this.btnDelMdl.UseVisualStyleBackColor = true;
            // 
            // listViewModels
            // 
            this.listViewModels.Location = new System.Drawing.Point(101, 76);
            this.listViewModels.Name = "listViewModels";
            this.listViewModels.Size = new System.Drawing.Size(265, 218);
            this.listViewModels.TabIndex = 4;
            this.listViewModels.UseCompatibleStateImageBehavior = false;
            // 
            // FormExistingModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 393);
            this.Controls.Add(this.listViewModels);
            this.Controls.Add(this.btnCloseMdl);
            this.Controls.Add(this.btnDelMdl);
            this.Controls.Add(this.btnNewMdl);
            this.Controls.Add(this.label1);
            this.Name = "FormExistingModel";
            this.Text = "KDP - Machine Learning models";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewMdl;
        private System.Windows.Forms.Button btnCloseMdl;
        private System.Windows.Forms.Button btnDelMdl;
        private System.Windows.Forms.ListView listViewModels;
    }
}