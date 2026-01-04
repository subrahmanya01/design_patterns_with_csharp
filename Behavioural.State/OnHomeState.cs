using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.State
{
    internal class OnHomeState : State
    {
        public OnHomeState(Phone phone) : base(phone)
        {
            
        }
        public override void OnHome()
        {
            Console.WriteLine("On Home Screen");
        }

        public override void OnOffOn()
        {
            _phone.SetState(new LockedState(_phone));
            Console.WriteLine("Phone turned off");
        }
    }
}
