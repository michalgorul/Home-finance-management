using IOWpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace IOWpf.Services
{
    public class Expense_service:I_Money_flow_service
    {
        public void cancel()
        {

        }

        public void edit()
        {

        }

        public void set_cyclic()
        {

        }

        public void add(int _creator_id, string _creator_name, float _amount, string _date, bool _ifchilds, string _description,string bill_path)
        {
            Expense exp = new Expense();
            exp.amount = _amount;
            exp.date = _date;
            exp.creator_name = _creator_name;
            exp.UserId = _creator_id;
            exp.description = _description;
            exp.if_childs = _ifchilds;
            exp.bill_photo_path = bill_path;
            exp.add(); 
        }
    }
}
