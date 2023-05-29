using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DTO
{
    public class FilialDTO
    {
        private List<FuncionarioDTO> funcionarios;
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        

        public List<FuncionarioDTO> GetFuncionarios() { return funcionarios; }
        public void SetFuncionarios(List<FuncionarioDTO> funcionarios)
        {
            this.funcionarios = funcionarios;
        }
    }
}
