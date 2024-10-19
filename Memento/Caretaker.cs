using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    /// <summary>
    /// класс, отвечающий за хранение снимка 
    /// хранить снимки можно как во множественном виде в виде коллекций
    /// так и в одиночном как в текущем примере
    /// </summary>
    internal class Caretaker
    {
        public Memento Memento { get; set; }    
    }
}
