using MaterialOrderingApp.Models;
using MaterialOrderingApp.Repositories;
using System;
using System.Collections.Generic;

namespace MaterialOrderingApp.Services
{
    public class TransactionService
    {
        private readonly TransactionRepository _repo;

        public TransactionService(TransactionRepository repo)
        {
            _repo = repo;
        }

        public List<Transaction> AmbilSemua()
        {
            return _repo.GetAllTransactions();
        }

        public void TambahPesanan(Transaction transaction)
        {
            //if (transaction == null)
            //    throw new ArgumentNullException(nameof(transaction));

            //if (transaction.quantity <= 0)
            //    throw new ArgumentException("Jumlah harus lebih dari 0.");

            _repo.Insert(transaction);
        }
    }
}