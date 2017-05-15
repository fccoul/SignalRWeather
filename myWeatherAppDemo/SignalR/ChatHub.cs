using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myWeatherAppDemo.SignalR
{
    public class ChatHub : Hub
    {
        static int _temperature;

        [HubMethodName("Change_Weather")]
        public void ChangeWeather(int temperature)
        {
            _temperature = temperature;
            //NotifyUser is a function on the clientside, 
            Clients.Others.NotifyUser(temperature);
        }

        [HubMethodName("get_weather")]//---methode depuis le client en JS (ts client se connectant au hub)
        public void GetWeather()
        {
            //pushing the data only to the user which has called this method.   
            Clients.Caller.NotifyUser(_temperature); //---led etail de cette methode sera defini coté JS sur lapage client
        }
    }
}
