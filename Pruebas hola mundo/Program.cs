using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leap;


namespace Pruebas_hola_mundo
{
    class Program //: Listener
    {

        static void Main(string[] args)
        {
            SampleListener listener = new SampleListener();
            Controller controller = new Controller();
            controller.AddListener(listener);

            // Keep this process running until Enter is pressed
            Console.WriteLine("Press Enter to quit....");
            Console.ReadLine();

            controller.RemoveListener(listener);
            controller.Dispose();
        }

    }
}
