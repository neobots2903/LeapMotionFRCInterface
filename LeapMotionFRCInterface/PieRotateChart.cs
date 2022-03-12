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
    class PieRotateChart
    {
        static Chart chart;
        public static void Init(Chart chart)
        {
            PieRotateChart.chart = chart;

            float outerSize = 100;

            // we add two chart areas:
            chart.ChartAreas.Clear();
            for (int i = 0; i < 8; i++)
            {
                ChartArea ca = chart.ChartAreas.Add("CA"+i);
                ca.Position = new ElementPosition(0, 0, 100, 100);
                ca.InnerPlotPosition = new ElementPosition((100 - (outerSize-10*i)) / 2,
                    (100 - (outerSize - 10 * i)) / 2 + 10, (outerSize - 10 * i), (outerSize - 10 * i) - 10);
                ca.BackColor = Color.Transparent;
            }

            // we add two series:
            chart.Series.Clear();
            for (int i = 0; i < 8; i++)
            {
                Series s = chart.Series.Add("S" + i);
                s.ChartType = SeriesChartType.Doughnut;
                s["DoughnutRadius"] = Math.Min(10*(100 / (outerSize - 10 * i)), 99).ToString().Replace(",", ".");
                s["PieStartAngle"] = "270";
                s.ChartArea = chart.ChartAreas[i].Name;
            }

            //chart.Series[0]["DoughnutRadius"] = "41"; // leave just a little space!
            //chart.Series[1]["DoughnutRadius"] = "99"; // 99 is the limit. a tiny spot remains open

            chart.ApplyPaletteColors();
        }

        public static void setValues(bool isLeft, double xVal, double yVal, double zVal)
        {
            int s = isLeft ? 0 : 4;
            chart.Series[s].Points.Clear();
            chart.Series[s].Points[chart.Series[s].Points.AddXY("X", Math.Round(xVal*360, 1))].Label = $"Pitch: {Math.Round(xVal * 360, 1)}";
            chart.Series[s].Points[chart.Series[s].Points.AddXY("", Math.Round(360 - xVal * 360, 1))].IsVisibleInLegend = false;
            chart.Series[s].Points[1].Color = Color.Transparent;
            if (!isLeft) chart.Series[s].Points[0].Color = Color.Orange;
            chart.Series[s+1].Points.Clear();
            chart.Series[s+1].Points[chart.Series[s + 1].Points.AddXY("Y", Math.Round(yVal*360, 1))].Label = $"Yaw: {Math.Round(yVal * 360, 1)}";
            chart.Series[s+1].Points[chart.Series[s + 1].Points.AddXY("", Math.Round(360 - yVal * 360, 1))].IsVisibleInLegend = false;
            chart.Series[s+1].Points[1].Color = Color.Transparent;
            if (!isLeft) chart.Series[s+1].Points[0].Color = Color.Orange;
            chart.Series[s+2].Points.Clear();
            chart.Series[s+2].Points[chart.Series[s + 2].Points.AddXY("Z", Math.Round(zVal*360, 1))].Label = $"Roll: {Math.Round(zVal * 360, 1)}";
            chart.Series[s+2].Points[chart.Series[s + 2].Points.AddXY("", Math.Round(360 - zVal * 360, 1))].IsVisibleInLegend = false;
            chart.Series[s + 2].Points[1].Color = Color.Transparent;
            if (!isLeft) chart.Series[s+2].Points[0].Color = Color.Orange;
        }
    }
}
