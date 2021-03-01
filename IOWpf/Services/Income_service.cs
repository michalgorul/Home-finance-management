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
    public class Income_service:I_Money_flow_service
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

        public void add(int _creator_id, string _creator_name, float _amount, string _date, bool _ifchilds, string _description, string bill_path)
        {
            Income inc = new Income();
            inc.amount = _amount;
            inc.date = _date;
            inc.creator_name = _creator_name;
            inc.UserId = _creator_id;
            inc.description = _description;
            inc.if_childs = _ifchilds;
            inc.add();
        }
    }
}
