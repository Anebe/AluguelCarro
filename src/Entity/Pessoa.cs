﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneAluguel.Entity
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
    }
}