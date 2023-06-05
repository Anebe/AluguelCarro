using AluguelCarro.src.Controller;
using AluguelCarro.src.DTO;
using AluguelCarro.src.DTO.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelCarro.View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }

        List<Cliente> listaClientes = new List<Cliente>();
        List<Carro> listaCarros = new List<Carro>();

        Cliente cliente = new Cliente();
        Carro carro = new Carro();

        private void BtnAlugar_Click(object sender, EventArgs e)
        {

            AluguelVO aluguel = new AluguelVO();

            aluguel.Id_cliente = cliente.Id;
            aluguel.Cpf = cliente.Cpf;
            aluguel.Id_carro = carro.Id;
            aluguel.Placa = carro.Placa;
            aluguel.DataInicio = DateTime.Parse(dateTime_Entrega.Text);
            aluguel.DataFim = DateTime.Parse(dateTime_Devolucao.Text);
            //aluguel.Total = aluguel.calcular(carro);

            AtendimentoController control = new AtendimentoController(Startup.GetServiceProvider());
            
            // Verificar o resultado
            try
            {
                bool resultado = control.AdicionarAluguel(aluguel);
                if (resultado)
                {
                    MessageBox.Show("Carro alugado com sucesso!");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Erro ao alugar o carro.\n" + excep.Message);
            }
            

        }

        private void dataGridView_Clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int indiceLinha = e.RowIndex;

            cliente.Id = (int)dataGridView_Clientes.Rows[indiceLinha].Cells[0].Value;
            cliente.Nome = dataGridView_Clientes.Rows[indiceLinha].Cells[1].Value.ToString();
            cliente.Cpf = dataGridView_Clientes.Rows[indiceLinha].Cells[2].Value.ToString();
            cliente.Email = dataGridView_Clientes.Rows[indiceLinha].Cells[3].Value.ToString();
            cliente.Rg = dataGridView_Clientes.Rows[indiceLinha].Cells[4].Value.ToString();
            cliente.Telefone = dataGridView_Clientes.Rows[indiceLinha].Cells[5].Value.ToString();
            cliente.Cnh = dataGridView_Clientes.Rows[indiceLinha].Cells[6].Value.ToString();
            cliente.DtNascimento = (DateTime)dataGridView_Clientes.Rows[indiceLinha].Cells[7].Value;
            cliente.Renach = dataGridView_Clientes.Rows[indiceLinha].Cells[8].Value.ToString();

            MessageBox.Show("Cliente Escolhido");


        }

        private void dataGridView_Carro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int indiceLinha = e.RowIndex;

            carro.Id = (int)dataGridView_Carro.Rows[indiceLinha].Cells[0].Value;
            carro.Marca = dataGridView_Carro.Rows[indiceLinha].Cells[1].Value.ToString();
            carro.Modelo = dataGridView_Carro.Rows[indiceLinha].Cells[2].Value.ToString();
            carro.Placa = dataGridView_Carro.Rows[indiceLinha].Cells[3].Value.ToString();
            carro.Valor_diaria = (decimal)dataGridView_Carro.Rows[indiceLinha].Cells[4].Value;

            MessageBox.Show("Carro Escolhido");
        }

        private void BtnCarregarDados_Click(object sender, EventArgs e)
        {
            AtendimentoController control = new AtendimentoController(Startup.GetServiceProvider());

            
            listaClientes = control.BuscarClientes();
            listaCarros = control.BuscarCarroS();

            dataGridView_Clientes.DataSource = listaClientes;
            dataGridView_Carro.DataSource = listaCarros;

        }

        
    }
}
