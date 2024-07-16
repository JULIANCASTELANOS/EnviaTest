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
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void LoadSelectedRow()
        {
            txt_id.Text = CSVar.selected_id.ToString();
            txt_uname.Text = CSVar.selected_uname;
            txt_fname.Text = CSVar.selected_fname;
            txt_lname.Text = CSVar.selected_lname;
            txt_email.Text = CSVar.selected_email;
            txt_ulevel.Text = CSVar.selected_userlevel.ToString();
            CSVar.Clear();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            LoadSelectedRow();
            if (CSULevel.Admin()) txt_ulevel.ReadOnly = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseas actualizar el usuario Envia?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                UpdateUser();
            }
            else if (dialogResult == DialogResult.No)
            {
        
            }
        }

        private void UpdateUser()
        {
            SqlConnection conn = new SqlConnection(CSTool.sqlConnString());
            SqlCommand cmd = new SqlCommand("SP_UpdateUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            txt_uname.Text = txt_uname.Text.Trim();
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.Parameters.AddWithValue("@uname", txt_uname.Text);
            cmd.Parameters.AddWithValue("@fname", txt_fname.Text);
            cmd.Parameters.AddWithValue("@lname", txt_lname.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@ulevel", txt_ulevel.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            refreshUsersTable();
            CSTool.infoMessage("El usuario Envia ha sido actualizado!!.");
        }

        private void refreshUsersTable()
        {
            var UMInstance = Application.OpenForms.OfType<AdminUsuario>().Single();
            UMInstance.DGV_GetUsers();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
