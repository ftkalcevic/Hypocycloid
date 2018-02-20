//#define GRADIENT_PRESSURE_ANGLE

using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hypocycloidcam
{
    public class CycloidDisplay: Panel
    {

        private HypocycloidCam cam;
        float xoffset;
        float yoffset;
        float xscale;
        float yscale;

        public CycloidDisplay()
        {
            this.DoubleBuffered = true;
        }

        public HypocycloidCam Cam
        {
            get
            {
                return cam;
            }

            set
            {
                cam = value;
                if ( cam != null )
                    cam.OnChanged += Cam_OnChanged;
            }
        }

        private void Cam_OnChanged()
        {
            if (Cam == null || Cam.rollerPoints == null)
                return;

            // Calculate bounding box
            double minx = 0, maxx = 0;
            double miny = 0, maxy = 0;
            foreach ( Pt p in cam.camPoints)
            {
                UpdateMinMax(ref minx, ref maxx, p.x);
                UpdateMinMax(ref miny, ref maxy, p.y);
            }
            foreach (Pt p in cam.rollerPoints)
            {
                float x = (float)(p.x * xscale + xoffset);
                float y = (float)(-1 * p.y * yscale + yoffset);
                float r = (float)(cam.RollerDiameter * xscale / 2.0);
                UpdateMinMax(ref minx, ref maxx, p.x - cam.RollerDiameter/2);
                UpdateMinMax(ref minx, ref maxx, p.x + cam.RollerDiameter/2);
                UpdateMinMax(ref miny, ref maxy, p.y - cam.RollerDiameter/2);
                UpdateMinMax(ref miny, ref maxy, p.y + cam.RollerDiameter/2);
            }
            double dx = Math.Max(maxx, Math.Abs(minx));
            double dy = Math.Max(maxy, Math.Abs(miny));

            // Always keep the origin in the center.
            double displaySize, camSize;
            if (Height / dx < Width / dy)
            {
                displaySize = Height;
                camSize = dy;
            }
            else
            {
                displaySize = Width;
                camSize = dx;
            }

            camSize *= 1.1; // 10% border

            xoffset = Width / 2;
            yoffset = Height / 2;
            xscale = (float)(displaySize / (2 * camSize));
            yscale = xscale;            
            Refresh();
        }

        private static void UpdateMinMax(ref double min, ref double max, double n)
        {
            if (n > max)
                max = n;
            if (n < min)
                min = n;
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            if ( cam != null)
                Cam_OnChanged();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Cam == null || Cam.rollerPoints == null)
            {
                base.OnPaint(e);
                return;
            }

            Graphics g = e.Graphics;

            // Min/Max Radii
            float offs = (float)(cam.Eccentricity * xscale);
            GraphicsPath path = new GraphicsPath();
            float r;
            r = (float)(cam.PressureAngleMaxRadius * xscale);
            path.AddEllipse(xoffset - r - offs, yoffset - r, r * 2, r * 2);
            r = (float)(cam.PressureAngleMinRadius * xscale);
            path.AddEllipse(xoffset - r - offs, yoffset - r, r * 2, r * 2);
            g.FillPath(Brushes.LightGray, path);

            //cam
            PointF[] displayPoints = new PointF[cam.camPoints.Count];
            int i = 0;
            foreach (Pt p in cam.camPoints)
            {
                displayPoints[i].X = (float)((p.x - cam.Eccentricity) * xscale + xoffset);
                displayPoints[i].Y = (float)(-1 * p.y * yscale + yoffset);
                i++;
            }
            path = new GraphicsPath();
            path.AddLines(displayPoints);
            g.DrawPath(Pens.Black, path);

#if GRADIENT_PRESSURE_ANGLE
            float firstx =0, firsty=0, lastx=0, lasty=0;
            //int i = 0;
            foreach (Pt p in cam.camPoints)
            {
                float x = (float)(p.x * xscale + xoffset);
                float y = (float)(-1 * p.y * yscale + yoffset);
                if (p.Equals(cam.camPoints[0]))
                {
                    firstx = x;
                    firsty = y;
                }
                else
                {
                    int angle = (int)((360*i / cam.camPoints.Count * cam.TeethInCAM) % 180);
                    int level = (int)( 32 + 196 * (Math.Abs(cam.pressureAngle[angle]) - cam.PressureAngleMin) / (cam.PressureAngleMax - cam.PressureAngleMin));
                    g.DrawLine(new Pen(Color.FromArgb(255,level,level,level),2), lastx, lasty, x, y);
                }
                lastx = x;
                lasty = y;
                i++;
            }
            g.DrawLine(Pens.Red, lastx, lasty, firstx, firsty);
#endif

            foreach (Pt p in cam.rollerPoints)
            {
                float x = (float)(p.x * xscale + xoffset);
                float y = (float)(-1 * p.y * yscale + yoffset);
                r = (float)(cam.RollerDiameter * xscale / 2.0);
                g.DrawEllipse(Pens.Blue, x - r, y - r, 2 * r, 2 * r);
            }

            double d = cam.EccentricBearingOuterDia * xscale;
            g.DrawEllipse(Pens.Black, (float)(xoffset - d / 2 -cam.Eccentricity*xscale), (float)(yoffset - d / 2), (float)d, (float)d);

            // cam output circles
            if (cam.OutputBearings > 0)
            {
                double holeDia = (cam.OutputBearingsDia + cam.Eccentricity * 2) * xscale;
                double pitchDia = (cam.OutputPitchCircleDia) *xscale;
                for (i = 0; i < cam.OutputBearings; i++)
                {
                    double angle = Math.PI * 2.0 * (double)i / (double)cam.OutputBearings;
                    double x = (pitchDia / 2) * Math.Cos(angle);
                    x -= cam.Eccentricity * xscale;
                    double y = (pitchDia / 2 ) * Math.Sin(angle);


                    g.DrawEllipse(Pens.Black, (float)(xoffset + x - holeDia/2), (float)(yoffset + y - holeDia/2), (float)holeDia, (float)holeDia);
                }
            }

            //RectangleF b = g.VisibleClipBounds;
            //g.DrawLine(Pens.Red, 0, 0, b.Width-1, b.Height - 1);
            //g.DrawLine(Pens.Red, b.Width - 1, 0, 0, b.Height - 1);
            //g.DrawLine(Pens.Red, 0, 0, b.Width - 1, 0);
            //g.DrawLine(Pens.Red, b.Width - 1, 0, b.Width - 1, b.Height - 1);
            //g.DrawLine(Pens.Red, b.Width - 1, b.Height - 1, 0, b.Height - 1);
            //g.DrawLine(Pens.Red, 0, b.Height - 1, 0,0);
        }
    }
}
