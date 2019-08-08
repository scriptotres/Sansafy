using Sansafy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sansafy.Repositories
{
    class AccountRepository : IRepository<Account>
    {
        List<Account> accounts;

        public AccountRepository()
        {
            accounts = new List<Account>();
            accounts.Add(new Account()
            {
                Id = new Guid(),
                NameCompany = "Intec",      
            });
            accounts.Add(new Account()
            {
                Id = new Guid(),
                NameCompany = "De Post"
            });
            accounts.Add(new Account()
            {
                Id = new Guid(),
                NameCompany = "NMBS"
            });
        }
        public Account Create(Account account)
        {
            accounts.Add(account);
            return account;
        }

        public Account Delete(Account account)
        {
            accounts.Remove(account);
            return account;
        }

        public List<Account> GetAll()
        {
            return accounts;
        }

        public Account GetById(Guid id)
        {
            var account = accounts.FirstOrDefault(x => x.Id == id);
            return account;
        }

        public Account Update(Account t)
        {
            throw new NotImplementedException();
        }
    }
}
