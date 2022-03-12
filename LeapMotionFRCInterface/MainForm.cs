using FRC.NetworkTables;
using FRC.NetworkTables.Interop;
using Leap;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Leap_Motion_FRC_Interface
{
    public partial class MainForm : Form
    {

        public static NetworkTableInstance inst;
        public static NetworkTable table;
        public static int teamNum = -1;

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (ChkBoxViewData.Checked) this.Width = 876;
            else this.Width = 293;

            Console.SetOut(new ControlWriter(LeapLog));
            inst = NetworkTableInstance.Default;
            inst.StartDSClient();
            table = inst.GetTable("leapmotion");
            Console.Out.WriteLine("Network Table started!");
            Console.Out.WriteLine("Waiting for Team Number...");
            txtData.Text = TxtDataFormatter.getMessage();
            BarPositionChart.Init(LeapValChart);
            BarFingerChart.Init(LeapFingerChart);
            PieRotateChart.Init(LeapRotateChart);
            TxtDataFormatter.Init(txtData);
            LeapInit();
        }

        public class ControlWriter : TextWriter
        {
            private TextBox textbox;
            public ControlWriter(TextBox textbox)
            {
                this.textbox = textbox;
            }

            public override void Write(char value)
            {
                textbox.AppendText($"{value}");
            }

            public override void Write(string value)
            {
                textbox.AppendText(value);
            }

            public override Encoding Encoding
            {
                get { return Encoding.ASCII; }
            }
        }

        public void LeapInit()
        {
            LeapInterface leap = new LeapInterface();
            leap.FrameReady += OnFrame;
            leap.Init();
        }

        void OnFrame(object sender, FrameEventArgs eventArgs)
        {
            foreach (Hand hand in eventArgs.frame.Hands) {
                string side = hand.IsLeft ? "Left" : "Right";

                table.GetEntry(side + "Visible").SetBoolean(true);

                table.GetEntry(side + "PalmPositionX").SetDouble(hand.PalmPosition.x);
                table.GetEntry(side + "PalmPositionY").SetDouble(hand.PalmPosition.y);
                table.GetEntry(side + "PalmPositionZ").SetDouble(hand.PalmPosition.z);

                table.GetEntry(side + "StabilizedPalmPositionX").SetDouble(hand.StabilizedPalmPosition.x);
                table.GetEntry(side + "StabilizedPalmPositionY").SetDouble(hand.StabilizedPalmPosition.y);
                table.GetEntry(side + "StabilizedPalmPositionZ").SetDouble(hand.StabilizedPalmPosition.z);

                table.GetEntry(side + "PinchDistance").SetDouble(hand.PinchDistance);
                table.GetEntry(side + "PinchStrength").SetDouble(hand.PinchStrength);

                table.GetEntry(side + "RotationX").SetDouble(hand.Rotation.x);
                table.GetEntry(side + "RotationY").SetDouble(hand.Rotation.y);
                table.GetEntry(side + "RotationZ").SetDouble(hand.Rotation.z);
            }

            if (eventArgs.frame.Hands.Count == 0)
            {
                table.GetEntry("LeftVisible").SetBoolean(false);
                table.GetEntry("RightVisible").SetBoolean(false);
                return;
            } else if (eventArgs.frame.Hands.Count == 1)
            {
                table.GetEntry((eventArgs.frame.Hands[0].IsLeft ? "Right" : "Left") +"Visible").SetBoolean(false);
            }

            if (ChkBoxViewData.Checked)
                foreach (Hand hand in eventArgs.frame.Hands) {
                    BarPositionChart.setPosition(hand.IsLeft, hand.PalmPosition.x, hand.PalmPosition.y, hand.PalmPosition.z);
                    BarFingerChart.setValues(hand.IsLeft, hand.PinchDistance, hand.PinchStrength);
                    PieRotateChart.setValues(hand.IsLeft, hand.Rotation.x, hand.Rotation.y, hand.Rotation.z);
                }
            txtData.Text = TxtDataFormatter.getMessage();
        }

        private void ChkBoxViewData_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBoxViewData.Checked) this.Width = 876;
            else this.Width = 293;
        }

        private void BtnTeamNum_Click(object sender, EventArgs e)
        {
            int team = -1;
            if (Int32.TryParse(txtTeamNum.Text, out team))
            {
                inst.StartClientTeam(team);
                txtData.Text = TxtDataFormatter.getMessage();
                Console.Out.WriteLine("Configured for team " + team + "!");
            } else
            {
                Console.Out.WriteLine("Please enter a valid team number.");
            }
        }
    }
}
