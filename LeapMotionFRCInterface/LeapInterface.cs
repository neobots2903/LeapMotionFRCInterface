using Leap;
using System;
using static Leap.Controller;

namespace Leap_Motion_FRC_Interface
{
    class LeapInterface
    {
        Controller controller;
        bool printFrames = false;

        public EventHandler<ConnectionEventArgs> Connect;
        public EventHandler<DeviceEventArgs> Device;
        public EventHandler<FrameEventArgs> FrameReady;
        public EventHandler<ImageEventArgs> ImageReady;
        public EventHandler<PointMappingChangeEventArgs> PointMappingChange;
        public EventHandler<LogEventArgs> LogMessage;
        public EventHandler<HeadPoseEventArgs> HeadPoseChange;

        /** Callback for when the connection opens. */
        void OnConnect(object sender, ConnectionEventArgs eventArgs)
        {
            Console.Out.WriteLine("Connected.");
        }
    
        /** Callback for when a device is found. */
        void OnDevice(object sender, DeviceEventArgs eventArgs)
        {
            Console.Out.WriteLine($"Found device {eventArgs.Device.SerialNumber}.");
        }

        /** Callback for when a frame of tracking data is available. */
        void OnFrame(object sender, FrameEventArgs eventArgs)
        {
            if (!printFrames) return;

            Console.Out.WriteLine($"Frame {eventArgs.frame.Id} with {eventArgs.frame.Hands.Count} hands.");
      
            for (int  h = 0; h < eventArgs.frame.Hands.Count; h++)
            {
                Hand hand = eventArgs.frame.Hands[h];
                Console.Out.WriteLine(
                    string.Format("Hand id {0} is a {1} hand with position ({2}, {3}, {4}).\n",
                    hand.Id,
                    (hand.IsLeft ? "left" : "right"),
                    hand.PalmPosition.x,
                    hand.PalmPosition.y,
                    hand.PalmPosition.z)
                    );
            }
        }
    
        void OnImage(object sender, ImageEventArgs eventArgs)
        {
            Console.Out.WriteLine(
                string.Format("Image {0}  => {1} x {2} (bpp={3})",
                eventArgs.image.SequenceId,
                eventArgs.image.Width,
                eventArgs.image.Height,
                eventArgs.image.BytesPerPixel
                ));
        }
    
        void OnLogMessage(object sender, LogEventArgs eventArgs)
        {
            string severity_str;
            switch (eventArgs.severity)
            {
                case MessageSeverity.MESSAGE_CRITICAL:
                    severity_str = "Critical";
                    break;
                case MessageSeverity.MESSAGE_WARNING:
                    severity_str = "Warning";
                    break;
                case MessageSeverity.MESSAGE_INFORMATION:
                    severity_str = "Info";
                    break;
                default:
                    severity_str = "";
                    break;
            }
            Console.Out.WriteLine($"[{severity_str}][{DateTime.Now.ToString("hh:mm:ss tt")}] {eventArgs.message}");
        }
    
        void OnPointMappingChange(object sender, PointMappingChangeEventArgs eventArgs)
        {
            PointMapping pointMapping = new PointMapping();
            controller.GetPointMapping(ref pointMapping);
            if (pointMapping.points != null) {
                Console.Out.WriteLine($"Managing {pointMapping.points.Length} points as of frame {pointMapping.frameId} at {pointMapping.timestamp}");
            }
        }
    
        void OnHeadPose(object sender, HeadPoseEventArgs eventArgs)
        {
            Console.Out.WriteLine("Head pose:");
            Console.Out.WriteLine($"Head position ({eventArgs.headPosition.x}, {eventArgs.headPosition.y}, {eventArgs.headPosition.z})");
            Console.Out.WriteLine($"Head orientation ({eventArgs.headOrientation.w}, {eventArgs.headOrientation.x}, {eventArgs.headOrientation.y}, {eventArgs.headOrientation.z}).");
        }

        public bool isConnected()
        {
            return controller.IsConnected;
        }

        public void printFrame(bool state)
        {
            printFrames = state;
        }
   
        public void Init()
        {
            Console.Out.WriteLine("Initializing...");

            controller = new Controller();

            controller.SetPolicy(PolicyFlag.POLICY_IMAGES | PolicyFlag.POLICY_MAP_POINTS);
            controller.Connect += OnConnect;
            controller.Connect += Connect;
            controller.Device += OnDevice;
            controller.Device += Device;
            controller.FrameReady += OnFrame;
            controller.FrameReady += FrameReady;
            controller.ImageReady += OnImage;
            controller.ImageReady += ImageReady;
            controller.PointMappingChange += OnPointMappingChange;
            controller.PointMappingChange += PointMappingChange;
            controller.LogMessage += OnLogMessage;
            controller.LogMessage += LogMessage;
            controller.HeadPoseChange += OnHeadPose;
            controller.HeadPoseChange += HeadPoseChange;
        }


    }
}
