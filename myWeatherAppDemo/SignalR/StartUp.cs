using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly:OwinStartup(typeof(myWeatherAppDemo.SignalR.StartUp))]
namespace myWeatherAppDemo.SignalR
{
    //We are calling owinstartup with the parameter WeatherAppDemo.SignalR.StartUp, which will initialize our StartUp class.
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            //Mapping : afin de pouvoir y acceder depuis l'url avec .../SignalR/hubs 
            app.MapSignalR();
        }
    }
}
