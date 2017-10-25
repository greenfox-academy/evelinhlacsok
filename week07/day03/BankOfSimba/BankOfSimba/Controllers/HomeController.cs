﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("Simba")]
        public IActionResult Index()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Name = "Simba";
            bankAccount.Balance = "2000";
            bankAccount.AnimalType = AnimalType.Lion;

            return View(bankAccount);
        }
        [Route("Accounts")]
        public IActionResult ListOfBankAccounts()
        {
            List<BankAccount> BankAccounts = new List<BankAccount>();
            BankAccounts.Add(new BankAccount("Nala", "1000", AnimalType.Tiger));
            BankAccounts.Add(new BankAccount("Zazu", "500", AnimalType.Bird));
            BankAccounts.Add(new BankAccount("Zordon", "4000", AnimalType.Tiger));
            BankAccounts.Add(new BankAccount("Rafiki", "3000", AnimalType.Monkey));

            return View(BankAccounts);
        }
    }
}
