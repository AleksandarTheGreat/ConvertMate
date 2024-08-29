namespace ConvertMate
{
    partial class FormCurrencies
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
            this.btnMoveToTo = new System.Windows.Forms.Button();
            this.btnMoveToFrom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxCurrencies = new System.Windows.Forms.ListBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMoveToTo
            // 
            this.btnMoveToTo.Location = new System.Drawing.Point(273, 329);
            this.btnMoveToTo.Name = "btnMoveToTo";
            this.btnMoveToTo.Size = new System.Drawing.Size(108, 23);
            this.btnMoveToTo.TabIndex = 24;
            this.btnMoveToTo.Text = "Move to To field";
            this.btnMoveToTo.UseVisualStyleBackColor = true;
            this.btnMoveToTo.Click += new System.EventHandler(this.btnMoveToTo_Click);
            // 
            // btnMoveToFrom
            // 
            this.btnMoveToFrom.Location = new System.Drawing.Point(273, 284);
            this.btnMoveToFrom.Name = "btnMoveToFrom";
            this.btnMoveToFrom.Size = new System.Drawing.Size(108, 23);
            this.btnMoveToFrom.TabIndex = 23;
            this.btnMoveToFrom.Text = "Move to From field";
            this.btnMoveToFrom.UseVisualStyleBackColor = true;
            this.btnMoveToFrom.Click += new System.EventHandler(this.btnMoveToFrom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "All currencies";
            // 
            // listBoxCurrencies
            // 
            this.listBoxCurrencies.FormattingEnabled = true;
            this.listBoxCurrencies.Location = new System.Drawing.Point(57, 67);
            this.listBoxCurrencies.Name = "listBoxCurrencies";
            this.listBoxCurrencies.Size = new System.Drawing.Size(184, 342);
            this.listBoxCurrencies.TabIndex = 21;
            this.listBoxCurrencies.DoubleClick += new System.EventHandler(this.listBoxCurrencies_DoubleClick);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(273, 163);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(93, 13);
            this.lbResult.TabIndex = 20;
            this.lbResult.Text = "Result will be here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "From";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(273, 221);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(281, 23);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(427, 71);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 15;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(273, 71);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrom.TabIndex = 14;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(273, 118);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTo.TabIndex = 13;
            // 
            // FormCurrencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 483);
            this.Controls.Add(this.btnMoveToTo);
            this.Controls.Add(this.btnMoveToFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxCurrencies);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.textBoxTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCurrencies";
            this.Text = "FormCurrencies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoveToTo;
        private System.Windows.Forms.Button btnMoveToFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxCurrencies;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
    }
}