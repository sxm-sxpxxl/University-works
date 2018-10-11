using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimationOfHeartLaboratory
{
    class Heart
    {
        private const int COUNT_OF_POINTS = 128;
        private const int OFFSET_Y = 150;

        private PointF[] points;
        private PointF centerPoint;

        public Heart(PointF centerPoint, double scale = 100, double speedChangeRad = 1)
        {
            this.centerPoint = centerPoint;
            points = new PointF[COUNT_OF_POINTS + 1];

            this.centerPoint.Y -= OFFSET_Y;
            UpdatePoints(scale);
        }

        public void UpdatePoints(double scale)
        {
            double angleRadian = 0;
            double addedAngleRadian = 2 * Math.PI / COUNT_OF_POINTS;
            for (int i = 0; i < points.Length; i++)
            {
                if (i == points.Length - 1)
                {
                    points[i] = points[0];
                    break;
                }

                double RAD = scale * RadialCoordinate(angleRadian);
                points[i].X = (float)(RAD * Math.Cos(angleRadian)) + centerPoint.X;
                points[i].Y = (float)(-RAD * Math.Sin(angleRadian)) + centerPoint.Y;
                angleRadian += addedAngleRadian;
            }
        }

        private double RadialCoordinate(double polarAngleRadian)
        {
            return Math.Sin(polarAngleRadian) * Math.Sqrt(Math.Abs(Math.Cos(polarAngleRadian))) / (Math.Sin(polarAngleRadian) + 1.4) - 2 * Math.Sin(polarAngleRadian) + 2;
        }

        public PointF[] Points
        {
            get { return points; }
        }
    }
}
