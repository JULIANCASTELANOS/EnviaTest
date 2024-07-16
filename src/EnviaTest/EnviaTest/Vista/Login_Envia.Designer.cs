namespace EnviaTest
{
    partial class Login_Envia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Envia));
            this.txt_loginID = new System.Windows.Forms.TextBox();
            this.txt_loginPW = new System.Windows.Forms.TextBox();
            this.lbl_loginID = new System.Windows.Forms.Label();
            this.lbl_loginPW = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_loginID
            // 
            this.txt_loginID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_loginID.Location = new System.Drawing.Point(195, 40);
            this.txt_loginID.MaxLength = 21;
            this.txt_loginID.Name = "txt_loginID";
            this.txt_loginID.Size = new System.Drawing.Size(161, 20);
            this.txt_loginID.TabIndex = 0;
            this.txt_loginID.TextChanged += new System.EventHandler(this.txt_loginID_TextChanged);
            this.txt_loginID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_loginID_KeyPress);
            // 
            // txt_loginPW
            // 
            this.txt_loginPW.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_loginPW.Location = new System.Drawing.Point(195, 79);
            this.txt_loginPW.MaxLength = 21;
            this.txt_loginPW.Name = "txt_loginPW";
            this.txt_loginPW.PasswordChar = '*';
            this.txt_loginPW.Size = new System.Drawing.Size(161, 20);
            this.txt_loginPW.TabIndex = 1;
            this.txt_loginPW.TextChanged += new System.EventHandler(this.txt_loginPW_TextChanged);
            this.txt_loginPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_loginPW_KeyPress);
            // 
            // lbl_loginID
            // 
            this.lbl_loginID.AutoSize = true;
            this.lbl_loginID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loginID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_loginID.ForeColor = System.Drawing.Color.White;
            this.lbl_loginID.Location = new System.Drawing.Point(133, 43);
            this.lbl_loginID.Name = "lbl_loginID";
            this.lbl_loginID.Size = new System.Drawing.Size(46, 13);
            this.lbl_loginID.TabIndex = 2;
            this.lbl_loginID.Text = "Usuario:";
            // 
            // lbl_loginPW
            // 
            this.lbl_loginPW.AutoSize = true;
            this.lbl_loginPW.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loginPW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_loginPW.ForeColor = System.Drawing.Color.White;
            this.lbl_loginPW.Location = new System.Drawing.Point(142, 82);
            this.lbl_loginPW.Name = "lbl_loginPW";
            this.lbl_loginPW.Size = new System.Drawing.Size(37, 13);
            this.lbl_loginPW.TabIndex = 3;
            this.lbl_loginPW.Text = "Clave:";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(195, 116);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(161, 28);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "INGRESAR";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "envia.png");
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(957, 13);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(994, 651);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_loginPW);
            this.Controls.Add(this.lbl_loginID);
            this.Controls.Add(this.txt_loginPW);
            this.Controls.Add(this.txt_loginID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(296, 179);
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ENVIA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_loginID;
        private System.Windows.Forms.TextBox txt_loginPW;
        private System.Windows.Forms.Label lbl_loginID;
        private System.Windows.Forms.Label lbl_loginPW;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_close;
    }
}

