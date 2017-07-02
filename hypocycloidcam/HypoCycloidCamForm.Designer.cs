namespace hypocycloidcam
{
    partial class HypoCycloidCamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Redraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.spinTeethInCam = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.spinRollerDiameter = new System.Windows.Forms.NumericUpDown();
            this.spinPinBoltCircleDiameter = new System.Windows.Forms.NumericUpDown();
            this.spinEccentricity = new System.Windows.Forms.NumericUpDown();
            this.spinToothPitch = new System.Windows.Forms.NumericUpDown();
            this.spinPressureAngleLimit = new System.Windows.Forms.NumericUpDown();
            this.spinOffsetInPressureAngle = new System.Windows.Forms.NumericUpDown();
            this.lblActualToothPitch = new System.Windows.Forms.Label();
            this.lblActualBoltCircleDiameter = new System.Windows.Forms.Label();
            this.btnSaveDXF = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMinPressureAngle = new System.Windows.Forms.Label();
            this.lblMaxPressureAngle = new System.Windows.Forms.Label();
            this.spinBoreDiameter = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.camPanel = new hypocycloidcam.CycloidDisplay();
            ((System.ComponentModel.ISupportInitialize)(this.spinTeethInCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRollerDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPinBoltCircleDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEccentricity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinToothPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPressureAngleLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOffsetInPressureAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoreDiameter)).BeginInit();
            this.SuspendLayout();
            // 
            // Redraw
            // 
            this.Redraw.Location = new System.Drawing.Point(860, 84);
            this.Redraw.Name = "Redraw";
            this.Redraw.Size = new System.Drawing.Size(129, 47);
            this.Redraw.TabIndex = 1;
            this.Redraw.Text = "Refresh";
            this.Redraw.UseVisualStyleBackColor = true;
            this.Redraw.Click += new System.EventHandler(this.Redraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teeth In Cam";
            // 
            // spinTeethInCam
            // 
            this.spinTeethInCam.Location = new System.Drawing.Point(248, 12);
            this.spinTeethInCam.Name = "spinTeethInCam";
            this.spinTeethInCam.Size = new System.Drawing.Size(80, 29);
            this.spinTeethInCam.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Roller Diameter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pin Bolt Circle Diameter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Eccentricity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tooth Pitch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pressure Angle Limit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Offset in Pressure Angle";
            // 
            // spinRollerDiameter
            // 
            this.spinRollerDiameter.DecimalPlaces = 2;
            this.spinRollerDiameter.Location = new System.Drawing.Point(248, 47);
            this.spinRollerDiameter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinRollerDiameter.Name = "spinRollerDiameter";
            this.spinRollerDiameter.Size = new System.Drawing.Size(114, 29);
            this.spinRollerDiameter.TabIndex = 11;
            // 
            // spinPinBoltCircleDiameter
            // 
            this.spinPinBoltCircleDiameter.DecimalPlaces = 2;
            this.spinPinBoltCircleDiameter.Location = new System.Drawing.Point(248, 82);
            this.spinPinBoltCircleDiameter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinPinBoltCircleDiameter.Name = "spinPinBoltCircleDiameter";
            this.spinPinBoltCircleDiameter.Size = new System.Drawing.Size(114, 29);
            this.spinPinBoltCircleDiameter.TabIndex = 12;
            // 
            // spinEccentricity
            // 
            this.spinEccentricity.DecimalPlaces = 2;
            this.spinEccentricity.Location = new System.Drawing.Point(248, 117);
            this.spinEccentricity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEccentricity.Name = "spinEccentricity";
            this.spinEccentricity.Size = new System.Drawing.Size(114, 29);
            this.spinEccentricity.TabIndex = 13;
            // 
            // spinToothPitch
            // 
            this.spinToothPitch.DecimalPlaces = 2;
            this.spinToothPitch.Location = new System.Drawing.Point(720, 12);
            this.spinToothPitch.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinToothPitch.Name = "spinToothPitch";
            this.spinToothPitch.Size = new System.Drawing.Size(114, 29);
            this.spinToothPitch.TabIndex = 14;
            // 
            // spinPressureAngleLimit
            // 
            this.spinPressureAngleLimit.DecimalPlaces = 2;
            this.spinPressureAngleLimit.Location = new System.Drawing.Point(720, 47);
            this.spinPressureAngleLimit.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.spinPressureAngleLimit.Name = "spinPressureAngleLimit";
            this.spinPressureAngleLimit.Size = new System.Drawing.Size(114, 29);
            this.spinPressureAngleLimit.TabIndex = 15;
            // 
            // spinOffsetInPressureAngle
            // 
            this.spinOffsetInPressureAngle.DecimalPlaces = 2;
            this.spinOffsetInPressureAngle.Location = new System.Drawing.Point(720, 82);
            this.spinOffsetInPressureAngle.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.spinOffsetInPressureAngle.Name = "spinOffsetInPressureAngle";
            this.spinOffsetInPressureAngle.Size = new System.Drawing.Size(114, 29);
            this.spinOffsetInPressureAngle.TabIndex = 16;
            // 
            // lblActualToothPitch
            // 
            this.lblActualToothPitch.AutoSize = true;
            this.lblActualToothPitch.Location = new System.Drawing.Point(855, 14);
            this.lblActualToothPitch.Name = "lblActualToothPitch";
            this.lblActualToothPitch.Size = new System.Drawing.Size(53, 25);
            this.lblActualToothPitch.TabIndex = 17;
            this.lblActualToothPitch.Text = "(0.1)";
            // 
            // lblActualBoltCircleDiameter
            // 
            this.lblActualBoltCircleDiameter.AutoSize = true;
            this.lblActualBoltCircleDiameter.Location = new System.Drawing.Point(369, 84);
            this.lblActualBoltCircleDiameter.Name = "lblActualBoltCircleDiameter";
            this.lblActualBoltCircleDiameter.Size = new System.Drawing.Size(48, 25);
            this.lblActualBoltCircleDiameter.TabIndex = 18;
            this.lblActualBoltCircleDiameter.Text = "(80)";
            // 
            // btnSaveDXF
            // 
            this.btnSaveDXF.Location = new System.Drawing.Point(1010, 84);
            this.btnSaveDXF.Name = "btnSaveDXF";
            this.btnSaveDXF.Size = new System.Drawing.Size(129, 47);
            this.btnSaveDXF.TabIndex = 19;
            this.btnSaveDXF.Text = "Save DXF";
            this.btnSaveDXF.UseVisualStyleBackColor = true;
            this.btnSaveDXF.Click += new System.EventHandler(this.btnSaveDXF_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(929, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Min Pressure Angle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(929, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Max Pressure Angle";
            // 
            // lblMinPressureAngle
            // 
            this.lblMinPressureAngle.AutoSize = true;
            this.lblMinPressureAngle.Location = new System.Drawing.Point(1128, 14);
            this.lblMinPressureAngle.Name = "lblMinPressureAngle";
            this.lblMinPressureAngle.Size = new System.Drawing.Size(23, 25);
            this.lblMinPressureAngle.TabIndex = 21;
            this.lblMinPressureAngle.Text = "0";
            // 
            // lblMaxPressureAngle
            // 
            this.lblMaxPressureAngle.AutoSize = true;
            this.lblMaxPressureAngle.Location = new System.Drawing.Point(1128, 49);
            this.lblMaxPressureAngle.Name = "lblMaxPressureAngle";
            this.lblMaxPressureAngle.Size = new System.Drawing.Size(23, 25);
            this.lblMaxPressureAngle.TabIndex = 22;
            this.lblMaxPressureAngle.Text = "0";
            // 
            // spinBoreDiameter
            // 
            this.spinBoreDiameter.DecimalPlaces = 2;
            this.spinBoreDiameter.Location = new System.Drawing.Point(248, 152);
            this.spinBoreDiameter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinBoreDiameter.Name = "spinBoreDiameter";
            this.spinBoreDiameter.Size = new System.Drawing.Size(114, 29);
            this.spinBoreDiameter.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Bore Diameter";
            // 
            // camPanel
            // 
            this.camPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.camPanel.BackColor = System.Drawing.SystemColors.Window;
            this.camPanel.Cam = null;
            this.camPanel.Location = new System.Drawing.Point(13, 207);
            this.camPanel.Name = "camPanel";
            this.camPanel.Size = new System.Drawing.Size(1236, 590);
            this.camPanel.TabIndex = 0;
            // 
            // HypoCycloidCamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 825);
            this.Controls.Add(this.spinBoreDiameter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblMaxPressureAngle);
            this.Controls.Add(this.lblMinPressureAngle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSaveDXF);
            this.Controls.Add(this.lblActualBoltCircleDiameter);
            this.Controls.Add(this.lblActualToothPitch);
            this.Controls.Add(this.spinOffsetInPressureAngle);
            this.Controls.Add(this.spinPressureAngleLimit);
            this.Controls.Add(this.spinToothPitch);
            this.Controls.Add(this.spinEccentricity);
            this.Controls.Add(this.spinPinBoltCircleDiameter);
            this.Controls.Add(this.spinRollerDiameter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spinTeethInCam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Redraw);
            this.Controls.Add(this.camPanel);
            this.Name = "HypoCycloidCamForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.spinTeethInCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRollerDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPinBoltCircleDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEccentricity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinToothPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPressureAngleLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOffsetInPressureAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoreDiameter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CycloidDisplay camPanel;
        private System.Windows.Forms.Button Redraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spinTeethInCam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown spinRollerDiameter;
        private System.Windows.Forms.NumericUpDown spinPinBoltCircleDiameter;
        private System.Windows.Forms.NumericUpDown spinEccentricity;
        private System.Windows.Forms.NumericUpDown spinToothPitch;
        private System.Windows.Forms.NumericUpDown spinPressureAngleLimit;
        private System.Windows.Forms.NumericUpDown spinOffsetInPressureAngle;
        private System.Windows.Forms.Label lblActualToothPitch;
        private System.Windows.Forms.Label lblActualBoltCircleDiameter;
        private System.Windows.Forms.Button btnSaveDXF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMinPressureAngle;
        private System.Windows.Forms.Label lblMaxPressureAngle;
        private System.Windows.Forms.NumericUpDown spinBoreDiameter;
        private System.Windows.Forms.Label label10;
    }
}

