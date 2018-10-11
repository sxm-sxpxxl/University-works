using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartLaboratory
{
    public partial class MainForm : Form
    {
        private Function psiFunc = new Function();
        private bool isUpdate;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateChart()
        {
            ChartArea area = new ChartArea
            {
                Name = "Graph"
            };
            area.AxisX.Minimum = psiFunc.X_Min;
            area.AxisX.Maximum = psiFunc.X_Max;
            area.AxisX.MajorGrid.Interval = psiFunc.Step * 10;
            MainChart.ChartAreas.Add(area);

            Series seriesFirst = new Series();
            seriesFirst.ChartArea = area.Name;
            seriesFirst.ChartType = SeriesChartType.Spline;
            seriesFirst.BorderWidth = 3;
            seriesFirst.LegendText = "psi(x)";
            MainChart.Series.Add(seriesFirst);

            Legend legend = new Legend();
            MainChart.Legends.Add(legend);
        }

        private void InitParameters(double x_min, double x_max, double step, double y, double z)
        {
            XMinParamTextBox.Text = Convert.ToString(x_min);
            XMaxParamTextBox.Text = Convert.ToString(x_max);
            StepParamTextBox.Text = Convert.ToString(step);
            YParamTextBox.Text = Convert.ToString(y);
            ZParamTextBox.Text = Convert.ToString(z);
            isUpdate = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateChart();
            InitParameters(psiFunc.X_Min, psiFunc.X_Max, psiFunc.Step, psiFunc.YParam, psiFunc.ZParam);
            psiFunc.CalcFunction();
            MainChart.Series[0].Points.DataBindXY(psiFunc.X, psiFunc.PSI);
        }

        private void ReCalcButton_Click(object sender, EventArgs e)
        {
            if (!isUpdate) { MessageBox.Show("Function parameters aren't update."); return; }

            double x_min, x_max, step, y, z;
            try
            {
                x_min = Convert.ToDouble(XMinParamTextBox.Text);
                x_max = Convert.ToDouble(XMaxParamTextBox.Text);
                step = Convert.ToDouble(StepParamTextBox.Text);
                y = Convert.ToDouble(YParamTextBox.Text);
                z = Convert.ToDouble(ZParamTextBox.Text);
            }
            catch(FormatException exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }

            psiFunc = new Function(x_min, x_max, step, y, z);
            MainChart.ChartAreas[0].AxisX.Minimum = psiFunc.X_Min;
            MainChart.ChartAreas[0].AxisX.Maximum = psiFunc.X_Max;
            MainChart.ChartAreas[0].AxisX.MajorGrid.Interval = psiFunc.Step * 10;

            psiFunc.CalcFunction();
            MainChart.Series[0].Points.DataBindXY(psiFunc.X, psiFunc.PSI);
            isUpdate = false;
        }

        private void ParamTextBox_TextChanged(object sender, EventArgs e)
        {
            isUpdate = true;
        }
    }
}
