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
            
           


        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string super { get; set; }
        public string info { get; set; }
        private void busqueda(object sender, EventArgs e)
        {
            super = textBoxBusq.Text;

            info = listaSuperheroes.FindAll(super);
          
        }

      
    }
}
