﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo04.Escola.Models
{
    public class Professor: Pessoa
    {
        //Composicao
        public List<Materia> Materias { get; set; }
    }
}
