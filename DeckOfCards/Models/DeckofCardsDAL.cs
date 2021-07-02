using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DeckOfCards.Models
{
    public class DeckofCardsDAL
    {
        public string CallCAPI(int cards)
        {
            string url = $@"https://deckofcardsapi.com/api/deck/new/draw/?count={cards}";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();


            StreamReader rd = new StreamReader(response.GetResponseStream());
            string JSON = rd.ReadToEnd();
            rd.Close();

            return JSON;
        }

        public Draw DrawFive()
        {
            string Json = CallCAPI(5);
            Draw d = JsonConvert.DeserializeObject<Draw>(Json);
            return d;
        }

        public Draw DrawSame(string ID)
        {
            string url = $@"https://deckofcardsapi.com/api/deck/{ID}/draw/?count=5";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());
            string Json = rd.ReadToEnd();
            rd.Close();
            Draw d = JsonConvert.DeserializeObject<Draw>(Json);
            return d;

        }
    }
}
