using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EnviaTest
{
    public partial class Login_Envia : Form
    {
        public Login_Envia()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(CSTool.sqlConnString());
            SqlCommand cmd = new SqlCommand("SP_Login", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@uname", txt_loginID.Text);
            cmd.Parameters.AddWithValue("@pass", txt_loginPW.Text);
            conn.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CSVar.userLevel = (int)reader[0];
                if (CSVar.userLevel > 0)
                {
                    CSTool.infoMessage("Usuario Envia Logueado!!.");
                    
                    if (CSULevel.User() || CSULevel.Support() || CSULevel.Admin())
                    {
                        Panel_Envia enviapanel = new Panel_Envia();
                        enviapanel.Show();
                        this.Hide();
                    }
                }else
                {
                    CSTool.errorMessage("Verifique su Usuario Envia.");
                }
            }

            conn.Close();
        }

        private void txt_loginID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == CSKey.Enter) btn_Login.PerformClick(); 
        }

        private void txt_loginPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == CSKey.Enter) btn_Login.PerformClick();
        }

        private void txt_loginID_TextChanged(object sender, EventArgs e)
        {
            if (txt_loginID.Text.Length > CSTool.maxLoginChars)
            {
                CSTool.errorMessage("El max de caracteres para el nombre de usuario Envia es: " + CSTool.maxLoginChars);
                txt_loginID.Text = CSTool.removeLastChar(txt_loginID.Text);
            }
        }

        private void txt_loginPW_TextChanged(object sender, EventArgs e)
        {
            if (txt_loginPW.Text.Length > CSTool.maxLoginChars)
            {
                CSTool.errorMessage("El Max de caracteres de passw Envia es: " + CSTool.maxLoginChars);
                txt_loginPW.Text = CSTool.removeLastChar(txt_loginPW.Text);
                txt_loginPW.Clear();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
