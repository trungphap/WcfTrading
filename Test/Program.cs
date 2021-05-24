using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocketSharp;

namespace Test
{
    class Program
    {
        public static decimal Price { get; set; } = 0;
        public static decimal PriceMin { get; set; } = 0;
        public static decimal PriceMax { get; set; } = 0;
        public static int Iteration { get; set; } = 0;

        static void Main(string[] args)
        {
            
            var uri = "wss://stream.binance.com:9443/ws/btcusdt@trade";
            WebSocket client = new WebSocket(uri);
            client.Connect();
            client.OnMessage += Ws_OnMessage;          
            Console.ReadLine();
        }

        private static void Ws_OnMessage(object sender, MessageEventArgs e)
        {            
            TradeResponse tradeResponse = JsonConvert.DeserializeObject<TradeResponse>(e.Data);
            Console.WriteLine("prix : " + tradeResponse.p);

            decimal.TryParse(tradeResponse.p, out decimal price);
            if (Iteration == 0)
            {
                Price = price;
                PriceMin = price;
                PriceMax = price;
            }
            Iteration++;
            if (price > PriceMax) PriceMax = price;
            if (price < PriceMin) PriceMin = price;
            Console.WriteLine("prix Min: " + PriceMin);
            Console.WriteLine("prix Max : " + PriceMax);
            if ((PriceMax-PriceMin)/PriceMin > 0.0002m)
            {
                Console.WriteLine("Send message to telegram");
                var client = (WebSocket)sender;
                client.Close();               
            }
            Thread.Sleep(500);
        }

 
        static void TestWcf()
        {
            var c = new ServiceReference1.ShapeClient();

            var s = c.GetCircle();
            Console.WriteLine("diametre =" + s.Diametre + "name= " + s.Name + " id= " + s.Id);


        }     
    }
}
