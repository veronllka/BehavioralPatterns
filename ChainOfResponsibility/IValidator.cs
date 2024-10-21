using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal interface IValidator
    {
        void SetNext(IValidator validator);
        bool Validate(User user);
    }
}
