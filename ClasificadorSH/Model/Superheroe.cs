﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasificadorSH.Model
{
    public class Superheroe
    {
        public string nombre { get; set; }
        public string img { get; set; }
        public string desc { get; set; }

        public Superheroe(string nombre,string img, string desc)
        {
            this.nombre = nombre;
            this.img = img;
            this.desc = desc;
        }


    }
}
