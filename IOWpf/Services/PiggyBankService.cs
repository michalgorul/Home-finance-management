using IOWpf.Migrations;
using IOWpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Services
{
    public class PiggyBankService
    {
        public void Deposit(float _amount, int PbId)
        {
            using (var db = new ApplicationContext())
            {
                var query = from pb in db.piggyBanks
                            where pb.piggyBankId == PbId
                            select pb;
                query.FirstOrDefault().treasuredAmount += _amount;
                db.SaveChanges();
                MainWindow.piggyBanksList.Clear();
                MainWindow.piggyBanksList = db.piggyBanks.ToList();
                
            }
        }

        void EndPiggyBank()
        {

        }

        public void Withdraw(float _amount, int PbId)
        {
            using (var db = new ApplicationContext())
            {
                var query = from pb in db.piggyBanks
                            where pb.piggyBankId == PbId
                            select pb;
                query.FirstOrDefault().treasuredAmount -= _amount;
                if(query.FirstOrDefault().treasuredAmount < 0)
                {
                    query.FirstOrDefault().treasuredAmount += _amount;
                }
                db.SaveChanges();
                MainWindow.piggyBanksList.Clear();
                MainWindow.piggyBanksList = db.piggyBanks.ToList();
            }
        }
    }
}
