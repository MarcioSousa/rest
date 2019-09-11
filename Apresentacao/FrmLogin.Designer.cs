namespace Apresentacao
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.LblConexao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblEmpresa = new System.Windows.Forms.Label();
            this.LblVersao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblConexao
            // 
            this.LblConexao.Location = new System.Drawing.Point(23, 331);
            this.LblConexao.Name = "LblConexao";
            this.LblConexao.Size = new System.Drawing.Size(391, 17);
            this.LblConexao.TabIndex = 31;
            this.LblConexao.Text = "conexão";
            this.LblConexao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Usuário:";
            // 
            // LblEmpresa
            // 
            this.LblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpresa.Location = new System.Drawing.Point(10, 106);
            this.LblEmpresa.Name = "LblEmpresa";
            this.LblEmpresa.Size = new System.Drawing.Size(424, 37);
            this.LblEmpresa.TabIndex = 28;
            this.LblEmpresa.Text = "CadFácil Sistemas";
            this.LblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblEmpresa.DoubleClick += new System.EventHandler(this.LblEmpresa_DoubleClick);
            // 
            // LblVersao
            // 
            this.LblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersao.Location = new System.Drawing.Point(263, 13);
            this.LblVersao.Name = "LblVersao";
            this.LblVersao.Size = new System.Drawing.Size(168, 17);
            this.LblVersao.TabIndex = 27;
            this.LblVersao.Text = "versão";
            this.LblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(182, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // LblNome
            // 
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(10, 149);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(424, 37);
            this.LblNome.TabIndex = 37;
            this.LblNome.Text = "Marcio de Sousa";
            this.LblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(63, 291);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(94, 27);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "&Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(290, 291);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(94, 27);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "&Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.TxtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtUsuario.Location = new System.Drawing.Point(189, 209);
            this.TxtUsuario.MaxLength = 15;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(126, 20);
            this.TxtUsuario.TabIndex = 0;
            // 
            // TxtSenha
            // 
            this.TxtSenha.BackColor = System.Drawing.SystemColors.Control;
            this.TxtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSenha.Location = new System.Drawing.Point(189, 242);
            this.TxtSenha.MaxLength = 15;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(126, 20);
            this.TxtSenha.TabIndex = 1;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(445, 369);
            this.ControlBox = false;
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblConexao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblEmpresa);
            this.Controls.Add(this.LblVersao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login do Sistema";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblConexao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblEmpresa;
        private System.Windows.Forms.Label LblVersao;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
    }
}