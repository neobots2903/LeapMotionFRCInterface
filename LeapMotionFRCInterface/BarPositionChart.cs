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
    class BarPositionChart
    {
        static Chart chart;
        public static void Init(Chart chart)
        {
            BarPositionChart.chart = chart;
            ChartArea ca = chart.ChartAreas[0];
            ca.AxisY.Minimum = -600;
            ca.AxisY.Maximum = 600;
            ca.AxisY.Interval = 100;
            ca.AxisX.Title = "Position";
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
                s.ChartType = SeriesChartType.Bar;
            }
            chart.ApplyPaletteColors();
        }

        public static void setPosition(bool isLeft, double xVal, double yVal, double zVal)
        {
            Series s = chart.Series[isLeft ? 0 : 1];
            s.Points.Clear();
            s.Points[s.Points.AddXY("X", Math.Round(xVal,1))].IsValueShownAsLabel = true;
            s.Points[s.Points.AddXY("Y", Math.Round(yVal,1))].IsValueShownAsLabel = true;
            s.Points[s.Points.AddXY("Z", Math.Round(zVal,1))].IsValueShownAsLabel = true;
        }
    }
}
