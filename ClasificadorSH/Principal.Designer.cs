
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
            this.textBoxBusq = new System.Windows.Forms.TextBox();
            this.labelSuper = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeAll = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.rad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personajesFav = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.find = new System.Windows.Forms.Button();
            this.superheroeViewCard = new ClasificadorSH.Views.SuperheroeView();
            this.bottonFav = new RoundedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBusq
            // 
            this.textBoxBusq.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusq.Location = new System.Drawing.Point(690, 245);
            this.textBoxBusq.Name = "textBoxBusq";
            this.textBoxBusq.Size = new System.Drawing.Size(328, 34);
            this.textBoxBusq.TabIndex = 1;
            this.textBoxBusq.TextChanged += new System.EventHandler(this.textBoxBusq_TextChanged);
            // 
            // labelSuper
            // 
            this.labelSuper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSuper.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuper.Location = new System.Drawing.Point(332, 245);
            this.labelSuper.Name = "labelSuper";
            this.labelSuper.Size = new System.Drawing.Size(352, 44);
            this.labelSuper.TabIndex = 2;
            this.labelSuper.Text = "Introduce un nombre de superheroe:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.superheroeViewCard);
            this.panel1.Controls.Add(this.bottonFav);
            this.panel1.Controls.Add(this.removeAll);
            this.panel1.Controls.Add(this.remove);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.find);
            this.panel1.Controls.Add(this.labelSuper);
            this.panel1.Controls.Add(this.textBoxBusq);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1603, 884);
            this.panel1.TabIndex = 5;
            // 
            // removeAll
            // 
            this.removeAll.Location = new System.Drawing.Point(1217, 620);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(120, 53);
            this.removeAll.TabIndex = 11;
            this.removeAll.Text = "Remover todos";
            this.removeAll.UseVisualStyleBackColor = true;
            this.removeAll.Click += new System.EventHandler(this.removeAll_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(1217, 526);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(120, 53);
            this.remove.TabIndex = 10;
            this.remove.Text = "Remover";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rad,
            this.personajesFav});
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(337, 461);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(835, 383);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // find
            // 
            this.find.BackgroundImage = global::ClasificadorSH.Properties.Resources.lupa;
            this.find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.find.ImageKey = "(none)";
            this.find.Location = new System.Drawing.Point(1024, 240);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(58, 41);
            this.find.TabIndex = 8;
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // superheroeViewCard
            // 
            this.superheroeViewCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.superheroeViewCard.Location = new System.Drawing.Point(530, 326);
            this.superheroeViewCard.Name = "superheroeViewCard";
            this.superheroeViewCard.Size = new System.Drawing.Size(1073, 558);
            this.superheroeViewCard.TabIndex = 13;
            // 
            // bottonFav
            // 
            this.bottonFav.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bottonFav.BackgroundImage = global::ClasificadorSH.Properties.Resources.stra;
            this.bottonFav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottonFav.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bottonFav.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bottonFav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bottonFav.Location = new System.Drawing.Point(1261, 240);
            this.bottonFav.Name = "bottonFav";
            this.bottonFav.Size = new System.Drawing.Size(58, 53);
            this.bottonFav.TabIndex = 12;
            this.bottonFav.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1603, 884);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Buscador de Superheroes";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBusq;
        private System.Windows.Forms.Label labelSuper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button removeAll;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader rad;
        private System.Windows.Forms.ColumnHeader personajesFav;
        private RoundedButton bottonFav;
        private Views.SuperheroeView superheroeViewCard;

    }
}

