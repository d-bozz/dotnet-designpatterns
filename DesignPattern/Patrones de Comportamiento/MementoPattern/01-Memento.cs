﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patrones_de_Comportamiento.MementoPattern
{
    public class Memento
    {
        private string _estado;

        public Memento(){}

        public Memento(string estado)
        {
            _estado = estado;
        }

        public string Estado
        {
            get
            {
                return _estado;
            }
        }

    }
}
