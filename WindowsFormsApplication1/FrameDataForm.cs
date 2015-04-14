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
            //*************************************************************esti*****************************************
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

            //hola25

            //this.aux.Text = "Frame id4: " + frame.Id
            //         + ", timestamp: " + frame.Timestamp
            //         + ", hands: " + frame.Hands.Count
            //         + ", fingers: " + frame.Fingers.Count
            //         + ", tools: " + frame.Tools.Count
            //         + ", gestures: " + frame.Gestures().Count;


            Vector vectorHueso1 = frame.Hands[0].Fingers[1].Bone(Bone.BoneType.TYPE_PROXIMAL).Direction;
            Vector vectorHueso2 = frame.Hands[0].Fingers[2].Bone(Bone.BoneType.TYPE_PROXIMAL).Direction;

            float dotProduct = vectorHueso1.Dot(vectorHueso2);

            double angulo = Math.Acos(dotProduct);

           // SafeWriteLine("angulo normal: " + angulo);

            int anguloEntero = Convert.ToInt32(angulo * 100);

            this.aux.Text = angulo.ToString();

           // SafeWriteLine("angulo entero: " + anguloEntero);


            #region cargarMano1
            Hand mano1 = frame.Hands[0];

            Finger mano1Dedo1 = mano1.Fingers[0];
            Finger mano1Dedo2 = mano1.Fingers[1];
            Finger mano1Dedo3 = mano1.Fingers[2];
            Finger mano1Dedo4 = mano1.Fingers[3];
            Finger mano1Dedo5 = mano1.Fingers[4];

            Bone mano1Dedo1Metacarpo = mano1Dedo1.Bone(Bone.BoneType.TYPE_METACARPAL);
            Bone mano1Dedo1Proximal = mano1Dedo1.Bone(Bone.BoneType.TYPE_PROXIMAL);
            Bone mano1Dedo1Intermedio = mano1Dedo1.Bone(Bone.BoneType.TYPE_INTERMEDIATE);
            Bone mano1Dedo1Distal = mano1Dedo1.Bone(Bone.BoneType.TYPE_DISTAL);

            Bone mano1Dedo2Metacarpo = mano1Dedo2.Bone(Bone.BoneType.TYPE_METACARPAL);
            Bone mano1Dedo2Proximal = mano1Dedo2.Bone(Bone.BoneType.TYPE_PROXIMAL);
            Bone mano1Dedo2Intermedio = mano1Dedo2.Bone(Bone.BoneType.TYPE_INTERMEDIATE);
            Bone mano1Dedo2Distal = mano1Dedo2.Bone(Bone.BoneType.TYPE_DISTAL);

            Bone mano1Dedo3Metacarpo = mano1Dedo3.Bone(Bone.BoneType.TYPE_METACARPAL);
            Bone mano1Dedo3Proximal = mano1Dedo3.Bone(Bone.BoneType.TYPE_PROXIMAL);
            Bone mano1Dedo3Intermedio = mano1Dedo3.Bone(Bone.BoneType.TYPE_INTERMEDIATE);
            Bone mano1Dedo3Distal = mano1Dedo3.Bone(Bone.BoneType.TYPE_DISTAL);

            Bone mano1Dedo4Metacarpo = mano1Dedo4.Bone(Bone.BoneType.TYPE_METACARPAL);
            Bone mano1Dedo4Proximal = mano1Dedo4.Bone(Bone.BoneType.TYPE_PROXIMAL);
            Bone mano1Dedo4Intermedio = mano1Dedo4.Bone(Bone.BoneType.TYPE_INTERMEDIATE);
            Bone mano1Dedo4Distal = mano1Dedo4.Bone(Bone.BoneType.TYPE_DISTAL);

            Bone mano1Dedo5Metacarpo = mano1Dedo5.Bone(Bone.BoneType.TYPE_METACARPAL);
            Bone mano1Dedo5Proximal = mano1Dedo5.Bone(Bone.BoneType.TYPE_PROXIMAL);
            Bone mano1Dedo5Intermedio = mano1Dedo5.Bone(Bone.BoneType.TYPE_INTERMEDIATE);
            Bone mano1Dedo5Distal = mano1Dedo5.Bone(Bone.BoneType.TYPE_DISTAL);

            Vector mano1Dedo1MetacarpoDireccion = mano1Dedo1Metacarpo.Direction;
            Vector mano1Dedo1ProximalDireccion = mano1Dedo1Proximal.Direction;
            Vector mano1Dedo1IntermedioDireccion = mano1Dedo1Intermedio.Direction;
            Vector mano1Dedo1DistalDireccion = mano1Dedo1Distal.Direction;

            Vector mano1Dedo2MetacarpoDireccion = mano1Dedo2Metacarpo.Direction;
            Vector mano1Dedo2ProximalDireccion = mano1Dedo2Proximal.Direction;
            Vector mano1Dedo2IntermedioDireccion = mano1Dedo2Intermedio.Direction;
            Vector mano1Dedo2DistalDireccion = mano1Dedo2Distal.Direction;

            Vector mano1Dedo3MetacarpoDireccion = mano1Dedo3Metacarpo.Direction;
            Vector mano1Dedo3ProximalDireccion = mano1Dedo3Proximal.Direction;
            Vector mano1Dedo3IntermedioDireccion = mano1Dedo3Intermedio.Direction;
            Vector mano1Dedo3DistalDireccion = mano1Dedo3Distal.Direction;

            Vector mano1Dedo4MetacarpoDireccion = mano1Dedo3Metacarpo.Direction;
            Vector mano1Dedo4ProximalDireccion = mano1Dedo3Proximal.Direction;
            Vector mano1Dedo4IntermedioDireccion = mano1Dedo3Intermedio.Direction;
            Vector mano1Dedo4DistalDireccion = mano1Dedo3Distal.Direction;

            Vector mano1Dedo5MetacarpoDireccion = mano1Dedo4Metacarpo.Direction;
            Vector mano1Dedo5ProximalDireccion = mano1Dedo4Proximal.Direction;
            Vector mano1Dedo5IntermedioDireccion = mano1Dedo4Intermedio.Direction;
            Vector mano1Dedo5DistalDireccion = mano1Dedo4Distal.Direction; 

            #endregion


            this.d1AngMetProx.Text = calcularAngulo(mano1Dedo1MetacarpoDireccion, mano1Dedo1ProximalDireccion);
            this.d1AngProxInt.Text = calcularAngulo(mano1Dedo1ProximalDireccion, mano1Dedo1IntermedioDireccion);
            this.d1AngIntDist.Text = calcularAngulo(mano1Dedo1IntermedioDireccion, mano1Dedo1DistalDireccion);


            this.d2AngMetProx.Text = calcularAngulo(mano1Dedo2MetacarpoDireccion, mano1Dedo2ProximalDireccion);
            this.d2AngProxInt.Text = calcularAngulo(mano1Dedo2ProximalDireccion, mano1Dedo2IntermedioDireccion);
            this.d2AngIntDist.Text = calcularAngulo(mano1Dedo2IntermedioDireccion, mano1Dedo2DistalDireccion);

        }

        private string calcularAngulo(Vector direccion1, Vector direccion2) {
            float dotProduct = direccion1.Dot(direccion2);
            
            //Arcocoseno es una función que solo está definida entre -1 y 1. 
            //A veces el producto vectorial es un poco superior a 1 y casca
            //TODO: revisar
            if (dotProduct > 1)
                dotProduct = 1;
            if (dotProduct < -1)
                dotProduct = -1;

            this.aux.Text = dotProduct.ToString();

            double angulo = Math.Acos(dotProduct);
            int anguloEntero = Convert.ToInt32(angulo * 100);
            return anguloEntero.ToString();
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
