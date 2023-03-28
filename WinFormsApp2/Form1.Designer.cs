namespace WinFormsApp2
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
            panel1 = new Panel();
            btnCancelar = new Button();
            btnIniciar = new Button();
            txtPassword = new MaskedTextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnIniciar);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(45, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 284);
            panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(170, 233);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = SystemColors.Highlight;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.ForeColor = SystemColors.HighlightText;
            btnIniciar.Location = new Point(44, 233);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(102, 29);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "Iniciar sesión";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(62, 193);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(174, 23);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(64, 170);
            label3.Name = "label3";
            label3.Size = new Size(56, 13);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(64, 133);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(172, 22);
            txtUsuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 106);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(60, 58);
            label1.Name = "label1";
            label1.Size = new Size(161, 30);
            label1.TabIndex = 0;
            label1.Text = "Inicio de sesión";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(384, 361);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inicio de sesión";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnIniciar;
        private MaskedTextBox txtPassword;
        private Label label3;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
    }
}