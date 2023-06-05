namespace AluguelCarro.View
{
    partial class Form4
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
            BtnFechar = new Button();
            panel1 = new Panel();
            BtnAdmin = new Button();
            BtnAluguel = new Button();
            BtnClientes = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            label8 = new Label();
            label3 = new Label();
            textBox_MARCA = new TextBox();
            label4 = new Label();
            textBox_MODELO = new TextBox();
            label5 = new Label();
            textBox_PLACA = new TextBox();
            label6 = new Label();
            textBox_VALOR_DIARIA = new TextBox();
            label7 = new Label();
            BtnCadastrarCarro = new Button();
            label9 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            label10 = new Label();
            BtnBuscarPlaca = new Button();
            textBox_PLACA_buscar = new TextBox();
            label13 = new Label();
            textBox_VALOR_DIARIA_atualizar = new TextBox();
            label11 = new Label();
            textBox_PLACA_atualizar = new TextBox();
            label12 = new Label();
            textBox_MODELO_atualizar = new TextBox();
            label14 = new Label();
            textBox_MARCA_atualizar = new TextBox();
            label15 = new Label();
            BtnAtualizarCarro = new Button();
            BtnExcluirCarro = new Button();
            label16 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            label17 = new Label();
            textBox_ALUGUEL_PLACA_buscar = new TextBox();
            label18 = new Label();
            BtnBuscarAluguelCpf = new Button();
            textBox_ALUGUEL_CPF_bucar = new TextBox();
            label20 = new Label();
            dataGridView_Alugueis = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Alugueis).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 24;
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
            BtnAluguel.Click += BtnAluguel_Click;
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 156, 149);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(201, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 156, 149);
            panel4.Location = new Point(0, 11);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 1);
            panel4.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 156, 149);
            label8.Location = new Point(0, -12);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 7;
            label8.Text = "Cadastrar Carro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 156, 149);
            label3.Location = new Point(201, 18);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 5;
            label3.Text = "Cadastrar Carro";
            // 
            // textBox_MARCA
            // 
            textBox_MARCA.BackColor = Color.FromArgb(24, 30, 54);
            textBox_MARCA.BorderStyle = BorderStyle.None;
            textBox_MARCA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_MARCA.ForeColor = SystemColors.InactiveCaption;
            textBox_MARCA.Location = new Point(317, 54);
            textBox_MARCA.Name = "textBox_MARCA";
            textBox_MARCA.Size = new Size(189, 19);
            textBox_MARCA.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(201, 53);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 25;
            label4.Text = "marca:";
            // 
            // textBox_MODELO
            // 
            textBox_MODELO.BackColor = Color.FromArgb(24, 30, 54);
            textBox_MODELO.BorderStyle = BorderStyle.None;
            textBox_MODELO.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_MODELO.ForeColor = SystemColors.InactiveCaption;
            textBox_MODELO.Location = new Point(317, 83);
            textBox_MODELO.Name = "textBox_MODELO";
            textBox_MODELO.Size = new Size(189, 19);
            textBox_MODELO.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(201, 83);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 27;
            label5.Text = "modelo:";
            // 
            // textBox_PLACA
            // 
            textBox_PLACA.BackColor = Color.FromArgb(24, 30, 54);
            textBox_PLACA.BorderStyle = BorderStyle.None;
            textBox_PLACA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_PLACA.ForeColor = SystemColors.InactiveCaption;
            textBox_PLACA.Location = new Point(317, 114);
            textBox_PLACA.Name = "textBox_PLACA";
            textBox_PLACA.Size = new Size(189, 19);
            textBox_PLACA.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(201, 112);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 29;
            label6.Text = "placa:";
            // 
            // textBox_VALOR_DIARIA
            // 
            textBox_VALOR_DIARIA.BackColor = Color.FromArgb(24, 30, 54);
            textBox_VALOR_DIARIA.BorderStyle = BorderStyle.None;
            textBox_VALOR_DIARIA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_VALOR_DIARIA.ForeColor = SystemColors.InactiveCaption;
            textBox_VALOR_DIARIA.Location = new Point(317, 145);
            textBox_VALOR_DIARIA.Name = "textBox_VALOR_DIARIA";
            textBox_VALOR_DIARIA.Size = new Size(189, 19);
            textBox_VALOR_DIARIA.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(201, 144);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 31;
            label7.Text = "valor da diaria:";
            // 
            // BtnCadastrarCarro
            // 
            BtnCadastrarCarro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCadastrarCarro.Location = new Point(201, 182);
            BtnCadastrarCarro.Name = "BtnCadastrarCarro";
            BtnCadastrarCarro.Size = new Size(84, 23);
            BtnCadastrarCarro.TabIndex = 33;
            BtnCadastrarCarro.Text = "Cadastrar";
            BtnCadastrarCarro.UseVisualStyleBackColor = true;
            BtnCadastrarCarro.Click += BtnCadastrarCarro_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 156, 149);
            label9.Location = new Point(549, 22);
            label9.Name = "label9";
            label9.Size = new Size(114, 20);
            label9.TabIndex = 5;
            label9.Text = "Buscar Carro";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 156, 149);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(549, 45);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 1);
            panel5.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 156, 149);
            panel6.Location = new Point(0, 11);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 1);
            panel6.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 156, 149);
            label10.Location = new Point(0, -12);
            label10.Name = "label10";
            label10.Size = new Size(137, 20);
            label10.TabIndex = 7;
            label10.Text = "Cadastrar Carro";
            // 
            // BtnBuscarPlaca
            // 
            BtnBuscarPlaca.Image = Properties.Resources.lupa;
            BtnBuscarPlaca.Location = new Point(808, 51);
            BtnBuscarPlaca.Name = "BtnBuscarPlaca";
            BtnBuscarPlaca.Size = new Size(33, 33);
            BtnBuscarPlaca.TabIndex = 36;
            BtnBuscarPlaca.UseVisualStyleBackColor = true;
            BtnBuscarPlaca.Click += BtnBuscarPlaca_Click;
            // 
            // textBox_PLACA_buscar
            // 
            textBox_PLACA_buscar.BackColor = Color.FromArgb(24, 30, 54);
            textBox_PLACA_buscar.BorderStyle = BorderStyle.None;
            textBox_PLACA_buscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_PLACA_buscar.ForeColor = SystemColors.InactiveCaption;
            textBox_PLACA_buscar.Location = new Point(609, 57);
            textBox_PLACA_buscar.Name = "textBox_PLACA_buscar";
            textBox_PLACA_buscar.Size = new Size(189, 19);
            textBox_PLACA_buscar.TabIndex = 35;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(549, 56);
            label13.Name = "label13";
            label13.Size = new Size(51, 20);
            label13.TabIndex = 34;
            label13.Text = "placa:";
            // 
            // textBox_VALOR_DIARIA_atualizar
            // 
            textBox_VALOR_DIARIA_atualizar.BackColor = Color.FromArgb(24, 30, 54);
            textBox_VALOR_DIARIA_atualizar.BorderStyle = BorderStyle.None;
            textBox_VALOR_DIARIA_atualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_VALOR_DIARIA_atualizar.ForeColor = SystemColors.InactiveCaption;
            textBox_VALOR_DIARIA_atualizar.Location = new Point(665, 204);
            textBox_VALOR_DIARIA_atualizar.Name = "textBox_VALOR_DIARIA_atualizar";
            textBox_VALOR_DIARIA_atualizar.Size = new Size(189, 19);
            textBox_VALOR_DIARIA_atualizar.TabIndex = 44;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(549, 203);
            label11.Name = "label11";
            label11.Size = new Size(110, 20);
            label11.TabIndex = 43;
            label11.Text = "valor da diaria:";
            // 
            // textBox_PLACA_atualizar
            // 
            textBox_PLACA_atualizar.BackColor = Color.FromArgb(24, 30, 54);
            textBox_PLACA_atualizar.BorderStyle = BorderStyle.None;
            textBox_PLACA_atualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_PLACA_atualizar.ForeColor = SystemColors.InactiveCaption;
            textBox_PLACA_atualizar.Location = new Point(665, 173);
            textBox_PLACA_atualizar.Name = "textBox_PLACA_atualizar";
            textBox_PLACA_atualizar.Size = new Size(189, 19);
            textBox_PLACA_atualizar.TabIndex = 42;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(549, 171);
            label12.Name = "label12";
            label12.Size = new Size(51, 20);
            label12.TabIndex = 41;
            label12.Text = "placa:";
            // 
            // textBox_MODELO_atualizar
            // 
            textBox_MODELO_atualizar.BackColor = Color.FromArgb(24, 30, 54);
            textBox_MODELO_atualizar.BorderStyle = BorderStyle.None;
            textBox_MODELO_atualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_MODELO_atualizar.ForeColor = SystemColors.InactiveCaption;
            textBox_MODELO_atualizar.Location = new Point(665, 142);
            textBox_MODELO_atualizar.Name = "textBox_MODELO_atualizar";
            textBox_MODELO_atualizar.Size = new Size(189, 19);
            textBox_MODELO_atualizar.TabIndex = 40;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(549, 142);
            label14.Name = "label14";
            label14.Size = new Size(65, 20);
            label14.TabIndex = 39;
            label14.Text = "modelo:";
            // 
            // textBox_MARCA_atualizar
            // 
            textBox_MARCA_atualizar.BackColor = Color.FromArgb(24, 30, 54);
            textBox_MARCA_atualizar.BorderStyle = BorderStyle.None;
            textBox_MARCA_atualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_MARCA_atualizar.ForeColor = SystemColors.InactiveCaption;
            textBox_MARCA_atualizar.Location = new Point(665, 113);
            textBox_MARCA_atualizar.Name = "textBox_MARCA_atualizar";
            textBox_MARCA_atualizar.Size = new Size(189, 19);
            textBox_MARCA_atualizar.TabIndex = 38;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(549, 112);
            label15.Name = "label15";
            label15.Size = new Size(57, 20);
            label15.TabIndex = 37;
            label15.Text = "marca:";
            // 
            // BtnAtualizarCarro
            // 
            BtnAtualizarCarro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAtualizarCarro.Location = new Point(549, 248);
            BtnAtualizarCarro.Name = "BtnAtualizarCarro";
            BtnAtualizarCarro.Size = new Size(84, 23);
            BtnAtualizarCarro.TabIndex = 45;
            BtnAtualizarCarro.Text = "Atualizar";
            BtnAtualizarCarro.UseVisualStyleBackColor = true;
            BtnAtualizarCarro.Click += BtnAtualizarCarro_Click;
            // 
            // BtnExcluirCarro
            // 
            BtnExcluirCarro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExcluirCarro.Location = new Point(653, 248);
            BtnExcluirCarro.Name = "BtnExcluirCarro";
            BtnExcluirCarro.Size = new Size(84, 23);
            BtnExcluirCarro.TabIndex = 46;
            BtnExcluirCarro.Text = "Excluir";
            BtnExcluirCarro.UseVisualStyleBackColor = true;
            BtnExcluirCarro.Click += BtnExcluirCarro_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(0, 156, 149);
            label16.Location = new Point(201, 299);
            label16.Name = "label16";
            label16.Size = new Size(130, 20);
            label16.TabIndex = 5;
            label16.Text = "Buscar Aluguel";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 156, 149);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(label17);
            panel7.Location = new Point(201, 322);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 1);
            panel7.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 156, 149);
            panel8.Location = new Point(0, 11);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 1);
            panel8.TabIndex = 8;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(0, 156, 149);
            label17.Location = new Point(0, -12);
            label17.Name = "label17";
            label17.Size = new Size(137, 20);
            label17.TabIndex = 7;
            label17.Text = "Cadastrar Carro";
            // 
            // textBox_ALUGUEL_PLACA_buscar
            // 
            textBox_ALUGUEL_PLACA_buscar.BackColor = Color.FromArgb(24, 30, 54);
            textBox_ALUGUEL_PLACA_buscar.BorderStyle = BorderStyle.None;
            textBox_ALUGUEL_PLACA_buscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ALUGUEL_PLACA_buscar.ForeColor = SystemColors.InactiveCaption;
            textBox_ALUGUEL_PLACA_buscar.Location = new Point(261, 338);
            textBox_ALUGUEL_PLACA_buscar.Name = "textBox_ALUGUEL_PLACA_buscar";
            textBox_ALUGUEL_PLACA_buscar.Size = new Size(189, 19);
            textBox_ALUGUEL_PLACA_buscar.TabIndex = 48;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ButtonHighlight;
            label18.Location = new Point(201, 337);
            label18.Name = "label18";
            label18.Size = new Size(51, 20);
            label18.TabIndex = 47;
            label18.Text = "placa:";
            // 
            // BtnBuscarAluguelCpf
            // 
            BtnBuscarAluguelCpf.Image = Properties.Resources.lupa;
            BtnBuscarAluguelCpf.Location = new Point(801, 333);
            BtnBuscarAluguelCpf.Name = "BtnBuscarAluguelCpf";
            BtnBuscarAluguelCpf.Size = new Size(33, 33);
            BtnBuscarAluguelCpf.TabIndex = 53;
            BtnBuscarAluguelCpf.UseVisualStyleBackColor = true;
            BtnBuscarAluguelCpf.Click += BtnBuscarAluguelCpf_Click;
            // 
            // textBox_ALUGUEL_CPF_bucar
            // 
            textBox_ALUGUEL_CPF_bucar.BackColor = Color.FromArgb(24, 30, 54);
            textBox_ALUGUEL_CPF_bucar.BorderStyle = BorderStyle.None;
            textBox_ALUGUEL_CPF_bucar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ALUGUEL_CPF_bucar.ForeColor = SystemColors.InactiveCaption;
            textBox_ALUGUEL_CPF_bucar.Location = new Point(602, 339);
            textBox_ALUGUEL_CPF_bucar.Name = "textBox_ALUGUEL_CPF_bucar";
            textBox_ALUGUEL_CPF_bucar.Size = new Size(189, 19);
            textBox_ALUGUEL_CPF_bucar.TabIndex = 52;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ButtonHighlight;
            label20.Location = new Point(549, 338);
            label20.Name = "label20";
            label20.Size = new Size(38, 20);
            label20.TabIndex = 51;
            label20.Text = "Cpf:";
            // 
            // dataGridView_Alugueis
            // 
            dataGridView_Alugueis.AllowUserToAddRows = false;
            dataGridView_Alugueis.AllowUserToDeleteRows = false;
            dataGridView_Alugueis.BackgroundColor = Color.FromArgb(24, 30, 54);
            dataGridView_Alugueis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Alugueis.Location = new Point(201, 374);
            dataGridView_Alugueis.Name = "dataGridView_Alugueis";
            dataGridView_Alugueis.ReadOnly = true;
            dataGridView_Alugueis.RowTemplate.Height = 25;
            dataGridView_Alugueis.Size = new Size(653, 177);
            dataGridView_Alugueis.TabIndex = 62;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(951, 577);
            Controls.Add(dataGridView_Alugueis);
            Controls.Add(BtnBuscarAluguelCpf);
            Controls.Add(textBox_ALUGUEL_CPF_bucar);
            Controls.Add(label20);
            Controls.Add(textBox_ALUGUEL_PLACA_buscar);
            Controls.Add(label18);
            Controls.Add(BtnAtualizarCarro);
            Controls.Add(BtnExcluirCarro);
            Controls.Add(textBox_VALOR_DIARIA_atualizar);
            Controls.Add(label11);
            Controls.Add(textBox_PLACA_atualizar);
            Controls.Add(label12);
            Controls.Add(textBox_MODELO_atualizar);
            Controls.Add(label14);
            Controls.Add(textBox_MARCA_atualizar);
            Controls.Add(label15);
            Controls.Add(BtnBuscarPlaca);
            Controls.Add(textBox_PLACA_buscar);
            Controls.Add(label13);
            Controls.Add(BtnCadastrarCarro);
            Controls.Add(textBox_VALOR_DIARIA);
            Controls.Add(label7);
            Controls.Add(textBox_PLACA);
            Controls.Add(label6);
            Controls.Add(textBox_MODELO);
            Controls.Add(label5);
            Controls.Add(textBox_MARCA);
            Controls.Add(label4);
            Controls.Add(panel5);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(label16);
            Controls.Add(label3);
            Controls.Add(BtnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Alugueis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnFechar;
        private Panel panel1;
        private Button BtnAdmin;
        private Button BtnAluguel;
        private Button BtnClientes;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label3;
        private TextBox textBox_MARCA;
        private Label label4;
        private TextBox textBox_MODELO;
        private Label label5;
        private TextBox textBox_PLACA;
        private Label label6;
        private TextBox textBox_VALOR_DIARIA;
        private Label label7;
        private Button BtnCadastrarCarro;
        private Panel panel4;
        private Label label8;
        private Label label9;
        private Panel panel5;
        private Panel panel6;
        private Label label10;
        private Button BtnBuscarPlaca;
        private TextBox textBox_PLACA_buscar;
        private Label label13;
        private TextBox textBox_VALOR_DIARIA_atualizar;
        private Label label11;
        private TextBox textBox_PLACA_atualizar;
        private Label label12;
        private TextBox textBox_MODELO_atualizar;
        private Label label14;
        private TextBox textBox_MARCA_atualizar;
        private Label label15;
        private Button BtnAtualizarCarro;
        private Button BtnExcluirCarro;
        private Label label16;
        private Panel panel7;
        private Panel panel8;
        private Label label17;
        private TextBox textBox_ALUGUEL_PLACA_buscar;
        private Label label18;
        private Button BtnBuscarAluguelCpf;
        private TextBox textBox_ALUGUEL_CPF_bucar;
        private Label label20;
        private DataGridView dataGridView_Alugueis;
    }
}