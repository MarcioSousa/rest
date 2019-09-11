namespace Apresentacao
{
    partial class FrmPagamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagamento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblMesa = new System.Windows.Forms.Label();
            this.LblTotalConta = new System.Windows.Forms.Label();
            this.LblGarcon = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblValorPago = new System.Windows.Forms.Label();
            this.LblValorFaltante = new System.Windows.Forms.Label();
            this.LblQtdePagamento = new System.Windows.Forms.Label();
            this.DgvPagamento = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATAPAGAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlPagamento = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.RbtOutro = new System.Windows.Forms.RadioButton();
            this.RbtCredito = new System.Windows.Forms.RadioButton();
            this.RbtDebito = new System.Windows.Forms.RadioButton();
            this.RbtCheque = new System.Windows.Forms.RadioButton();
            this.RbtDinheiro = new System.Windows.Forms.RadioButton();
            this.BtnReceber = new System.Windows.Forms.Button();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEncerrarMesa = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPagamento)).BeginInit();
            this.PnlPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnFechar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 100);
            this.panel1.TabIndex = 7;
            // 
            // BtnFechar
            // 
            this.BtnFechar.AutoSize = true;
            this.BtnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnFechar.Location = new System.Drawing.Point(704, 3);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(110, 34);
            this.BtnFechar.TabIndex = 0;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.LblMesa);
            this.panel3.Controls.Add(this.LblTotalConta);
            this.panel3.Controls.Add(this.LblGarcon);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 90);
            this.panel3.TabIndex = 26;
            // 
            // LblMesa
            // 
            this.LblMesa.AutoSize = true;
            this.LblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMesa.Location = new System.Drawing.Point(5, 6);
            this.LblMesa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblMesa.Name = "LblMesa";
            this.LblMesa.Size = new System.Drawing.Size(57, 20);
            this.LblMesa.TabIndex = 21;
            this.LblMesa.Text = "Mesa:";
            // 
            // LblTotalConta
            // 
            this.LblTotalConta.AutoSize = true;
            this.LblTotalConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalConta.Location = new System.Drawing.Point(5, 34);
            this.LblTotalConta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTotalConta.Name = "LblTotalConta";
            this.LblTotalConta.Size = new System.Drawing.Size(107, 20);
            this.LblTotalConta.TabIndex = 18;
            this.LblTotalConta.Text = "Total Conta:";
            // 
            // LblGarcon
            // 
            this.LblGarcon.AutoSize = true;
            this.LblGarcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGarcon.Location = new System.Drawing.Point(5, 62);
            this.LblGarcon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblGarcon.Name = "LblGarcon";
            this.LblGarcon.Size = new System.Drawing.Size(68, 20);
            this.LblGarcon.TabIndex = 22;
            this.LblGarcon.Text = "Garçon";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.LblValorPago);
            this.panel4.Controls.Add(this.LblValorFaltante);
            this.panel4.Controls.Add(this.LblQtdePagamento);
            this.panel4.Location = new System.Drawing.Point(505, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(328, 186);
            this.panel4.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "RESUMO DA MESA";
            // 
            // LblValorPago
            // 
            this.LblValorPago.AutoSize = true;
            this.LblValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorPago.Location = new System.Drawing.Point(5, 93);
            this.LblValorPago.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblValorPago.Name = "LblValorPago";
            this.LblValorPago.Size = new System.Drawing.Size(100, 20);
            this.LblValorPago.TabIndex = 21;
            this.LblValorPago.Text = "Total Pago:";
            // 
            // LblValorFaltante
            // 
            this.LblValorFaltante.AutoSize = true;
            this.LblValorFaltante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorFaltante.Location = new System.Drawing.Point(5, 121);
            this.LblValorFaltante.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblValorFaltante.Name = "LblValorFaltante";
            this.LblValorFaltante.Size = new System.Drawing.Size(128, 20);
            this.LblValorFaltante.TabIndex = 18;
            this.LblValorFaltante.Text = "Valor Faltante:";
            // 
            // LblQtdePagamento
            // 
            this.LblQtdePagamento.AutoSize = true;
            this.LblQtdePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtdePagamento.Location = new System.Drawing.Point(5, 65);
            this.LblQtdePagamento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblQtdePagamento.Name = "LblQtdePagamento";
            this.LblQtdePagamento.Size = new System.Drawing.Size(99, 20);
            this.LblQtdePagamento.TabIndex = 22;
            this.LblQtdePagamento.Text = "Qtde Pago:";
            // 
            // DgvPagamento
            // 
            this.DgvPagamento.AllowUserToAddRows = false;
            this.DgvPagamento.AllowUserToDeleteRows = false;
            this.DgvPagamento.AllowUserToResizeColumns = false;
            this.DgvPagamento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvPagamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPagamento.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPagamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.CODIGOPEDIDO,
            this.DATAPAGAMENTO,
            this.NOME,
            this.VALOR});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPagamento.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvPagamento.Location = new System.Drawing.Point(12, 215);
            this.DgvPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.DgvPagamento.MultiSelect = false;
            this.DgvPagamento.Name = "DgvPagamento";
            this.DgvPagamento.ReadOnly = true;
            this.DgvPagamento.RowHeadersVisible = false;
            this.DgvPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPagamento.Size = new System.Drawing.Size(486, 226);
            this.DgvPagamento.TabIndex = 5;
            this.DgvPagamento.SelectionChanged += new System.EventHandler(this.DgvPagamento_SelectionChanged);
            // 
            // CODIGO
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CODIGO.DefaultCellStyle = dataGridViewCellStyle3;
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Visible = false;
            this.CODIGO.Width = 80;
            // 
            // CODIGOPEDIDO
            // 
            this.CODIGOPEDIDO.HeaderText = "CodigoPedido";
            this.CODIGOPEDIDO.Name = "CODIGOPEDIDO";
            this.CODIGOPEDIDO.ReadOnly = true;
            this.CODIGOPEDIDO.Visible = false;
            // 
            // DATAPAGAMENTO
            // 
            this.DATAPAGAMENTO.HeaderText = "Data Pagamento";
            this.DATAPAGAMENTO.Name = "DATAPAGAMENTO";
            this.DATAPAGAMENTO.ReadOnly = true;
            this.DATAPAGAMENTO.Width = 200;
            // 
            // NOME
            // 
            this.NOME.HeaderText = "Tipo";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 140;
            // 
            // VALOR
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C";
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle4;
            this.VALOR.HeaderText = "Valor";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 120;
            // 
            // PnlPagamento
            // 
            this.PnlPagamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlPagamento.Controls.Add(this.label3);
            this.PnlPagamento.Controls.Add(this.RbtOutro);
            this.PnlPagamento.Controls.Add(this.RbtCredito);
            this.PnlPagamento.Controls.Add(this.RbtDebito);
            this.PnlPagamento.Controls.Add(this.RbtCheque);
            this.PnlPagamento.Controls.Add(this.RbtDinheiro);
            this.PnlPagamento.Controls.Add(this.BtnReceber);
            this.PnlPagamento.Controls.Add(this.TxtValor);
            this.PnlPagamento.Controls.Add(this.label4);
            this.PnlPagamento.Enabled = false;
            this.PnlPagamento.Location = new System.Drawing.Point(12, 158);
            this.PnlPagamento.Name = "PnlPagamento";
            this.PnlPagamento.Size = new System.Drawing.Size(821, 50);
            this.PnlPagamento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(498, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "|";
            // 
            // RbtOutro
            // 
            this.RbtOutro.AutoSize = true;
            this.RbtOutro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.RbtOutro.Location = new System.Drawing.Point(406, 9);
            this.RbtOutro.Name = "RbtOutro";
            this.RbtOutro.Size = new System.Drawing.Size(84, 28);
            this.RbtOutro.TabIndex = 4;
            this.RbtOutro.Text = "Outros";
            this.RbtOutro.UseVisualStyleBackColor = true;
            // 
            // RbtCredito
            // 
            this.RbtCredito.AutoSize = true;
            this.RbtCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.RbtCredito.Location = new System.Drawing.Point(310, 9);
            this.RbtCredito.Name = "RbtCredito";
            this.RbtCredito.Size = new System.Drawing.Size(88, 28);
            this.RbtCredito.TabIndex = 3;
            this.RbtCredito.Text = "Crédito";
            this.RbtCredito.UseVisualStyleBackColor = true;
            // 
            // RbtDebito
            // 
            this.RbtDebito.AutoSize = true;
            this.RbtDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.RbtDebito.Location = new System.Drawing.Point(220, 9);
            this.RbtDebito.Name = "RbtDebito";
            this.RbtDebito.Size = new System.Drawing.Size(82, 28);
            this.RbtDebito.TabIndex = 2;
            this.RbtDebito.Text = "Débito";
            this.RbtDebito.UseVisualStyleBackColor = true;
            // 
            // RbtCheque
            // 
            this.RbtCheque.AutoSize = true;
            this.RbtCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.RbtCheque.Location = new System.Drawing.Point(116, 9);
            this.RbtCheque.Name = "RbtCheque";
            this.RbtCheque.Size = new System.Drawing.Size(96, 28);
            this.RbtCheque.TabIndex = 1;
            this.RbtCheque.Text = "Cheque";
            this.RbtCheque.UseVisualStyleBackColor = true;
            this.RbtCheque.CheckedChanged += new System.EventHandler(this.RbtCheque_CheckedChanged);
            // 
            // RbtDinheiro
            // 
            this.RbtDinheiro.AutoSize = true;
            this.RbtDinheiro.Checked = true;
            this.RbtDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.RbtDinheiro.Location = new System.Drawing.Point(9, 9);
            this.RbtDinheiro.Name = "RbtDinheiro";
            this.RbtDinheiro.Size = new System.Drawing.Size(99, 28);
            this.RbtDinheiro.TabIndex = 0;
            this.RbtDinheiro.TabStop = true;
            this.RbtDinheiro.Text = "Dinheiro";
            this.RbtDinheiro.UseVisualStyleBackColor = true;
            // 
            // BtnReceber
            // 
            this.BtnReceber.AutoSize = true;
            this.BtnReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnReceber.Location = new System.Drawing.Point(704, 7);
            this.BtnReceber.Name = "BtnReceber";
            this.BtnReceber.Size = new System.Drawing.Size(110, 34);
            this.BtnReceber.TabIndex = 6;
            this.BtnReceber.Text = "Receber";
            this.BtnReceber.UseVisualStyleBackColor = true;
            this.BtnReceber.Click += new System.EventHandler(this.BtnReceber_Click);
            // 
            // TxtValor
            // 
            this.TxtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValor.Location = new System.Drawing.Point(582, 9);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(116, 29);
            this.TxtValor.TabIndex = 5;
            this.TxtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor";
            // 
            // BtnInserir
            // 
            this.BtnInserir.AutoSize = true;
            this.BtnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnInserir.Location = new System.Drawing.Point(12, 118);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(110, 34);
            this.BtnInserir.TabIndex = 0;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.AutoSize = true;
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnAlterar.Location = new System.Drawing.Point(128, 118);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(110, 34);
            this.BtnAlterar.TabIndex = 1;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.AutoSize = true;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnExcluir.Location = new System.Drawing.Point(244, 118);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(110, 34);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEncerrarMesa
            // 
            this.BtnEncerrarMesa.AutoSize = true;
            this.BtnEncerrarMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnEncerrarMesa.Location = new System.Drawing.Point(689, 408);
            this.BtnEncerrarMesa.Name = "BtnEncerrarMesa";
            this.BtnEncerrarMesa.Size = new System.Drawing.Size(144, 34);
            this.BtnEncerrarMesa.TabIndex = 6;
            this.BtnEncerrarMesa.Text = "Encerrar Mesa";
            this.BtnEncerrarMesa.UseVisualStyleBackColor = true;
            this.BtnEncerrarMesa.Click += new System.EventHandler(this.BtnEncerrarMesa_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSize = true;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(718, 118);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 34);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 454);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEncerrarMesa);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnInserir);
            this.Controls.Add(this.PnlPagamento);
            this.Controls.Add(this.DgvPagamento);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Pagamento de Mesa";
            this.Load += new System.EventHandler(this.FrmPagamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPagamento)).EndInit();
            this.PnlPagamento.ResumeLayout(false);
            this.PnlPagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblGarcon;
        private System.Windows.Forms.Label LblMesa;
        private System.Windows.Forms.Label LblTotalConta;
        private System.Windows.Forms.DataGridView DgvPagamento;
        private System.Windows.Forms.Panel PnlPagamento;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblValorPago;
        private System.Windows.Forms.Label LblValorFaltante;
        private System.Windows.Forms.Label LblQtdePagamento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnReceber;
        private System.Windows.Forms.RadioButton RbtOutro;
        private System.Windows.Forms.RadioButton RbtCredito;
        private System.Windows.Forms.RadioButton RbtDebito;
        private System.Windows.Forms.RadioButton RbtCheque;
        private System.Windows.Forms.RadioButton RbtDinheiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnEncerrarMesa;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATAPAGAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.Label label1;
    }
}