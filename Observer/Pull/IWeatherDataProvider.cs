using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using Observer.Push;

namespace Observer.Pull
{
    public interface IWeatherDataProvider : Subject
    {
        float GetTemperature();
        float GetHumidity();
        float GetPressure();
    }

}
