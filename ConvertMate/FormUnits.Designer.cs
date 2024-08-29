namespace ConvertMate
{
    partial class FormUnits
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
            this.buttonDistance = new System.Windows.Forms.Button();
            this.buttonTemperature = new System.Windows.Forms.Button();
            this.buttonMass = new System.Windows.Forms.Button();
            this.buttonVolume = new System.Windows.Forms.Button();
            this.buttonTime = new System.Windows.Forms.Button();
            this.listBoxMeasurments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDistance
            // 
            this.buttonDistance.Location = new System.Drawing.Point(71, 59);
            this.buttonDistance.Name = "buttonDistance";
            this.buttonDistance.Size = new System.Drawing.Size(130, 38);
            this.buttonDistance.TabIndex = 0;
            this.buttonDistance.Text = "Distance";
            this.buttonDistance.UseVisualStyleBackColor = true;
            this.buttonDistance.Click += new System.EventHandler(this.buttonDistance_Click);
            // 
            // buttonTemperature
            // 
            this.buttonTemperature.Location = new System.Drawing.Point(71, 119);
            this.buttonTemperature.Name = "buttonTemperature";
            this.buttonTemperature.Size = new System.Drawing.Size(130, 38);
            this.buttonTemperature.TabIndex = 1;
            this.buttonTemperature.Text = "Temperature";
            this.buttonTemperature.UseVisualStyleBackColor = true;
            this.buttonTemperature.Click += new System.EventHandler(this.buttonTemperature_Click);
            // 
            // buttonMass
            // 
            this.buttonMass.Location = new System.Drawing.Point(71, 182);
            this.buttonMass.Name = "buttonMass";
            this.buttonMass.Size = new System.Drawing.Size(130, 38);
            this.buttonMass.TabIndex = 2;
            this.buttonMass.Text = "Weight/Mass";
            this.buttonMass.UseVisualStyleBackColor = true;
            this.buttonMass.Click += new System.EventHandler(this.buttonMass_Click);
            // 
            // buttonVolume
            // 
            this.buttonVolume.Location = new System.Drawing.Point(71, 247);
            this.buttonVolume.Name = "buttonVolume";
            this.buttonVolume.Size = new System.Drawing.Size(130, 38);
            this.buttonVolume.TabIndex = 3;
            this.buttonVolume.Text = "Volume";
            this.buttonVolume.UseVisualStyleBackColor = true;
            this.buttonVolume.Click += new System.EventHandler(this.buttonVolume_Click);
            // 
            // buttonTime
            // 
            this.buttonTime.Location = new System.Drawing.Point(71, 313);
            this.buttonTime.Name = "buttonTime";
            this.buttonTime.Size = new System.Drawing.Size(130, 38);
            this.buttonTime.TabIndex = 4;
            this.buttonTime.Text = "Time";
            this.buttonTime.UseVisualStyleBackColor = true;
            this.buttonTime.Click += new System.EventHandler(this.buttonTime_Click);
            // 
            // listBoxMeasurments
            // 
            this.listBoxMeasurments.FormattingEnabled = true;
            this.listBoxMeasurments.Location = new System.Drawing.Point(258, 59);
            this.listBoxMeasurments.Name = "listBoxMeasurments";
            this.listBoxMeasurments.Size = new System.Drawing.Size(192, 290);
            this.listBoxMeasurments.TabIndex = 5;
            this.listBoxMeasurments.DoubleClick += new System.EventHandler(this.listBoxMeasurments_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Groups of Units";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Measurments for Group";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(492, 59);
            this.textBoxFrom.Multiline = true;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(132, 38);
            this.textBoxFrom.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "From ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(645, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "To";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(648, 59);
            this.textBoxTo.Multiline = true;
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(135, 38);
            this.textBoxTo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Amount";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(492, 160);
            this.textBoxAmount.Multiline = true;
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(291, 38);
            this.textBoxAmount.TabIndex = 13;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(492, 217);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(291, 26);
            this.buttonCalculate.TabIndex = 14;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(492, 284);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(291, 67);
            this.textBoxResult.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Result";
            // 
            // FormUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 409);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMeasurments);
            this.Controls.Add(this.buttonTime);
            this.Controls.Add(this.buttonVolume);
            this.Controls.Add(this.buttonMass);
            this.Controls.Add(this.buttonTemperature);
            this.Controls.Add(this.buttonDistance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormUnits";
            this.Text = "FormUnits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDistance;
        private System.Windows.Forms.Button buttonTemperature;
        private System.Windows.Forms.Button buttonMass;
        private System.Windows.Forms.Button buttonVolume;
        private System.Windows.Forms.Button buttonTime;
        private System.Windows.Forms.ListBox listBoxMeasurments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label6;
    }
}