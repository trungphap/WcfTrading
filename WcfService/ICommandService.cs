using System.Runtime.Serialization;
using System.ServiceModel;
using System.Windows.Input;
using Models;
using Interfaces;
namespace WcfService
{   
    [ServiceContract]
    [ServiceKnownTypeAttribute(typeof(Shell))]
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
        Shell GetShell(bool statusExecutable);

    }

    
}
