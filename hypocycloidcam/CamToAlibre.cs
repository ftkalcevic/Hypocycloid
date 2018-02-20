using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlibreX;
using System.Runtime.InteropServices;

namespace hypocycloidcam
{
    static class AlibreExtensions
    {
        
        public static IADDesignPlane planeXY(this IADPartSession part)
        {
            return part.DesignPlanes.Item("XY-Plane");
        }
        //public static IADPlane FindPlane(this IADDesignPlanes planes, string name)
        //{
        //    for ( int i = 0; i < planes.Count; i++ )
        //        if ( planes.Item(
        //}
    }

    struct Motor
    {
        public double motorMountBore;
        public int mountingHoles;
        public double mountingHolePitchCircle;
        public double mountingHoleDia;
        public double mountingHoleCSDia;
        public double shaftDia;
    }

    class CamToAlibre
    {
        HypocycloidCam cam;

        public double CamThickness { get; set; }
        public double PinHeight { get; set; }
        public double BaseThickness { get; set; }
        public double BearingID { get; set; }
        public Motor motor { get; set; }

        public CamToAlibre(HypocycloidCam cam)
        {
            this.cam = cam;
            CamThickness = 5.0;
            PinHeight = 10;
            BaseThickness = 5;
            BearingID = 15;
            motor = new Motor()
            {
                motorMountBore = 22,
                mountingHoles = 4,
                mountingHolePitchCircle = 2.0 * Math.Sqrt(Math.Pow(31.0/2.0, 2) * 2),
                mountingHoleDia = 3.2,
                mountingHoleCSDia = 7,
                shaftDia = 5
            };
        }

        public void Create(string name)
        {
            IAutomationHook hook = null;
            try
            {
                hook = (IAutomationHook)Marshal.GetActiveObject("AlibreX.AutomationHook");
            }
            catch (Exception e)
            {
                throw new Exception("Failed to connect to Alibre Design.  Is it running?", e);
            }

            IADRoot root = (IADRoot)hook.Root;
            IADAssemblySession assembly = root.CreateEmptyAssembly(name);

            CreateParameters(assembly, name + "_Parameters");
            CreateCAM(assembly, name + "_CAM");
            CreateBase(assembly, name + "_BASE");
            CreateEccentric(assembly, name + "_ECCENTRIC");
            //object path = @"c:\temp\ad";
            //assembly.SaveAs(ref path, name);
            //assembly.Close();
        }

        private void CreateParameters(IADAssemblySession assembly, string name)
        {
            IADGlobalParameterSession session = assembly.Root.CreateEmptyGlobalParameters("GlobalParameters");

            IADParameter globalPararmEccentric = session.Parameters.NewParameter("Eccentricy", ADParameterType.AD_DISTANCE);
            IADParameter globalBearingInnerDia = session.Parameters.NewParameter("BearingInnerDia", ADParameterType.AD_DISTANCE);
            IADParameter globalDriveShaftDia = session.Parameters.NewParameter("DriveShaftDia", ADParameterType.AD_DISTANCE);

            session.Parameters.OpenParameterTransaction();

            globalPararmEccentric.Units = ADUnits.AD_MILLIMETERS;
            globalPararmEccentric.Value = cam.Eccentricity;

            globalBearingInnerDia.Units = ADUnits.AD_MILLIMETERS;
            globalBearingInnerDia.Value = 15;

            globalDriveShaftDia.Units = ADUnits.AD_MILLIMETERS;
            globalDriveShaftDia.Value = motor.shaftDia;

            session.Parameters.CloseParameterTransaction();
        }

        private void CreateEccentric(IADAssemblySession assembly, string name)
        {
            IADTransformation trans = assembly.GeometryFactory.CreateIdentityTransform();
            IADOccurrence occurrence = assembly.RootOccurrence.Occurrences.AddEmptyPart(name, isSheetMetal: false, pTransform: trans);
            IADPartSession part = (IADPartSession)occurrence.DesignSession;
            IADDesignPlane xyPlane = part.DesignPlanes.Item("XY-Plane");

            //IADParameter eccentricParam = part.Parameters.NewParameter("Eccentric", ADParameterType.AD_DISTANCE);
            //IADParameter bearingInnerDiaParam = part.Parameters.NewParameter("BearingInnerDia", ADParameterType.AD_DISTANCE);
            //part.Parameters.OpenParameterTransaction();
            //eccentricParam.Value = MMToCM(cam.Eccentricity);
            //bearingInnerDiaParam.Value = MMToCM(BearingID);
            //part.Parameters.CloseParameterTransaction();

            //IADParameter eccentricyParam = part.Parameters.NewParameter("Eccentricy", ADParameterType.AD_DISTANCE);
            //part.Parameters.OpenParameterTransaction();
            //eccentricyParam.ExternallyDriven = true;
            //eccentricyParam.SourceDocumentID = "GlobalParameters";
            //eccentricyParam.SourceItemID = "Eccentricy";
            //part.Parameters.CloseParameterTransaction();

            // Create circle for the pin
            IADSketch sketch = part.Sketches.AddSketch(null, part.planeXY(), "Eccentric");
            sketch.BeginChange();
            IADSketchCircle circle = sketch.Figures.AddCircle(MMToCM(cam.Eccentricity), 0, MMToCM(BearingID / 2.0));
            //IADDimension dim = sketch.Dimensions.PlaceDiametricDimension(circle, "BearingInnerDia");
            sketch.EndChange();
            part.Features.AddExtrudedBoss(pSketch: sketch,
                                          depth: MMToCM(PinHeight),
                                          endCondition: ADPartFeatureEndCondition.AD_TO_DEPTH,
                                          toGeometryOcc: null,
                                          toGeometryObject: null,
                                          toGeometryOffset: 0,
                                          direction: ADDirectionType.AD_ALONG_NORMAL,
                                          pDirectionOcc: null,
                                          pDirectionObject: null,
                                          isDirectionReversed: true,
                                          draftAngle: null,
                                          IsOutwardDraft: false,
                                          name: "Eccentric");

            sketch = part.Sketches.AddSketch(null, part.planeXY(), "Centered");
            sketch.BeginChange();
            circle = sketch.Figures.AddCircle(0, 0, MMToCM(BearingID / 2.0));
            //dim = sketch.Dimensions.PlaceDiametricDimension(circle, "BearingInnerDia");
            sketch.EndChange();
            part.Features.AddExtrudedBoss(pSketch: sketch,
                                          depth: MMToCM(PinHeight),
                                          endCondition: ADPartFeatureEndCondition.AD_TO_DEPTH,
                                          toGeometryOcc: null,
                                          toGeometryObject: null,
                                          toGeometryOffset: 0,
                                          direction: ADDirectionType.AD_ALONG_NORMAL,
                                          pDirectionOcc: null,
                                          pDirectionObject: null,
                                          isDirectionReversed: false,
                                          draftAngle: null,
                                          IsOutwardDraft: false,
                                          name: "Pin");

            // Create the bore for the motor shaft
            sketch = part.Sketches.AddSketch(null, part.planeXY(), "Motor shaft Bore ");
            sketch.BeginChange();
            circle = sketch.Figures.AddCircle(0, 0, MMToCM(motor.shaftDia / 2.0));
            //dim = sketch.Dimensions.PlaceDiametricDimension(circle, "DriveShaftDia");
            sketch.EndChange();
            part.Features.AddExtrudedCutout(pSketch: sketch,
                                             depth: 0,
                                             endCondition: ADPartFeatureEndCondition.AD_THROUGH_ALL,
                                             toGeometryOcc: null,
                                             toGeometryObject: null,
                                             toGeometryOffset: 0,
                                             direction: ADDirectionType.AD_ALONG_NORMAL,
                                             pDirectionOcc: null,
                                             pDirectionObject: null,
                                             isDirectionReversed: false,
                                             draftAngle: null,
                                             IsOutwardDraft: false,
                                             name: "Motor shaft Bore");

            //object filename = @"c:\temp\ad";
            //part.SaveAs(ref filename, "name");

        }


        private void CreateBase(IADAssemblySession assembly, string name)
        {
            IADTransformation trans = assembly.GeometryFactory.CreateIdentityTransform();
            IADOccurrence occurrence = assembly.RootOccurrence.Occurrences.AddEmptyPart(name, isSheetMetal: false, pTransform: trans);
            IADPartSession part = (IADPartSession)occurrence.DesignSession;

            IADDesignPlane xyPlane = part.DesignPlanes.Item("XY-Plane");
            IADSketch sketch = part.Sketches.AddSketch(null, part.planeXY(), "Pin");

            // Create circle for the pin
           
            sketch.BeginChange();
            foreach (Pt p in cam.rollerPoints)
            {
                sketch.Figures.AddCircle(MMToCM(p.x), MMToCM(p.y), MMToCM(cam.RollerDiameter / 2.0));
            }
            sketch.EndChange();
            part.Features.AddExtrudedBoss(pSketch: sketch,
                                          depth: MMToCM(PinHeight),
                                          endCondition: ADPartFeatureEndCondition.AD_TO_DEPTH,
                                          toGeometryOcc: null,
                                          toGeometryObject: null,
                                          toGeometryOffset: 0,
                                          direction: ADDirectionType.AD_ALONG_NORMAL,
                                          pDirectionOcc: null,
                                          pDirectionObject: null,
                                          isDirectionReversed: false,
                                          draftAngle: null,
                                          IsOutwardDraft: false,
                                          name: "Pin");

            // Base body
            sketch = part.Sketches.AddSketch(null, part.planeXY(), "Base");

            sketch.BeginChange();
            sketch.Figures.AddCircle(0, 0, MMToCM(cam.ComputedPinBoltCircleDiameter/2 + cam.RollerDiameter));
            sketch.EndChange();

            part.Features.AddExtrudedBoss(pSketch: sketch,
                                          depth: MMToCM(BaseThickness),
                                          endCondition: ADPartFeatureEndCondition.AD_TO_DEPTH,
                                          toGeometryOcc: null,
                                          toGeometryObject: null,
                                          toGeometryOffset: 0,
                                          direction: ADDirectionType.AD_ALONG_NORMAL,
                                          pDirectionOcc: null,
                                          pDirectionObject: null,
                                          isDirectionReversed: true,
                                          draftAngle: null,
                                          IsOutwardDraft: false,
                                          name: "Base");

            // Create the bore for the motor
            sketch = part.Sketches.AddSketch(null, part.planeXY(), "Motor Mount Bore ");
            sketch.BeginChange();
            sketch.Figures.AddCircle(0, 0, MMToCM(motor.motorMountBore / 2.0));
            sketch.EndChange();
            part.Features.AddExtrudedCutout(pSketch: sketch,
                                             depth: 0,
                                             endCondition: ADPartFeatureEndCondition.AD_THROUGH_ALL,
                                             toGeometryOcc: null,
                                             toGeometryObject: null,
                                             toGeometryOffset: 0,
                                             direction: ADDirectionType.AD_ALONG_NORMAL,
                                             pDirectionOcc: null,
                                             pDirectionObject: null,
                                             isDirectionReversed: false,
                                             draftAngle: null,
                                             IsOutwardDraft: false,
                                             name: "Motor Mount Bore");

            // Create the CS mounting holes for the motor
            sketch = part.Sketches.AddSketch(null, part.planeXY(), "Motor Mounting Holes");
            sketch.BeginChange();
            for (int i = 0; i < motor.mountingHoles; i++)
            {
                sketch.Figures.AddSketchPoint(MMToCM(Math.Cos(2*Math.PI * i / motor.mountingHoles) * motor.mountingHolePitchCircle/2),
                                              MMToCM(Math.Sin(2*Math.PI * i / motor.mountingHoles) * motor.mountingHolePitchCircle/2));
            }
            sketch.EndChange();
            part.Features.AddCounterSunkHole(pSketch: sketch,
                                              depth: 0,
                                              diameter: MMToCM(motor.mountingHoleDia),
                                              counterSinkDiameter: MMToCM(motor.mountingHoleCSDia),
                                              counterSinkAngle: Math.PI / 2,
                                              isReversed: false,
                                              tappedThread: null,
                                              depthCondition: ADHoleDepthCondition.AD_HOLE_THROUGH_ALL,
                                              toGeometryOcc: null,
                                              toGeometryObject: null,
                                              toGeometryOffset: 0,
                                              name: "Motor mounting holes");

            //object filename = @"c:\temp\ad";
            //part.SaveAs(ref filename, "name");
        }

        private void CreateCAM(IADAssemblySession assembly, string name)
        {
            IADTransformation trans =  assembly.GeometryFactory.CreateIdentityTransform();
            IADOccurrence occurrence = assembly.RootOccurrence.Occurrences.AddEmptyPart(name, isSheetMetal: false, pTransform: trans);
            IADPartSession part = (IADPartSession)occurrence.DesignSession;


            IADDesignPlane xyPlane = part.DesignPlanes.Item("XY-Plane");
            IADSketch sketch = part.Sketches.AddSketch(null, part.planeXY(), "CAM Profile");

            // Create the spline
            int order = 3;
            int splinePoints = cam.camPoints.Count + 1;
            Array points = new double [splinePoints*2];
            Array knots = new double[splinePoints+order];
            Array weights = new double[splinePoints];

            int idx = 0;
            for (int i = 0; i < cam.camPoints.Count; i++)
            {
                points.SetValue(MMToCM(cam.camPoints[i].x), idx * 2);
                points.SetValue(MMToCM(cam.camPoints[i].y), idx * 2 + 1);
                weights.SetValue(0, idx);
                idx++;
                //if (i == 0 )
                //{
                //    points.SetValue(cam.camPoints[i].x, idx * 2);
                //    points.SetValue(cam.camPoints[i].y, idx * 2 + 1);
                //    weights.SetValue(0, idx);
                //    idx++;
                //}
            }
            // Add the first point again to close the spline
            points.SetValue(points.GetValue(0), idx * 2);
            points.SetValue(points.GetValue(1), idx * 2 + 1);
            weights.SetValue(0, idx);
            idx++;
            //points.SetValue(cam.camPoints[0].x, idx * 2);
            //points.SetValue(cam.camPoints[0].y, idx * 2 + 1);
            //weights.SetValue(0, idx);
            //idx++;

            idx = 0;
            for (int i = 0; i < splinePoints-order+1; i++)
            {
                knots.SetValue((float)i / (float)(splinePoints-order+1), i+order-1);
            }
            for (int i = 0; i < order; i++)
            {
                knots.SetValue(0, i);
                knots.SetValue(1, splinePoints + i);
            }
            sketch.BeginChange();
            sketch.Figures.AddBspline(order, splinePoints, ref points, ref knots, ref weights);
            sketch.EndChange();

            // Extrude the cam
            double draftAngle = 0;
            part.Features.AddExtrudedBoss(pSketch: sketch,
                                           depth: MMToCM(CamThickness),
                                           endCondition: ADPartFeatureEndCondition.AD_TO_DEPTH,
                                           toGeometryOcc: null,
                                           toGeometryObject: null,
                                           toGeometryOffset: 0,
                                           direction: ADDirectionType.AD_ALONG_NORMAL,
                                           pDirectionOcc: null,
                                           pDirectionObject: null,
                                           isDirectionReversed: false,
                                           draftAngle: draftAngle,
                                           IsOutwardDraft: false,
                                           name: "CAM Boss");

            // Create the bore
            sketch = part.Sketches.AddSketch(null, part.planeXY(), "Bore ");
            sketch.BeginChange();
            sketch.Figures.AddCircle(0, 0, MMToCM(cam.BoreDiameter/2.0));
            sketch.EndChange();
            part.Features.AddExtrudedCutout(pSketch: sketch,
                                             depth: 0,
                                             endCondition: ADPartFeatureEndCondition.AD_THROUGH_ALL,
                                             toGeometryOcc: null,
                                             toGeometryObject: null,
                                             toGeometryOffset: 0,
                                             direction: ADDirectionType.AD_ALONG_NORMAL,
                                             pDirectionOcc: null,
                                             pDirectionObject: null,
                                             isDirectionReversed: false,
                                             draftAngle: draftAngle,
                                             IsOutwardDraft: false,
                                             name: "Bore cutout");
                                             
            //object filename = @"c:\temp\ad";
            //part.SaveAs(ref filename,"name");
        }

        private double MMToCM(double mm)
        {
            return mm / 10.0;
        }
    }
}
