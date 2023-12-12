namespace Taskool
{
    partial class CadastroPage
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
            this.EmailText = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.SenhaText = new System.Windows.Forms.Label();
            this.SenhaInput = new System.Windows.Forms.TextBox();
            this.ApelidoText = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.TimeText = new System.Windows.Forms.Label();
            this.TelefoneInput = new System.Windows.Forms.TextBox();
            this.Cor = new System.Windows.Forms.Label();
            this.NomeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailText
            // 
            this.EmailText.AutoSize = true;
            this.EmailText.Location = new System.Drawing.Point(98, 81);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(41, 16);
            this.EmailText.TabIndex = 0;
            this.EmailText.Text = "Email";
            this.EmailText.Click += new System.EventHandler(this.EmailText_Click);
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(101, 100);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(526, 22);
            this.EmailInput.TabIndex = 1;
            this.EmailInput.TextChanged += new System.EventHandler(this.EmailInput_TextChanged);
            // 
            // SenhaText
            // 
            this.SenhaText.AutoSize = true;
            this.SenhaText.Location = new System.Drawing.Point(98, 138);
            this.SenhaText.Name = "SenhaText";
            this.SenhaText.Size = new System.Drawing.Size(46, 16);
            this.SenhaText.TabIndex = 0;
            this.SenhaText.Text = "Senha";
            this.SenhaText.Click += new System.EventHandler(this.SenhaText_Click);
            // 
            // SenhaInput
            // 
            this.SenhaInput.Location = new System.Drawing.Point(101, 157);
            this.SenhaInput.Name = "SenhaInput";
            this.SenhaInput.Size = new System.Drawing.Size(526, 22);
            this.SenhaInput.TabIndex = 1;
            this.SenhaInput.TextChanged += new System.EventHandler(this.SenhaInput_TextChanged);
            // 
            // ApelidoText
            // 
            this.ApelidoText.AutoSize = true;
            this.ApelidoText.Location = new System.Drawing.Point(98, 203);
            this.ApelidoText.Name = "ApelidoText";
            this.ApelidoText.Size = new System.Drawing.Size(70, 16);
            this.ApelidoText.TabIndex = 0;
            this.ApelidoText.Text = "Username";
            this.ApelidoText.Click += new System.EventHandler(this.ApelidoText_Click);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(101, 222);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(526, 22);
            this.UsernameInput.TabIndex = 1;
            this.UsernameInput.TextChanged += new System.EventHandler(this.ApelidoInput_TextChanged);
            // 
            // TimeText
            // 
            this.TimeText.AutoSize = true;
            this.TimeText.Location = new System.Drawing.Point(98, 260);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(61, 16);
            this.TimeText.TabIndex = 0;
            this.TimeText.Text = "Telefone";
            this.TimeText.Click += new System.EventHandler(this.TimeText_Click);
            // 
            // TelefoneInput
            // 
            this.TelefoneInput.Location = new System.Drawing.Point(101, 279);
            this.TelefoneInput.Name = "TelefoneInput";
            this.TelefoneInput.Size = new System.Drawing.Size(526, 22);
            this.TelefoneInput.TabIndex = 1;
            this.TelefoneInput.TextChanged += new System.EventHandler(this.TimeInput_TextChanged);
            // 
            // Cor
            // 
            this.Cor.AutoSize = true;
            this.Cor.Location = new System.Drawing.Point(98, 20);
            this.Cor.Name = "Cor";
            this.Cor.Size = new System.Drawing.Size(44, 16);
            this.Cor.TabIndex = 0;
            this.Cor.Text = "Nome";
            this.Cor.Click += new System.EventHandler(this.Cor_Click);
            // 
            // NomeInput
            // 
            this.NomeInput.Location = new System.Drawing.Point(101, 39);
            this.NomeInput.Name = "NomeInput";
            this.NomeInput.Size = new System.Drawing.Size(526, 22);
            this.NomeInput.TabIndex = 1;
            this.NomeInput.TextChanged += new System.EventHandler(this.CorInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nascimento";
            this.label1.Click += new System.EventHandler(this.Cor_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 347);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(494, 332);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 53);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Insira a Imagem aqui";
            this.label2.Click += new System.EventHandler(this.Cor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sugerir Username";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastroPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.NomeInput);
            this.Controls.Add(this.TelefoneInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cor);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.ApelidoText);
            this.Controls.Add(this.SenhaInput);
            this.Controls.Add(this.SenhaText);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.EmailText);
            this.Name = "CadastroPage";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CadastroPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailText;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label SenhaText;
        private System.Windows.Forms.TextBox SenhaInput;
        private System.Windows.Forms.Label ApelidoText;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.TextBox TelefoneInput;
        private System.Windows.Forms.Label Cor;
        private System.Windows.Forms.TextBox NomeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}