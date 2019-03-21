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
          
        }

        private void textBoxBusq_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                List<SuperheroeModel> listado = SuperheroeController.getModelsByNombre(textBoxBusq.Text);

                foreach (SuperheroeModel a in listado)
                {
                    System.Diagnostics.Debug.WriteLine(a.nombre.ToString());
                }




            }
            catch (Exception)
            {

            }
        }
          

    }
}
