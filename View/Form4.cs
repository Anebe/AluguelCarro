using AluguelCarro.src.Controller;
using AluguelCarro.src.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelCarro.View
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAluguel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCadastrarCarro_Click(object sender, EventArgs e)
        {
            AtendimentoController control = new AtendimentoController(Startup.GetServiceProvider());
            Carro carro = new Carro();

            decimal valor_diaria = decimal.Parse(textBox_VALOR_DIARIA.Text, CultureInfo.InvariantCulture);

            carro.Marca = textBox_MARCA.Text;
            carro.Modelo = textBox_MODELO.Text;
            carro.Placa = textBox_PLACA.Text;
            carro.Valor_diaria = valor_diaria;

            /*
            carro.Marca = "A";
            carro.Modelo = "B";
            carro.Placa = "R3H82-4U";
            carro.Valor_diaria = 120.40M;
            */

            bool resultado = control.AdicionarCarro(carro);

            // Verificar o resultado
            if (resultado)
            {
                MessageBox.Show("carro adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao adicionar o carro.");
            }
        }

        private void BtnBuscarPlaca_Click(object sender, EventArgs e)
        {
            AtendimentoController control = new AtendimentoController(Startup.GetServiceProvider());
            Carro carroBusca = new Carro();
            Carro carroRetorno = new Carro();

            carroBusca.Placa = textBox_PLACA_buscar.Text;

            MessageBox.Show(carroBusca.Placa);

            carroRetorno = control.BuscarCarro(carroBusca);

            MessageBox.Show(carroRetorno.Placa);

            //Limpando o form
            textBox_MARCA.Text = "";
            textBox_MODELO.Text = "";
            textBox_PLACA.Text = "";
            textBox_VALOR_DIARIA.Text = "";

            //Preenchendo os campos para atualizar
            textBox_MARCA_atualizar.Text = carroRetorno.Marca;
            textBox_MODELO_atualizar.Text = carroRetorno.Modelo;
            textBox_PLACA_atualizar.Text = carroRetorno.Placa;
            textBox_VALOR_DIARIA_atualizar.Text = carroRetorno.Valor_diaria.ToString();
        }

        private void BtnAtualizarCarro_Click(object sender, EventArgs e)
        {
            AtendimentoController control = new AtendimentoController(Startup.GetServiceProvider());
            Carro carroBusca = new Carro();
            Carro carroRetorno = new Carro();

            carroBusca.Placa = textBox_PLACA_buscar.Text;

            carroRetorno = control.BuscarCarro(carroBusca);


            carroRetorno.Marca = textBox_MARCA_atualizar.Text;
            carroRetorno.Modelo = textBox_MODELO_atualizar.Text;
            carroRetorno.Placa = textBox_PLACA_atualizar.Text;
            carroRetorno.Valor_diaria = decimal.Parse(textBox_VALOR_DIARIA.Text);


            bool resultado = control.AtualizarCarro(carroRetorno);

            // Verificar o resultado
            if (resultado)
            {
                MessageBox.Show("carro atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o carro.");
            }

            //Limpando o form
            textBox_MARCA_atualizar.Text = "";
            textBox_MODELO_atualizar.Text = "";
            textBox_PLACA_atualizar.Text = "";
            textBox_VALOR_DIARIA_atualizar.Text = "";
        }

        private void BtnExcluirCarro_Click(object sender, EventArgs e)
        {
            AtendimentoController control = new AtendimentoController(Startup.GetServiceProvider());
            Carro carroBusca = new Carro();
            Carro carroRetorno = new Carro();

            carroBusca.Placa = textBox_PLACA_buscar.Text;

            carroRetorno = control.BuscarCarro(carroBusca);

            bool resultado = control.RemoverCarro(carroRetorno);

            // Verificar o resultado
            if (resultado)
            {
                MessageBox.Show("carro removido com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao remover o carro.");
            }
        }

        private void BtnBuscarAluguelCarro_Click(object sender, EventArgs e)
        {
            AtendimentoController control = new AtendimentoController(Startup.GetServiceProvider());
            Carro carroBusca = new Carro();
            Carro carroRetorno = new Carro();
            Aluguel aluguelBusca = new Aluguel();
            Aluguel aluguelRetorno = new Aluguel();

            carroBusca.Placa = textBox_ALUGUEL_PLACA_buscar.Text;

            carroRetorno = control.BuscarCarro(carroBusca);

            aluguelBusca.SetCarro(carroRetorno);

            aluguelRetorno = control.BuscarAluguel(aluguelBusca);

            //Preenchendo os campos para atualizar
            textBox_ID_carro.Text = aluguelRetorno.Id_carro.ToString();
            textBox_ID_cliente.Text = aluguelRetorno.Id_cliente.ToString();
            textBox_dataInicio.Text = aluguelRetorno.DtInicio.ToString();
            textBox_dataFim.Text = aluguelRetorno.DtFim.ToString();
            textBox_total.Text = aluguelRetorno.Total.ToString();
        }

        private void BtnBuscarAluguelCpf_Click(object sender, EventArgs e)
        {
            AtendimentoController control = new AtendimentoController(Startup.GetServiceProvider());
            Cliente clienteBusca = new Cliente();
            Cliente clienteRetorno = new Cliente();
            Aluguel aluguelBusca = new Aluguel();
            Aluguel aluguelRetorno = new Aluguel();

            clienteBusca.Cpf = textBox_ALUGUEL_CPF_bucar.Text;

            clienteRetorno = control.BuscarCliente(clienteBusca);

            aluguelBusca.SetCliente(clienteRetorno);

            aluguelRetorno = control.BuscarAluguel(aluguelBusca);

            //Preenchendo os campos para atualizar
            textBox_ID_carro.Text = aluguelRetorno.Id_carro.ToString();
            textBox_ID_cliente.Text = aluguelRetorno.Id_cliente.ToString();
            textBox_dataInicio.Text = aluguelRetorno.DtInicio.ToString();
            textBox_dataFim.Text = aluguelRetorno.DtFim.ToString();
            textBox_total.Text = aluguelRetorno.Total.ToString();
        }
    }
}
