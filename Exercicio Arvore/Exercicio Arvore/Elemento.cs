﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Arvore
{
    class Elemento
    {
        public Dados d;
        public Elemento prox;

        public Elemento (Dados d)
        {
            this.d = d;
            this.prox = null;
        }
    }
}
