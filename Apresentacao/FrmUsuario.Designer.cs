namespace Apresentacao
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.PnlNovoUsuario = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.TxtConfirmaNovaSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNovaSenha = new System.Windows.Forms.TextBox();
            this.TxtNovoUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.PnlNovoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlNovoUsuario
            // 
            this.PnlNovoUsuario.Controls.Add(this.BtnCancelar);
            this.PnlNovoUsuario.Controls.Add(this.BtnConfirmar);
            this.PnlNovoUsuario.Controls.Add(this.TxtConfirmaNovaSenha);
            this.PnlNovoUsuario.Controls.Add(this.label5);
            this.PnlNovoUsuario.Controls.Add(this.TxtNovaSenha);
            this.PnlNovoUsuario.Controls.Add(this.TxtNovoUsuario);
            this.PnlNovoUsuario.Controls.Add(this.label3);
            this.PnlNovoUsuario.Controls.Add(this.label4);
            this.PnlNovoUsuario.Enabled = false;
            this.PnlNovoUsuario.Location = new System.Drawing.Point(12, 97);
            this.PnlNovoUsuario.Name = "PnlNovoUsuario";
            this.PnlNovoUsuario.Size = new System.Drawing.Size(282, 132);
            this.PnlNovoUsuario.TabIndex = 4;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(28, 93);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(192, 93);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirmar.TabIndex = 3;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // TxtConfirmaNovaSenha
            // 
            this.TxtConfirmaNovaSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtConfirmaNovaSenha.Location = new System.Drawing.Point(119, 67);
            this.TxtConfirmaNovaSenha.MaxLength = 30;
            this.TxtConfirmaNovaSenha.Name = "TxtConfirmaNovaSenha";
            this.TxtConfirmaNovaSenha.PasswordChar = '*';
            this.TxtConfirmaNovaSenha.Size = new System.Drawing.Size(148, 20);
            this.TxtConfirmaNovaSenha.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirmar Senha:";
            // 
            // TxtNovaSenha
            // 
            this.TxtNovaSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNovaSenha.Location = new System.Drawing.Point(119, 41);
            this.TxtNovaSenha.MaxLength = 30;
            this.TxtNovaSenha.Name = "TxtNovaSenha";
            this.TxtNovaSenha.PasswordChar = '*';
            this.TxtNovaSenha.Size = new System.Drawing.Size(148, 20);
            this.TxtNovaSenha.TabIndex = 1;
            // 
            // TxtNovoUsuario
            // 
            this.TxtNovoUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNovoUsuario.Location = new System.Drawing.Point(119, 15);
            this.TxtNovoUsuario.MaxLength = 30;
            this.TxtNovoUsuario.Name = "TxtNovoUsuario";
            this.TxtNovoUsuario.Size = new System.Drawing.Size(148, 20);
            this.TxtNovoUsuario.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nova Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Novo Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtUsuario.Location = new System.Drawing.Point(131, 45);
            this.TxtUsuario.MaxLength = 30;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(148, 20);
            this.TxtUsuario.TabIndex = 2;
            // 
            // TxtSenha
            // 
            this.TxtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSenha.Location = new System.Drawing.Point(131, 71);
            this.TxtSenha.MaxLength = 30;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(148, 20);
            this.TxtSenha.TabIndex = 3;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(40, 12);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 0;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(204, 12);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 1;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 238);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.PnlNovoUsuario);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Usuário";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.PnlNovoUsuario.ResumeLayout(false);
            this.PnlNovoUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlNovoUsuario;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.TextBox TxtConfirmaNovaSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNovaSenha;
        private System.Windows.Forms.TextBox TxtNovoUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnFechar;
    }
}