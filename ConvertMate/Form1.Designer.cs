namespace ConvertMate
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
            this.buttonCurrencies = new System.Windows.Forms.Button();
            this.buttonUnits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCurrencies
            // 
            this.buttonCurrencies.Location = new System.Drawing.Point(342, 104);
            this.buttonCurrencies.Name = "buttonCurrencies";
            this.buttonCurrencies.Size = new System.Drawing.Size(154, 53);
            this.buttonCurrencies.TabIndex = 0;
            this.buttonCurrencies.Text = "Open Currencies ";
            this.buttonCurrencies.UseVisualStyleBackColor = true;
            this.buttonCurrencies.Click += new System.EventHandler(this.buttonCurrencies_Click);
            // 
            // buttonUnits
            // 
            this.buttonUnits.Location = new System.Drawing.Point(342, 201);
            this.buttonUnits.Name = "buttonUnits";
            this.buttonUnits.Size = new System.Drawing.Size(154, 53);
            this.buttonUnits.TabIndex = 1;
            this.buttonUnits.Text = "Open Units";
            this.buttonUnits.UseVisualStyleBackColor = true;
            this.buttonUnits.Click += new System.EventHandler(this.buttonUnits_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 512);
            this.Controls.Add(this.buttonUnits);
            this.Controls.Add(this.buttonCurrencies);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCurrencies;
        private System.Windows.Forms.Button buttonUnits;
    }
}

