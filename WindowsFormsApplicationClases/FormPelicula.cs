using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationClases
{
    public partial class FormPelicula : Form
    {
        List<Pelicula> listaPeliculas = new List<Pelicula>();


        public FormPelicula()
        {
            InitializeComponent();
        }

        private void buttonAnyadir_Click(object sender, EventArgs e)
        {
            Pelicula peli = new Pelicula();



        }
    }
}
