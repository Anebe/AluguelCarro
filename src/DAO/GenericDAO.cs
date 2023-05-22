using AluguelCarro.src.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace AluguelCarro.src.DAO
{
    public class GenericDAO<T> : IGenericDAO<T> where T : class
    {
        private MySqlContext _dbContext;

        public GenericDAO()
        {
            _dbContext = new MySqlContext();
        }


        public bool Adicionar(T item)
        {
            try
            {
                _dbContext.Add(item);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Atualizar(T item)
        {
            try
            {
                _dbContext.Update(item);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<T> Buscar()
        {
            try
            {
                return _dbContext.Set<T>().ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public T Buscar(int id)
        {
            try
            {
                return _dbContext.Find<T>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Remover(T item)
        {
            try
            {
                return _dbContext.Remove(item) != null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
