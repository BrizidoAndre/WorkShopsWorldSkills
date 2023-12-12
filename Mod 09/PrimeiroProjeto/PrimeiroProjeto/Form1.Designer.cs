namespace PrimeiroProjeto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(479, 22);
            this.textBox1.TabIndex = 0;
            // 
            // TxtEmail
            // 
            this.TxtEmail.AutoSize = true;
            this.TxtEmail.Location = new System.Drawing.Point(144, 180);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(41, 16);
            this.TxtEmail.TabIndex = 1;
            this.TxtEmail.Text = "Email";
            // 
            // TxtSenha
            // 
            this.TxtSenha.AutoSize = true;
            this.TxtSenha.Location = new System.Drawing.Point(144, 240);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(46, 16);
            this.TxtSenha.TabIndex = 3;
            this.TxtSenha.Text = "Senha";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 259);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(479, 22);
            this.textBox2.TabIndex = 2;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnEntrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEntrar.Location = new System.Drawing.Point(315, 340);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(140, 61);
            this.BtnEntrar.TabIndex = 4;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TxtEmail;
        private System.Windows.Forms.Label TxtSenha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnEntrar;
    }
}

