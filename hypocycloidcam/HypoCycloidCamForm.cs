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
        private CycloidDisplay camPanel;

        public HypoCycloidCamForm()
        {
            InitializeComponent();
            this.camPanel = new CycloidDisplay();
            this.camPanel.Anchor = panelPlaceHolder.Anchor;
            this.camPanel.BackColor = System.Drawing.SystemColors.Window;
            this.camPanel.Cam = null;
            this.camPanel.Location = panelPlaceHolder.Location;
            this.camPanel.Name = "camPanel";
            this.camPanel.Size = panelPlaceHolder.Size;
            this.camPanel.TabIndex = 0;
            this.Controls.Add(this.camPanel);
            cam = new HypocycloidCam();
            this.camPanel.Cam = cam;
            this.panelPlaceHolder.Visible = false;

            this.AutoScaleMode = AutoScaleMode.Dpi;

            cam.TeethInCAM = Properties.Settings.Default.TeethInCam;
            cam.RollerDiameter = Properties.Settings.Default.RollerDiameter;
            cam.PinBoltCircleDiameter = Properties.Settings.Default.PinBoltCircleDiameter;
            cam.Eccentricity = Properties.Settings.Default.Eccentricity;
            //cam.BoreDiameter = Properties.Settings.Default.BoreDiameter;
            cam.ToothPitch = Properties.Settings.Default.ToothPitch;
            cam.PressureAngleLimit = Properties.Settings.Default.PressureAngleLimit;
            cam.OffsetInPressureAngle = Properties.Settings.Default.OffsetInPressureAngle;
            cam.OutputBearings = Properties.Settings.Default.OutputBearings;
            cam.OutputBearingsDia = Properties.Settings.Default.OutputBearingsDia;
            cam.OutputPitchCircleDia = Properties.Settings.Default.OutputPitchCircleDia;
            cam.EccentricBearingInnerDia = Properties.Settings.Default.EccentricBearingInnerDia;
            cam.EccentricBearingOuterDia = Properties.Settings.Default.EccentricBearingOuterDia;

            spinTeethInCam.Value = cam.TeethInCAM;
            spinRollerDiameter.Value = (decimal)cam.RollerDiameter;
            spinPinBoltCircleDiameter.Value = (decimal)cam.PinBoltCircleDiameter;
            spinEccentricity.Value = (decimal)cam.Eccentricity;
            spinToothPitch.Value = (decimal)cam.ToothPitch;
            spinPressureAngleLimit.Value = (decimal)cam.PressureAngleLimit;
            spinOffsetInPressureAngle.Value = (decimal)cam.OffsetInPressureAngle;
            //spinBoreDiameter.Value = (decimal)cam.BoreDiameter;
            spinOutputBearings.Value = cam.OutputBearings;
            spinOutputBearingsDia.Value = (decimal)cam.OutputBearingsDia;
            spinOutputPitchCircleDia.Value = (decimal)cam.OutputPitchCircleDia;
            spinEccentricBearingInnerDia.Value = (decimal)cam.EccentricBearingInnerDia;
            spinEccentricBearingOuterDia.Value = (decimal)cam.EccentricBearingOuterDia;

            spinTeethInCam.ValueChanged += SpinTeethInCam_ValueChanged;
            spinRollerDiameter.ValueChanged += SpinRollerDiameter_ValueChanged;
            spinPinBoltCircleDiameter.ValueChanged += SpinPinBoltCircleDiameter_ValueChanged;
            spinEccentricity.ValueChanged += SpinEccentricity_ValueChanged;
            spinToothPitch.ValueChanged += SpinToothPitch_ValueChanged;
            spinPressureAngleLimit.ValueChanged += SpinPressureAngleLimit_ValueChanged;
            spinOffsetInPressureAngle.ValueChanged += SpinOffsetInPressureAngle_ValueChanged;
            //spinBoreDiameter.ValueChanged += SpinBoreDiameter_ValueChanged;
            spinOutputBearings.ValueChanged += OtherValues_Changed;
            spinOutputBearingsDia.ValueChanged += OtherValues_Changed;
            spinOutputPitchCircleDia.ValueChanged += OtherValues_Changed;
            spinEccentricBearingInnerDia.ValueChanged += OtherValues_Changed;
            spinEccentricBearingOuterDia.ValueChanged += OtherValues_Changed;

            Regen();
        }

        private void OtherValues_Changed(object sender, EventArgs e)
        {
            cam.OutputBearings = (int)spinOutputBearings.Value;
            cam.OutputBearingsDia = (double)spinOutputBearingsDia.Value;
            cam.OutputPitchCircleDia = (double)spinOutputPitchCircleDia.Value;
            cam.EccentricBearingInnerDia = (double)spinEccentricBearingInnerDia.Value;
            cam.EccentricBearingOuterDia = (double)spinEccentricBearingOuterDia.Value;

            Regen();
        }

        private void Regen()
        {
            System.Diagnostics.Debug.WriteLine("Regen()");
            cam.OutputLineSegments = cam.TeethInCAM * 80;
            cam.main();
            Refresh();
            lblActualToothPitch.Text = $"({cam.ComputedToothPitch})";
            lblActualBoltCircleDiameter.Text = $"({cam.ComputedPinBoltCircleDiameter})";
            lblMinPressureAngle.Text = cam.PressureAngleMin.ToString() + @"°";
            lblMaxPressureAngle.Text = cam.PressureAngleMax.ToString() + @"°";
        }

        //private void SpinBoreDiameter_ValueChanged(object sender, EventArgs e)
        //{
        //    cam.BoreDiameter = (double)spinBoreDiameter.Value;
        //    Regen();
        //}
        
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
            System.Diagnostics.Debug.WriteLine("SpinPinBoltCircleDiameter_ValueChanged");
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

        private void btnCreateAD_Click(object sender, EventArgs e)
        {
            try
            {
                CamToAlibre a = new CamToAlibre(cam);
                a.Create("hypocylcoid");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create Alibre Design assembly\n\n" + ex.ToString());
            }
        }

        private void HypoCycloidCamForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.TeethInCam = cam.TeethInCAM;
            Properties.Settings.Default.RollerDiameter = cam.RollerDiameter;
            Properties.Settings.Default.PinBoltCircleDiameter = cam.PinBoltCircleDiameter;
            Properties.Settings.Default.Eccentricity = cam.Eccentricity;
            //Properties.Settings.Default.BoreDiameter = cam.BoreDiameter;
            Properties.Settings.Default.ToothPitch = cam.ToothPitch;
            Properties.Settings.Default.PressureAngleLimit = cam.PressureAngleLimit;
            Properties.Settings.Default.OffsetInPressureAngle = cam.OffsetInPressureAngle;
            Properties.Settings.Default.OutputBearings = cam.OutputBearings;
            Properties.Settings.Default.OutputBearingsDia = cam.OutputBearingsDia;
            Properties.Settings.Default.OutputPitchCircleDia = cam.OutputPitchCircleDia;
            Properties.Settings.Default.EccentricBearingInnerDia = cam.EccentricBearingInnerDia;
            Properties.Settings.Default.EccentricBearingOuterDia = cam.EccentricBearingOuterDia;

            Properties.Settings.Default.Save();
        }
    }
}
