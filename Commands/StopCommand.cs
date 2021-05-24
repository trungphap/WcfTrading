using Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Commands
{
    public sealed class StopCommand : AsyncCommand
    {

        readonly IShell _stopShell;
        readonly List<IShell> _shellList;

        public StopCommand(IShell stopShell, List<IShell> shellList)
        {
            _stopShell = stopShell;
            _shellList = shellList;
        }




        public override bool CanExecute(object parameter)
        {
            return !_stopShell.StatusExecutable;
        }



        public async override Task ExecuteAsync(object parameter)
        {
            foreach (var s in _shellList)
            {
                s.IsExecuting = false;               
            }
            _stopShell.StatusExecutable = true;
            int.TryParse((string)parameter, out int t);
            await Task.Delay(Math.Max(t, 3000));
            _stopShell.FontText = "";
            if (SingleChannel.ShareChannelWriter.TryComplete()) SingleChannel.ResetChannel();

            _stopShell.IsExecuting = false;
        }

    }
}
