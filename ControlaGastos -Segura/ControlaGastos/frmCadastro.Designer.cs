namespace ControlaGastos
{
    partial class frmCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPago = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Gastos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSair.Location = new System.Drawing.Point(330, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 91);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(112, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Conta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 54);
            this.label3.TabIndex = 7;
            this.label3.Text = "@Silvana Betoldo ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtConta
            // 
            this.txtConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConta.Location = new System.Drawing.Point(146, 140);
            this.txtConta.Multiline = true;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(123, 35);
            this.txtConta.TabIndex = 8;
            this.txtConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConta.TextChanged += new System.EventHandler(this.txtConta_TextChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Fixa",
            "Variável"});
            this.cmbTipo.Location = new System.Drawing.Point(146, 210);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(123, 28);
            this.cmbTipo.TabIndex = 9;
            this.cmbTipo.Text = "Selecione...";
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(119, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(112, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(75, 189);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(123, 35);
            this.txtValor.TabIndex = 13;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(296, 423);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 54);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(112, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pago";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbPago
            // 
            this.cmbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPago.FormattingEnabled = true;
            this.cmbPago.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.cmbPago.Location = new System.Drawing.Point(146, 344);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(123, 28);
            this.cmbPago.TabIndex = 15;
            this.cmbPago.Text = "Selecione...";
            this.cmbPago.SelectedIndexChanged += new System.EventHandler(this.cmbPago_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(71, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 345);
            this.panel1.TabIndex = 30;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(405, 476);
            this.Controls.Add(this.cmbPago);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPago;
        private System.Windows.Forms.Panel panel1;
    }
}