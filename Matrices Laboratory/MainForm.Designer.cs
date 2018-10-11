namespace MatricesLaboratory
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
            this.MatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.BuildMatrixButton = new System.Windows.Forms.Button();
            this.BaseMatrixRadioButton = new System.Windows.Forms.RadioButton();
            this.IndividualMatrixRadioButton = new System.Windows.Forms.RadioButton();
            this.ColumnsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ColRowGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RowsTextBox = new System.Windows.Forms.TextBox();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixDataGridView)).BeginInit();
            this.ColRowGroupBox.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MatrixDataGridView
            // 
            this.MatrixDataGridView.AllowUserToAddRows = false;
            this.MatrixDataGridView.AllowUserToDeleteRows = false;
            this.MatrixDataGridView.AllowUserToResizeColumns = false;
            this.MatrixDataGridView.AllowUserToResizeRows = false;
            this.MatrixDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MatrixDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.MatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixDataGridView.ColumnHeadersVisible = false;
            this.MatrixDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MatrixDataGridView.Location = new System.Drawing.Point(16, 15);
            this.MatrixDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MatrixDataGridView.Name = "MatrixDataGridView";
            this.MatrixDataGridView.RowHeadersWidth = 21;
            this.MatrixDataGridView.Size = new System.Drawing.Size(1013, 430);
            this.MatrixDataGridView.StandardTab = true;
            this.MatrixDataGridView.TabIndex = 0;
            // 
            // ProcessButton
            // 
            this.ProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcessButton.Location = new System.Drawing.Point(253, 452);
            this.ProcessButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(231, 66);
            this.ProcessButton.TabIndex = 1;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextBox.Location = new System.Drawing.Point(87, 11);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(155, 26);
            this.ResultTextBox.TabIndex = 3;
            this.ResultTextBox.Text = "0";
            // 
            // BuildMatrixButton
            // 
            this.BuildMatrixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildMatrixButton.Location = new System.Drawing.Point(16, 452);
            this.BuildMatrixButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuildMatrixButton.Name = "BuildMatrixButton";
            this.BuildMatrixButton.Size = new System.Drawing.Size(231, 66);
            this.BuildMatrixButton.TabIndex = 4;
            this.BuildMatrixButton.Text = "Build Matrix";
            this.BuildMatrixButton.UseVisualStyleBackColor = true;
            this.BuildMatrixButton.Click += new System.EventHandler(this.BuildMatrixButton_Click);
            // 
            // BaseMatrixRadioButton
            // 
            this.BaseMatrixRadioButton.AutoSize = true;
            this.BaseMatrixRadioButton.Checked = true;
            this.BaseMatrixRadioButton.Location = new System.Drawing.Point(491, 496);
            this.BaseMatrixRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BaseMatrixRadioButton.Name = "BaseMatrixRadioButton";
            this.BaseMatrixRadioButton.Size = new System.Drawing.Size(102, 21);
            this.BaseMatrixRadioButton.TabIndex = 5;
            this.BaseMatrixRadioButton.TabStop = true;
            this.BaseMatrixRadioButton.Text = "Base matrix";
            this.BaseMatrixRadioButton.UseVisualStyleBackColor = true;
            // 
            // IndividualMatrixRadioButton
            // 
            this.IndividualMatrixRadioButton.AutoSize = true;
            this.IndividualMatrixRadioButton.Location = new System.Drawing.Point(601, 496);
            this.IndividualMatrixRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IndividualMatrixRadioButton.Name = "IndividualMatrixRadioButton";
            this.IndividualMatrixRadioButton.Size = new System.Drawing.Size(129, 21);
            this.IndividualMatrixRadioButton.TabIndex = 6;
            this.IndividualMatrixRadioButton.Text = "Individual matrix";
            this.IndividualMatrixRadioButton.UseVisualStyleBackColor = true;
            this.IndividualMatrixRadioButton.CheckedChanged += new System.EventHandler(this.IndividualMatrixRadioButton_CheckedChanged);
            // 
            // ColumnsTextBox
            // 
            this.ColumnsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnsTextBox.Location = new System.Drawing.Point(99, 25);
            this.ColumnsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColumnsTextBox.Name = "ColumnsTextBox";
            this.ColumnsTextBox.Size = new System.Drawing.Size(49, 26);
            this.ColumnsTextBox.TabIndex = 8;
            this.ColumnsTextBox.Text = "0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Columns: ";
            // 
            // ColRowGroupBox
            // 
            this.ColRowGroupBox.Controls.Add(this.label3);
            this.ColRowGroupBox.Controls.Add(this.RowsTextBox);
            this.ColRowGroupBox.Controls.Add(this.label2);
            this.ColRowGroupBox.Controls.Add(this.ColumnsTextBox);
            this.ColRowGroupBox.Location = new System.Drawing.Point(747, 446);
            this.ColRowGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColRowGroupBox.Name = "ColRowGroupBox";
            this.ColRowGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColRowGroupBox.Size = new System.Drawing.Size(283, 73);
            this.ColRowGroupBox.TabIndex = 9;
            this.ColRowGroupBox.TabStop = false;
            this.ColRowGroupBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(163, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rows:";
            // 
            // RowsTextBox
            // 
            this.RowsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RowsTextBox.Location = new System.Drawing.Point(224, 25);
            this.RowsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RowsTextBox.Name = "RowsTextBox";
            this.RowsTextBox.Size = new System.Drawing.Size(49, 26);
            this.RowsTextBox.TabIndex = 10;
            this.RowsTextBox.Text = "0";
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.label1);
            this.ResultGroupBox.Controls.Add(this.ResultTextBox);
            this.ResultGroupBox.Location = new System.Drawing.Point(491, 446);
            this.ResultGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultGroupBox.Size = new System.Drawing.Size(249, 44);
            this.ResultGroupBox.TabIndex = 10;
            this.ResultGroupBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 530);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.ColRowGroupBox);
            this.Controls.Add(this.IndividualMatrixRadioButton);
            this.Controls.Add(this.BaseMatrixRadioButton);
            this.Controls.Add(this.BuildMatrixButton);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.MatrixDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Laboratory 4 - Matrices";
            ((System.ComponentModel.ISupportInitialize)(this.MatrixDataGridView)).EndInit();
            this.ColRowGroupBox.ResumeLayout(false);
            this.ColRowGroupBox.PerformLayout();
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MatrixDataGridView;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button BuildMatrixButton;
        private System.Windows.Forms.RadioButton BaseMatrixRadioButton;
        private System.Windows.Forms.RadioButton IndividualMatrixRadioButton;
        private System.Windows.Forms.TextBox ColumnsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox ColRowGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RowsTextBox;
        private System.Windows.Forms.GroupBox ResultGroupBox;
    }
}

