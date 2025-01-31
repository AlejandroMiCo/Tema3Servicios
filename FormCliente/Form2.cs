using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCliente
{
    public partial class Form2 : Form
    {
        IPEndPoint ie;
        IPAddress ip;
        ushort port;

        public Form2(IPEndPoint ie)
        {
            InitializeComponent();

            this.ie = ie;
            txtIp.Text = ie.Address.ToString();
            txtPuerto.Text = ie.Port.ToString();
        }

        public void chekValidity(object sender, EventArgs e)
        {
            bool isValidIp = IPAddress.TryParse(txtIp.Text, out ip);
            bool isValidPort = ushort.TryParse(txtPuerto.Text, out port);

            if (isValidIp && isValidPort)
            {
                btnConfirm.Enabled = true;
            }
            else
            {
                btnConfirm.Enabled = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ie.Address = ip;
            ie.Port = port;
        }
    }
}
