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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hypocycloidcam
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HypoCycloidCamForm());
        }
    }
}
