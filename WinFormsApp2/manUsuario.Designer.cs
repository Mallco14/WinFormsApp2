namespace WinFormsApp2
{
    partial class manUsuario
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
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDni = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            dni = new DataGridViewTextBoxColumn();
            txtNombre = new DataGridViewTextBoxColumn();
            txtTelefono = new DataGridViewTextBoxColumn();
            txtDireccion = new DataGridViewTextBoxColumn();
            txtEmail = new DataGridViewTextBoxColumn();
            txtApellido = new DataGridViewTextBoxColumn();
            txtFecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtDni);
            panel1.Location = new Point(51, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 181);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(477, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(168, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(477, 67);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(168, 23);
            textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(477, 107);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(168, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(93, 147);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(552, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(433, 110);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 6;
            label7.Text = "Email";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(420, 70);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(352, 41);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 150);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 113);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 70);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // txtDni
            // 
            txtDni.AutoSize = true;
            txtDni.Location = new Point(33, 30);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(27, 15);
            txtDni.TabIndex = 0;
            txtDni.Text = "DNI";
            txtDni.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(372, 229);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(473, 229);
            button2.Name = "button2";
            button2.Size = new Size(82, 23);
            button2.TabIndex = 2;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(578, 229);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(678, 229);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "BUSCAR";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dni, txtNombre, txtTelefono, txtDireccion, txtEmail, txtApellido, txtFecha });
            dataGridView1.Location = new Point(46, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(742, 150);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dni
            // 
            dni.HeaderText = "dni";
            dni.Name = "dni";
            // 
            // txtNombre
            // 
            txtNombre.HeaderText = "nombre";
            txtNombre.Name = "txtNombre";
            // 
            // txtTelefono
            // 
            txtTelefono.HeaderText = "telefono";
            txtTelefono.Name = "txtTelefono";
            // 
            // txtDireccion
            // 
            txtDireccion.HeaderText = "direccion";
            txtDireccion.Name = "txtDireccion";
            // 
            // txtEmail
            // 
            txtEmail.HeaderText = "Email";
            txtEmail.Name = "txtEmail";
            // 
            // txtApellido
            // 
            txtApellido.HeaderText = "apellido";
            txtApellido.Name = "txtApellido";
            // 
            // txtFecha
            // 
            txtFecha.HeaderText = "fecha de nacimiento";
            txtFecha.Name = "txtFecha";
            // 
            // manUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "manUsuario";
            Text = "manUsuario";
            Load += manUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label txtDni;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn txtNombre;
        private DataGridViewTextBoxColumn txtTelefono;
        private DataGridViewTextBoxColumn txtDireccion;
        private DataGridViewTextBoxColumn txtEmail;
        private DataGridViewTextBoxColumn txtApellido;
        private DataGridViewTextBoxColumn txtFecha;
    }
}