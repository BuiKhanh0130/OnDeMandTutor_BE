using BusinessObjects;
using BusinessObjects.Models;
using DAOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAccountRepository
    {
        public bool AddAccount(Account account);

        public bool DelAccounts(string id);
        public Task<Account> GetAccountById(string id);

        public List<Account> GetAccounts();

        public bool UpdateAccounts(Account account);

        Task<IdentityResult> SignUpAsync(AccountDTO model);
        Task<Account> SignInAsync(UserSignIn model);
        Task<IList<String>> GetRolesAsync(Account user);

    }
}
