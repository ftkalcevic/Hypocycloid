using netDxf;
using netDxf.Entities;
using netDxf.Tables;

namespace hypocycloidcam
{
    class CamToDxf
    {
        private HypocycloidCam cam;

        public CamToDxf(HypocycloidCam cam)
        {
            this.cam = cam;
        }

        public void Save(string filename)
        {
            var dxf = new DxfDocument();

            Layer textLayer = new Layer("text") { Color = AciColor.Yellow };
            Layer camLayer = new Layer("cam") { Color = AciColor.Red };
            Layer rollerLayer = new Layer("roller") { Color = AciColor.Blue };
            Layer pressureLayer = new Layer("pressure") { Color = AciColor.Magenta };

            // Add text to discribe the cam - autodocument
            double textX = cam.ComputedPinBoltCircleDiameter / 2 + cam.RollerDiameter;
            double textY = cam.ComputedPinBoltCircleDiameter / 2;
            double textRowHeight = cam.ComputedPinBoltCircleDiameter / 15;
            double textHeight = textRowHeight * 0.5;

            dxf.AddEntity(new Text($"pitch={cam.ToothPitch}", new Vector2(textX, textY), textHeight) { Layer = textLayer }); textY -= textRowHeight;
            dxf.AddEntity(new Text($"pin diameter={cam.RollerDiameter}", new Vector2(textX, textY), textHeight) { Layer = textLayer }); textY -= textRowHeight;
            dxf.AddEntity(new Text($"pin bolt circle dia.={cam.ComputedPinBoltCircleDiameter}", new Vector2(textX, textY), textHeight) { Layer = textLayer }); textY -= textRowHeight;
            dxf.AddEntity(new Text($"eccentricty={cam.Eccentricity}", new Vector2(textX, textY), textHeight) { Layer = textLayer }); textY -= textRowHeight;
            dxf.AddEntity(new Text($"# of teeth={cam.TeethInCAM}", new Vector2(textX, textY), textHeight) { Layer = textLayer }); textY -= textRowHeight;
            dxf.AddEntity(new Text($"pressure angle limit={cam.PressureAngleLimit}", new Vector2(textX, textY), textHeight) { Layer = textLayer }); textY -= textRowHeight;
            dxf.AddEntity(new Text($"pressure angle offset={cam.OffsetInPressureAngle}", new Vector2(textX, textY), textHeight) { Layer = textLayer }); textY -= textRowHeight;
            dxf.AddEntity(new Text($"min pressure angle={cam.PressureAngleMin}", new Vector2(textX, textY), textHeight) { Layer = textLayer }); textY -= textRowHeight;
            dxf.AddEntity(new Text($"max pressure angle={cam.PressureAngleMax}", new Vector2(textX, textY), textHeight) { Layer = textLayer }); textY -= textRowHeight;

            dxf.AddEntity(new Circle(new Vector2(-cam.Eccentricity, 0), cam.PressureAngleMinRadius) { Layer = pressureLayer });
            dxf.AddEntity(new Circle(new Vector2(-cam.Eccentricity, 0), cam.PressureAngleMaxRadius) { Layer = pressureLayer });

            // add a circle in the center of the cam
            dxf.AddEntity(new Circle(new Vector2(-cam.Eccentricity, 0), cam.EccentricBearingOuterDia / 2) { Layer = camLayer });

            // generate the cam profile - note: shifted in -x by eccentricicy amount
            Pt? lastPt = null;
            foreach (Pt p in cam.camPoints)
            {
                if (lastPt != null)
                {
                    dxf.AddEntity(new Line(new Vector2(lastPt.Value.x, lastPt.Value.y), new Vector2(p.x, p.y)) { Layer = camLayer });
                }
                lastPt = p;
            }
            dxf.AddEntity(new Line(new Vector2(lastPt.Value.x, lastPt.Value.y), new Vector2(cam.camPoints[0].x, cam.camPoints[0].y)) { Layer = camLayer });

            // generate the pin locations
            foreach (Pt p in cam.rollerPoints)
            {
                dxf.AddEntity(new Circle(new Vector2(p.x, p.y), cam.RollerDiameter / 2) { Layer = rollerLayer });
            }

            // add a circle in the center of the pins
            dxf.AddEntity(new Circle(new Vector2(0, 0), cam.EccentricBearingOuterDia / 2) { Layer = rollerLayer });

            dxf.Save(filename);
        }
    }
}

