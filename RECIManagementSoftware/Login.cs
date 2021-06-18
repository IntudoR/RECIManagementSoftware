using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RECIManagementSoftware
{
    public partial class Login : Form
    {
        private bool _lockedBy;

        public Login()
        {
            InitializeComponent();

            CenterToScreen();

            label_InocorrectStatus.Hide();

            _lockedBy = checkBox_isRemoteServer.Checked;
      
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox_ServerName.Enabled = false;
            textBox_Password.UseSystemPasswordChar = true;

        }

        private void checkBox_isRemoteServer_Click(object sender, EventArgs e)
        {
            _lockedBy = checkBox_isRemoteServer.Checked;

            if (_lockedBy)
                textBox_ServerName.Enabled = true;
            else
                textBox_ServerName.Enabled = false;

        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked)
                textBox_Password.UseSystemPasswordChar = false;
            else
                textBox_Password.UseSystemPasswordChar = true;
        }
    }
}
