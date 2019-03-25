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
using System.Drawing.Drawing2D;


namespace ClasificadorSH
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
           

            SuperheroeController.creaLista();
           
        }
        void bottonFav_Click(Object sender, System.EventArgs e)
        {
           
        }

       private void Form1_Load(object sender, EventArgs e)
         {
           

         }
   
              
       

        private void textBoxBusq_TextChanged(object sender, EventArgs e)
        {
            this.textBoxBusq.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.textBoxBusq.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TextBox t = sender as TextBox;
            if (t != null)
            {
                if (t.Text.Length >= 2)
                {
                   
                   // string[] arr = SuperheroeController.getListNombres();

                    AutoCompleteStringCollection collectionNombres = new AutoCompleteStringCollection();
                    collectionNombres.AddRange(SuperheroeController.getListNombres());
                    this.textBoxBusq.AutoCompleteCustomSource = collectionNombres;
                }
            }

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
                        Console.Write("nombre desde el modelo: "+ model.nombre);

                        if (!(model.Equals(null)))
                        {
                            SuperheroeView superHView = new SuperheroeView();
                            //Agregar cambio a SuperheroeView 
                            Console.Write("Entra if");
                            //NO FUNCIONA !!!!!!!!!!!!
                            superHView.SuperheroeViewInfo(model);
                            panel1.Visible = false;   
                            superheroeViewCard.Visible = true;
                            Console.Write("Visibilidad de SuperheroeView : "+superheroeViewCard.Visible);
                        }
                        else
                        {
                            model = null;
                            MessageBox.Show("SuperHeroe no encontrado");

                        }
                      
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

class RoundedButton : Button
{
    GraphicsPath GetRoundPath(RectangleF Rect, int radius)
    {
        float r2 = radius / 2f;
        GraphicsPath GraphPath = new GraphicsPath();

        GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
        GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
        GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
        GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
        GraphPath.AddArc(Rect.X + Rect.Width - radius,
                         Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
        GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
        GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
        GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

        GraphPath.CloseFigure();
        return GraphPath;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
        GraphicsPath GraphPath = GetRoundPath(Rect, 55);

        this.Region = new Region(GraphPath);
        using (Pen pen = new Pen(Color.Black, 1.7f))
        {
            pen.Alignment = PenAlignment.Inset;
            e.Graphics.DrawPath(pen, GraphPath);
        }
    }
}
