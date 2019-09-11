namespace Apresentacao
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.MsSistema = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GarconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sAIRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnMesas = new System.Windows.Forms.Button();
            this.BtnCaixa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAvancado = new System.Windows.Forms.Button();
            this.BtnEstoque = new System.Windows.Forms.Button();
            this.BtnGarcon = new System.Windows.Forms.Button();
            this.BtnProduto = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.BtnDeletaUsuario = new System.Windows.Forms.Button();
            this.MsSistema.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.SuspendLayout();
            // 
            // MsSistema
            // 
            this.MsSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem,
            this.UsuarioToolStripMenuItem,
            this.SairToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.MsSistema.Location = new System.Drawing.Point(0, 0);
            this.MsSistema.Name = "MsSistema";
            this.MsSistema.Size = new System.Drawing.Size(685, 24);
            this.MsSistema.TabIndex = 0;
            this.MsSistema.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GarconToolStripMenuItem,
            this.ProdutoToolStripMenuItem,
            this.caixaToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.sAIRToolStripMenuItem1});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.menu1ToolStripMenuItem.Text = "&Principal";
            // 
            // GarconToolStripMenuItem
            // 
            this.GarconToolStripMenuItem.Name = "GarconToolStripMenuItem";
            this.GarconToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.GarconToolStripMenuItem.Text = "&Garçon";
            this.GarconToolStripMenuItem.Click += new System.EventHandler(this.GarconToolStripMenuItem_Click);
            // 
            // ProdutoToolStripMenuItem
            // 
            this.ProdutoToolStripMenuItem.Name = "ProdutoToolStripMenuItem";
            this.ProdutoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.ProdutoToolStripMenuItem.Text = "&Produto";
            this.ProdutoToolStripMenuItem.Click += new System.EventHandler(this.ProdutoToolStripMenuItem_Click);
            // 
            // caixaToolStripMenuItem1
            // 
            this.caixaToolStripMenuItem1.Name = "caixaToolStripMenuItem1";
            this.caixaToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.caixaToolStripMenuItem1.Text = "&Caixa";
            this.caixaToolStripMenuItem1.Click += new System.EventHandler(this.CaixaToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(114, 6);
            // 
            // sAIRToolStripMenuItem1
            // 
            this.sAIRToolStripMenuItem1.Name = "sAIRToolStripMenuItem1";
            this.sAIRToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.sAIRToolStripMenuItem1.Text = "&Sair";
            // 
            // UsuarioToolStripMenuItem
            // 
            this.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem";
            this.UsuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.UsuarioToolStripMenuItem.Text = "&Usuário";
            this.UsuarioToolStripMenuItem.Click += new System.EventHandler(this.UsuarioToolStripMenuItem_Click);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.SairToolStripMenuItem.Text = "&Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.desenvolvedorToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "S&obre";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sistemaToolStripMenuItem.Text = "&Sistema";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.SistemaToolStripMenuItem_Click);
            // 
            // desenvolvedorToolStripMenuItem
            // 
            this.desenvolvedorToolStripMenuItem.Name = "desenvolvedorToolStripMenuItem";
            this.desenvolvedorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.desenvolvedorToolStripMenuItem.Text = "&Desenvolvedor";
            this.desenvolvedorToolStripMenuItem.Click += new System.EventHandler(this.DesenvolvedorToolStripMenuItem_Click);
            // 
            // BtnMesas
            // 
            this.BtnMesas.AutoSize = true;
            this.BtnMesas.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMesas.Location = new System.Drawing.Point(6, 171);
            this.BtnMesas.Name = "BtnMesas";
            this.BtnMesas.Size = new System.Drawing.Size(141, 32);
            this.BtnMesas.TabIndex = 4;
            this.BtnMesas.Text = "Mesas";
            this.BtnMesas.UseVisualStyleBackColor = true;
            this.BtnMesas.Click += new System.EventHandler(this.BtnMesas_Click);
            // 
            // BtnCaixa
            // 
            this.BtnCaixa.AutoSize = true;
            this.BtnCaixa.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCaixa.Location = new System.Drawing.Point(6, 57);
            this.BtnCaixa.Name = "BtnCaixa";
            this.BtnCaixa.Size = new System.Drawing.Size(141, 32);
            this.BtnCaixa.TabIndex = 1;
            this.BtnCaixa.Text = "Caixa";
            this.BtnCaixa.UseVisualStyleBackColor = true;
            this.BtnCaixa.Click += new System.EventHandler(this.BtnCaixa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAvancado);
            this.groupBox1.Controls.Add(this.BtnEstoque);
            this.groupBox1.Controls.Add(this.BtnGarcon);
            this.groupBox1.Controls.Add(this.BtnMesas);
            this.groupBox1.Controls.Add(this.BtnProduto);
            this.groupBox1.Controls.Add(this.BtnCaixa);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // BtnAvancado
            // 
            this.BtnAvancado.AutoSize = true;
            this.BtnAvancado.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAvancado.Location = new System.Drawing.Point(6, 209);
            this.BtnAvancado.Name = "BtnAvancado";
            this.BtnAvancado.Size = new System.Drawing.Size(141, 32);
            this.BtnAvancado.TabIndex = 5;
            this.BtnAvancado.Text = "Avançado";
            this.BtnAvancado.UseVisualStyleBackColor = true;
            this.BtnAvancado.Click += new System.EventHandler(this.BtnAvancado_Click);
            // 
            // BtnEstoque
            // 
            this.BtnEstoque.AutoSize = true;
            this.BtnEstoque.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstoque.Location = new System.Drawing.Point(6, 133);
            this.BtnEstoque.Name = "BtnEstoque";
            this.BtnEstoque.Size = new System.Drawing.Size(141, 32);
            this.BtnEstoque.TabIndex = 3;
            this.BtnEstoque.Text = "Estoque";
            this.BtnEstoque.UseVisualStyleBackColor = true;
            this.BtnEstoque.Click += new System.EventHandler(this.BtnEstoque_Click);
            // 
            // BtnGarcon
            // 
            this.BtnGarcon.AutoSize = true;
            this.BtnGarcon.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGarcon.Location = new System.Drawing.Point(6, 95);
            this.BtnGarcon.Name = "BtnGarcon";
            this.BtnGarcon.Size = new System.Drawing.Size(141, 32);
            this.BtnGarcon.TabIndex = 2;
            this.BtnGarcon.Text = "Garçon";
            this.BtnGarcon.UseVisualStyleBackColor = true;
            this.BtnGarcon.Click += new System.EventHandler(this.BtnGarcon_Click);
            // 
            // BtnProduto
            // 
            this.BtnProduto.AutoSize = true;
            this.BtnProduto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProduto.Location = new System.Drawing.Point(6, 19);
            this.BtnProduto.Name = "BtnProduto";
            this.BtnProduto.Size = new System.Drawing.Size(141, 32);
            this.BtnProduto.TabIndex = 0;
            this.BtnProduto.Text = "Produto";
            this.BtnProduto.UseVisualStyleBackColor = true;
            this.BtnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(685, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "Aero (Black).vssf");
            // 
            // BtnDeletaUsuario
            // 
            this.BtnDeletaUsuario.AutoSize = true;
            this.BtnDeletaUsuario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletaUsuario.Location = new System.Drawing.Point(18, 291);
            this.BtnDeletaUsuario.Name = "BtnDeletaUsuario";
            this.BtnDeletaUsuario.Size = new System.Drawing.Size(170, 32);
            this.BtnDeletaUsuario.TabIndex = 9;
            this.BtnDeletaUsuario.Text = "Deletar Usuário";
            this.BtnDeletaUsuario.UseVisualStyleBackColor = true;
            this.BtnDeletaUsuario.Visible = false;
            this.BtnDeletaUsuario.Click += new System.EventHandler(this.BtnDeletaUsuario_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 441);
            this.Controls.Add(this.BtnDeletaUsuario);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MsSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Restaurante - Menu Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.MsSistema.ResumeLayout(false);
            this.MsSistema.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MsSistema;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.Button BtnMesas;
        private System.Windows.Forms.Button BtnCaixa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnProduto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnEstoque;
        private System.Windows.Forms.Button BtnGarcon;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.ToolStripMenuItem GarconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem UsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedorToolStripMenuItem;
        private System.Windows.Forms.Button BtnAvancado;
        private System.Windows.Forms.Button BtnDeletaUsuario;
    }
}