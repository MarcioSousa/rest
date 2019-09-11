namespace Apresentacao
{
    partial class FrmGarcon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGarcon));
            this.groupBox123 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.DgvGarcon = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.groupBox123.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGarcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox123
            // 
            this.groupBox123.Controls.Add(this.panel1);
            this.groupBox123.Controls.Add(this.BtnFechar);
            this.groupBox123.Controls.Add(this.BtnAdicionar);
            this.groupBox123.Controls.Add(this.BtnEditar);
            this.groupBox123.Controls.Add(this.BtnExcluir);
            this.groupBox123.Controls.Add(this.BtnCancelar);
            this.groupBox123.Controls.Add(this.DgvGarcon);
            this.groupBox123.Controls.Add(this.groupBox1);
            this.groupBox123.Location = new System.Drawing.Point(12, 12);
            this.groupBox123.Name = "groupBox123";
            this.groupBox123.Size = new System.Drawing.Size(537, 614);
            this.groupBox123.TabIndex = 1;
            this.groupBox123.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtPesquisa);
            this.panel1.Location = new System.Drawing.Point(11, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 33);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pesquisa";
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPesquisa.Location = new System.Drawing.Point(77, 6);
            this.TxtPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPesquisa.MaxLength = 30;
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(331, 20);
            this.TxtPesquisa.TabIndex = 8;
            this.TxtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnFechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnFechar.Location = new System.Drawing.Point(430, 22);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(100, 28);
            this.BtnFechar.TabIndex = 7;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(11, 22);
            this.BtnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(100, 28);
            this.BtnAdicionar.TabIndex = 0;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(118, 22);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(100, 28);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnExcluir.Location = new System.Drawing.Point(224, 22);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(100, 28);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.Location = new System.Drawing.Point(430, 137);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 28);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // DgvGarcon
            // 
            this.DgvGarcon.AllowUserToAddRows = false;
            this.DgvGarcon.AllowUserToDeleteRows = false;
            this.DgvGarcon.AllowUserToResizeColumns = false;
            this.DgvGarcon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvGarcon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGarcon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvGarcon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvGarcon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGarcon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOME});
            this.DgvGarcon.Location = new System.Drawing.Point(11, 173);
            this.DgvGarcon.Margin = new System.Windows.Forms.Padding(4);
            this.DgvGarcon.MultiSelect = false;
            this.DgvGarcon.Name = "DgvGarcon";
            this.DgvGarcon.ReadOnly = true;
            this.DgvGarcon.RowHeadersVisible = false;
            this.DgvGarcon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGarcon.Size = new System.Drawing.Size(519, 434);
            this.DgvGarcon.TabIndex = 3;
            this.DgvGarcon.SelectionChanged += new System.EventHandler(this.DgvGarcon_SelectionChanged);
            this.DgvGarcon.DoubleClick += new System.EventHandler(this.DgvGarcon_DoubleClick);
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CODIGO.DefaultCellStyle = dataGridViewCellStyle2;
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 80;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "Nome";
            this.NOME.HeaderText = "Garçon";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 410;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnConfirmar);
            this.groupBox1.Location = new System.Drawing.Point(11, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(519, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // TxtNome
            // 
            this.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNome.Location = new System.Drawing.Point(88, 36);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNome.MaxLength = 30;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.ReadOnly = true;
            this.TxtNome.Size = new System.Drawing.Size(323, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(13, 36);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigo.MaxLength = 5;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(67, 20);
            this.TxtCodigo.TabIndex = 0;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Enabled = false;
            this.BtnConfirmar.Location = new System.Drawing.Point(419, 31);
            this.BtnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(100, 28);
            this.BtnConfirmar.TabIndex = 5;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // FrmGarcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 637);
            this.Controls.Add(this.groupBox123);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGarcon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Garçons";
            this.Load += new System.EventHandler(this.FrmGarcon_Load);
            this.groupBox123.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGarcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox123;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridView DgvGarcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
    }
}