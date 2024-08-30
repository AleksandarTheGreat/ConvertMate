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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxRecently = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "All currencies";
            // 
            // listBoxCurrencies
            // 
            this.listBoxCurrencies.FormattingEnabled = true;
            this.listBoxCurrencies.Location = new System.Drawing.Point(34, 138);
            this.listBoxCurrencies.Name = "listBoxCurrencies";
            this.listBoxCurrencies.Size = new System.Drawing.Size(184, 342);
            this.listBoxCurrencies.TabIndex = 21;
            this.listBoxCurrencies.DoubleClick += new System.EventHandler(this.listBoxCurrencies_DoubleClick);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(263, 297);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(93, 13);
            this.lbResult.TabIndex = 20;
            this.lbResult.Text = "Result will be here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "From";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(263, 355);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(254, 23);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(417, 205);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 15;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(263, 205);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrom.TabIndex = 14;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(263, 252);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTo.TabIndex = 13;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(263, 138);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(254, 20);
            this.textBoxSearch.TabIndex = 25;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Search Currency";
            // 
            // listBoxRecently
            // 
            this.listBoxRecently.FormattingEnabled = true;
            this.listBoxRecently.Location = new System.Drawing.Point(573, 138);
            this.listBoxRecently.Name = "listBoxRecently";
            this.listBoxRecently.Size = new System.Drawing.Size(258, 342);
            this.listBoxRecently.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Recently converted currencies";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(573, 501);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(258, 23);
            this.buttonRemove.TabIndex = 29;
            this.buttonRemove.Text = "Remove Log";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 31);
            this.label7.TabIndex = 30;
            this.label7.Text = "Currencies Converter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "ConvertMate";
            // 
            // FormCurrencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 558);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxRecently);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSearch);
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
            this.Text = "Currencies Converter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCurrencies_FormClosed);
            this.Load += new System.EventHandler(this.FormCurrencies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxRecently;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}