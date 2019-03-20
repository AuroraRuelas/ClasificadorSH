using ClasificadorSH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasificadorSH.Controller
{
    class controller
    {
        public void creaLista()
        {
             List<Superheroe> listaSuperheroes = new List<Superheroe>();
            listaSuperheroes.Add(new Superheroe("iron-man", "pathimg1", "El  mejor"));
            listaSuperheroes.Add(new Superheroe("Superman", "pathimg2", "EL más guapo"));
            listaSuperheroes.Add(new Superheroe("Spiderrman", "pathimg3", "Superheroe ubicado en queens , "));
           
        }
       


        public busqueda(string super){
            
            
               // System.Diagnostics.Debug.WriteLine("No existe");
   
           
        }
    }
}
