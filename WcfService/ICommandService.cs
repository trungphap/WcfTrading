using System.Runtime.Serialization;
using System.ServiceModel;
using System.Windows.Input;
using Models;
using Interfaces;
namespace WcfService
{   
    [ServiceContract]
    public interface ICommandService
    {

        [OperationContract]
        ICommand GetQueueCommand(IShell queueIShell);

        [OperationContract]
        ICommand GetStopCommand(IShell queueIShell);

        [OperationContract]
        ICommand GetStopTask(IShell taskIShell);

        [OperationContract]
        ICommand GetProduceCommand(IShell produceIShell, IShell queueIShell);

        [OperationContract]
        ICommand GetConsumeCommand(IShell consumeIShell, IShell queueIShell);

        [OperationContract]
        ShellData GetShell(bool statusExecutable);       
    }

    [DataContract]
    public class ShellData
    {
        [DataMember(Name = "iShell")]
        private Shell _shellInterface;
        public IShell ShellMember {
            get { return (_shellInterface); }
            set { _shellInterface = (value as Shell); }
        }
    }
    
}
