﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneAluguel.Entity
{

    public class Funcionario : Pessoa
    {
        public int Id { get; private set; }
        public string Cargo { get; set; }
        public decimal Salario { get; private set; }
        public DateTime DataContratacao { get; set; }
        public int Filial_id { get; set; }
    }
}
