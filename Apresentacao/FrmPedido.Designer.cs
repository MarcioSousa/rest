namespace Apresentacao
{
    partial class FrmPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodMesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvPedido = new System.Windows.Forms.DataGridView();
            this.QTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEDIDOPRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDeletarMesa = new System.Windows.Forms.Button();
            this.TxtCodProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNomeProduto = new System.Windows.Forms.TextBox();
            this.BtnAdicionarPedido = new System.Windows.Forms.Button();
            this.TxtQtde = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnRemoverPedido = new System.Windows.Forms.Button();
            this.PdImprimirDocumento = new System.Drawing.Printing.PrintDocument();
            this.lblCodPedProd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGarcon = new System.Windows.Forms.Button();
            this.LblDataHoraPedido = new System.Windows.Forms.Label();
            this.LblCodigoPedido = new System.Windows.Forms.Label();
            this.LblCodigoGarcon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnOcupaMesa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PnlProduto = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnPagamento = new System.Windows.Forms.Button();
            this.TxtTotalPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTotalMesa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnGravarImprimir = new System.Windows.Forms.Button();
            this.BtnImprimeConta = new System.Windows.Forms.Button();
            this.BtnImprimePedido = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedido)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PnlProduto.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(251, 4);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Ocupação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(665, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Garçon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido";
            // 
            // txtCodMesa
            // 
            this.txtCodMesa.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodMesa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodMesa.Enabled = false;
            this.txtCodMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodMesa.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtCodMesa.Location = new System.Drawing.Point(38, 37);
            this.txtCodMesa.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodMesa.Multiline = true;
            this.txtCodMesa.Name = "txtCodMesa";
            this.txtCodMesa.Size = new System.Drawing.Size(69, 55);
            this.txtCodMesa.TabIndex = 0;
            this.txtCodMesa.Text = "10";
            this.txtCodMesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(48, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesa";
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
            this.QTDE,
            this.PEDIDOPRODUTO,
            this.CODIGO,
            this.PRODUTO,
            this.VALOR,
            this.TOTAL});
            this.DgvPedido.Location = new System.Drawing.Point(5, 5);
            this.DgvPedido.Margin = new System.Windows.Forms.Padding(5);
            this.DgvPedido.MultiSelect = false;
            this.DgvPedido.Name = "DgvPedido";
            this.DgvPedido.ReadOnly = true;
            this.DgvPedido.RowHeadersVisible = false;
            this.DgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPedido.Size = new System.Drawing.Size(812, 409);
            this.DgvPedido.TabIndex = 3;
            // 
            // QTDE
            // 
            this.QTDE.DataPropertyName = "Qtde";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QTDE.DefaultCellStyle = dataGridViewCellStyle2;
            this.QTDE.HeaderText = "Qtde";
            this.QTDE.Name = "QTDE";
            this.QTDE.ReadOnly = true;
            this.QTDE.Width = 50;
            // 
            // PEDIDOPRODUTO
            // 
            this.PEDIDOPRODUTO.DataPropertyName = "Codigo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PEDIDOPRODUTO.DefaultCellStyle = dataGridViewCellStyle3;
            this.PEDIDOPRODUTO.HeaderText = "Codigo";
            this.PEDIDOPRODUTO.Name = "PEDIDOPRODUTO";
            this.PEDIDOPRODUTO.ReadOnly = true;
            this.PEDIDOPRODUTO.Visible = false;
            this.PEDIDOPRODUTO.Width = 70;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CodProduto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CODIGO.DefaultCellStyle = dataGridViewCellStyle4;
            this.CODIGO.HeaderText = "CodigoProduto";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Visible = false;
            // 
            // PRODUTO
            // 
            this.PRODUTO.DataPropertyName = "Nome";
            this.PRODUTO.HeaderText = "Nome";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            this.PRODUTO.Width = 560;
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C";
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle5;
            this.VALOR.HeaderText = "Valor Un.";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 90;
            // 
            // TOTAL
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C";
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle6;
            this.TOTAL.HeaderText = "Total";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Width = 90;
            // 
            // BtnDeletarMesa
            // 
            this.BtnDeletarMesa.AutoSize = true;
            this.BtnDeletarMesa.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDeletarMesa.Enabled = false;
            this.BtnDeletarMesa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnDeletarMesa.Location = new System.Drawing.Point(698, 6);
            this.BtnDeletarMesa.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDeletarMesa.Name = "BtnDeletarMesa";
            this.BtnDeletarMesa.Size = new System.Drawing.Size(119, 26);
            this.BtnDeletarMesa.TabIndex = 1;
            this.BtnDeletarMesa.Text = "Deletar Mesa";
            this.BtnDeletarMesa.UseVisualStyleBackColor = true;
            this.BtnDeletarMesa.Click += new System.EventHandler(this.BtnDeletarMesa_Click);
            // 
            // TxtCodProduto
            // 
            this.TxtCodProduto.Enabled = false;
            this.TxtCodProduto.Location = new System.Drawing.Point(12, 30);
            this.TxtCodProduto.Margin = new System.Windows.Forms.Padding(5);
            this.TxtCodProduto.MaxLength = 5;
            this.TxtCodProduto.Name = "TxtCodProduto";
            this.TxtCodProduto.Size = new System.Drawing.Size(62, 22);
            this.TxtCodProduto.TabIndex = 0;
            this.TxtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodProduto.TextChanged += new System.EventHandler(this.TxtCodProduto_TextChanged);
            this.TxtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodProduto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Produto";
            // 
            // TxtNomeProduto
            // 
            this.TxtNomeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtNomeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtNomeProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNomeProduto.Enabled = false;
            this.TxtNomeProduto.Location = new System.Drawing.Point(84, 30);
            this.TxtNomeProduto.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNomeProduto.MaxLength = 30;
            this.TxtNomeProduto.Name = "TxtNomeProduto";
            this.TxtNomeProduto.Size = new System.Drawing.Size(554, 22);
            this.TxtNomeProduto.TabIndex = 1;
            this.TxtNomeProduto.TextChanged += new System.EventHandler(this.TxtNomeProduto_TextChanged);
            // 
            // BtnAdicionarPedido
            // 
            this.BtnAdicionarPedido.AutoSize = true;
            this.BtnAdicionarPedido.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAdicionarPedido.Enabled = false;
            this.BtnAdicionarPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAdicionarPedido.Location = new System.Drawing.Point(692, 28);
            this.BtnAdicionarPedido.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAdicionarPedido.Name = "BtnAdicionarPedido";
            this.BtnAdicionarPedido.Size = new System.Drawing.Size(125, 26);
            this.BtnAdicionarPedido.TabIndex = 3;
            this.BtnAdicionarPedido.Text = "Adicionar Pedido";
            this.BtnAdicionarPedido.UseVisualStyleBackColor = true;
            this.BtnAdicionarPedido.Click += new System.EventHandler(this.BtnAdicionarPedido_Click);
            // 
            // TxtQtde
            // 
            this.TxtQtde.Enabled = false;
            this.TxtQtde.Location = new System.Drawing.Point(648, 30);
            this.TxtQtde.Margin = new System.Windows.Forms.Padding(5);
            this.TxtQtde.MaxLength = 2;
            this.TxtQtde.Name = "TxtQtde";
            this.TxtQtde.Size = new System.Drawing.Size(34, 22);
            this.TxtQtde.TabIndex = 2;
            this.TxtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQtde_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(645, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Qtde";
            // 
            // BtnRemoverPedido
            // 
            this.BtnRemoverPedido.AutoSize = true;
            this.BtnRemoverPedido.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRemoverPedido.Enabled = false;
            this.BtnRemoverPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnRemoverPedido.Location = new System.Drawing.Point(568, 6);
            this.BtnRemoverPedido.Margin = new System.Windows.Forms.Padding(5);
            this.BtnRemoverPedido.Name = "BtnRemoverPedido";
            this.BtnRemoverPedido.Size = new System.Drawing.Size(124, 26);
            this.BtnRemoverPedido.TabIndex = 2;
            this.BtnRemoverPedido.Text = "Remover Item";
            this.BtnRemoverPedido.UseVisualStyleBackColor = true;
            this.BtnRemoverPedido.Click += new System.EventHandler(this.BtnRemoverPedido_Click);
            // 
            // PdImprimirDocumento
            // 
            this.PdImprimirDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PdImprimirDocumento_PrintPage);
            // 
            // lblCodPedProd
            // 
            this.lblCodPedProd.AutoSize = true;
            this.lblCodPedProd.Location = new System.Drawing.Point(561, 474);
            this.lblCodPedProd.Name = "lblCodPedProd";
            this.lblCodPedProd.Size = new System.Drawing.Size(0, 16);
            this.lblCodPedProd.TabIndex = 23;
            this.lblCodPedProd.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnGarcon);
            this.panel1.Controls.Add(this.LblDataHoraPedido);
            this.panel1.Controls.Add(this.LblCodigoPedido);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.LblCodigoGarcon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 64);
            this.panel1.TabIndex = 1;
            // 
            // BtnGarcon
            // 
            this.BtnGarcon.AutoSize = true;
            this.BtnGarcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGarcon.Location = new System.Drawing.Point(769, 16);
            this.BtnGarcon.Name = "BtnGarcon";
            this.BtnGarcon.Size = new System.Drawing.Size(35, 35);
            this.BtnGarcon.TabIndex = 0;
            this.BtnGarcon.Text = "+";
            this.BtnGarcon.UseVisualStyleBackColor = true;
            this.BtnGarcon.Click += new System.EventHandler(this.BtnGarcon_Click);
            // 
            // LblDataHoraPedido
            // 
            this.LblDataHoraPedido.AutoSize = true;
            this.LblDataHoraPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.LblDataHoraPedido.Location = new System.Drawing.Point(251, 20);
            this.LblDataHoraPedido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDataHoraPedido.Name = "LblDataHoraPedido";
            this.LblDataHoraPedido.Size = new System.Drawing.Size(76, 31);
            this.LblDataHoraPedido.TabIndex = 1;
            this.LblDataHoraPedido.Text = "Data";
            // 
            // LblCodigoPedido
            // 
            this.LblCodigoPedido.AutoSize = true;
            this.LblCodigoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.LblCodigoPedido.Location = new System.Drawing.Point(5, 20);
            this.LblCodigoPedido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCodigoPedido.Name = "LblCodigoPedido";
            this.LblCodigoPedido.Size = new System.Drawing.Size(30, 31);
            this.LblCodigoPedido.TabIndex = 0;
            this.LblCodigoPedido.Text = "0";
            // 
            // LblCodigoGarcon
            // 
            this.LblCodigoGarcon.AutoSize = true;
            this.LblCodigoGarcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.LblCodigoGarcon.Location = new System.Drawing.Point(662, 20);
            this.LblCodigoGarcon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCodigoGarcon.Name = "LblCodigoGarcon";
            this.LblCodigoGarcon.Size = new System.Drawing.Size(30, 31);
            this.LblCodigoGarcon.TabIndex = 2;
            this.LblCodigoGarcon.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCodMesa);
            this.panel2.Location = new System.Drawing.Point(844, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 111);
            this.panel2.TabIndex = 4;
            // 
            // BtnOcupaMesa
            // 
            this.BtnOcupaMesa.AutoSize = true;
            this.BtnOcupaMesa.BackColor = System.Drawing.SystemColors.Control;
            this.BtnOcupaMesa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnOcupaMesa.Location = new System.Drawing.Point(5, 6);
            this.BtnOcupaMesa.Margin = new System.Windows.Forms.Padding(5);
            this.BtnOcupaMesa.Name = "BtnOcupaMesa";
            this.BtnOcupaMesa.Size = new System.Drawing.Size(119, 26);
            this.BtnOcupaMesa.TabIndex = 0;
            this.BtnOcupaMesa.Text = "Ocupar Mesa";
            this.BtnOcupaMesa.UseVisualStyleBackColor = true;
            this.BtnOcupaMesa.Click += new System.EventHandler(this.BtnOcupaMesa_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.BtnOcupaMesa);
            this.panel3.Controls.Add(this.BtnRemoverPedido);
            this.panel3.Controls.Add(this.BtnDeletarMesa);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(826, 41);
            this.panel3.TabIndex = 0;
            // 
            // PnlProduto
            // 
            this.PnlProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlProduto.Controls.Add(this.BtnAdicionarPedido);
            this.PnlProduto.Controls.Add(this.label3);
            this.PnlProduto.Controls.Add(this.TxtQtde);
            this.PnlProduto.Controls.Add(this.label4);
            this.PnlProduto.Controls.Add(this.label7);
            this.PnlProduto.Controls.Add(this.TxtCodProduto);
            this.PnlProduto.Controls.Add(this.TxtNomeProduto);
            this.PnlProduto.Location = new System.Drawing.Point(12, 129);
            this.PnlProduto.Name = "PnlProduto";
            this.PnlProduto.Size = new System.Drawing.Size(826, 63);
            this.PnlProduto.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.BtnFechar);
            this.panel5.Controls.Add(this.BtnPagamento);
            this.panel5.Controls.Add(this.TxtTotalPago);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.TxtTotalMesa);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.BtnGravarImprimir);
            this.panel5.Controls.Add(this.BtnImprimeConta);
            this.panel5.Controls.Add(this.BtnImprimePedido);
            this.panel5.Location = new System.Drawing.Point(844, 129);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(148, 491);
            this.panel5.TabIndex = 4;
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnFechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnFechar.Location = new System.Drawing.Point(10, 261);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(124, 26);
            this.BtnFechar.TabIndex = 31;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnPagamento
            // 
            this.BtnPagamento.AutoSize = true;
            this.BtnPagamento.Enabled = false;
            this.BtnPagamento.Location = new System.Drawing.Point(10, 186);
            this.BtnPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.BtnPagamento.Name = "BtnPagamento";
            this.BtnPagamento.Size = new System.Drawing.Size(124, 26);
            this.BtnPagamento.TabIndex = 13;
            this.BtnPagamento.Text = "Pagamentos";
            this.BtnPagamento.UseVisualStyleBackColor = true;
            this.BtnPagamento.Click += new System.EventHandler(this.BtnPagamento_Click);
            // 
            // TxtTotalPago
            // 
            this.TxtTotalPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTotalPago.Enabled = false;
            this.TxtTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalPago.Location = new System.Drawing.Point(-2, 133);
            this.TxtTotalPago.Margin = new System.Windows.Forms.Padding(5);
            this.TxtTotalPago.MaxLength = 2;
            this.TxtTotalPago.Name = "TxtTotalPago";
            this.TxtTotalPago.ReadOnly = true;
            this.TxtTotalPago.Size = new System.Drawing.Size(148, 22);
            this.TxtTotalPago.TabIndex = 12;
            this.TxtTotalPago.Text = "R$";
            this.TxtTotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(20, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "TOTAL PAGO";
            // 
            // TxtTotalMesa
            // 
            this.TxtTotalMesa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTotalMesa.Enabled = false;
            this.TxtTotalMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalMesa.Location = new System.Drawing.Point(-2, 56);
            this.TxtTotalMesa.Margin = new System.Windows.Forms.Padding(5);
            this.TxtTotalMesa.MaxLength = 2;
            this.TxtTotalMesa.Name = "TxtTotalMesa";
            this.TxtTotalMesa.ReadOnly = true;
            this.TxtTotalMesa.Size = new System.Drawing.Size(148, 22);
            this.TxtTotalMesa.TabIndex = 10;
            this.TxtTotalMesa.Text = "R$";
            this.TxtTotalMesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(20, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "TOTAL MESA";
            // 
            // BtnGravarImprimir
            // 
            this.BtnGravarImprimir.Enabled = false;
            this.BtnGravarImprimir.Location = new System.Drawing.Point(10, 361);
            this.BtnGravarImprimir.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGravarImprimir.Name = "BtnGravarImprimir";
            this.BtnGravarImprimir.Size = new System.Drawing.Size(124, 26);
            this.BtnGravarImprimir.TabIndex = 2;
            this.BtnGravarImprimir.Text = "Gravar / Imprimir";
            this.BtnGravarImprimir.UseVisualStyleBackColor = true;
            this.BtnGravarImprimir.Click += new System.EventHandler(this.BtnGravarImprimir_Click);
            // 
            // BtnImprimeConta
            // 
            this.BtnImprimeConta.AutoSize = true;
            this.BtnImprimeConta.Enabled = false;
            this.BtnImprimeConta.Location = new System.Drawing.Point(10, 397);
            this.BtnImprimeConta.Margin = new System.Windows.Forms.Padding(5);
            this.BtnImprimeConta.Name = "BtnImprimeConta";
            this.BtnImprimeConta.Size = new System.Drawing.Size(124, 26);
            this.BtnImprimeConta.TabIndex = 1;
            this.BtnImprimeConta.Text = "Imprime Conta";
            this.BtnImprimeConta.UseVisualStyleBackColor = true;
            this.BtnImprimeConta.Click += new System.EventHandler(this.BtnImprimeConta_Click);
            // 
            // BtnImprimePedido
            // 
            this.BtnImprimePedido.Enabled = false;
            this.BtnImprimePedido.Location = new System.Drawing.Point(10, 433);
            this.BtnImprimePedido.Margin = new System.Windows.Forms.Padding(5);
            this.BtnImprimePedido.Name = "BtnImprimePedido";
            this.BtnImprimePedido.Size = new System.Drawing.Size(124, 26);
            this.BtnImprimePedido.TabIndex = 0;
            this.BtnImprimePedido.Text = "Imprime Pedido";
            this.BtnImprimePedido.UseVisualStyleBackColor = true;
            this.BtnImprimePedido.Click += new System.EventHandler(this.BtnImprimePedido_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.DgvPedido);
            this.panel6.Location = new System.Drawing.Point(12, 198);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(826, 422);
            this.panel6.TabIndex = 30;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 628);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.PnlProduto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCodPedProd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Pedidos da Mesa";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PnlProduto.ResumeLayout(false);
            this.PnlProduto.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodMesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvPedido;
        private System.Windows.Forms.Button BtnDeletarMesa;
        private System.Windows.Forms.TextBox TxtCodProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNomeProduto;
        private System.Windows.Forms.TextBox TxtQtde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Drawing.Printing.PrintDocument PdImprimirDocumento;
        private System.Windows.Forms.Label lblCodPedProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAdicionarPedido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnOcupaMesa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblDataHoraPedido;
        private System.Windows.Forms.Label LblCodigoGarcon;
        private System.Windows.Forms.Label LblCodigoPedido;
        private System.Windows.Forms.Button BtnGarcon;
        private System.Windows.Forms.Button BtnRemoverPedido;
        private System.Windows.Forms.Panel PnlProduto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnImprimeConta;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnGravarImprimir;
        private System.Windows.Forms.Button BtnImprimePedido;
        private System.Windows.Forms.TextBox TxtTotalMesa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTotalPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnPagamento;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDIDOPRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}