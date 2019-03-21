using ClasificadorSH.Model;
//using ClasificadorSH.Form1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClasificadorSH.Controller
{
    public class SuperheroeController
    {
        public static List<SuperheroeModel> listado;

        public static  List<SuperheroeModel> creaLista()
        {
            listado = new List<SuperheroeModel>();
            listado.Add(new SuperheroeModel("iron-man", "pathimg1", "El  mejor"));
            listado.Add(new SuperheroeModel("Superman", "pathimg2", "EL más guapo"));
            listado.Add(new SuperheroeModel("Spiderrman", "pathimg3", "Superheroe ubicado en queens , "));
            //busqueda(listaSuperheroes);
            return listado;
        
        }

        public string filter { get; set; }

        
        public static List<SuperheroeModel> getModelsByNombre(string filter)
        {
            return SuperheroeController.listado.Where(c => c.nombre.Contains(filter)).ToList<SuperheroeModel>();
            
        }
            

    }
}
