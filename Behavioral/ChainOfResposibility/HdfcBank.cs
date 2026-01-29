using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.ChainOfResposibility
{
    internal class HdfcBank : Account
    {
        public HdfcBank(float balance): base(balance)
        {
            
        }
    }
}
