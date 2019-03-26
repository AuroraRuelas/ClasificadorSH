
using System.Windows.Forms;
namespace ClasificadorSH
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.gradientPanelB1 = new ClasificadorSH.Views.GradientPanelB();
            this.listFav = new System.Windows.Forms.ListView();
            this.rad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personajesFav = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeAll = new System.Windows.Forms.Button();
            this.textBoxBusq = new System.Windows.Forms.TextBox();
            this.remove = new System.Windows.Forms.Button();
            this.labelSuper = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Button();
            this.gradientPanelB2 = new ClasificadorSH.Views.GradientPanelB();
            this.superheroeViewCard = new ClasificadorSH.Views.SuperheroeView();
            this.gradientPanelB1.SuspendLayout();
            this.gradientPanelB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanelB1
            // 
            this.gradientPanelB1.ColorBottom = System.Drawing.Color.LightSeaGreen;
            this.gradientPanelB1.ColorTop = System.Drawing.Color.PaleTurquoise;
            this.gradientPanelB1.Controls.Add(this.listFav);
            this.gradientPanelB1.Controls.Add(this.removeAll);
            this.gradientPanelB1.Controls.Add(this.textBoxBusq);
            this.gradientPanelB1.Controls.Add(this.remove);
            this.gradientPanelB1.Controls.Add(this.labelSuper);
            this.gradientPanelB1.Controls.Add(this.find);
            this.gradientPanelB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelB1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelB1.Name = "gradientPanelB1";
            this.gradientPanelB1.Size = new System.Drawing.Size(1603, 884);
            this.gradientPanelB1.TabIndex = 14;
            // 
            // listFav
            // 
            this.listFav.CheckBoxes = true;
            this.listFav.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rad,
            this.personajesFav});
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.listFav.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listFav.Location = new System.Drawing.Point(294, 397);
            this.listFav.Name = "listFav";
            this.listFav.Size = new System.Drawing.Size(835, 383);
            this.listFav.TabIndex = 9;
            this.listFav.UseCompatibleStateImageBehavior = false;
            this.listFav.View = System.Windows.Forms.View.Details;
            // 
            // rad
            // 
            this.rad.Text = "";
            // 
            // personajesFav
            // 
            this.personajesFav.Text = "Personajes Favoritos";
            this.personajesFav.Width = 758;
            // 
            // removeAll
            // 
            this.removeAll.Location = new System.Drawing.Point(1207, 607);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(120, 53);
            this.removeAll.TabIndex = 11;
            this.removeAll.Text = "Remover todos";
            this.removeAll.UseVisualStyleBackColor = true;
            this.removeAll.Click += new System.EventHandler(this.removeAll_Click);
            // 
            // textBoxBusq
            // 
            this.textBoxBusq.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBoxBusq.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusq.Location = new System.Drawing.Point(635, 136);
            this.textBoxBusq.Name = "textBoxBusq";
            this.textBoxBusq.Size = new System.Drawing.Size(412, 34);
            this.textBoxBusq.TabIndex = 1;
            this.textBoxBusq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBusq_KeyUp);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(1207, 476);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(120, 53);
            this.remove.TabIndex = 10;
            this.remove.Text = "Remover";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // labelSuper
            // 
            this.labelSuper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSuper.BackColor = System.Drawing.Color.Transparent;
            this.labelSuper.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuper.Location = new System.Drawing.Point(266, 139);
            this.labelSuper.Name = "labelSuper";
            this.labelSuper.Size = new System.Drawing.Size(536, 73);
            this.labelSuper.TabIndex = 2;
            this.labelSuper.Text = "Introduce un nombre de superheroe:";
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.Transparent;
            this.find.BackgroundImage = global::ClasificadorSH.Properties.Resources.lupa;
            this.find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.find.ImageKey = "(none)";
            this.find.Location = new System.Drawing.Point(1071, 129);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(58, 41);
            this.find.TabIndex = 8;
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // gradientPanelB2
            // 
            this.gradientPanelB2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gradientPanelB2.ColorBottom = System.Drawing.Color.LightSeaGreen;
            this.gradientPanelB2.ColorTop = System.Drawing.Color.PaleTurquoise;
            this.gradientPanelB2.Controls.Add(this.superheroeViewCard);
            this.gradientPanelB2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelB2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelB2.Name = "gradientPanelB2";
            this.gradientPanelB2.Size = new System.Drawing.Size(1603, 884);
            this.gradientPanelB2.TabIndex = 15;
            // 
            // superheroeViewCard
            // 
            this.superheroeViewCard.BackColor = System.Drawing.Color.Transparent;
            this.superheroeViewCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.superheroeViewCard.Location = new System.Drawing.Point(93, 0);
            this.superheroeViewCard.Name = "superheroeViewCard";
            this.superheroeViewCard.Size = new System.Drawing.Size(1359, 998);
            this.superheroeViewCard.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1603, 884);
            this.Controls.Add(this.gradientPanelB1);
            this.Controls.Add(this.gradientPanelB2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Buscador de Superheroes";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gradientPanelB1.ResumeLayout(false);
            this.gradientPanelB1.PerformLayout();
            this.gradientPanelB2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBusq;
        private System.Windows.Forms.Label labelSuper;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button removeAll;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.ListView listFav;
        private System.Windows.Forms.ColumnHeader rad;
        private System.Windows.Forms.ColumnHeader personajesFav;
        private Views.SuperheroeView superheroeViewCard;
        private Views.GradientPanelB gradientPanelB1;
        private Views.GradientPanelB gradientPanelB2;

    }
}

