using Interfaces;
using System.Windows.Input;

namespace ViewModels
{
    public class ProducerConsumer
    {
        public ICommand MyCommand { get; }
        public ICommand OpenCommand { get; }
        public ICommand ProduceCommand { get; }
        public ICommand ProduceCommand2 { get; }
        public ICommand ConsumeCommand { get; }
        public ICommand ConsumeCommand2 { get; }
        public ICommand QueueCommand { get; }
        public ICommand StopCommand { get; }
        public ICommand StopProduce { get; }
        public ICommand StopProduce2 { get; }
        public ICommand StopConsumer1 { get; }
        public ICommand StopConsumer2 { get; }
        public IShell ProducerShell2 { get; set; }
        public IShell ProducerShell { get; set; }
        public IShell Consummer { get; set; }
        public IShell Consummer2 { get; set; }
        public IShell QueueShell { get; set; }


        public ProducerConsumer()
        {
            using (var client = new CommandServiceReference.CommandServiceClient())
            {
                Consummer = (IShell)client.GetShell(true);
                Consummer2 = (IShell)client.GetShell(true);
                QueueShell = (IShell)client.GetShell(true);
                ProducerShell = (IShell)client.GetShell(true);
                ProducerShell2 = (IShell)client.GetShell(true);


                ProduceCommand2 = (ICommand)client.GetProduceCommand(ProducerShell2, QueueShell);
                ProduceCommand = (ICommand )client.GetProduceCommand(ProducerShell, QueueShell);
                ConsumeCommand = (ICommand)client.GetConsumeCommand(Consummer, QueueShell);
                ConsumeCommand2 = (ICommand)client.GetConsumeCommand(Consummer2, QueueShell);
                QueueCommand = (ICommand)client.GetQueueCommand(QueueShell); 
                StopCommand = (ICommand)client.GetStopCommand(QueueShell);  

                StopProduce = (ICommand)client.GetStopTask(ProducerShell);
                StopProduce2 = (ICommand)client.GetStopTask (ProducerShell2);
                StopConsumer1 = (ICommand)client.GetStopTask (Consummer);
                StopConsumer2 = (ICommand)client.GetStopTask (Consummer2);
            }
        }
    }
}
