namespace ControlaGastos
{
    partial class Frmexcluir
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPago = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(106, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Pago";
            // 
            // cmbPago
            // 
            this.cmbPago.Enabled = false;
            this.cmbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPago.FormattingEnabled = true;
            this.cmbPago.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.cmbPago.Location = new System.Drawing.Point(70, 238);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(123, 28);
            this.cmbPago.TabIndex = 27;
            this.cmbPago.Text = "Selecione...";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(280, 383);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 54);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(70, 168);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(123, 35);
            this.txtValor.TabIndex = 25;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(105, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(107, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Enabled = false;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Fixa",
            "Variável"});
            this.cmbTipo.Location = new System.Drawing.Point(138, 190);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(123, 28);
            this.cmbTipo.TabIndex = 22;
            this.cmbTipo.Text = "Selecione...";
            // 
            // txtConta
            // 
            this.txtConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConta.Location = new System.Drawing.Point(70, 43);
            this.txtConta.Multiline = true;
            this.txtConta.Name = "txtConta";
            this.txtConta.ReadOnly = true;
            this.txtConta.Size = new System.Drawing.Size(123, 35);
            this.txtConta.TabIndex = 21;
            this.txtConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 54);
            this.label3.TabIndex = 20;
            this.label3.Text = "@Silvana Betoldo ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(99, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Conta";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSair.Location = new System.Drawing.Point(314, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 91);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            this.label1.Size = new System.Drawing.Size(389, 91);
            this.label1.TabIndex = 17;
            this.label1.Text = "Controle de Gastos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.cmbPago);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtConta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(68, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 301);
            this.panel1.TabIndex = 29;
            // 
            // Frmexcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(389, 437);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmexcluir";
            this.Text = "Frmexcluir";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPago;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}