namespace WinFormsAula2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeB = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.SenhaB = new System.Windows.Forms.TextBox();
            this.EmailB = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Estado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btEnviar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EnderecoB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(62, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meu Primeiro Formullário";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NomeB
            // 
            this.NomeB.Location = new System.Drawing.Point(183, 125);
            this.NomeB.Name = "NomeB";
            this.NomeB.Size = new System.Drawing.Size(176, 23);
            this.NomeB.TabIndex = 2;
            this.NomeB.TextChanged += new System.EventHandler(this.NomeB_TextChanged);
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.BackColor = System.Drawing.Color.Chocolate;
            this.Senha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Senha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Senha.Location = new System.Drawing.Point(90, 176);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(43, 15);
            this.Senha.TabIndex = 3;
            this.Senha.Text = "Senha";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Chocolate;
            this.Email.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Email.Location = new System.Drawing.Point(90, 230);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 15);
            this.Email.TabIndex = 4;
            this.Email.Text = "E-mail";
            // 
            // SenhaB
            // 
            this.SenhaB.Location = new System.Drawing.Point(183, 173);
            this.SenhaB.Name = "SenhaB";
            this.SenhaB.PasswordChar = '*';
            this.SenhaB.Size = new System.Drawing.Size(176, 23);
            this.SenhaB.TabIndex = 5;
            // 
            // EmailB
            // 
            this.EmailB.Location = new System.Drawing.Point(183, 222);
            this.EmailB.Name = "EmailB";
            this.EmailB.Size = new System.Drawing.Size(176, 23);
            this.EmailB.TabIndex = 6;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Chocolate;
            this.Nome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nome.Location = new System.Drawing.Point(90, 128);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(40, 15);
            this.Nome.TabIndex = 7;
            this.Nome.Text = "Nome";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Estado
            // 
            this.Estado.FormattingEnabled = true;
            this.Estado.Items.AddRange(new object[] {
            "Acre",
            "Amazonas",
            "Brasília",
            "Ceará",
            "Rio de Janeiro",
            "São Paulo"});
            this.Estado.Location = new System.Drawing.Point(480, 128);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(121, 23);
            this.Estado.TabIndex = 11;
            this.Estado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(490, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Estado";
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(480, 282);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(75, 23);
            this.btEnviar.TabIndex = 13;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(90, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Endereço";
            // 
            // EnderecoB
            // 
            this.EnderecoB.Location = new System.Drawing.Point(183, 283);
            this.EnderecoB.Name = "EnderecoB";
            this.EnderecoB.Size = new System.Drawing.Size(176, 23);
            this.EnderecoB.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(738, 351);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EnderecoB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.EmailB);
            this.Controls.Add(this.SenhaB);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.NomeB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Formulário de Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NomeB;
        private Label Senha;
        private Label Email;
        private TextBox SenhaB;
        private TextBox EmailB;
        private Label Nome;
        private MenuStrip menuStrip1;
        private ComboBox Estado;
        private Label label3;
        private Button btEnviar;
        private Label label5;
        private TextBox EnderecoB;
        private Button button2;
    }
}