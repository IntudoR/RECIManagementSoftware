using System;
using System.Windows.Forms;

namespace RECIManagementSoftware
{
    public class MessageHandler
    {
        private string _msg;

        public void SetMessage(string msg)
        {
            _msg = msg;
        }

        public string GetMessage()
        {
            return _msg;
        }
    }
    
    public class MessageCoordinator
    {
        public void SendMessage(string msg)
        {
            OnMessageAlert?.Invoke(msg);
        }
        public Action<string> OnMessageAlert { get; set; }
    }

    public class Communication
    {
        public Communication() 
        {
            MessageCoordinator coordinator = new();
            MessageHandler msg = new();

            coordinator.OnMessageAlert = Receive;
            coordinator.SendMessage(msg.GetMessage());
        }

        private string _msg;

        private void Receive(string msg)
        {
            MessageBox.Show(msg);
            _msg = msg;
        }

        public string GetMessage()
        {
            return _msg;
        }

    }

}
