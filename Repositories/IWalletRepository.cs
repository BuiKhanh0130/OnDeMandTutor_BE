﻿using BusinessObjects;
using DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IWalletRepository
    {
        public bool AddWallet(Wallet wallet);

        public bool DelWallets(int id);

        public List<Wallet> GetWallets();

        public bool UpdateWallets(Wallet wallet);

        Task<float?> CreaterHistoryTransaction(HistoryTransaction transaction);

        Task<float?> UpdateBalance(string userId, float plusMoney);

        Task<float?> WithdrawMoney(string userId, float money);
    }
}
