using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationOfHeartLaboratory
{
    public partial class MainForm : Form
    {
        private Heart heart = null;
        private readonly int MAX_SCALE = 100;
        private readonly int MIN_SCALE = 50;
        private readonly int INCREASE_SCALE = 10;
        private int scale = 0;
        private bool isIncreaseScale = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillPolygon(new SolidBrush(Color.Red), heart.Points);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            heart = new Heart(new PointF(Width / 2, Height / 2));
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            if (scale + INCREASE_SCALE <= MAX_SCALE && isIncreaseScale) scale += INCREASE_SCALE;
            else isIncreaseScale = false;

            if (scale - INCREASE_SCALE >= MIN_SCALE && !isIncreaseScale) scale -= INCREASE_SCALE;
            else isIncreaseScale = true;

            heart.UpdatePoints(scale);
            Invalidate();
        }
    }
}
