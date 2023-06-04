using AluguelCarro.src.Controller;
using AluguelCarro.src.DTO;
using AluguelCarro.View;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AluguelCarro

{
    public partial class Form1 : Form
    {
        private IServiceProvider _serviceProvider;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnClientes.Height;
            PnlNav.Top = BtnClientes.Top;
            PnlNav.Left = BtnClientes.Left;
            BtnClientes.BackColor = Color.FromArgb(46, 51, 73);    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            // ESTÉTICA
            PnlNav.Height = BtnClientes.Height;
            PnlNav.Top = BtnClientes.Top;
            PnlNav.Left = BtnClientes.Left;
            BtnClientes.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnAluguel_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAluguel.Height;
            PnlNav.Top = BtnAluguel.Top;
            PnlNav.Left = BtnAluguel.Left;
            BtnAluguel.BackColor = Color.FromArgb(46, 51, 73);
            Form2 frm = new Form2();
            frm.Show();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAdmin.Height;
            PnlNav.Top = BtnAdmin.Top;
            PnlNav.Left = BtnAdmin.Left;
            BtnAdmin.BackColor = Color.FromArgb(46, 51, 73);

            Form4 frm = new Form4();
            frm.Show();
        }

        private void BtnClientes_Leave(object sender, EventArgs e)
        {
            BtnClientes.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAluguel_Leave(object sender, EventArgs e)
        {
            BtnAluguel.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAdmin_Leave(object sender, EventArgs e)
        {
            BtnAdmin.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            AtendimentoController control = new AtendimentoController(Startup.GetServiceProvider());
            Cliente cliente = new Cliente();

            cliente.Nome = textBox_NOME.Text;
            cliente.Cpf = textBox_CPF.Text;
            cliente.Email = textBox_EMAIL.Text;
            cliente.Rg = textBox_RG.Text;
            cliente.Telefone = textBox_TEL.Text;
            cliente.Cnh = textBox_CNH.Text;
            cliente.DtNascimento = DateTime.Parse(dateTime_NASC.Text);
            cliente.Renach = textBox_RENACH.Text;

            /*
            cliente.Nome = "gab";
            cliente.Cpf = "123.123.123-12";
            cliente.Email = "gab@gmail.com";
            cliente.Rg = "123456789 - 1";
            cliente.Telefone = "(98)91234 - 1234";
            cliente.Cnh = "1234";
            cliente.DtNascimento = DateTime.Parse("2001-10-08");
            cliente.Renach = "45678";
            */

            bool resultado = control.AdicionarCliente(cliente);

            // Verificar o resultado
            if (resultado)
            {
                MessageBox.Show("cliente adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao adicionar o cliente.");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            AtendimentoController control = new AtendimentoController(Startup.GetServiceProvider());
            Cliente clienteBusca = new Cliente();
            Cliente clienteRetorno = new Cliente();

            clienteBusca.Cpf = textBox_CPF_buscar.Text;

            clienteRetorno = control.BuscarCliente(clienteBusca);

            //Limpando o form
            textBox_NOME.Text = "";
            textBox_CPF.Text = "";
            textBox_EMAIL.Text = "";
            textBox_RG.Text = "";
            textBox_TEL.Text = "";
            textBox_CNH.Text = "";
            textBox_RENACH.Text = "";

            //Preenchendo os campos para atualizar
            textBox_NOME_atualizar.Text = clienteRetorno.Nome;
            textBoxCPF_atualizar.Text = clienteRetorno.Cpf;
            textBox_EMAIL_atualizar.Text = clienteRetorno.Email;
            textBox_RG_atualizar.Text = clienteRetorno.Rg;
            textBox_Tel_atualizar.Text = clienteRetorno.Telefone;
            textBox_CNH_atualizar.Text = clienteRetorno.Cnh;
            textBox_RENACH_atualizar.Text = clienteRetorno.Renach;
            dateTimePicker_NASC_atualizar.Format = DateTimePickerFormat.Short;
            dateTimePicker_NASC_atualizar.Value = clienteRetorno.DtNascimento;
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            AtendimentoController control = new AtendimentoController(Startup.GetServiceProvider());
            Cliente clienteBusca = new Cliente();
            Cliente clienteRetorno = new Cliente();

            clienteBusca.Cpf = textBox_CPF_buscar.Text;

            clienteRetorno = control.BuscarCliente(clienteBusca);


            clienteRetorno.Nome = textBox_NOME_atualizar.Text;
            clienteRetorno.Cpf = textBoxCPF_atualizar.Text;
            clienteRetorno.Email = textBox_EMAIL_atualizar.Text;
            clienteRetorno.Rg = textBox_RG_atualizar.Text;
            clienteRetorno.Telefone = textBox_Tel_atualizar.Text;
            clienteRetorno.Cnh = textBox_CNH_atualizar.Text;
            clienteRetorno.DtNascimento = DateTime.Parse(dateTimePicker_NASC_atualizar.Text);
            clienteRetorno.Renach = textBox_RENACH_atualizar.Text;


            bool resultado = control.AtualizarCliente(clienteRetorno);

            // Verificar o resultado
            if (resultado)
            {
                MessageBox.Show("cliente atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o cliente.");
            }

            //Limpando o form
            textBox_NOME_atualizar.Text = "";
            textBoxCPF_atualizar.Text = "";
            textBox_EMAIL_atualizar.Text = "";
            textBox_RG_atualizar.Text = "";
            textBox_Tel_atualizar.Text = "";
            textBox_CNH_atualizar.Text = "";
            textBox_RENACH_atualizar.Text = "";
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            AtendimentoController control = new AtendimentoController(Startup.GetServiceProvider());
            Cliente clienteBusca = new Cliente();
            Cliente clienteRetorno = new Cliente();

            clienteBusca.Cpf = textBox_CPF_buscar.Text;

            clienteRetorno = control.BuscarCliente(clienteBusca);

            bool resultado = control.RemoverCliente(clienteRetorno);

            // Verificar o resultado
            if (resultado)
            {
                MessageBox.Show("cliente removido com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao remover o cliente.");
            }
        }
    }
}