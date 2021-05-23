using Models;
using System.ServiceModel;
using System.Windows.Input;

namespace WcfService
{   
    [ServiceContract]
    public interface ICommandService
    {

        [OperationContract]
        ICommand GetQueueCommand(IShell queueShell);

        [OperationContract]
        ICommand GetStopCommand(IShell queueShell);

 
    }
}
