using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Memento
    {
        private string _savedPassword;
        private UserRole _savedRole;

        public Memento (string savedPassword, UserRole savedRole)
        {
            _savedPassword=savedPassword;
            _savedRole=savedRole;
        }

        public string GetSavedState(out UserRole role)
        {  
            role = _savedRole;
            return _savedPassword; 
        }
    }
}
