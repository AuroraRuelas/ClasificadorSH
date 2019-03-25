using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasificadorSH.Model;
using ClasificadorSH.Controller;
using System.Drawing.Drawing2D;
namespace ClasificadorSH.Views
{
    public partial class SuperheroeView : UserControl
    {
        public SuperheroeView()
        {
            InitializeComponent();
           
          // this.nombrePersonaje.Text = "HOLA QUE TAL";
        }

        public void SuperheroeViewInfo(SuperheroeModel model)
        {
            this.Visible = true;
            this.nombrePersonaje.Text = model.nombre;
            Console.Write(model.nombre + " " + model.desc);
            this.pictureSuper.Image = SuperheroeController.getImageByName(model.nombre.ToUpper());
           //Cambiar este por otro metodo o cambiar el metodo getImageByName() para que regrese 2 bitmaps (uno de la imagen del personaje y otro de la carta de presentación)
           this.pictureBox1.Image = SuperheroeController.getImageByName(model.nombre.ToUpper());
            this.textBoxHistoria.Text = model.desc;
            this.richTextBoxFunFacts.Text = model.desc;
        }
    }
}
