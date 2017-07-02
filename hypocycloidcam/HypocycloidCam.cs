/*
C# Port (with extensions) of...

Hypocycloid cam generator
Generate dxfs of hypocycloid cams for cycloid drives

Copyright 	2009, Alex Lait
Version v0.2 (09/13/09)
License GPL
Homepage http://www.zincland.com/hypocycloid

Credit to:
	Formulas to describe a hypocycloid cam

    http://gears.ru/transmis/zaprogramata/2.139.pdf

	Insperational thread on CNCzone

    http://www.cnczone.com/forums/showthread.php?t=72261

	Documenting and updating the sdxf library

    http://www.kellbot.com/sdxf-python-library-for-dxf/

	Formulas for calculating the pressure angle and finding the limit circles
    http://imtuoradea.ro/auo.fmte/files-2007/MECATRONICA_files/Anamaria_Dascalescu_1.pdf

Notes:
	Does not currently do ANY checking for sane input values and it
	is possible to create un-machinable cams, use at your own risk


    Suggestions:
	- Eccentricity should not be more than the roller radius
	- Has not been tested with negative values, may have interesting results :)
*/

using System;
using System.Collections.Generic;


namespace hypocycloidcam
{
    struct Pt
    {
        public Pt(double x, double y) { this.x = x; this.y = y; }
        public double x;
        public double y;
    }

    class HypocycloidCam
    {
        public delegate void OnChangedDelegate();
        
        public event OnChangedDelegate OnChanged;

        public List<Pt> camPoints { get; private set; }
        public List<Pt> rollerPoints { get; private set; }
        public List<double> pressureAngle { get; private set; }

        public double ToothPitch
        {
            get
            {
                return inputToothPitch;
            }

            set
            {
                inputToothPitch = value;
            }
        }

        public double ComputedToothPitch { get { return toothPitch; } }
        public double ComputedPinBoltCircleDiameter { get { return pinBoltCircleDiameter; } }

        public double RollerDiameter
        {
            get
            {
                return rollerDiameter;
            }

            set
            {
                rollerDiameter = value;
            }
        }

        public double Eccentricity
        {
            get
            {
                return eccentricity;
            }

            set
            {
                eccentricity = value;
            }
        }

        public int TeethInCAM
        {
            get
            {
                return teethInCAM;
            }

            set
            {
                teethInCAM = value;
            }
        }

        public int OutputLineSegments
        {
            get
            {
                return outputLineSegments;
            }

            set
            {
                outputLineSegments = value;
            }
        }

        public double PinBoltCircleDiameter
        {
            get
            {
                return inputPinBoltCircleDiameter;
            }

            set
            {
                inputPinBoltCircleDiameter = value;
            }
        }

        public string OutputFilename
        {
            get
            {
                return outputFilename;
            }

            set
            {
                outputFilename = value;
            }
        }

        public double PressureAngleLimit
        {
            get
            {
                return pressureAngleLimit;
            }

            set
            {
                pressureAngleLimit = value;
            }
        }

        public double OffsetInPressureAngle
        {
            get
            {
                return offsetInPressureAngle;
            }

            set
            {
                offsetInPressureAngle = value;
            }
        }

        public double BoreDiameter
        {
            get
            {
                return boreDiameter;
            }

            set
            {
                boreDiameter = value;
            }
        }

        public double PressureAngleMin
        {
            get
            {
                return pressureAngleMin;
            }
        }

        public double PressureAngleMax
        {
            get
            {
                return pressureAngleMax;
            }
        }

        public double PressureAngleMinRadius
        {
            get
            {
                return pressureAngleMinRadius;
            }
        }

        public double PressureAngleMaxRadius
        {
            get
            {
                return pressureAngleMaxRadius;
            }
        }

        //public double rollerDiameter { get; set; }
        // 	print "\nExample: hypocycloid.py -p 0.08 -d 0.15 -e 0.05 -a 50.0 -c 0.01 -n 10 -s 400 -f foo.dxf"

        double toothPitch;
        double inputToothPitch;
        double rollerDiameter;
        double eccentricity;
        int teethInCAM;
        double pinBoltCircleDiameter;
        double inputPinBoltCircleDiameter;
        double pressureAngleLimit;
        double offsetInPressureAngle;

        double boreDiameter;
        int outputLineSegments;
        string outputFilename;

        double pressureAngleMin;
        double pressureAngleMax;
        double pressureAngleMinRadius;
        double pressureAngleMaxRadius;
        
        public HypocycloidCam()
        {
            toothPitch = inputToothPitch = 0;
            rollerDiameter = 10;
            eccentricity = 2;
            teethInCAM = 10;
            pinBoltCircleDiameter = inputPinBoltCircleDiameter = 80.00;
            pressureAngleLimit = 50.0;
            offsetInPressureAngle = 0.00;
            boreDiameter = 24;

            outputLineSegments = 400;
            outputFilename = "fooxxx";
        }

        Pt toPolar(double x, double y)
        {
            return new hypocycloidcam.Pt( Math.Sqrt(x * x + y * y), Math.Atan2(y, x) );
        }

        Pt toRect(double r, double a)
        {
            return new hypocycloidcam.Pt( r * Math.Cos(a), r * Math.Sin(a) );
        }

        double calcyp(double a, double e, int n)
        {
            return Math.Atan(Math.Sin(n * a) / (Math.Cos(n * a) + (n * toothPitch) / (e * (n + 1))));
        }

        double calcX(double p, double d, double e, int n, double a)
        {
            return (n * p) * Math.Cos(a) + e * Math.Cos((n + 1) * a) - d / 2 * Math.Cos(calcyp(a, e, n) + a);
        }

        double calcY(double p, double d, double e, int n, double a)
        {
            return (n * p) * Math.Sin(a) + e * Math.Sin((n + 1) * a) - d / 2 * Math.Sin(calcyp(a, e, n) + a);
        }

        double calcPressureAngle(double p, double d, int n, double a)
        {
            double ex = Math.Sqrt(2);
            double r3 = p * n;
            double rg = r3 / ex;
            double pp = rg * Math.Sqrt(ex * ex + 1 - 2 * ex * Math.Cos(a)) - d / 2;
            return Math.Asin((r3 * Math.Cos(a) - rg) / (pp + d / 2)) * 180 / Math.PI;
        }

        double calcPressureLimit(double p, double d, double e, int n, double a)
        {
            double ex = Math.Sqrt(2);
            double r3 = p * n;
            double rg = r3 / ex;
            double q = Math.Sqrt(r3 * r3 + rg * rg - 2 * r3 * rg * Math.Cos(a));
            double x = rg - e + (q - d / 2) * (r3 * Math.Cos(a) - rg) / q;
            double y = (q - d / 2) * r3 * Math.Sin(a) / q;
            return Math.Sqrt(x * x + y * y);
        }

        Pt checkLimit(double x, double y, double maxrad, double minrad, double offset)
        {
            Pt polar = toPolar(x, y);
            double r = polar.x, a = polar.y;
            if (r > maxrad || r < minrad)
            {
                r = r - offset;
                Pt xy = toRect(r, a);
                x = xy.x;
                y = xy.y;
            }
            return new Pt(x, y);
        }


        public void main()
        {
            if (inputPinBoltCircleDiameter > 0)
            {
                toothPitch = pinBoltCircleDiameter / 2 / teethInCAM;
                pinBoltCircleDiameter = inputPinBoltCircleDiameter;
            }
            else
            {
                toothPitch = inputToothPitch;
                pinBoltCircleDiameter = toothPitch * 2 * teethInCAM;
            }

            double q = 2 * Math.PI / outputLineSegments;


            // Find the pressure angle limit circles
            pressureAngleMin = -1.0;
            pressureAngleMax = -1.0;
            pressureAngle = new List<double>();
            for (int i = 0; i < 180; i++)
            {
                double x = calcPressureAngle(toothPitch, rollerDiameter, teethInCAM, (double)i * Math.PI / 180);
                pressureAngle.Add(x);
                if (x < pressureAngleLimit && pressureAngleMin < 0)
                    pressureAngleMin = (double)i;
                if (x < -pressureAngleLimit && pressureAngleMax < 0)
                    pressureAngleMax = (double)(i - 1);
            }

            pressureAngleMinRadius = calcPressureLimit(toothPitch, rollerDiameter, eccentricity, teethInCAM, pressureAngleMin * Math.PI / 180);
            pressureAngleMaxRadius = calcPressureLimit(toothPitch, rollerDiameter, eccentricity, teethInCAM, pressureAngleMax * Math.PI / 180);

            // generate the cam profile - note: shifted in -x by eccentricicy amount
            camPoints = new List<Pt>();
            for (int i = 0; i < outputLineSegments; i++)
            {
                double x = calcX(toothPitch, rollerDiameter, eccentricity, teethInCAM, q * i);
                double y = calcY(toothPitch, rollerDiameter, eccentricity, teethInCAM, q * i);
                Pt v = checkLimit(x, y, pressureAngleMaxRadius, pressureAngleMinRadius, offsetInPressureAngle);
                camPoints.Add(v);
            }


            // generate the pin locations
            rollerPoints = new List<Pt>();
            for (int i = 0; i < teethInCAM + 1; i++)
            {
                double x = toothPitch * teethInCAM * Math.Cos(2 * Math.PI / (teethInCAM + 1) * i);
                double y = toothPitch * teethInCAM * Math.Sin(2 * Math.PI / (teethInCAM + 1) * i);

                rollerPoints.Add(new Pt(x, y));
            }

            if (OnChanged != null)
                OnChanged();
        }

    }
}
