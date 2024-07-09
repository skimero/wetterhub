using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Wetterhub.Models.DTO;

namespace Wetterhub.Models
{
    internal class Dashboard : INotifyPropertyChanged
    {
        private WetterDTO _dto;
        public WetterDTO DTO
        {
            get
            {
                return _dto;
            } 
            set
            {
                _dto = value;
                NotifyPropertyChanged();
            }
        }

        public Dashboard()
        {
            RefreshWeather();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async void RefreshWeather()
        {
            //using http client
            //http get auf api
            //parsen in WetterDTO -> Newtonsoft, geht glaube automatisch
            // return das Ergebnis
            using(HttpClient client = new HttpClient())
            {
                try
                {
                    var resp = await client.GetStringAsync(""); //API Key
                    DTO = JsonConvert.DeserializeObject<WetterDTO>(resp);
                } catch(Exception ex)
                {
                    DTO = null;
                }
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}