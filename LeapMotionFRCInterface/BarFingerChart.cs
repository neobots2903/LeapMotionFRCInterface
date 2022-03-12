using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Leap_Motion_FRC_Interface
{
    class BarFingerChart
    {
        static Chart chart;
        public static void Init(Chart chart)
        {
            BarFingerChart.chart = chart;
            ChartArea ca = chart.ChartAreas[0];
            ca.AxisY.Minimum = 0;
            ca.AxisY.Maximum = 100;
            ca.AxisY.Interval = 10;
            ca.AxisX.Title = "Pinch";
            ca.AxisY.Title = "Distance (mm)";

            ca.AxisY.MajorGrid.Enabled = false;
            ca.AxisY.MinorGrid.Enabled = false;
            ca.AxisX.MajorGrid.Enabled = false;
            ca.AxisX.MinorGrid.Enabled = false;

            // we add two series:
            chart.Series.Clear();
            for (int i = 0; i < 2; i++)
            {
                Series s = chart.Series.Add((i == 0) ? "Left" : "Right");
                s.ChartType = SeriesChartType.Column;
                
            }
            chart.ApplyPaletteColors();
        }

        public static void setValues(bool isLeft, double pinchDist, double pinchStrength)
        {
            Series s = chart.Series[isLeft ? 0 : 1];
            s.Points.Clear();
            s.Points[s.Points.AddXY("Dist.", Math.Round(pinchDist, 1))].IsValueShownAsLabel = true;
            s.Points[s.Points.AddXY("Strength", Math.Round(pinchStrength, 1))].IsValueShownAsLabel = true;
        }
    }
}
