using ClasificadorSH.Controller;
namespace ClasificadorSH
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxBusq = new System.Windows.Forms.TextBox();
            this.labelSuper = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.pictureSuper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSuper)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBusq
            // 
            this.textBoxBusq.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusq.Location = new System.Drawing.Point(292, 41);
            this.textBoxBusq.Name = "textBoxBusq";
            this.textBoxBusq.Size = new System.Drawing.Size(186, 21);
            this.textBoxBusq.TabIndex = 1;
            this.textBoxBusq.TextChanged += new System.EventHandler(this.textBoxBusq_TextChanged);
            // 
            // labelSuper
            // 
            this.labelSuper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSuper.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuper.Location = new System.Drawing.Point(12, 39);
            this.labelSuper.Name = "labelSuper";
            this.labelSuper.Size = new System.Drawing.Size(271, 22);
            this.labelSuper.TabIndex = 2;
            this.labelSuper.Text = "Introduce un nombre de superheroe:";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxInfo.Enabled = false;
            this.textBoxInfo.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxInfo.Location = new System.Drawing.Point(240, 112);
            this.textBoxInfo.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(270, 245);
            this.textBoxInfo.TabIndex = 4;
            // 
            // pictureSuper
            // 

            this.pictureSuper.Location = new System.Drawing.Point(12, 112);
            this.pictureSuper.Name = "pictureSuper";
            this.pictureSuper.Size = new System.Drawing.Size(204, 245);
            this.pictureSuper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSuper.TabIndex = 3;
            this.pictureSuper.TabStop = false;
            this.pictureSuper.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 441);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.pictureSuper);
            this.Controls.Add(this.labelSuper);
            this.Controls.Add(this.textBoxBusq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Buscador de Superheroes";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            ((System.ComponentModel.ISupportInitialize)(this.pictureSuper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBusq;
        private System.Windows.Forms.Label labelSuper;
        private System.Windows.Forms.PictureBox pictureSuper;
        private System.Windows.Forms.TextBox textBoxInfo;

    }
}

