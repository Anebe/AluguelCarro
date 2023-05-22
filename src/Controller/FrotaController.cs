using AluguelCarro.src.DTO;
using AluguelCarro.src.Interface;
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

        private ICrudService<Carro> _crudServiceCarro;
        private ICarroService _carroService;

        public FrotaController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _crudServiceCarro = _serviceProvider.GetRequiredService<ICrudService<Carro>>();
            _carroService = _serviceProvider.GetRequiredService<ICarroService>();
        }


        //CARRO MÉTODOS --------------------------------------------------------------
        public bool AdicionarCarro(Carro carro)
        {
            try
            {
                return _crudServiceCarro.Adicionar(carro);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool AtualizarCarro(Carro carro)
        {
            try
            {
                return _crudServiceCarro.Atualizar(carro);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public Carro BuscarCarro(int id)
        {
            try
            {
                return _crudServiceCarro.Buscar(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<Carro> BuscarCarro()
        {
            try
            {
                return _crudServiceCarro.Buscar();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool RemoverCarro(int id)
        {
            try
            {
                return _crudServiceCarro.Remover(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

    }
}
