using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo
{
    /// <summary>
    /// общий интерфейс для всех команд. подразумевает возможность 
    /// выполнить команду и отменить ее
    /// </summary>
    interface ICommand
    {
        void Execute();
        void Undo();    
    }
}
