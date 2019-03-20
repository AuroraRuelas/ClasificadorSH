using ClasificadorSH.Model;
using ClasificadorSH.Form1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClasificadorSH.Controller
{
    public class ControllerC
    {
        List<Superheroe> listaSuperheroes = new List<Superheroe>();

        public void creaLista()
        {
             
            listaSuperheroes.Add(new Superheroe("iron-man", "pathimg1", "El  mejor"));
            listaSuperheroes.Add(new Superheroe("Superman", "pathimg2", "EL más guapo"));
            listaSuperheroes.Add(new Superheroe("Spiderrman", "pathimg3", "Superheroe ubicado en queens , "));
            //busqueda(listaSuperheroes);
           
        }
        public string info { get; set; }
        public string palabra { get; set; }
        public string palabra1 { get; set; }
        public void busqueda(string palabra1)
        {
            //this.palabra = palabra;
            //info = 
            listaSuperheroes.Contains(palabra1);
           

        }
            
               // System.Diagnostics.Debug.WriteLine("No existe");
   
    }
}
