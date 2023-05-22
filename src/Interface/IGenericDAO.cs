﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Interface
{
    public interface IGenericDAO<T> where T : class
    {
        public bool Adicionar(T item);
        public bool Atualizar(T item);
        public bool Remover(T item);
        public List<T> Buscar();
        public T Buscar(int id);
    }
}