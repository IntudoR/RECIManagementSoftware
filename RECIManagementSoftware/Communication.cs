using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECIManagementSoftware
{
    class Communication
    {
        public Communication()
        {

        }

        private string _msg;

        public void SetMessage(string msg)
        {
            _msg = msg;
        }

        public void SendMessage(string msg)
        {
            OnMessageAlert?.Invoke(msg);
        }

        public Action<string> OnMessageAlert { get; set; }
    }
}
