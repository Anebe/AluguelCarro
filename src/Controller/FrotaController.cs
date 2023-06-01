using AluguelCarro.src.DTO;
using AluguelCarro.src.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Controller
{
    internal class FrotaController
    {
        private IServiceProvider _serviceProvider;
        private ICarroService _carroService;

        public FrotaController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _carroService = _serviceProvider.GetRequiredService<ICarroService>();
        }


        //CARRO MÉTODOS --------------------------------------------------------------
        public bool AdicionarCarro(CarroDTO carro)
        {
            try
            {
                return _carroService.Adicionar(carro);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool AtualizarCarro(CarroDTO carro)
        {
            try
            {
                return _carroService.Atualizar(carro);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public CarroDTO BuscarCarro(CarroDTO carro)
        {
            try
            {
                return _carroService.BuscarUnico(carro);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<CarroDTO> BuscarCarroS()
        {
            try
            {
                return _carroService.BuscarVarios();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool RemoverCarro(CarroDTO carro)
        {
            try
            {
                return _carroService.Remover(carro);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

    }
}
