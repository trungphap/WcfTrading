using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocketSharp;
using Telegram.Bot;
namespace Test
{
    class Program
    {
        public static decimal StartPrice { get; set; } = 0;
        public static decimal PriceCap { get; set; } = 0.001m;
        public static decimal PriceMin { get; set; } = 0;
        public static decimal PriceMax { get; set; } = 0;
        public static int Iteration { get; set; } = 0;

        static void Main(string[] args)
        {
            
            var uri = "wss://stream.binance.com:9443/ws/dogeusdt@trade";
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
                StartPrice = price;
                PriceMin = price;
                PriceMax = price;
            }
            Iteration++;
            if (price > PriceMax) PriceMax = price;
            if (price < PriceMin) PriceMin = price;
            Console.WriteLine("prix Min: " + PriceMin);
            Console.WriteLine("prix Max : " + PriceMax);
            if ((StartPrice - PriceMin) / PriceMin > PriceCap)
            {
                DateTime.TryParse(tradeResponse.t.ToString(), out DateTime tradeDateTime);
                string message = $"Price baisse > {PriceCap} DogecoinUsdt price = {price} Datetime= {tradeDateTime}";
                Console.WriteLine(message);
                Task.Run(async () => await SendTelegramMessage(message));
                //var client = (WebSocket)sender;
                //client.Close();
                PriceMin = PriceMax = StartPrice = price;
            }
            else if ((PriceMax - StartPrice) / PriceMin > PriceCap)
            {
                DateTime.TryParse(tradeResponse.t.ToString(), out DateTime tradeDateTime);
                string message = $"Price monte > {PriceCap} DogecoinUsdt price = {price} Datetime= {tradeDateTime}";
                Console.WriteLine(message);
                Task.Run(async () => await SendTelegramMessage(message));
                //var client = (WebSocket)sender;
                //client.Close();
                PriceMin = PriceMax = StartPrice = price;
            }
            // Thread.Sleep(500);
        }
        private static async Task SendTelegramMessage(string message)
        {
            string token = "1794207254:AAGW_paSPms-Et35OdGmJLfIi6TbVVkJhBg";
            string id = "-1001468772498";
            var client = new TelegramBotClient(token);
            await client.SendTextMessageAsync(id,message);
        } 

 
        static void TestWcf()
        {
            var c = new ServiceReference1.ShapeClient();

            var s = c.GetCircle();
            Console.WriteLine("diametre =" + s.Diametre + "name= " + s.Name + " id= " + s.Id);


        }     
    }
}
