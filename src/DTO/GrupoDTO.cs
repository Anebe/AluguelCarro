﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.DTO
{
    public class GrupoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}
