namespace ControlaGastos
{
    partial class frmLogin
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
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Label();
            this.btnSenha = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(304, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 46);
            this.button6.TabIndex = 5;
            this.button6.Text = "Sair";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 47);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(-3, 59);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(271, 33);
            this.txtUser.TabIndex = 8;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastro.Location = new System.Drawing.Point(0, 373);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(385, 58);
            this.btnCadastro.TabIndex = 12;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // btnUsuario
            // 
            this.btnUsuario.AutoSize = true;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuario.Location = new System.Drawing.Point(101, 25);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(71, 20);
            this.btnUsuario.TabIndex = 7;
            this.btnUsuario.Text = "Usúario";
            // 
            // btnSenha
            // 
            this.btnSenha.AutoSize = true;
            this.btnSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSenha.Location = new System.Drawing.Point(101, 116);
            this.btnSenha.Name = "btnSenha";
            this.btnSenha.Size = new System.Drawing.Size(61, 20);
            this.btnSenha.TabIndex = 9;
            this.btnSenha.Text = "Senha";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(32, 148);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(210, 33);
            this.txtPass.TabIndex = 10;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(55, 211);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 48);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.btnSenha);
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Location = new System.Drawing.Point(66, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 289);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(385, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login do Usuário";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnUsuario;
        private System.Windows.Forms.Label btnSenha;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
    }
}