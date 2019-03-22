using ClasificadorSH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


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
            listado.Add(new SuperheroeModel("Test", "pathimg7", "prueba de bitmap vacio"));

            return listado;
        
        }
        
        public static List<SuperheroeModel> getModelsByNombre(string filter)
        {
            return SuperheroeController.listado.Where(c => c.nombre.ToUpper().Equals(filter.ToUpper())).ToList<SuperheroeModel>();
           
            
        }


        public static Bitmap getImageByName(string superheroeABuscar)
        {
            //Define variable a devolver
            Bitmap bitmap = null;

            switch (superheroeABuscar)
            {
                case "IRON-MAN":
                   bitmap =  global::ClasificadorSH.Properties.Resources.ironman;

                    break;

                case "SUPERMAN":
                    bitmap = global::ClasificadorSH.Properties.Resources.superman;

                    break;

                case "SPIDERMAN":
                    bitmap = global::ClasificadorSH.Properties.Resources.spiderman1;

                    break;

                case "CYCLOPS":
                    bitmap = global::ClasificadorSH.Properties.Resources.cyclops;

                    break;

                case "MYSTIQUE":
                    bitmap = global::ClasificadorSH.Properties.Resources.mystique;

                    break;

                case "TEST":
                   

                    break;



            }
            if (bitmap==null)
            {
                bitmap = global::ClasificadorSH.Properties.Resources.no_image_available;
           }
            return  bitmap;
        }
            

    }
}
