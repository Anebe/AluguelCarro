﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Entity
{
    internal class Login
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public Funcionario Funcionario{ get; set; }
    }
}
