using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    //******************************************************************************************************
    //   ESTA INTERFAZ SOLO ES PARA CAPTURAR LOS EVENTOS. NO HACE FALTA TOCARLA NUNCA
    //******************************************************************************************************

    public interface ILeapEventDelegate
    {
        void LeapEventNotification(string EventName);
    }
}
