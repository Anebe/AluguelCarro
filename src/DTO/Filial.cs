using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DTO
{
    public class Filial
    {
        private List<Funcionario> funcionarios;
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        

        public List<Funcionario> GetFuncionarios() { return funcionarios; }
        public void SetFuncionarios(List<Funcionario> funcionarios)
        {
            this.funcionarios = funcionarios;
        }
    }
}
