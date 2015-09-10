using OWASPDemos.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace OWASPDemos.Controllers
{
    [Authorize]
    public class CsrfController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new AccountsContext())
            {
                var model = from a in context.Accounts where a.Owner == User.Identity.Name select a;
                return View(model);
            }
        }

        [HttpPost]
        public ActionResult Transfer(string fromAccountId, string toAccountId, decimal? amount = null)
        {
            if (amount != null)
            {
                decimal amountToTransfer = (decimal)amount;

                using (var context = new AccountsContext())
                {
                    var fromAccount = (from a in context.Accounts where a.Id == fromAccountId select a).SingleOrDefault();
                    var toAccount = (from a in context.Accounts where a.Id == toAccountId select a).SingleOrDefault();

                    if (fromAccount != null && toAccount != null)
                    {
                        if (fromAccount.Balance >= amountToTransfer)
                        {
                            fromAccount.Balance -= amountToTransfer;
                            toAccount.Balance += amountToTransfer;
                        }
                    }
                }
            }

            return RedirectToAction("Index");
        }

        public ActionResult Protected()
        {
            using (var context = new AccountsContext())
            {
                var model = from a in context.Accounts where a.Owner == User.Identity.Name select a;
                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TransferProtected(string fromAccountId, string toAccountId, decimal? amount = null)
        {
            if (amount != null)
            {
                decimal amountToTransfer = (decimal)amount;

                using (var context = new AccountsContext())
                {
                    var fromAccount = (from a in context.Accounts where a.Id == fromAccountId select a).SingleOrDefault();
                    var toAccount = (from a in context.Accounts where a.Id == toAccountId select a).SingleOrDefault();

                    if (fromAccount != null && toAccount != null)
                    {
                        if (fromAccount.Balance >= amountToTransfer)
                        {
                            fromAccount.Balance -= amountToTransfer;
                            toAccount.Balance += amountToTransfer;
                        }
                    }
                }
            }

            return RedirectToAction("Protected");
        }
    }
}