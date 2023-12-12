namespace Taskool
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
            this.Title = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.UsuarioLogin = new System.Windows.Forms.TextBox();
            this.CredencialText = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.CadastreText = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CapslockLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AllowDrop = true;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Title.Location = new System.Drawing.Point(258, 52);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(288, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "Bem Vindo Ao Taskool";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(372, 125);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(54, 16);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "Usuário";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(542, 158);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 16);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Teclado Virtual";
            // 
            // UsuarioLogin
            // 
            this.UsuarioLogin.Location = new System.Drawing.Point(319, 155);
            this.UsuarioLogin.Name = "UsuarioLogin";
            this.UsuarioLogin.Size = new System.Drawing.Size(162, 22);
            this.UsuarioLogin.TabIndex = 3;
            // 
            // CredencialText
            // 
            this.CredencialText.AutoSize = true;
            this.CredencialText.Location = new System.Drawing.Point(366, 199);
            this.CredencialText.Name = "CredencialText";
            this.CredencialText.Size = new System.Drawing.Size(72, 16);
            this.CredencialText.TabIndex = 4;
            this.CredencialText.Text = "Credencial";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(345, 339);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(111, 41);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Entrar";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // CadastreText
            // 
            this.CadastreText.AutoSize = true;
            this.CadastreText.Location = new System.Drawing.Point(357, 394);
            this.CadastreText.Name = "CadastreText";
            this.CadastreText.Size = new System.Drawing.Size(81, 16);
            this.CadastreText.TabIndex = 6;
            this.CadastreText.TabStop = true;
            this.CadastreText.Text = "Cadastre-se";
            this.CadastreText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CadastreText_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(345, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // CapslockLabel
            // 
            this.CapslockLabel.AutoSize = true;
            this.CapslockLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.CapslockLabel.Location = new System.Drawing.Point(316, 180);
            this.CapslockLabel.Name = "CapslockLabel";
            this.CapslockLabel.Size = new System.Drawing.Size(123, 16);
            this.CapslockLabel.TabIndex = 8;
            this.CapslockLabel.Text = "Caps Lock Ativado!";
            this.CapslockLabel.Visible = false;
            this.CapslockLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CapslockLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CadastreText);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.CredencialText);
            this.Controls.Add(this.UsuarioLogin);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox UsuarioLogin;
        private System.Windows.Forms.Label CredencialText;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel CadastreText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CapslockLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

