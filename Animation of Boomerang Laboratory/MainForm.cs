using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

#pragma warning disable UNREACHABLE_CODE, CS0162

namespace AnimationLaboratory
{
    enum DirectRotation
    {
        ClockWise, // по часовой стрелке
        AntiClockWise // против часовой стрелки
    }

    public partial class MainForm : Form
    {
        private readonly Int32 SIZE = 100;
        private readonly Int32 SPEED_X = 30;
        private readonly Int32 SPEED_Y = 30;
        private readonly Double SPEED_ROTATION = 1;
        private readonly Int32 BORDER = 5;
        private readonly DirectRotation DIRECT = DirectRotation.ClockWise;

        private Double angleInRad = 0;
        private Int32 offset_x = 0;
        private Int32 offset_y = 0;

        private Boolean isMoveRight = true;
        private Boolean isMoveDown = true;

        private Point centerOfScreen;
        private Point firstPoint = new Point();
        private Point secondPoint = new Point();
        private Point thirdPoint = new Point();
        private Point fourthPoint = new Point();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillClosedCurve(new HatchBrush(HatchStyle.BackwardDiagonal, Color.Orange), new Point[] { firstPoint, secondPoint, thirdPoint, fourthPoint });
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isMoveRight)
            {
                offset_x += SPEED_X;
                if (offset_x + centerOfScreen.X >= Width - Width / BORDER) isMoveRight = false;
            }
            else {
                offset_x -= SPEED_X;
                if (offset_x + centerOfScreen.X <= Width / BORDER) isMoveRight = true;
            }

            if (isMoveDown)
            {
                offset_y += SPEED_Y;
                if (offset_y + centerOfScreen.Y >= Height - Height / BORDER) isMoveDown = false;
            }
            else
            {
                offset_y -= SPEED_Y;
                if (offset_y + centerOfScreen.Y <= Height / BORDER) isMoveDown = true;
            }

            if (DIRECT != DirectRotation.ClockWise) angleInRad += SPEED_ROTATION;
            else angleInRad -= SPEED_ROTATION;

            ReCalcPoints();
            Invalidate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            centerOfScreen = new Point(Width / 2, Height / 2);
            ReCalcPoints();
        }

        private Point RoundPoint(Point point, double deg, double rad)
        {
            return new Point(
                (centerOfScreen.X + offset_x) + (int)(rad * Math.Cos(deg)),
                (centerOfScreen.Y + offset_y) - (int)(rad * Math.Sin(deg))
            );
        }

        private void ReCalcPoints()
        {
            firstPoint = RoundPoint(firstPoint, angleInRad - Math.PI / 6, SIZE);
            secondPoint = RoundPoint(secondPoint, angleInRad + Math.PI / 2, SIZE);
            fourthPoint = RoundPoint(thirdPoint, angleInRad + Math.PI / 2, 0.5 * SIZE);
            thirdPoint = RoundPoint(thirdPoint, angleInRad + 21 * Math.PI / 18, SIZE);
        }
    }
}
