namespace EnviaTest
{
    partial class Panel_Envia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_manageUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_manageUser
            // 
            this.btn_manageUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_manageUser.ForeColor = System.Drawing.Color.White;
            this.btn_manageUser.Location = new System.Drawing.Point(12, 12);
            this.btn_manageUser.Name = "btn_manageUser";
            this.btn_manageUser.Size = new System.Drawing.Size(247, 98);
            this.btn_manageUser.TabIndex = 0;
            this.btn_manageUser.Text = "Administrar usuarios Envia";
            this.btn_manageUser.UseVisualStyleBackColor = true;
            this.btn_manageUser.Click += new System.EventHandler(this.btn_manageUser_Click);
            // 
            // CPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(271, 122);
            this.Controls.Add(this.btn_manageUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENVIA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CPanel_FormClosed);
            this.Load += new System.EventHandler(this.CPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_manageUser;
    }
}