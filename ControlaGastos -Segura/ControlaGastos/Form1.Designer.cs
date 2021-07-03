namespace ControlaGastos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPagar = new System.Windows.Forms.Label();
            this.tmtPagar = new System.Windows.Forms.Timer(this.components);
            this.lblPago = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tmtPago = new System.Windows.Forms.Timer(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controle de Gasto Mensal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 498);
            this.panel1.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExcluir.Location = new System.Drawing.Point(4, 369);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(160, 60);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExportar.Location = new System.Drawing.Point(4, 435);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(160, 60);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEditar.Location = new System.Drawing.Point(4, 303);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(160, 60);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAtualizar.Location = new System.Drawing.Point(3, 237);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(161, 60);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCadastrar.Location = new System.Drawing.Point(4, 171);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(160, 60);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(672, 66);
            this.label2.TabIndex = 2;
            this.label2.Text = " @SilvanaBetoldo | 2021 ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvGastos
            // 
            this.dgvGastos.AllowUserToAddRows = false;
            this.dgvGastos.AllowUserToDeleteRows = false;
            this.dgvGastos.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvGastos.CausesValidation = false;
            this.dgvGastos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGastos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGastos.GridColor = System.Drawing.Color.Black;
            this.dgvGastos.Location = new System.Drawing.Point(166, 64);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGastos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGastos.RowHeadersVisible = false;
            this.dgvGastos.RowHeadersWidth = 50;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGastos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGastos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.dgvGastos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGastos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGastos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvGastos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGastos.RowTemplate.DividerHeight = 2;
            this.dgvGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGastos.Size = new System.Drawing.Size(506, 501);
            this.dgvGastos.TabIndex = 2;
            this.dgvGastos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGastos_CellContentClick_1);
            this.dgvGastos.VisibleChanged += new System.EventHandler(this.Form1_Load);
            this.dgvGastos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvGastos_MouseClick);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSair.Location = new System.Drawing.Point(574, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 64);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "A pagar :";
            // 
            // lblPagar
            // 
            this.lblPagar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagar.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPagar.Location = new System.Drawing.Point(551, 562);
            this.lblPagar.Name = "lblPagar";
            this.lblPagar.Size = new System.Drawing.Size(121, 66);
            this.lblPagar.TabIndex = 6;
            this.lblPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmtPagar
            // 
            this.tmtPagar.Enabled = true;
            this.tmtPagar.Interval = 1;
            this.tmtPagar.Tick += new System.EventHandler(this.tmtPagar_Tick);
            // 
            // lblPago
            // 
            this.lblPago.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPago.Location = new System.Drawing.Point(339, 563);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(121, 66);
            this.lblPago.TabIndex = 7;
            this.lblPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPago.Click += new System.EventHandler(this.lblPago_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkCyan;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pago:";
            // 
            // tmtPago
            // 
            this.tmtPago.Enabled = true;
            this.tmtPago.Interval = 1;
            this.tmtPago.Tick += new System.EventHandler(this.tmtPago_Tick);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Conta";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Pago";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 105;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 628);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblPagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGastos);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPagar;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.Timer tmtPagar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmtPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

