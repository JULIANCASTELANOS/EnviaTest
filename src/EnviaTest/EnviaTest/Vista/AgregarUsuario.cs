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

namespace EnviaTest
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void AddNewUser()
        {
            SqlConnection conn = new SqlConnection(CSTool.sqlConnString());
            SqlCommand cmd = new SqlCommand("SP_AddUser2", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            txt_uname.Text = txt_uname.Text.Trim();
            cmd.Parameters.AddWithValue("@uname", txt_uname.Text);
            cmd.Parameters.AddWithValue("@pword", txt_pword.Text);
            cmd.Parameters.AddWithValue("@fname", txt_fname.Text);
            cmd.Parameters.AddWithValue("@lname", txt_lname.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@ulevel", txt_ulevel.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            refreshUsersTable();

            CSTool.infoMessage("El usuario Envia ha sido agregado.");
            this.Close();
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            if ((txt_uname.Text=="")||(txt_pword.Text==""))
            {
                MessageBox.Show("Valide los campos");
            }
            else { 

            DialogResult dialogResult = MessageBox.Show("Agregar este usuario Envia?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                AddNewUser();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
            }
        }

        private void refreshUsersTable()
        {
            var UMInstance = Application.OpenForms.OfType<AdminUsuario>().Single();
            UMInstance.DGV_GetUsers();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
        }
    }
}
