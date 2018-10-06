namespace WindowsFormsApplicationClases
{
    partial class FormPelicula
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
            this.groupBoxPelicula = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAnyoEstreno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxTemas = new System.Windows.Forms.GroupBox();
            this.listBoxTemas = new System.Windows.Forms.ListBox();
            this.groupBoxPeliculas = new System.Windows.Forms.GroupBox();
            this.listBoxPeliculas = new System.Windows.Forms.ListBox();
            this.buttonAnyadir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.groupBoxPelicula.SuspendLayout();
            this.groupBoxTemas.SuspendLayout();
            this.groupBoxPeliculas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPelicula
            // 
            this.groupBoxPelicula.Controls.Add(this.groupBoxTemas);
            this.groupBoxPelicula.Controls.Add(this.textBoxAnyoEstreno);
            this.groupBoxPelicula.Controls.Add(this.label3);
            this.groupBoxPelicula.Controls.Add(this.textBoxDirector);
            this.groupBoxPelicula.Controls.Add(this.label2);
            this.groupBoxPelicula.Controls.Add(this.textBoxTitulo);
            this.groupBoxPelicula.Controls.Add(this.label1);
            this.groupBoxPelicula.Location = new System.Drawing.Point(13, 13);
            this.groupBoxPelicula.Name = "groupBoxPelicula";
            this.groupBoxPelicula.Size = new System.Drawing.Size(463, 421);
            this.groupBoxPelicula.TabIndex = 0;
            this.groupBoxPelicula.TabStop = false;
            this.groupBoxPelicula.Text = "Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(110, 38);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(334, 22);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(110, 66);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(334, 22);
            this.textBoxDirector.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Director";
            // 
            // textBoxAnyoEstreno
            // 
            this.textBoxAnyoEstreno.Location = new System.Drawing.Point(110, 94);
            this.textBoxAnyoEstreno.Name = "textBoxAnyoEstreno";
            this.textBoxAnyoEstreno.Size = new System.Drawing.Size(334, 22);
            this.textBoxAnyoEstreno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Año estreno";
            // 
            // groupBoxTemas
            // 
            this.groupBoxTemas.Controls.Add(this.listBoxTemas);
            this.groupBoxTemas.Location = new System.Drawing.Point(25, 136);
            this.groupBoxTemas.Name = "groupBoxTemas";
            this.groupBoxTemas.Size = new System.Drawing.Size(419, 279);
            this.groupBoxTemas.TabIndex = 6;
            this.groupBoxTemas.TabStop = false;
            this.groupBoxTemas.Text = "Temas";
            // 
            // listBoxTemas
            // 
            this.listBoxTemas.FormattingEnabled = true;
            this.listBoxTemas.ItemHeight = 16;
            this.listBoxTemas.Items.AddRange(new object[] {
            "Ciencia ficción",
            "Western",
            "Dibujos animados",
            "Acción",
            "Terror",
            "Fantasia",
            "Romántica",
            "Drama",
            "Comedia",
            "Aventuras",
            "Suspense"});
            this.listBoxTemas.Location = new System.Drawing.Point(6, 30);
            this.listBoxTemas.Name = "listBoxTemas";
            this.listBoxTemas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxTemas.Size = new System.Drawing.Size(407, 244);
            this.listBoxTemas.TabIndex = 0;
            // 
            // groupBoxPeliculas
            // 
            this.groupBoxPeliculas.Controls.Add(this.listBoxPeliculas);
            this.groupBoxPeliculas.Location = new System.Drawing.Point(492, 67);
            this.groupBoxPeliculas.Name = "groupBoxPeliculas";
            this.groupBoxPeliculas.Size = new System.Drawing.Size(365, 367);
            this.groupBoxPeliculas.TabIndex = 1;
            this.groupBoxPeliculas.TabStop = false;
            this.groupBoxPeliculas.Text = "Películas";
            // 
            // listBoxPeliculas
            // 
            this.listBoxPeliculas.FormattingEnabled = true;
            this.listBoxPeliculas.ItemHeight = 16;
            this.listBoxPeliculas.Location = new System.Drawing.Point(6, 21);
            this.listBoxPeliculas.Name = "listBoxPeliculas";
            this.listBoxPeliculas.Size = new System.Drawing.Size(353, 340);
            this.listBoxPeliculas.TabIndex = 0;
            // 
            // buttonAnyadir
            // 
            this.buttonAnyadir.Location = new System.Drawing.Point(498, 26);
            this.buttonAnyadir.Name = "buttonAnyadir";
            this.buttonAnyadir.Size = new System.Drawing.Size(149, 23);
            this.buttonAnyadir.TabIndex = 2;
            this.buttonAnyadir.Text = "Añadir";
            this.buttonAnyadir.UseVisualStyleBackColor = true;
            this.buttonAnyadir.Click += new System.EventHandler(this.buttonAnyadir_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(653, 26);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(198, 23);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar seleccionada";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // FormPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 446);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAnyadir);
            this.Controls.Add(this.groupBoxPeliculas);
            this.Controls.Add(this.groupBoxPelicula);
            this.Name = "FormPelicula";
            this.Text = "Película";
            this.groupBoxPelicula.ResumeLayout(false);
            this.groupBoxPelicula.PerformLayout();
            this.groupBoxTemas.ResumeLayout(false);
            this.groupBoxPeliculas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPelicula;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTemas;
        private System.Windows.Forms.ListBox listBoxTemas;
        private System.Windows.Forms.TextBox textBoxAnyoEstreno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxPeliculas;
        private System.Windows.Forms.ListBox listBoxPeliculas;
        private System.Windows.Forms.Button buttonAnyadir;
        private System.Windows.Forms.Button buttonEliminar;
    }
}