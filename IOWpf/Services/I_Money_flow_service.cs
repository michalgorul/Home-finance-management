using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Services
{
    public interface I_Money_flow_service
    {
        void cancel();

        void edit();

        void set_cyclic();

        void add(int _creator_id, string _creator_name, float _amount, string _date, bool _ifchilds, string _description,string bill_path);
    }
}
