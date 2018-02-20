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
            this.btnSaveDXF = new System.Windows.Forms.Button();
            this.btnCreateAD = new System.Windows.Forms.Button();
            this.panelPlaceHolder = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spinOutputBearings = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.spinOutputBearingsDia = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.spinOutputPitchCircleDia = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.Eccentric = new System.Windows.Forms.GroupBox();
            this.spinEccentricBearingInnerDia = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.spinEccentricBearingOuterDia = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.General = new System.Windows.Forms.GroupBox();
            this.lblMaxPressureAngle = new System.Windows.Forms.Label();
            this.lblMinPressureAngle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblActualBoltCircleDiameter = new System.Windows.Forms.Label();
            this.lblActualToothPitch = new System.Windows.Forms.Label();
            this.spinOffsetInPressureAngle = new System.Windows.Forms.NumericUpDown();
            this.spinPressureAngleLimit = new System.Windows.Forms.NumericUpDown();
            this.spinToothPitch = new System.Windows.Forms.NumericUpDown();
            this.spinEccentricity = new System.Windows.Forms.NumericUpDown();
            this.spinPinBoltCircleDiameter = new System.Windows.Forms.NumericUpDown();
            this.spinRollerDiameter = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spinTeethInCam = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinOutputBearings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOutputBearingsDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOutputPitchCircleDia)).BeginInit();
            this.Eccentric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEccentricBearingInnerDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEccentricBearingOuterDia)).BeginInit();
            this.General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinOffsetInPressureAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPressureAngleLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinToothPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEccentricity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPinBoltCircleDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRollerDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTeethInCam)).BeginInit();
            this.SuspendLayout();
            // 
            // Redraw
            // 
            this.Redraw.Location = new System.Drawing.Point(7, 368);
            this.Redraw.Margin = new System.Windows.Forms.Padding(2);
            this.Redraw.Name = "Redraw";
            this.Redraw.Size = new System.Drawing.Size(64, 25);
            this.Redraw.TabIndex = 1;
            this.Redraw.Text = "Refresh";
            this.Redraw.UseVisualStyleBackColor = true;
            this.Redraw.Click += new System.EventHandler(this.Redraw_Click);
            // 
            // btnSaveDXF
            // 
            this.btnSaveDXF.Location = new System.Drawing.Point(89, 368);
            this.btnSaveDXF.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveDXF.Name = "btnSaveDXF";
            this.btnSaveDXF.Size = new System.Drawing.Size(64, 25);
            this.btnSaveDXF.TabIndex = 19;
            this.btnSaveDXF.Text = "Save DXF";
            this.btnSaveDXF.UseVisualStyleBackColor = true;
            this.btnSaveDXF.Click += new System.EventHandler(this.btnSaveDXF_Click);
            // 
            // btnCreateAD
            // 
            this.btnCreateAD.Location = new System.Drawing.Point(89, 399);
            this.btnCreateAD.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateAD.Name = "btnCreateAD";
            this.btnCreateAD.Size = new System.Drawing.Size(64, 27);
            this.btnCreateAD.TabIndex = 25;
            this.btnCreateAD.Text = "Create AD";
            this.btnCreateAD.UseVisualStyleBackColor = true;
            this.btnCreateAD.Click += new System.EventHandler(this.btnCreateAD_Click);
            // 
            // panelPlaceHolder
            // 
            this.panelPlaceHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPlaceHolder.Location = new System.Drawing.Point(253, 7);
            this.panelPlaceHolder.Name = "panelPlaceHolder";
            this.panelPlaceHolder.Size = new System.Drawing.Size(739, 840);
            this.panelPlaceHolder.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spinOutputPitchCircleDia);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.spinOutputBearingsDia);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.spinOutputBearings);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(7, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 85);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CAM";
            // 
            // spinOutputBearings
            // 
            this.spinOutputBearings.Location = new System.Drawing.Point(135, 15);
            this.spinOutputBearings.Margin = new System.Windows.Forms.Padding(2);
            this.spinOutputBearings.Name = "spinOutputBearings";
            this.spinOutputBearings.Size = new System.Drawing.Size(44, 20);
            this.spinOutputBearings.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Output Bearings";
            // 
            // spinOutputBearingsDia
            // 
            this.spinOutputBearingsDia.Location = new System.Drawing.Point(135, 35);
            this.spinOutputBearingsDia.Margin = new System.Windows.Forms.Padding(2);
            this.spinOutputBearingsDia.Name = "spinOutputBearingsDia";
            this.spinOutputBearingsDia.Size = new System.Drawing.Size(44, 20);
            this.spinOutputBearingsDia.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 36);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Output Bearing Dia";
            // 
            // spinOutputPitchCircleDia
            // 
            this.spinOutputPitchCircleDia.Location = new System.Drawing.Point(135, 57);
            this.spinOutputPitchCircleDia.Margin = new System.Windows.Forms.Padding(2);
            this.spinOutputPitchCircleDia.Name = "spinOutputPitchCircleDia";
            this.spinOutputPitchCircleDia.Size = new System.Drawing.Size(44, 20);
            this.spinOutputPitchCircleDia.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 58);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Output Pitch Circle Dia";
            // 
            // Eccentric
            // 
            this.Eccentric.Controls.Add(this.spinEccentricBearingOuterDia);
            this.Eccentric.Controls.Add(this.label15);
            this.Eccentric.Controls.Add(this.spinEccentricBearingInnerDia);
            this.Eccentric.Controls.Add(this.label14);
            this.Eccentric.Location = new System.Drawing.Point(7, 301);
            this.Eccentric.Name = "Eccentric";
            this.Eccentric.Size = new System.Drawing.Size(194, 62);
            this.Eccentric.TabIndex = 28;
            this.Eccentric.TabStop = false;
            this.Eccentric.Text = "Eccentric";
            // 
            // spinEccentricBearingInnerDia
            // 
            this.spinEccentricBearingInnerDia.Location = new System.Drawing.Point(135, 15);
            this.spinEccentricBearingInnerDia.Margin = new System.Windows.Forms.Padding(2);
            this.spinEccentricBearingInnerDia.Name = "spinEccentricBearingInnerDia";
            this.spinEccentricBearingInnerDia.Size = new System.Drawing.Size(44, 20);
            this.spinEccentricBearingInnerDia.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Bearing Inner Dia";
            // 
            // spinEccentricBearingOuterDia
            // 
            this.spinEccentricBearingOuterDia.Location = new System.Drawing.Point(135, 37);
            this.spinEccentricBearingOuterDia.Margin = new System.Windows.Forms.Padding(2);
            this.spinEccentricBearingOuterDia.Name = "spinEccentricBearingOuterDia";
            this.spinEccentricBearingOuterDia.Size = new System.Drawing.Size(44, 20);
            this.spinEccentricBearingOuterDia.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 38);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Bearing Outer Dia";
            // 
            // General
            // 
            this.General.Controls.Add(this.lblMaxPressureAngle);
            this.General.Controls.Add(this.lblMinPressureAngle);
            this.General.Controls.Add(this.label9);
            this.General.Controls.Add(this.lblActualBoltCircleDiameter);
            this.General.Controls.Add(this.lblActualToothPitch);
            this.General.Controls.Add(this.spinOffsetInPressureAngle);
            this.General.Controls.Add(this.spinPressureAngleLimit);
            this.General.Controls.Add(this.spinToothPitch);
            this.General.Controls.Add(this.spinEccentricity);
            this.General.Controls.Add(this.spinPinBoltCircleDiameter);
            this.General.Controls.Add(this.spinRollerDiameter);
            this.General.Controls.Add(this.label7);
            this.General.Controls.Add(this.label6);
            this.General.Controls.Add(this.label8);
            this.General.Controls.Add(this.label5);
            this.General.Controls.Add(this.label4);
            this.General.Controls.Add(this.label3);
            this.General.Controls.Add(this.label2);
            this.General.Controls.Add(this.spinTeethInCam);
            this.General.Controls.Add(this.label1);
            this.General.Location = new System.Drawing.Point(7, 10);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(200, 193);
            this.General.TabIndex = 29;
            this.General.TabStop = false;
            this.General.Text = "General";
            // 
            // lblMaxPressureAngle
            // 
            this.lblMaxPressureAngle.AutoSize = true;
            this.lblMaxPressureAngle.Location = new System.Drawing.Point(117, 173);
            this.lblMaxPressureAngle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxPressureAngle.Name = "lblMaxPressureAngle";
            this.lblMaxPressureAngle.Size = new System.Drawing.Size(13, 13);
            this.lblMaxPressureAngle.TabIndex = 44;
            this.lblMaxPressureAngle.Text = "0";
            // 
            // lblMinPressureAngle
            // 
            this.lblMinPressureAngle.AutoSize = true;
            this.lblMinPressureAngle.Location = new System.Drawing.Point(117, 154);
            this.lblMinPressureAngle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinPressureAngle.Name = "lblMinPressureAngle";
            this.lblMinPressureAngle.Size = new System.Drawing.Size(13, 13);
            this.lblMinPressureAngle.TabIndex = 43;
            this.lblMinPressureAngle.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Max Pressure Angle";
            // 
            // lblActualBoltCircleDiameter
            // 
            this.lblActualBoltCircleDiameter.AutoSize = true;
            this.lblActualBoltCircleDiameter.Location = new System.Drawing.Point(201, 54);
            this.lblActualBoltCircleDiameter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActualBoltCircleDiameter.Name = "lblActualBoltCircleDiameter";
            this.lblActualBoltCircleDiameter.Size = new System.Drawing.Size(25, 13);
            this.lblActualBoltCircleDiameter.TabIndex = 41;
            this.lblActualBoltCircleDiameter.Text = "(80)";
            // 
            // lblActualToothPitch
            // 
            this.lblActualToothPitch.AutoSize = true;
            this.lblActualToothPitch.Location = new System.Drawing.Point(201, 148);
            this.lblActualToothPitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActualToothPitch.Name = "lblActualToothPitch";
            this.lblActualToothPitch.Size = new System.Drawing.Size(28, 13);
            this.lblActualToothPitch.TabIndex = 40;
            this.lblActualToothPitch.Text = "(0.1)";
            // 
            // spinOffsetInPressureAngle
            // 
            this.spinOffsetInPressureAngle.DecimalPlaces = 2;
            this.spinOffsetInPressureAngle.Location = new System.Drawing.Point(135, 128);
            this.spinOffsetInPressureAngle.Margin = new System.Windows.Forms.Padding(2);
            this.spinOffsetInPressureAngle.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.spinOffsetInPressureAngle.Name = "spinOffsetInPressureAngle";
            this.spinOffsetInPressureAngle.Size = new System.Drawing.Size(62, 20);
            this.spinOffsetInPressureAngle.TabIndex = 39;
            // 
            // spinPressureAngleLimit
            // 
            this.spinPressureAngleLimit.DecimalPlaces = 2;
            this.spinPressureAngleLimit.Location = new System.Drawing.Point(135, 109);
            this.spinPressureAngleLimit.Margin = new System.Windows.Forms.Padding(2);
            this.spinPressureAngleLimit.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.spinPressureAngleLimit.Name = "spinPressureAngleLimit";
            this.spinPressureAngleLimit.Size = new System.Drawing.Size(62, 20);
            this.spinPressureAngleLimit.TabIndex = 38;
            // 
            // spinToothPitch
            // 
            this.spinToothPitch.DecimalPlaces = 2;
            this.spinToothPitch.Location = new System.Drawing.Point(135, 91);
            this.spinToothPitch.Margin = new System.Windows.Forms.Padding(2);
            this.spinToothPitch.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinToothPitch.Name = "spinToothPitch";
            this.spinToothPitch.Size = new System.Drawing.Size(62, 20);
            this.spinToothPitch.TabIndex = 37;
            // 
            // spinEccentricity
            // 
            this.spinEccentricity.DecimalPlaces = 2;
            this.spinEccentricity.Location = new System.Drawing.Point(135, 71);
            this.spinEccentricity.Margin = new System.Windows.Forms.Padding(2);
            this.spinEccentricity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEccentricity.Name = "spinEccentricity";
            this.spinEccentricity.Size = new System.Drawing.Size(62, 20);
            this.spinEccentricity.TabIndex = 36;
            // 
            // spinPinBoltCircleDiameter
            // 
            this.spinPinBoltCircleDiameter.DecimalPlaces = 2;
            this.spinPinBoltCircleDiameter.Location = new System.Drawing.Point(135, 52);
            this.spinPinBoltCircleDiameter.Margin = new System.Windows.Forms.Padding(2);
            this.spinPinBoltCircleDiameter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinPinBoltCircleDiameter.Name = "spinPinBoltCircleDiameter";
            this.spinPinBoltCircleDiameter.Size = new System.Drawing.Size(62, 20);
            this.spinPinBoltCircleDiameter.TabIndex = 35;
            // 
            // spinRollerDiameter
            // 
            this.spinRollerDiameter.DecimalPlaces = 2;
            this.spinRollerDiameter.Location = new System.Drawing.Point(135, 33);
            this.spinRollerDiameter.Margin = new System.Windows.Forms.Padding(2);
            this.spinRollerDiameter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinRollerDiameter.Name = "spinRollerDiameter";
            this.spinRollerDiameter.Size = new System.Drawing.Size(62, 20);
            this.spinRollerDiameter.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Offset in Pressure Angle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Pressure Angle Limit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Min Pressure Angle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tooth Pitch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Eccentricity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Pin Bolt Circle Diameter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Roller Diameter";
            // 
            // spinTeethInCam
            // 
            this.spinTeethInCam.Location = new System.Drawing.Point(135, 15);
            this.spinTeethInCam.Margin = new System.Windows.Forms.Padding(2);
            this.spinTeethInCam.Name = "spinTeethInCam";
            this.spinTeethInCam.Size = new System.Drawing.Size(44, 20);
            this.spinTeethInCam.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Teeth In Cam";
            // 
            // HypoCycloidCamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 859);
            this.Controls.Add(this.General);
            this.Controls.Add(this.Eccentric);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelPlaceHolder);
            this.Controls.Add(this.btnCreateAD);
            this.Controls.Add(this.btnSaveDXF);
            this.Controls.Add(this.Redraw);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HypoCycloidCamForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HypoCycloidCamForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinOutputBearings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOutputBearingsDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOutputPitchCircleDia)).EndInit();
            this.Eccentric.ResumeLayout(false);
            this.Eccentric.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEccentricBearingInnerDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEccentricBearingOuterDia)).EndInit();
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinOffsetInPressureAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPressureAngleLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinToothPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEccentricity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPinBoltCircleDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRollerDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTeethInCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Redraw;
        private System.Windows.Forms.Button btnSaveDXF;
        private System.Windows.Forms.Button btnCreateAD;
        private System.Windows.Forms.Panel panelPlaceHolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown spinOutputPitchCircleDia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown spinOutputBearingsDia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown spinOutputBearings;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox Eccentric;
        private System.Windows.Forms.NumericUpDown spinEccentricBearingOuterDia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown spinEccentricBearingInnerDia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox General;
        private System.Windows.Forms.Label lblMaxPressureAngle;
        private System.Windows.Forms.Label lblMinPressureAngle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblActualBoltCircleDiameter;
        private System.Windows.Forms.Label lblActualToothPitch;
        private System.Windows.Forms.NumericUpDown spinOffsetInPressureAngle;
        private System.Windows.Forms.NumericUpDown spinPressureAngleLimit;
        private System.Windows.Forms.NumericUpDown spinToothPitch;
        private System.Windows.Forms.NumericUpDown spinEccentricity;
        private System.Windows.Forms.NumericUpDown spinPinBoltCircleDiameter;
        private System.Windows.Forms.NumericUpDown spinRollerDiameter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spinTeethInCam;
        private System.Windows.Forms.Label label1;
    }
}

