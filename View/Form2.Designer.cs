namespace AluguelCarro.View
{
    partial class Form2
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
            BtnAdmin = new Button();
            BtnAluguel = new Button();
            BtnClientes = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            BtnFechar = new Button();
            panel3 = new Panel();
            label3 = new Label();
            dataGridView_Clientes = new DataGridView();
            dataGridView_Carro = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            BtnAlugar = new Button();
            BtnCarregarDados = new Button();
            dateTime_Entrega = new DateTimePicker();
            dateTime_Devolucao = new DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Carro).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(BtnAdmin);
            panel1.Controls.Add(BtnAluguel);
            panel1.Controls.Add(BtnClientes);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 577);
            panel1.TabIndex = 2;
            // 
            // BtnAdmin
            // 
            BtnAdmin.Dock = DockStyle.Bottom;
            BtnAdmin.FlatAppearance.BorderSize = 0;
            BtnAdmin.FlatStyle = FlatStyle.Flat;
            BtnAdmin.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAdmin.ForeColor = Color.FromArgb(0, 126, 249);
            BtnAdmin.Image = Properties.Resources.admin;
            BtnAdmin.Location = new Point(0, 527);
            BtnAdmin.Name = "BtnAdmin";
            BtnAdmin.Size = new Size(186, 50);
            BtnAdmin.TabIndex = 2;
            BtnAdmin.Text = "Admin";
            BtnAdmin.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnAdmin.UseVisualStyleBackColor = true;
            BtnAdmin.Click += BtnAdmin_Click;
            // 
            // BtnAluguel
            // 
            BtnAluguel.Dock = DockStyle.Top;
            BtnAluguel.FlatAppearance.BorderSize = 0;
            BtnAluguel.FlatStyle = FlatStyle.Flat;
            BtnAluguel.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAluguel.ForeColor = Color.FromArgb(0, 126, 249);
            BtnAluguel.Image = Properties.Resources.frota;
            BtnAluguel.Location = new Point(0, 194);
            BtnAluguel.Name = "BtnAluguel";
            BtnAluguel.Size = new Size(186, 50);
            BtnAluguel.TabIndex = 2;
            BtnAluguel.Text = "Aluguel";
            BtnAluguel.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnAluguel.UseVisualStyleBackColor = true;
            // 
            // BtnClientes
            // 
            BtnClientes.Dock = DockStyle.Top;
            BtnClientes.FlatAppearance.BorderSize = 0;
            BtnClientes.FlatStyle = FlatStyle.Flat;
            BtnClientes.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnClientes.ForeColor = Color.FromArgb(0, 126, 249);
            BtnClientes.Image = Properties.Resources.cliente;
            BtnClientes.Location = new Point(0, 144);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(186, 50);
            BtnClientes.TabIndex = 2;
            BtnClientes.Text = "Clientes";
            BtnClientes.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnClientes.UseVisualStyleBackColor = true;
            BtnClientes.Click += BtnClientes_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 144);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(158, 161, 178);
            label2.Location = new Point(23, 119);
            label2.Name = "label2";
            label2.Size = new Size(142, 13);
            label2.TabIndex = 2;
            label2.Text = "Atendente Marcos Silva";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 156, 149);
            label1.Location = new Point(56, 97);
            label1.Name = "label1";
            label1.Size = new Size(77, 16);
            label1.TabIndex = 1;
            label1.Text = "Atendente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario;
            pictureBox1.Location = new Point(62, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnFechar
            // 
            BtnFechar.ForeColor = Color.DarkSlateGray;
            BtnFechar.Image = Properties.Resources.fechar;
            BtnFechar.Location = new Point(914, 12);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(25, 25);
            BtnFechar.TabIndex = 23;
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 156, 149);
            panel3.Location = new Point(201, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 156, 149);
            label3.Location = new Point(201, 18);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 24;
            label3.Text = "Alugar Veículo";
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.AllowUserToAddRows = false;
            dataGridView_Clientes.AllowUserToDeleteRows = false;
            dataGridView_Clientes.BackgroundColor = Color.FromArgb(24, 30, 54);
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Location = new Point(201, 90);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.ReadOnly = true;
            dataGridView_Clientes.RowTemplate.Height = 25;
            dataGridView_Clientes.Size = new Size(240, 150);
            dataGridView_Clientes.TabIndex = 26;
            dataGridView_Clientes.CellDoubleClick += dataGridView_Clientes_CellDoubleClick;
            // 
            // dataGridView_Carro
            // 
            dataGridView_Carro.AllowUserToAddRows = false;
            dataGridView_Carro.AllowUserToDeleteRows = false;
            dataGridView_Carro.BackgroundColor = Color.FromArgb(24, 30, 54);
            dataGridView_Carro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Carro.Location = new Point(490, 90);
            dataGridView_Carro.Name = "dataGridView_Carro";
            dataGridView_Carro.ReadOnly = true;
            dataGridView_Carro.RowTemplate.Height = 25;
            dataGridView_Carro.Size = new Size(240, 150);
            dataGridView_Carro.TabIndex = 26;
            dataGridView_Carro.CellDoubleClick += dataGridView_Carro_CellDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(201, 61);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 27;
            label4.Text = "Escolha o Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 126, 249);
            label5.Location = new Point(490, 61);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 28;
            label5.Text = "Escolha o Veículo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 126, 249);
            label6.Location = new Point(201, 274);
            label6.Name = "label6";
            label6.Size = new Size(226, 20);
            label6.TabIndex = 27;
            label6.Text = "Escolha a data de entrega:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 126, 249);
            label7.Location = new Point(490, 275);
            label7.Name = "label7";
            label7.Size = new Size(245, 20);
            label7.TabIndex = 27;
            label7.Text = "Escolha a data de devolução:";
            // 
            // BtnAlugar
            // 
            BtnAlugar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAlugar.Location = new Point(201, 481);
            BtnAlugar.Name = "BtnAlugar";
            BtnAlugar.Size = new Size(154, 33);
            BtnAlugar.TabIndex = 29;
            BtnAlugar.Text = "Finalizar Aluguel";
            BtnAlugar.UseVisualStyleBackColor = true;
            BtnAlugar.Click += BtnAlugar_Click;
            // 
            // BtnCarregarDados
            // 
            BtnCarregarDados.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCarregarDados.Location = new Point(490, 22);
            BtnCarregarDados.Name = "BtnCarregarDados";
            BtnCarregarDados.Size = new Size(75, 23);
            BtnCarregarDados.TabIndex = 30;
            BtnCarregarDados.Text = "Carregar Dados";
            BtnCarregarDados.UseVisualStyleBackColor = true;
            BtnCarregarDados.Click += BtnCarregarDados_Click;
            // 
            // dateTime_Entrega
            // 
            dateTime_Entrega.Location = new Point(201, 308);
            dateTime_Entrega.Name = "dateTime_Entrega";
            dateTime_Entrega.Size = new Size(200, 23);
            dateTime_Entrega.TabIndex = 31;
            // 
            // dateTime_Devolucao
            // 
            dateTime_Devolucao.Location = new Point(490, 308);
            dateTime_Devolucao.Name = "dateTime_Devolucao";
            dateTime_Devolucao.Size = new Size(200, 23);
            dateTime_Devolucao.TabIndex = 32;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(951, 577);
            Controls.Add(dateTime_Devolucao);
            Controls.Add(dateTime_Entrega);
            Controls.Add(BtnCarregarDados);
            Controls.Add(BtnAlugar);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(dataGridView_Carro);
            Controls.Add(dataGridView_Clientes);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(BtnFechar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Carro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button BtnAdmin;
        private Button BtnAluguel;
        private Button BtnClientes;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button BtnFechar;
        private Panel panel3;
        private Label label3;
        private DataGridView dataGridView_Clientes;
        private DataGridView dataGridView_Carro;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button BtnAlugar;
        private Button BtnCarregarDados;
        private DateTimePicker dateTime_Entrega;
        private DateTimePicker dateTime_Devolucao;
    }
}