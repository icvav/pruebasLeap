using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Leap;

namespace Pruebas_hola_mundo
{
    class SampleListener : Listener
    {
        private Object thisLock = new Object();

        private void SafeWriteLine(String line)
        {
            lock (thisLock)
            {
                Console.WriteLine(line);
            }
        }

        public override void OnConnect(Controller controller)
        {
            SafeWriteLine("Connected");
        }


        public override void OnFrame(Controller controller)
        {
            Frame frame = controller.Frame();


            SafeWriteLine("Frame id: " + frame.Id
                     + ", timestamp: " + frame.Timestamp
                     + ", hands: " + frame.Hands.Count
                     + ", fingers: " + frame.Fingers.Count
                     + ", tools: " + frame.Tools.Count
                     + ", gestures: " + frame.Gestures().Count);


            Vector vectorHueso1 = frame.Hands[0].Fingers[1].Bone(Bone.BoneType.TYPE_PROXIMAL).Direction;
            Vector vectorHueso2 = frame.Hands[0].Fingers[2].Bone(Bone.BoneType.TYPE_PROXIMAL).Direction;

            float dotProduct = vectorHueso1.Dot(vectorHueso2);

            double angulo = Math.Acos(dotProduct);

            SafeWriteLine("angulo normal: " + angulo);

            int anguloEntero = Convert.ToInt32(angulo * 100);

            SafeWriteLine("angulo entero: " + anguloEntero);

            




            //Vector vectorHueso1Dedo1 = frame.Hands[0].Fingers[1].Bone(Bone.BoneType.TYPE_PROXIMAL).Direction;
            //Vector vectorHueso2Dedo1 = frame.Hands[0].Fingers[1].Bone(Bone.BoneType.TYPE_INTERMEDIATE).Direction;

            //float dotProductMismoDedo = vectorHueso1Dedo1.Dot(vectorHueso2Dedo1);

            //double anguloMismoDedo = Math.Acos(dotProductMismoDedo);

            //SafeWriteLine("angulo normal mismo dedo: " + anguloMismoDedo);

            //int anguloEnteroMismoDedo = Convert.ToInt32(anguloMismoDedo * 100);

            //SafeWriteLine("angulo entero mismo dedo: " + anguloEnteroMismoDedo);



            //SafeWriteLine("xl: " + vectorHueso1.x + " yl: " + vectorHueso1.y + " zl: " + vectorHueso1.z);

            //Vector xBasisHueso1 = frame.Hands[0].Fingers[1].Bone(Bone.BoneType.TYPE_PROXIMAL).Basis.xBasis;
            //Vector xBasisHueso2 = frame.Hands[0].Fingers[2].Bone(Bone.BoneType.TYPE_PROXIMAL).Basis.xBasis;
            //float dotProductBasisx = xBasisHueso1.Dot(xBasisHueso2);
            //double anguloBaisx = Math.Acos(dotProductBasisx);
            //Vector yBasisHueso1 = frame.Hands[0].Fingers[1].Bone(Bone.BoneType.TYPE_PROXIMAL).Basis.yBasis;
            //Vector yBasisHueso2 = frame.Hands[0].Fingers[2].Bone(Bone.BoneType.TYPE_PROXIMAL).Basis.yBasis;
            //float dotProductBasisy = yBasisHueso1.Dot(yBasisHueso2);
            //double anguloBaisy = Math.Acos(dotProductBasisy);
            //Vector zBasisHueso1 = frame.Hands[0].Fingers[1].Bone(Bone.BoneType.TYPE_PROXIMAL).Basis.zBasis;
            //Vector zBasisHueso2 = frame.Hands[0].Fingers[2].Bone(Bone.BoneType.TYPE_PROXIMAL).Basis.zBasis;
            //float dotProductBasisz = zBasisHueso1.Dot(zBasisHueso2);
            //double anguloBaisz = Math.Acos(dotProductBasisz);

            //SafeWriteLine("anguloBaisx: " + anguloBaisx + " anguloBaisy: " + anguloBaisy + " anguloBaisz: " + anguloBaisz);


            //Vector vectorHueso1P = frame.Hands[0].Fingers[1].Bone(Bone.BoneType.TYPE_PROXIMAL).Direction;
            //Vector vectorHueso2P = frame.Hands[0].Fingers[2].Bone(Bone.BoneType.TYPE_PROXIMAL).Direction;

            //vectorHueso1P.z = 0;
            //vectorHueso1P.y = 0;

            //vectorHueso2P.z = 0;
            //vectorHueso2P.y = 0;

            //float dotProductP = vectorHueso1P.Dot(vectorHueso2P);

            //double anguloP = Math.Acos(dotProductP);

            //SafeWriteLine("angulo prueba: " + anguloP);
            

        }
    }
}
