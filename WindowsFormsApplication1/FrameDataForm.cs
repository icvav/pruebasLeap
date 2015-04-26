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
    public partial class FrameDataForm : Form, ILeapEventDelegate
    {
        private Controller controller;
        private LeapEventListener listener;
        private bool capturarMaximos = false;

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

            Vector mano1Dedo4MetacarpoDireccion = mano1Dedo4Metacarpo.Direction;
            Vector mano1Dedo4ProximalDireccion = mano1Dedo4Proximal.Direction;
            Vector mano1Dedo4IntermedioDireccion = mano1Dedo4Intermedio.Direction;
            Vector mano1Dedo4DistalDireccion = mano1Dedo4Distal.Direction;

            Vector mano1Dedo5MetacarpoDireccion = mano1Dedo5Metacarpo.Direction;
            Vector mano1Dedo5ProximalDireccion = mano1Dedo5Proximal.Direction;
            Vector mano1Dedo5IntermedioDireccion = mano1Dedo5Intermedio.Direction;
            Vector mano1Dedo5DistalDireccion = mano1Dedo5Distal.Direction;

            Arm brazo = mano1.Arm;

            #endregion

            if (mano1.IsValid)
            {
                this.mano.Text = "Mano " + (mano1.IsRight ? "derecha" : "izquieda");

                if (mano1Dedo1.IsValid)
                {

                    int d1AngMetProx = calcularAngulo(mano1Dedo1MetacarpoDireccion, mano1Dedo1ProximalDireccion);
                    this.d1AngMetProx.Text = d1AngMetProx.ToString();
                    int d1AngProxInt = calcularAngulo(mano1Dedo1ProximalDireccion, mano1Dedo1IntermedioDireccion);
                    this.d1AngProxInt.Text = d1AngProxInt.ToString();
                    int d1AngIntDist = calcularAngulo(mano1Dedo1IntermedioDireccion, mano1Dedo1DistalDireccion);
                    this.d1AngIntDist.Text = d1AngIntDist.ToString();

                    this.dedo1Tipo.Text = obtenerTipoDedo(mano1Dedo1);

                    if (capturarMaximos)
                    {
                        if (Int32.Parse(this.d1AngMetProxMax.Text) < d1AngMetProx)
                        {
                            this.d1AngMetProxMax.Text = d1AngMetProx.ToString();
                        }
                        if (Int32.Parse(this.d1AngProxIntMax.Text) < d1AngProxInt)
                        {
                            this.d1AngProxIntMax.Text = d1AngProxInt.ToString();
                        }
                        if (Int32.Parse(this.d1AngIntDistMax.Text) < d1AngIntDist)
                        {
                            this.d1AngIntDistMax.Text = d1AngIntDist.ToString();
                        }


                    }
                }

                //if (mano1Dedo4.IsValid)
                //{
                //    int d4AngMetProx = calcularAngulo(mano1Dedo1MetacarpoDireccion, mano1Dedo1ProximalDireccion);
                //    this.d4AngMetProx.Text = d4AngMetProx.ToString();
                //    int d4AngProxInt = calcularAngulo(mano1Dedo1ProximalDireccion, mano1Dedo1IntermedioDireccion);
                //    this.d1AngProxInt.Text = d4AngProxInt.ToString();
                //    int d4AngIntDist = calcularAngulo(mano1Dedo1IntermedioDireccion, mano1Dedo1DistalDireccion);
                //    this.d1AngIntDist.Text = d4AngIntDist.ToString();


                //}

                if (mano1Dedo2.IsValid)
                {
                    //int d2AngMetProx = calcularAngulo(mano1Dedo2MetacarpoDireccion, mano1Dedo2ProximalDireccion);
                    //double d2AngMetProx = calcularAngulo(mano1Dedo2Metacarpo, mano1Dedo2Proximal, false);
                    //this.d2AngMetProx.Text = d2AngMetProx.ToString();
                    int d2AngProxInt = calcularAngulo(mano1Dedo2ProximalDireccion, mano1Dedo2IntermedioDireccion);
                    this.d2AngProxInt.Text = d2AngProxInt.ToString();
                    int d2AngIntDist = calcularAngulo(mano1Dedo2IntermedioDireccion, mano1Dedo2DistalDireccion);
                    this.d2AngIntDist.Text = d2AngIntDist.ToString();

                    this.aux.Text = (mano1Dedo2MetacarpoDireccion.AngleTo(mano1Dedo2ProximalDireccion) * (180 / Math.PI)).ToString();


                    this.dedo2Tipo.Text = obtenerTipoDedo(mano1Dedo2);

                    if (capturarMaximos)
                    {
                        //if (Int32.Parse(this.d2AngMetProxMax.Text) < d2AngMetProx)
                        //{
                        //    this.d2AngMetProxMax.Text = d2AngMetProx.ToString();
                        //}
                        if (Int32.Parse(this.d2AngProxIntMax.Text) < d2AngProxInt)
                        {
                            this.d2AngProxIntMax.Text = d2AngProxInt.ToString();
                        }
                        if (Int32.Parse(this.d2AngIntDistMax.Text) < d2AngIntDist)
                        {
                            this.d2AngIntDistMax.Text = d2AngIntDist.ToString();
                        }
                    }
                }
                if (mano1Dedo3.IsValid)
                {
                    int d3AngMetProx = calcularAngulo(mano1Dedo3MetacarpoDireccion, mano1Dedo3ProximalDireccion);
                    this.d3AngMetProx.Text = d3AngMetProx.ToString();
                    int d3AngProxInt = calcularAngulo(mano1Dedo3ProximalDireccion, mano1Dedo3IntermedioDireccion);
                    this.d3AngProxInt.Text = d3AngProxInt.ToString();
                    int d3AngIntDist = calcularAngulo(mano1Dedo3IntermedioDireccion, mano1Dedo3DistalDireccion);
                    this.d3AngIntDist.Text = d3AngIntDist.ToString();

                    this.dedo3Tipo.Text = obtenerTipoDedo(mano1Dedo3);

                    if (capturarMaximos)
                    {
                        if (Int32.Parse(this.d3AngMetProxMax.Text) < d3AngMetProx)
                        {
                            this.d3AngMetProxMax.Text = d3AngMetProx.ToString();
                        }
                        if (Int32.Parse(this.d3AngProxIntMax.Text) < d3AngProxInt)
                        {
                            this.d3AngProxIntMax.Text = d3AngProxInt.ToString();
                        }
                        if (Int32.Parse(this.d3AngIntDistMax.Text) < d3AngIntDist)
                        {
                            this.d3AngIntDistMax.Text = d3AngIntDist.ToString();
                        }
                    }
                }
                if (mano1Dedo4.IsValid)
                {
                    int d4AngMetProx = calcularAngulo(mano1Dedo4MetacarpoDireccion, mano1Dedo4ProximalDireccion);
                    this.d4AngMetProx.Text = d4AngMetProx.ToString();
                    int d4AngProxInt = calcularAngulo(mano1Dedo4ProximalDireccion, mano1Dedo4IntermedioDireccion);
                    this.d4AngProxInt.Text = d4AngProxInt.ToString();
                    int d4AngIntDist = calcularAngulo(mano1Dedo4IntermedioDireccion, mano1Dedo4DistalDireccion);
                    this.d4AngIntDist.Text = d4AngIntDist.ToString();

                    this.dedo4Tipo.Text = obtenerTipoDedo(mano1Dedo4);

                    if (capturarMaximos)
                    {
                        if (Int32.Parse(this.d4AngMetProxMax.Text) < d4AngMetProx)
                        {
                            this.d4AngMetProxMax.Text = d4AngMetProx.ToString();
                        }
                        if (Int32.Parse(this.d4AngProxIntMax.Text) < d4AngProxInt)
                        {
                            this.d4AngProxIntMax.Text = d4AngProxInt.ToString();
                        }
                        if (Int32.Parse(this.d4AngIntDistMax.Text) < d4AngIntDist)
                        {
                            this.d4AngIntDistMax.Text = d4AngIntDist.ToString();
                        }
                    }
                }
                if (mano1Dedo5.IsValid)
                {
                    int d5AngMetProx = calcularAngulo(mano1Dedo5MetacarpoDireccion, mano1Dedo5ProximalDireccion);
                    this.d5AngMetProx.Text = d5AngMetProx.ToString();
                    int d5AngProxInt = calcularAngulo(mano1Dedo5ProximalDireccion, mano1Dedo5IntermedioDireccion);
                    this.d5AngProxInt.Text = d5AngProxInt.ToString();
                    int d5AngIntDist = calcularAngulo(mano1Dedo5IntermedioDireccion, mano1Dedo5DistalDireccion);
                    this.d5AngIntDist.Text = d5AngIntDist.ToString();

                    this.dedo5Tipo.Text = obtenerTipoDedo(mano1Dedo5);

                    if (capturarMaximos)
                    {
                        if (Int32.Parse(this.d5AngMetProxMax.Text) < d5AngMetProx)
                        {
                            this.d5AngMetProxMax.Text = d5AngMetProx.ToString();
                        }
                        if (Int32.Parse(this.d5AngProxIntMax.Text) < d5AngProxInt)
                        {
                            this.d5AngProxIntMax.Text = d5AngProxInt.ToString();
                        }
                        if (Int32.Parse(this.d5AngIntDistMax.Text) < d5AngIntDist)
                        {
                            this.d5AngIntDistMax.Text = d5AngIntDist.ToString();
                        }
                    }
                }

                if (mano1Dedo1.IsValid && mano1Dedo2.IsValid)
                {
                    int abd1 = calcularAngulo(mano1Dedo2MetacarpoDireccion, mano1Dedo1ProximalDireccion);
                    this.abd1.Text = abd1.ToString();

                    if (capturarMaximos)
                    {
                        if (Int32.Parse(this.abd1Max.Text) < abd1)
                        {
                            this.abd1Max.Text = abd1.ToString();
                        }
                    }
                }

                if (mano1Dedo3.IsValid && mano1Dedo2.IsValid)
                {
                    int abd2 = calcularAngulo(mano1Dedo3ProximalDireccion, mano1Dedo2ProximalDireccion);
                    this.abd2.Text = abd2.ToString();

                    if (capturarMaximos)
                    {
                        if (Int32.Parse(this.abd2Max.Text) < abd2)
                        {
                            this.abd2Max.Text = abd2.ToString();
                        }
                    }
                }

                if (mano1Dedo3.IsValid && mano1Dedo4.IsValid)
                {
                    int abd3 = calcularAngulo(mano1Dedo3ProximalDireccion, mano1Dedo4ProximalDireccion);
                    this.abd3.Text = abd3.ToString();

                    if (capturarMaximos)
                    {
                        if (Int32.Parse(this.abd3Max.Text) < abd3)
                        {
                            this.abd3Max.Text = abd3.ToString();
                        }
                    }
                }

                if (brazo.IsValid)
                {
                    int angBrazoMano = calcularAngulo(brazo.Direction, mano1.Direction);
                    this.angMuneca.Text = angBrazoMano.ToString();

                    if (capturarMaximos)
                    {
                        if (Int32.Parse(this.angMunecaMax.Text) < angBrazoMano)
                        {
                            this.angMunecaMax.Text = angBrazoMano.ToString();
                        }
                    }
                }
            }
            else
            {
                this.mano.Text = "Mano no válida";

                this.d1AngMetProx.Text = "-ND-";
                this.d1AngProxInt.Text = "-ND-";
                this.d1AngIntDist.Text = "-ND-";


                this.d2AngMetProx.Text = "-ND-";
                this.d2AngProxInt.Text = "-ND-";
                this.d2AngIntDist.Text = "-ND-";

                this.d3AngMetProx.Text = "-ND-";
                this.d3AngProxInt.Text = "-ND-";
                this.d3AngIntDist.Text = "-ND-";

                this.d4AngMetProx.Text = "-ND-";
                this.d4AngProxInt.Text = "-ND-";
                this.d4AngIntDist.Text = "-ND-";

                this.d5AngMetProx.Text = "-ND-";
                this.d5AngProxInt.Text = "-ND-";
                this.d5AngIntDist.Text = "-ND-";

                this.abd1.Text = "-ND-";
                this.abd2.Text = "-ND-";
                this.abd3.Text = "-ND-";

                this.angMuneca.Text = "-ND-";

            }





            //Vector metacarpalDirection = mano1Dedo2.Bone(Bone.BoneType.TYPE_INTERMEDIATE).Basis.zBasis;
            //Vector distalPhalangeDirection = mano1Dedo2.Bone(Bone.BoneType.TYPE_DISTAL).Basis.zBasis;

            Vector metacarpalDirection = mano1Dedo2.Bone(Bone.BoneType.TYPE_METACARPAL).Basis.zBasis;
            Vector distalPhalangeDirection = mano1Dedo2.Bone(Bone.BoneType.TYPE_PROXIMAL).Basis.zBasis;

            double rawangle = metacarpalDirection.AngleTo(distalPhalangeDirection) * 180 / Math.PI;

            //Find sign
            Vector crossBones = metacarpalDirection.Cross(distalPhalangeDirection);
            Vector boneXBasis = mano1Dedo2.Bone(Bone.BoneType.TYPE_METACARPAL).Basis.xBasis;
            if (mano1Dedo2.Hand.IsRight) boneXBasis = boneXBasis * (-1); //Left hand uses a left-hand basis
            double sign = (crossBones.Dot(boneXBasis) >= 0) ? 1 : -1;
            double sign2 = sign * rawangle;
            this.aux.Text = sign2.ToString();

        }

        private string obtenerTipoDedo(Finger dedo)
        {
            //El último dígito de su ID determina el tipo de dedo, numerados de 0 a 4 desde el pulgar al meñique
            String idDedoString = dedo.Id.ToString().Substring(dedo.Id.ToString().Length - 1, 1);
            int idDedo = Int32.Parse(idDedoString);
            switch (idDedo)
            {
                case 0:
                    return "Pulgar";
                case 1:
                    return "Índice";
                case 2:
                    return "Medio";
                case 3:
                    return "Anular";
                case 4:
                    return "Meñique";
                default:
                    return "Desconocido";
            }
        }

        //private string obtenerAngulo(Vector direccion1, Vector direccion2)
        //{

        //    //Cuando no hay ninguna mano, se llega a aquí con un 0 en todos los ejes => mostrar un No Disponible
        //    if (direccion1.x == 0 && direccion1.y == 0 && direccion1.z == 0
        //        && direccion2.x == 0 && direccion2.y == 0 && direccion2.z == 0)
        //    {
        //        return "-ND-";  //no disponible
        //    }
        //    else
        //    {

        //        int angulo = calcularAngulo(direccion1, direccion2);
        //        return angulo.ToString();
        //    }
        //}

        // private int calcularAngulo(Vector direccion1, Vector direccion2, Finger dedo1, Finger dedo2)
        private int calcularAngulo(Vector direccion1, Vector direccion2)
        {
            //float dotProduct = direccion1.Dot(direccion2);

            ////Arcocoseno es una función que solo está definida entre -1 y 1. 
            ////A veces el producto vectorial es un poco superior a 1 y casca
            ////TODO: revisar
            //if (dotProduct > 1)
            //    dotProduct = 1;
            //if (dotProduct < -1)
            //    dotProduct = -1;

            //double angulo = Math.Acos(dotProduct);

            ////Pasarlo a entero y olvidarnos de los decimales
            //int anguloEntero = Convert.ToInt32(angulo * 100);


            int anguloEntero = Convert.ToInt32(direccion1.AngleTo(direccion2) * (180 / Math.PI));


            return anguloEntero;
        }
        private double calcularAngulo(Bone hueso1, Bone hueso2, bool isRight)
        {
            //int angulo = calcularAngulo(hueso1.Direction, hueso2.Direction);

            // Comprobar el signo, basado libremente en https://community.leapmotion.com/t/signed-angle-between-fingers-and-palm/2680/3
            // No termino de entender bien como funciona pero funciona
            Vector direction1 = hueso1.Basis.zBasis;
            Vector direction2 = hueso2.Basis.zBasis;
            //float rawangle = metacarpalDirection.angleTo(distalPhalangeDirection) * 180 / PI;
            double angulo = direction1.AngleTo(direction2) * 180 / Math.PI;

            Vector crossBones = direction1.Cross(direction2);
            Vector boneXBasis = hueso1.Basis.xBasis;
            if (isRight) boneXBasis = boneXBasis * (-1);
            double sign = (crossBones.Dot(boneXBasis) >= 0) ? 1 : -1;
            double sign2 = sign * angulo;
            // this.aux.Text = sign2.ToString();

            return sign2;



            //Vector metacarpalDirection = mano1Dedo2.Bone(Bone.BoneType.TYPE_METACARPAL).Basis.zBasis;
            //Vector distalPhalangeDirection = mano1Dedo2.Bone(Bone.BoneType.TYPE_PROXIMAL).Basis.zBasis;

            //double rawangle = metacarpalDirection.AngleTo(distalPhalangeDirection) * 180 / Math.PI;

            ////Find sign
            //Vector crossBones = metacarpalDirection.Cross(distalPhalangeDirection);
            //Vector boneXBasis = mano1Dedo2.Bone(Bone.BoneType.TYPE_METACARPAL).Basis.xBasis;
            //if (mano1Dedo2.Hand.IsRight) boneXBasis = boneXBasis * (-1); //Left hand uses a left-hand basis
            //double sign = (crossBones.Dot(boneXBasis) >= 0) ? 1 : -1;
            //double sign2 = sign * rawangle;
            //this.aux.Text = sign2.ToString();
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

        private void start_Click(object sender, EventArgs e)
        {
            capturarMaximos = true;
            this.lEstado.Text = "Capturando máximos";
        }

        private void stop_Click(object sender, EventArgs e)
        {
            capturarMaximos = false;
            this.lEstado.Text = "Normal";
        }

        private void d5AngProxIntMax_Click(object sender, EventArgs e)
        {

        }

        private void d5AngIntDistMax_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void d5AngMetProxMax_Click(object sender, EventArgs e)
        {

        }
    }



}
