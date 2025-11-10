using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioural.ChainOfResposibility
{
    internal class Account
    {
        protected Account _successor;

        protected float _balance;

        public Account(float balance)
        {
            _balance = balance;
        }

        public void SetSuccessor(Account account) { 
            _successor = account;
        }

        public virtual void Pay(float amount) {
            if (CanPay(amount))
            {
                _balance -= amount;
                Console.WriteLine($"Payment successfull with {this.GetType().Name}");
            }
            else if (_successor != null) { 
                _successor.Pay(amount);
            }
            else{
                throw new Exception($"No payment method avaialable to pay the given amount {amount}");
            }
        }

        public bool CanPay(float amount)
        {
            return amount < _balance;
        }
    }
}
