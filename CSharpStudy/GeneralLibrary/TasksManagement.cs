using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeneralLibrary
{
    public class TasksManagement
    {
        private bool AnyMethod()
        {
            // Any long operation.
            return false;
        }

        public void TaskCancellation()
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = tokenSource.Token;
            int timeout = 30;
            bool taskReturn;
            
            var task = Task.Run( () => AnyMethod(), cancellationToken);

            if (task.Wait(TimeSpan.FromSeconds(timeout)))
            {
                taskReturn = task.Result; 
            }
            else
            {

                tokenSource.Cancel(); // This will not cancel the task.
                throw new Exception("Time out");
            }
        }
    }
}
