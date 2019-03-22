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
using ClasificadorSH.Views;


namespace ClasificadorSH
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();


            // SuperheroeController controlador = new SuperheroeController();
            SuperheroeController.creaLista();

        }


       private void Form1_Load(object sender, EventArgs e)
         {
           

         }
   
       


        private void textBoxBusq_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listaFav in listView1.SelectedItems)
	        {
                listaFav.Remove();
	        }
       
        }

        private void removeAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void find_Click(object sender, EventArgs e)
        {
            try
            {
                List<SuperheroeModel> listado = SuperheroeController.getModelsByNombre(textBoxBusq.Text);


                if (listado.Any())
                {

                    foreach (SuperheroeModel a in listado)
                    {

                        SuperheroeModel model = SuperheroeController.getModelsByNombre(a.nombre.ToUpper()).First();

                        if (model.Equals(0))
                        {
                            
                        }
                        else
                        {
                            model = null;
                        }
                        /*
                        textBoxHistoria.Text = a.nombre + ": " + a.desc;
                        pictureSuper.Name = a.img;
                        pictureSuper.Image = SuperheroeController.getImageByName(a.nombre.ToUpper());

                        */
                    }

                }
                else
                {
                    //this.textBoxHistoria.Text = "No se encontró nada";
                }



            }
            catch (Exception)
            {
                Console.WriteLine("Superheroe no encontrado");
            }
        }


    }
    
}
