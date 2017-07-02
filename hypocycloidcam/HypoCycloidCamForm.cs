using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hypocycloidcam
{
    public partial class HypoCycloidCamForm : Form
    {
        HypocycloidCam cam;

        public HypoCycloidCamForm()
        {
            InitializeComponent();
            cam = new HypocycloidCam();
            camPanel.Cam = cam;

            spinTeethInCam.Value = cam.TeethInCAM;
            spinRollerDiameter.Value = (decimal)cam.RollerDiameter;
            spinPinBoltCircleDiameter.Value = (decimal)cam.PinBoltCircleDiameter;
            spinEccentricity.Value = (decimal)cam.Eccentricity;
            spinToothPitch.Value = (decimal)cam.ToothPitch;
            spinPressureAngleLimit.Value = (decimal)cam.PressureAngleLimit;
            spinOffsetInPressureAngle.Value = (decimal)cam.OffsetInPressureAngle;
            spinBoreDiameter.Value = (decimal)cam.BoreDiameter;

            spinTeethInCam.ValueChanged += SpinTeethInCam_ValueChanged;
            spinRollerDiameter.ValueChanged += SpinRollerDiameter_ValueChanged;
            spinPinBoltCircleDiameter.ValueChanged += SpinPinBoltCircleDiameter_ValueChanged;
            spinEccentricity.ValueChanged += SpinEccentricity_ValueChanged;
            spinToothPitch.ValueChanged += SpinToothPitch_ValueChanged;
            spinPressureAngleLimit.ValueChanged += SpinPressureAngleLimit_ValueChanged;
            spinOffsetInPressureAngle.ValueChanged += SpinOffsetInPressureAngle_ValueChanged;
            spinBoreDiameter.ValueChanged += SpinBoreDiameter_ValueChanged;

            Regen();
        }

        private void Regen()
        {
            cam.main();
            Refresh();
            lblActualToothPitch.Text = $"({cam.ComputedToothPitch})";
            lblActualBoltCircleDiameter.Text = $"({cam.ComputedPinBoltCircleDiameter})";
            lblMinPressureAngle.Text = cam.PressureAngleMin.ToString() + @"°";
            lblMaxPressureAngle.Text = cam.PressureAngleMax.ToString() + @"°";
        }

        private void SpinBoreDiameter_ValueChanged(object sender, EventArgs e)
        {
            cam.BoreDiameter = (double)spinBoreDiameter.Value;
            Regen();
        }
        
        private void SpinOffsetInPressureAngle_ValueChanged(object sender, EventArgs e)
        {
            cam.OffsetInPressureAngle = (double)spinOffsetInPressureAngle.Value;
            Regen();
        }

        private void SpinPressureAngleLimit_ValueChanged(object sender, EventArgs e)
        {
            cam.PressureAngleLimit = (double)spinPressureAngleLimit.Value;
            Regen();
        }

        private void SpinToothPitch_ValueChanged(object sender, EventArgs e)
        {
            cam.ToothPitch = (double)spinToothPitch.Value;
            Regen();
        }

        private void SpinEccentricity_ValueChanged(object sender, EventArgs e)
        {
            cam.Eccentricity = (double)spinEccentricity.Value;
            Regen();
        }

        private void SpinPinBoltCircleDiameter_ValueChanged(object sender, EventArgs e)
        {
            cam.PinBoltCircleDiameter = (double)spinPinBoltCircleDiameter.Value;
            Regen();
        }

        private void SpinRollerDiameter_ValueChanged(object sender, EventArgs e)
        {
            cam.RollerDiameter = (double)spinRollerDiameter.Value;
            Regen();
        }

        private void SpinTeethInCam_ValueChanged(object sender, EventArgs e)
        {
            cam.TeethInCAM = (int)spinTeethInCam.Value;
            Regen();
        }

        private void Redraw_Click(object sender, EventArgs e)
        {
            Regen(); 
        }

        private void btnSaveDXF_Click(object sender, EventArgs e)
        {
            CamToDxf c = new CamToDxf(cam);
            c.Save("test.dxf");
        }
    }
}
