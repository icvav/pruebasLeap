using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leap;



namespace WindowsFormsApplication1
{
    public partial class FrameDataForm : Form , ILeapEventDelegate
    {
        private Controller controller;
        private LeapEventListener listener;

        public FrameDataForm()
        {
            InitializeComponent();

            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
            controller.AddListener(listener);
        }
        delegate void LeapEventDelegate(string EventName);
        public void LeapEventNotification(string EventName)
        {
            if (!this.InvokeRequired)
            {
                switch (EventName)
                {
                    case "onInit":
                        //Debug.WriteLine("Init");
                        break;
                    case "onConnect":
                        this.connectHandler();
                        break;
                    case "onFrame":
                        if (!this.Disposing)
                            this.newFrameHandler(this.controller.Frame());
                        break;
                }
            }
            else
            {
                BeginInvoke(new LeapEventDelegate(LeapEventNotification), new object[] { EventName });
            }
        }

        void connectHandler()
        {
            this.controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            this.controller.Config.SetFloat("Gesture.Circle.MinRadius", 40.0f);
            this.controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
        }

        void newFrameHandler(Frame frame)
        {
            //******************************************************************************************************
            //      REALMENTE ESTE ES EL ÚNICO MÉTODO QUE IMPORTA. 
            //      TODO LO QUE SEA "LEER" DATOS DEL LEAP MOTION VA AQUÍ
            //      Se ejecuta una vez por fotograma y en "frame" están todos los datos que tiene dicho fotograma
            //******************************************************************************************************

            this.displayID.Text = frame.Id.ToString();
            this.displayTimestamp.Text = frame.Timestamp.ToString();
            this.displayFPS.Text = frame.CurrentFramesPerSecond.ToString();
            this.displayIsValid.Text = frame.IsValid.ToString();
            this.displayGestureCount.Text = frame.Gestures().Count.ToString();
            this.displayImageCount.Text = frame.Images.Count.ToString();


            this.aux.Text = "Frame id: " + frame.Id
                     + ", timestamp: " + frame.Timestamp
                     + ", hands: " + frame.Hands.Count
                     + ", fingers: " + frame.Fingers.Count
                     + ", tools: " + frame.Tools.Count
                     + ", gestures: " + frame.Gestures().Count;

        }

        //protected override void Dispose(bool disposing)
        //{
        //    try
        //    {
        //        if (disposing)
        //        {
        //            if (components != null)
        //            {
        //                components.Dispose();
        //            }
        //            this.controller.RemoveListener(this.listener);
        //            this.controller.Dispose();
        //        }
        //    }
        //    finally
        //    {
        //        base.Dispose(disposing);
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }



}
