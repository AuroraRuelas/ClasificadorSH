using ClasificadorSH.Controller;
using ClasificadorSH.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClasificadorSH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            // SuperheroeController controlador = new SuperheroeController();
            SuperheroeController.creaLista();

        }


        /* private void Form1_Load(object sender, EventArgs e,)
         {

         }
   
        */


        private void textBoxBusq_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<SuperheroeModel> listado = SuperheroeController.getModelsByNombre(textBoxBusq.Text);


                if (listado.Any())
                {
                    foreach (SuperheroeModel a in listado)
                    {
                        textBoxInfo.Text = a.nombre + ": " + a.desc;
                        pictureSuper.Name = a.img;
                        //Console.WriteLine(a.nombre);
                        //Console.WriteLine(pictureSuper.Name);
                        switch (a.nombre.ToUpper())
                        {
                            case "IRON-MAN":
                                pictureSuper.Image = global::ClasificadorSH.Properties.Resources.ironman;
                                 
                                    break;

                            case "SUPERMAN":
                                 pictureSuper.Image = global::ClasificadorSH.Properties.Resources.superman;
   
                                 break;

                            case "SPIDERMAN":
                                 pictureSuper.Image = global::ClasificadorSH.Properties.Resources.spiderman1;
  
                                 break;
                            case "CYCLOPS":
                                 pictureSuper.Image = global::ClasificadorSH.Properties.Resources.cyclops;
 
                                 break;
                            case "MYSTIQUE":
                                 pictureSuper.Image = global::ClasificadorSH.Properties.Resources.mystique;

                                 break;


                        }
                       
                     
                    }

                }
                else
                {
                    this.textBoxInfo.Text = "No se encontró nada";
                }
                


            }
            catch (Exception)
            {
                Console.WriteLine("Superheroe no encontrado");
            }
        }

    }
    
}
