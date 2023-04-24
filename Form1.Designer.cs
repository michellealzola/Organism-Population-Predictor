namespace Organism_Population_Predictor
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxStartingNum = new System.Windows.Forms.TextBox();
            this.tboxDailyIncrease = new System.Windows.Forms.TextBox();
            this.tboxNumDays = new System.Windows.Forms.TextBox();
            this.lboxPredictionTable = new System.Windows.Forms.ListBox();
            this.btnPredict = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Number of Organisms:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average Daily Increase (%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Days to Multiply";
            // 
            // tboxStartingNum
            // 
            this.tboxStartingNum.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxStartingNum.Location = new System.Drawing.Point(288, 26);
            this.tboxStartingNum.Name = "tboxStartingNum";
            this.tboxStartingNum.Size = new System.Drawing.Size(268, 26);
            this.tboxStartingNum.TabIndex = 3;
            // 
            // tboxDailyIncrease
            // 
            this.tboxDailyIncrease.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDailyIncrease.Location = new System.Drawing.Point(288, 65);
            this.tboxDailyIncrease.Name = "tboxDailyIncrease";
            this.tboxDailyIncrease.Size = new System.Drawing.Size(268, 26);
            this.tboxDailyIncrease.TabIndex = 4;
            // 
            // tboxNumDays
            // 
            this.tboxNumDays.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNumDays.Location = new System.Drawing.Point(288, 104);
            this.tboxNumDays.Name = "tboxNumDays";
            this.tboxNumDays.Size = new System.Drawing.Size(268, 26);
            this.tboxNumDays.TabIndex = 5;
            // 
            // lboxPredictionTable
            // 
            this.lboxPredictionTable.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxPredictionTable.FormattingEnabled = true;
            this.lboxPredictionTable.ItemHeight = 19;
            this.lboxPredictionTable.Location = new System.Drawing.Point(12, 154);
            this.lboxPredictionTable.Name = "lboxPredictionTable";
            this.lboxPredictionTable.Size = new System.Drawing.Size(544, 232);
            this.lboxPredictionTable.TabIndex = 6;
            // 
            // btnPredict
            // 
            this.btnPredict.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredict.Location = new System.Drawing.Point(12, 403);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(290, 35);
            this.btnPredict.TabIndex = 7;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(308, 403);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("NanumGothicCoding", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(445, 403);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.lboxPredictionTable);
            this.Controls.Add(this.tboxNumDays);
            this.Controls.Add(this.tboxDailyIncrease);
            this.Controls.Add(this.tboxStartingNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Organism Population Predictor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxStartingNum;
        private System.Windows.Forms.TextBox tboxDailyIncrease;
        private System.Windows.Forms.TextBox tboxNumDays;
        private System.Windows.Forms.ListBox lboxPredictionTable;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

