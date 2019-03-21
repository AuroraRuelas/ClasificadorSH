using ClasificadorSH.Model;
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
            listado.Add(new SuperheroeModel("Spiderman", "pathimg3", "Superheroe ubicado en queens "));
            listado.Add(new SuperheroeModel("Cyclops", "pathimg4", "Pertenece al equipo X-Men, lanza rayos por los ojos"));
            listado.Add(new SuperheroeModel("Mystique", "pathimg6", "Ex miembro del equipo X-Men ahora villana aliada con Matgento"));
            //busqueda(listaSuperheroes);
            return listado;
        
        }
        
        public static List<SuperheroeModel> getModelsByNombre(string filter)
        {
            return SuperheroeController.listado.Where(c => c.nombre.ToUpper().Equals(filter.ToUpper())).ToList<SuperheroeModel>();
           
            
        }
            

    }
}
