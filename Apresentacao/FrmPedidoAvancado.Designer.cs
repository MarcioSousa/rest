namespace Apresentacao
{
    partial class FrmPedidoAvancado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoAvancado));
            this.DgvPedido = new System.Windows.Forms.DataGridView();
            this.PEDIDOPRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GARCON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMEROMESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATAHORAPEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISPONIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox123 = new System.Windows.Forms.GroupBox();
            this.BtnItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DtpPedido = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedido)).BeginInit();
            this.groupBox123.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvPedido
            // 
            this.DgvPedido.AllowUserToAddRows = false;
            this.DgvPedido.AllowUserToDeleteRows = false;
            this.DgvPedido.AllowUserToResizeColumns = false;
            this.DgvPedido.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPedido.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PEDIDOPRODUTO,
            this.GARCON,
            this.NUMEROMESA,
            this.DATAHORAPEDIDO,
            this.DISPONIVEL});
            this.DgvPedido.Location = new System.Drawing.Point(11, 98);
            this.DgvPedido.Margin = new System.Windows.Forms.Padding(5);
            this.DgvPedido.MultiSelect = false;
            this.DgvPedido.Name = "DgvPedido";
            this.DgvPedido.ReadOnly = true;
            this.DgvPedido.RowHeadersVisible = false;
            this.DgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPedido.Size = new System.Drawing.Size(534, 508);
            this.DgvPedido.TabIndex = 4;
            // 
            // PEDIDOPRODUTO
            // 
            this.PEDIDOPRODUTO.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PEDIDOPRODUTO.DefaultCellStyle = dataGridViewCellStyle2;
            this.PEDIDOPRODUTO.HeaderText = "Codigo";
            this.PEDIDOPRODUTO.Name = "PEDIDOPRODUTO";
            this.PEDIDOPRODUTO.ReadOnly = true;
            this.PEDIDOPRODUTO.Width = 70;
            // 
            // GARCON
            // 
            this.GARCON.HeaderText = "Garçon";
            this.GARCON.Name = "GARCON";
            this.GARCON.ReadOnly = true;
            this.GARCON.Width = 70;
            // 
            // NUMEROMESA
            // 
            this.NUMEROMESA.HeaderText = "Mesa";
            this.NUMEROMESA.Name = "NUMEROMESA";
            this.NUMEROMESA.ReadOnly = true;
            this.NUMEROMESA.Width = 70;
            // 
            // DATAHORAPEDIDO
            // 
            this.DATAHORAPEDIDO.HeaderText = "HoraPedido";
            this.DATAHORAPEDIDO.Name = "DATAHORAPEDIDO";
            this.DATAHORAPEDIDO.ReadOnly = true;
            this.DATAHORAPEDIDO.Width = 200;
            // 
            // DISPONIVEL
            // 
            this.DISPONIVEL.HeaderText = "Disp.";
            this.DISPONIVEL.Name = "DISPONIVEL";
            this.DISPONIVEL.ReadOnly = true;
            // 
            // groupBox123
            // 
            this.groupBox123.Controls.Add(this.BtnItem);
            this.groupBox123.Controls.Add(this.panel1);
            this.groupBox123.Controls.Add(this.DgvPedido);
            this.groupBox123.Controls.Add(this.BtnFechar);
            this.groupBox123.Controls.Add(this.BtnExcluir);
            this.groupBox123.Location = new System.Drawing.Point(12, 12);
            this.groupBox123.Name = "groupBox123";
            this.groupBox123.Size = new System.Drawing.Size(553, 614);
            this.groupBox123.TabIndex = 5;
            this.groupBox123.TabStop = false;
            // 
            // BtnItem
            // 
            this.BtnItem.BackColor = System.Drawing.SystemColors.Control;
            this.BtnItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnItem.Location = new System.Drawing.Point(11, 20);
            this.BtnItem.Margin = new System.Windows.Forms.Padding(4);
            this.BtnItem.Name = "BtnItem";
            this.BtnItem.Size = new System.Drawing.Size(100, 28);
            this.BtnItem.TabIndex = 11;
            this.BtnItem.Text = "Itens";
            this.BtnItem.UseVisualStyleBackColor = true;
            this.BtnItem.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.DtpPedido);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(121, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 33);
            this.panel1.TabIndex = 10;
            // 
            // DtpPedido
            // 
            this.DtpPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpPedido.Location = new System.Drawing.Point(87, 6);
            this.DtpPedido.Name = "DtpPedido";
            this.DtpPedido.Size = new System.Drawing.Size(118, 20);
            this.DtpPedido.TabIndex = 10;
            this.DtpPedido.ValueChanged += new System.EventHandler(this.DtpPedido_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pesquisa Data";
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnFechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnFechar.Location = new System.Drawing.Point(445, 20);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(100, 28);
            this.BtnFechar.TabIndex = 7;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnExcluir.Location = new System.Drawing.Point(337, 20);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(100, 28);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // FrmPedidoAvancado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 639);
            this.Controls.Add(this.groupBox123);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedidoAvancado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Pedidos - Modo Avançado";
            this.Load += new System.EventHandler(this.FrmPedidoAvancado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedido)).EndInit();
            this.groupBox123.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPedido;
        private System.Windows.Forms.GroupBox groupBox123;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DateTimePicker DtpPedido;
        private System.Windows.Forms.Button BtnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDIDOPRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GARCON;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMEROMESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATAHORAPEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISPONIVEL;
    }
}