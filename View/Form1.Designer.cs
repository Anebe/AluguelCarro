namespace AluguelCarro
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
            BtnAdmin = new Button();
            BtnAluguel = new Button();
            BtnClientes = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            PnlNav = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            textBox_NOME = new TextBox();
            textBox_CPF = new TextBox();
            label5 = new Label();
            textBox_EMAIL = new TextBox();
            label6 = new Label();
            textBox_RG = new TextBox();
            label7 = new Label();
            textBox_TEL = new TextBox();
            label8 = new Label();
            textBox_RENACH = new TextBox();
            label9 = new Label();
            textBox_CNH = new TextBox();
            label10 = new Label();
            dateTime_NASC = new DateTimePicker();
            label11 = new Label();
            BtnFechar = new Button();
            label12 = new Label();
            panel4 = new Panel();
            textBox_CPF_buscar = new TextBox();
            label13 = new Label();
            BtnBuscar = new Button();
            BtnCadastrar = new Button();
            label14 = new Label();
            textBox_NOME_atualizar = new TextBox();
            label15 = new Label();
            textBoxCPF_atualizar = new TextBox();
            label16 = new Label();
            textBox_EMAIL_atualizar = new TextBox();
            label17 = new Label();
            textBox_RG_atualizar = new TextBox();
            label18 = new Label();
            textBox_Tel_atualizar = new TextBox();
            label19 = new Label();
            textBox_RENACH_atualizar = new TextBox();
            label20 = new Label();
            textBox_CNH_atualizar = new TextBox();
            dateTimePicker_NASC_atualizar = new DateTimePicker();
            label21 = new Label();
            BtnAtualizar = new Button();
            BtnExcluir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.TabIndex = 1;
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
            BtnAdmin.Leave += BtnAdmin_Leave;
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
            BtnAluguel.Leave += BtnAluguel_Leave;
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
            BtnClientes.Leave += BtnClientes_Leave;
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
            // PnlNav
            // 
            PnlNav.BackColor = Color.FromArgb(0, 126, 249);
            PnlNav.Location = new Point(0, 193);
            PnlNav.Name = "PnlNav";
            PnlNav.Size = new Size(3, 100);
            PnlNav.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 156, 149);
            label3.Location = new Point(201, 18);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 3;
            label3.Text = "Cadastrar Cliente";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 156, 149);
            panel3.Location = new Point(201, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(201, 55);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 6;
            label4.Text = "Nome:";
            // 
            // textBox_NOME
            // 
            textBox_NOME.BackColor = Color.FromArgb(24, 30, 54);
            textBox_NOME.BorderStyle = BorderStyle.None;
            textBox_NOME.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_NOME.ForeColor = SystemColors.InactiveCaption;
            textBox_NOME.Location = new Point(262, 56);
            textBox_NOME.Name = "textBox_NOME";
            textBox_NOME.Size = new Size(189, 19);
            textBox_NOME.TabIndex = 7;
            // 
            // textBox_CPF
            // 
            textBox_CPF.BackColor = Color.FromArgb(24, 30, 54);
            textBox_CPF.BorderStyle = BorderStyle.None;
            textBox_CPF.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_CPF.ForeColor = SystemColors.InactiveCaption;
            textBox_CPF.Location = new Point(541, 56);
            textBox_CPF.Name = "textBox_CPF";
            textBox_CPF.Size = new Size(189, 19);
            textBox_CPF.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(488, 55);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 8;
            label5.Text = "Cpf:";
            // 
            // textBox_EMAIL
            // 
            textBox_EMAIL.BackColor = Color.FromArgb(24, 30, 54);
            textBox_EMAIL.BorderStyle = BorderStyle.None;
            textBox_EMAIL.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_EMAIL.ForeColor = SystemColors.InactiveCaption;
            textBox_EMAIL.Location = new Point(262, 98);
            textBox_EMAIL.Name = "textBox_EMAIL";
            textBox_EMAIL.Size = new Size(189, 19);
            textBox_EMAIL.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(201, 97);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 10;
            label6.Text = "Email:";
            // 
            // textBox_RG
            // 
            textBox_RG.BackColor = Color.FromArgb(24, 30, 54);
            textBox_RG.BorderStyle = BorderStyle.None;
            textBox_RG.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_RG.ForeColor = SystemColors.InactiveCaption;
            textBox_RG.Location = new Point(541, 97);
            textBox_RG.Name = "textBox_RG";
            textBox_RG.Size = new Size(189, 19);
            textBox_RG.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(488, 97);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 12;
            label7.Text = "RG:";
            // 
            // textBox_TEL
            // 
            textBox_TEL.BackColor = Color.FromArgb(24, 30, 54);
            textBox_TEL.BorderStyle = BorderStyle.None;
            textBox_TEL.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_TEL.ForeColor = SystemColors.InactiveCaption;
            textBox_TEL.Location = new Point(262, 144);
            textBox_TEL.Name = "textBox_TEL";
            textBox_TEL.Size = new Size(189, 19);
            textBox_TEL.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(201, 143);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 14;
            label8.Text = "Tel:";
            // 
            // textBox_RENACH
            // 
            textBox_RENACH.BackColor = Color.FromArgb(24, 30, 54);
            textBox_RENACH.BorderStyle = BorderStyle.None;
            textBox_RENACH.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_RENACH.ForeColor = SystemColors.InactiveCaption;
            textBox_RENACH.Location = new Point(575, 184);
            textBox_RENACH.Name = "textBox_RENACH";
            textBox_RENACH.Size = new Size(189, 19);
            textBox_RENACH.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(488, 183);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 16;
            label9.Text = "RENACH:";
            // 
            // textBox_CNH
            // 
            textBox_CNH.BackColor = Color.FromArgb(24, 30, 54);
            textBox_CNH.BorderStyle = BorderStyle.None;
            textBox_CNH.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_CNH.ForeColor = SystemColors.InactiveCaption;
            textBox_CNH.Location = new Point(541, 144);
            textBox_CNH.Name = "textBox_CNH";
            textBox_CNH.Size = new Size(189, 19);
            textBox_CNH.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(488, 143);
            label10.Name = "label10";
            label10.Size = new Size(47, 20);
            label10.TabIndex = 18;
            label10.Text = "CNH:";
            // 
            // dateTime_NASC
            // 
            dateTime_NASC.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTime_NASC.CalendarTitleForeColor = Color.FromArgb(24, 30, 54);
            dateTime_NASC.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTime_NASC.Format = DateTimePickerFormat.Short;
            dateTime_NASC.Location = new Point(315, 181);
            dateTime_NASC.Name = "dateTime_NASC";
            dateTime_NASC.Size = new Size(136, 21);
            dateTime_NASC.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(199, 181);
            label11.Name = "label11";
            label11.Size = new Size(110, 20);
            label11.TabIndex = 21;
            label11.Text = "Data de Nasc:";
            // 
            // BtnFechar
            // 
            BtnFechar.ForeColor = Color.DarkSlateGray;
            BtnFechar.Image = Properties.Resources.fechar;
            BtnFechar.Location = new Point(914, 12);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(25, 25);
            BtnFechar.TabIndex = 22;
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 156, 149);
            label12.Location = new Point(201, 261);
            label12.Name = "label12";
            label12.Size = new Size(126, 20);
            label12.TabIndex = 3;
            label12.Text = "Buscar Cliente";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 156, 149);
            panel4.Location = new Point(201, 284);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 1);
            panel4.TabIndex = 4;
            // 
            // textBox_CPF_buscar
            // 
            textBox_CPF_buscar.BackColor = Color.FromArgb(24, 30, 54);
            textBox_CPF_buscar.BorderStyle = BorderStyle.None;
            textBox_CPF_buscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_CPF_buscar.ForeColor = SystemColors.InactiveCaption;
            textBox_CPF_buscar.Location = new Point(245, 311);
            textBox_CPF_buscar.Name = "textBox_CPF_buscar";
            textBox_CPF_buscar.Size = new Size(189, 19);
            textBox_CPF_buscar.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(201, 310);
            label13.Name = "label13";
            label13.Size = new Size(38, 20);
            label13.TabIndex = 23;
            label13.Text = "Cpf:";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Image = Properties.Resources.lupa;
            BtnBuscar.Location = new Point(440, 305);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(33, 33);
            BtnBuscar.TabIndex = 26;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCadastrar.Location = new Point(201, 221);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(84, 23);
            BtnCadastrar.TabIndex = 27;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(201, 371);
            label14.Name = "label14";
            label14.Size = new Size(55, 20);
            label14.TabIndex = 6;
            label14.Text = "Nome:";
            // 
            // textBox_NOME_atualizar
            // 
            textBox_NOME_atualizar.BackColor = Color.FromArgb(24, 30, 54);
            textBox_NOME_atualizar.BorderStyle = BorderStyle.None;
            textBox_NOME_atualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_NOME_atualizar.ForeColor = SystemColors.InactiveCaption;
            textBox_NOME_atualizar.Location = new Point(262, 372);
            textBox_NOME_atualizar.Name = "textBox_NOME_atualizar";
            textBox_NOME_atualizar.Size = new Size(189, 19);
            textBox_NOME_atualizar.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(488, 371);
            label15.Name = "label15";
            label15.Size = new Size(38, 20);
            label15.TabIndex = 8;
            label15.Text = "Cpf:";
            // 
            // textBoxCPF_atualizar
            // 
            textBoxCPF_atualizar.BackColor = Color.FromArgb(24, 30, 54);
            textBoxCPF_atualizar.BorderStyle = BorderStyle.None;
            textBoxCPF_atualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCPF_atualizar.ForeColor = SystemColors.InactiveCaption;
            textBoxCPF_atualizar.Location = new Point(541, 372);
            textBoxCPF_atualizar.Name = "textBoxCPF_atualizar";
            textBoxCPF_atualizar.Size = new Size(189, 19);
            textBoxCPF_atualizar.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ButtonHighlight;
            label16.Location = new Point(201, 413);
            label16.Name = "label16";
            label16.Size = new Size(52, 20);
            label16.TabIndex = 10;
            label16.Text = "Email:";
            // 
            // textBox_EMAIL_atualizar
            // 
            textBox_EMAIL_atualizar.BackColor = Color.FromArgb(24, 30, 54);
            textBox_EMAIL_atualizar.BorderStyle = BorderStyle.None;
            textBox_EMAIL_atualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_EMAIL_atualizar.ForeColor = SystemColors.InactiveCaption;
            textBox_EMAIL_atualizar.Location = new Point(262, 414);
            textBox_EMAIL_atualizar.Name = "textBox_EMAIL_atualizar";
            textBox_EMAIL_atualizar.Size = new Size(189, 19);
            textBox_EMAIL_atualizar.TabIndex = 11;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ButtonHighlight;
            label17.Location = new Point(488, 413);
            label17.Name = "label17";
            label17.Size = new Size(38, 20);
            label17.TabIndex = 12;
            label17.Text = "RG:";
            // 
            // textBox_RG_atualizar
            // 
            textBox_RG_atualizar.BackColor = Color.FromArgb(24, 30, 54);
            textBox_RG_atualizar.BorderStyle = BorderStyle.None;
            textBox_RG_atualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_RG_atualizar.ForeColor = SystemColors.InactiveCaption;
            textBox_RG_atualizar.Location = new Point(541, 413);
            textBox_RG_atualizar.Name = "textBox_RG_atualizar";
            textBox_RG_atualizar.Size = new Size(189, 19);
            textBox_RG_atualizar.TabIndex = 13;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ButtonHighlight;
            label18.Location = new Point(201, 459);
            label18.Name = "label18";
            label18.Size = new Size(34, 20);
            label18.TabIndex = 14;
            label18.Text = "Tel:";
            // 
            // textBox_Tel_atualizar
            // 
            textBox_Tel_atualizar.BackColor = Color.FromArgb(24, 30, 54);
            textBox_Tel_atualizar.BorderStyle = BorderStyle.None;
            textBox_Tel_atualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Tel_atualizar.ForeColor = SystemColors.InactiveCaption;
            textBox_Tel_atualizar.Location = new Point(262, 460);
            textBox_Tel_atualizar.Name = "textBox_Tel_atualizar";
            textBox_Tel_atualizar.Size = new Size(189, 19);
            textBox_Tel_atualizar.TabIndex = 15;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ButtonHighlight;
            label19.Location = new Point(488, 499);
            label19.Name = "label19";
            label19.Size = new Size(81, 20);
            label19.TabIndex = 16;
            label19.Text = "RENACH:";
            // 
            // textBox_RENACH_atualizar
            // 
            textBox_RENACH_atualizar.BackColor = Color.FromArgb(24, 30, 54);
            textBox_RENACH_atualizar.BorderStyle = BorderStyle.None;
            textBox_RENACH_atualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_RENACH_atualizar.ForeColor = SystemColors.InactiveCaption;
            textBox_RENACH_atualizar.Location = new Point(575, 500);
            textBox_RENACH_atualizar.Name = "textBox_RENACH_atualizar";
            textBox_RENACH_atualizar.Size = new Size(189, 19);
            textBox_RENACH_atualizar.TabIndex = 17;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ButtonHighlight;
            label20.Location = new Point(488, 459);
            label20.Name = "label20";
            label20.Size = new Size(47, 20);
            label20.TabIndex = 18;
            label20.Text = "CNH:";
            // 
            // textBox_CNH_atualizar
            // 
            textBox_CNH_atualizar.BackColor = Color.FromArgb(24, 30, 54);
            textBox_CNH_atualizar.BorderStyle = BorderStyle.None;
            textBox_CNH_atualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_CNH_atualizar.ForeColor = SystemColors.InactiveCaption;
            textBox_CNH_atualizar.Location = new Point(541, 460);
            textBox_CNH_atualizar.Name = "textBox_CNH_atualizar";
            textBox_CNH_atualizar.Size = new Size(189, 19);
            textBox_CNH_atualizar.TabIndex = 19;
            // 
            // dateTimePicker_NASC_atualizar
            // 
            dateTimePicker_NASC_atualizar.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_NASC_atualizar.CalendarTitleForeColor = Color.FromArgb(24, 30, 54);
            dateTimePicker_NASC_atualizar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_NASC_atualizar.Format = DateTimePickerFormat.Short;
            dateTimePicker_NASC_atualizar.Location = new Point(315, 497);
            dateTimePicker_NASC_atualizar.Name = "dateTimePicker_NASC_atualizar";
            dateTimePicker_NASC_atualizar.Size = new Size(136, 21);
            dateTimePicker_NASC_atualizar.TabIndex = 20;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.ButtonHighlight;
            label21.Location = new Point(199, 497);
            label21.Name = "label21";
            label21.Size = new Size(110, 20);
            label21.TabIndex = 21;
            label21.Text = "Data de Nasc:";
            // 
            // BtnAtualizar
            // 
            BtnAtualizar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAtualizar.Location = new Point(801, 368);
            BtnAtualizar.Name = "BtnAtualizar";
            BtnAtualizar.Size = new Size(84, 23);
            BtnAtualizar.TabIndex = 27;
            BtnAtualizar.Text = "Atualizar";
            BtnAtualizar.UseVisualStyleBackColor = true;
            BtnAtualizar.Click += BtnAtualizar_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExcluir.Location = new Point(801, 410);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(84, 23);
            BtnExcluir.TabIndex = 27;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(951, 577);
            Controls.Add(BtnAtualizar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnCadastrar);
            Controls.Add(BtnBuscar);
            Controls.Add(textBox_CPF_buscar);
            Controls.Add(label13);
            Controls.Add(BtnFechar);
            Controls.Add(label21);
            Controls.Add(label11);
            Controls.Add(dateTimePicker_NASC_atualizar);
            Controls.Add(dateTime_NASC);
            Controls.Add(textBox_CNH_atualizar);
            Controls.Add(textBox_CNH);
            Controls.Add(label20);
            Controls.Add(label10);
            Controls.Add(textBox_RENACH_atualizar);
            Controls.Add(textBox_RENACH);
            Controls.Add(label19);
            Controls.Add(label9);
            Controls.Add(textBox_Tel_atualizar);
            Controls.Add(textBox_TEL);
            Controls.Add(label18);
            Controls.Add(label8);
            Controls.Add(textBox_RG_atualizar);
            Controls.Add(textBox_RG);
            Controls.Add(label17);
            Controls.Add(label7);
            Controls.Add(textBox_EMAIL_atualizar);
            Controls.Add(textBox_EMAIL);
            Controls.Add(label16);
            Controls.Add(label6);
            Controls.Add(textBoxCPF_atualizar);
            Controls.Add(textBox_CPF);
            Controls.Add(label15);
            Controls.Add(label5);
            Controls.Add(textBox_NOME_atualizar);
            Controls.Add(textBox_NOME);
            Controls.Add(label14);
            Controls.Add(label4);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label12);
            Controls.Add(label3);
            Controls.Add(PnlNav);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(50, 50);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel PnlNav;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private TextBox textBox_NOME;
        private TextBox textBox_CPF;
        private Label label5;
        private TextBox textBox_EMAIL;
        private Label label6;
        private TextBox textBox_RG;
        private Label label7;
        private TextBox textBox_TEL;
        private Label label8;
        private TextBox textBox_RENACH;
        private Label label9;
        private TextBox textBox_CNH;
        private Label label10;
        private DateTimePicker dateTime_NASC;
        private Label label11;
        private Button BtnFechar;
        private Label label12;
        private Panel panel4;
        private TextBox textBox_CPF_buscar;
        private Label label13;
        private Button BtnBuscar;
        private Button BtnCadastrar;
        private Label label14;
        private TextBox textBox_NOME_atualizar;
        private Label label15;
        private TextBox textBoxCPF_atualizar;
        private Label label16;
        private TextBox textBox_EMAIL_atualizar;
        private Label label17;
        private TextBox textBox_RG_atualizar;
        private Label label18;
        private TextBox textBox_Tel_atualizar;
        private Label label19;
        private TextBox textBox_RENACH_atualizar;
        private Label label20;
        private TextBox textBox_CNH_atualizar;
        private DateTimePicker dateTimePicker_NASC_atualizar;
        private Label label21;
        private Button BtnAtualizar;
        private Button BtnExcluir;
    }
}