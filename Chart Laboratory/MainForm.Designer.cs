namespace ChartLaboratory
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.YParamTextBox = new System.Windows.Forms.TextBox();
            this.ZParamTextBox = new System.Windows.Forms.TextBox();
            this.XMaxParamTextBox = new System.Windows.Forms.TextBox();
            this.XMinParamTextBox = new System.Windows.Forms.TextBox();
            this.StepParamTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReCalcButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(9, 27);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 28);
            label1.TabIndex = 1;
            label1.Text = "Y parameter";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(9, 62);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(135, 28);
            label2.TabIndex = 3;
            label2.Text = "Z parameter";
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(245, 60);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 28);
            label3.TabIndex = 7;
            label3.Text = "X max";
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(245, 30);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(71, 28);
            label4.TabIndex = 5;
            label4.Text = "X min";
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(409, 31);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 28);
            label5.TabIndex = 9;
            label5.Text = "Step";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(699, 619);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(618, 174);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // MainChart
            // 
            this.MainChart.Location = new System.Drawing.Point(16, 15);
            this.MainChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainChart.Name = "MainChart";
            this.MainChart.Size = new System.Drawing.Size(1301, 591);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "chart1";
            // 
            // YParamTextBox
            // 
            this.YParamTextBox.Location = new System.Drawing.Point(152, 32);
            this.YParamTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YParamTextBox.Name = "YParamTextBox";
            this.YParamTextBox.Size = new System.Drawing.Size(69, 22);
            this.YParamTextBox.TabIndex = 2;
            this.YParamTextBox.TextChanged += new System.EventHandler(this.ParamTextBox_TextChanged);
            // 
            // ZParamTextBox
            // 
            this.ZParamTextBox.Location = new System.Drawing.Point(152, 64);
            this.ZParamTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ZParamTextBox.Name = "ZParamTextBox";
            this.ZParamTextBox.Size = new System.Drawing.Size(69, 22);
            this.ZParamTextBox.TabIndex = 4;
            this.ZParamTextBox.TextChanged += new System.EventHandler(this.ParamTextBox_TextChanged);
            // 
            // XMaxParamTextBox
            // 
            this.XMaxParamTextBox.Location = new System.Drawing.Point(324, 63);
            this.XMaxParamTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XMaxParamTextBox.Name = "XMaxParamTextBox";
            this.XMaxParamTextBox.Size = new System.Drawing.Size(69, 22);
            this.XMaxParamTextBox.TabIndex = 8;
            this.XMaxParamTextBox.TextChanged += new System.EventHandler(this.ParamTextBox_TextChanged);
            // 
            // XMinParamTextBox
            // 
            this.XMinParamTextBox.Location = new System.Drawing.Point(324, 30);
            this.XMinParamTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XMinParamTextBox.Name = "XMinParamTextBox";
            this.XMinParamTextBox.Size = new System.Drawing.Size(69, 22);
            this.XMinParamTextBox.TabIndex = 6;
            this.XMinParamTextBox.TextChanged += new System.EventHandler(this.ParamTextBox_TextChanged);
            // 
            // StepParamTextBox
            // 
            this.StepParamTextBox.Location = new System.Drawing.Point(477, 30);
            this.StepParamTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StepParamTextBox.Name = "StepParamTextBox";
            this.StepParamTextBox.Size = new System.Drawing.Size(69, 22);
            this.StepParamTextBox.TabIndex = 10;
            this.StepParamTextBox.TextChanged += new System.EventHandler(this.ParamTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReCalcButton);
            this.groupBox1.Controls.Add(this.YParamTextBox);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.XMaxParamTextBox);
            this.groupBox1.Controls.Add(this.StepParamTextBox);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.ZParamTextBox);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.XMinParamTextBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 613);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(675, 181);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function parameters";
            // 
            // ReCalcButton
            // 
            this.ReCalcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReCalcButton.Location = new System.Drawing.Point(229, 111);
            this.ReCalcButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReCalcButton.Name = "ReCalcButton";
            this.ReCalcButton.Size = new System.Drawing.Size(212, 42);
            this.ReCalcButton.TabIndex = 11;
            this.ReCalcButton.Text = "Recalc";
            this.ReCalcButton.UseVisualStyleBackColor = true;
            this.ReCalcButton.Click += new System.EventHandler(this.ReCalcButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 809);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.MainChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Laboratory 6 - Chart";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.TextBox YParamTextBox;
        private System.Windows.Forms.TextBox ZParamTextBox;
        private System.Windows.Forms.TextBox XMaxParamTextBox;
        private System.Windows.Forms.TextBox XMinParamTextBox;
        private System.Windows.Forms.TextBox StepParamTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ReCalcButton;
    }
}

