using System;
using System.Collections.Generic;

namespace OWASPDemos.Models
{
    public class Account
    {
        public string Id { get; set; }

        public string Description { get; set; }

        public float Balance { get; set; }

        public string Owner { get; set; }
    }

    public class AccountsContext : IDisposable
    {
        private static List<Account> _accounts = 
            new List<Account>
            {
                new Account { Id = "100000001", Description = "Checking", Balance = 500.00F, Owner = "barryd@idunno.org" },
                new Account { Id = "100000002", Description = "Savings", Balance = 3.50F, Owner = "barryd@idunno.org" },
                new Account { Id = "100003001", Description = "Checking", Balance = 0, Owner = "attacker@badsite.example" }
            };

        public IList<Account> Accounts
        {
            get { return _accounts; }
        }

        public void Dispose()
        {
            ;
        }
    }
}