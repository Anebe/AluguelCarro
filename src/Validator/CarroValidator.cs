using AluguelCarro.src.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Validator
{
    public class CarroValidator
    {
        public static bool Validar(Carro carro)
        {
            string messagem = "";

            if(carro.Marca == string.Empty)
            {
                messagem += "Marca é obrigatório";
            }
            if (carro.Modelo == string.Empty)
            {
                messagem += "Modelo é obrigatório";
            }
            if (carro.Placa == string.Empty)
            {
                messagem += "Placa é obrigatório";
            }
            if (carro.Valor_diaria <= 0M)
            {
                messagem += "Valor da diária é obrigatório";
            }

            if (messagem == string.Empty)
            {
                return true;
            }
            else
            {
                throw new ArgumentException(messagem);
            }
        }
    }
}
