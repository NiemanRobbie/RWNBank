using System;
using System.Collections.Generic;
using System.Linq;

namespace RWNBank
{
    public class AccountTracker
    {
        public List<Accounts> Sightings { get; set; } = new List<Accounts>();

        public void AddANewAccount(string sav, string chk)
        {
            var account = new Accounts
            {
                checking = chk,
                savings = sav,
            };
            accounts.Add(account);
        }
        public void RemoveAccount(string chk)
        {

            var thingToRemove = acccounts.Where(account => account.Balance == chk).ToList();
            if (thingToRemove.Count() > 1)
            {
                for (int i = 0; i < thingToRemove.Count; i++)
                {
                    var chkbal = thingToRemove[i];
                    Console.WriteLine($"{i + 1}: {chkbal.Balance} at ${chkbal.Balance}");
                }

                var index = int.Parse(Console.ReadLine());
                Accounts.Remove(thingToRemove[index - 1]);

            }
            else
            {
                // remove the only instance found
                Accounts.Remove(thingToRemove.First());
            }
        }
        public void Transfer(string chk, string sav)
        {
            // find the item first
            var tran = Accounts.First(acount => account.Name == chk);
            // re-assign the fields
            tran.TansferAmount = int.Parse(sav);
        }
    }

