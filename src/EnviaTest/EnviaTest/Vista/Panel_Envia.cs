using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviaTest
{
    public partial class Panel_Envia : Form
    {
        public Panel_Envia()
        {
            InitializeComponent();
        }

        private void CPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var LPanelInstance = Application.OpenForms.OfType<Login_Envia>().Single();
            LPanelInstance.Show();
        }

        private void btn_manageUser_Click(object sender, EventArgs e)
        {
            AdminUsuario UManage = new AdminUsuario();
            UManage.Show();
            this.Hide();
        }

        private void CPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
