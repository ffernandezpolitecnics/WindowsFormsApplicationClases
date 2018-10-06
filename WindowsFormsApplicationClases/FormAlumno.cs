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
    public partial class FormAlumno : Form
    {
        List<Alumno> clase = new List<Alumno>();

        public FormAlumno()
        {
            InitializeComponent();
        }

        private void refrescarLIstBox()
        {
            listBoxClase.DataSource = null;
            listBoxClase.DataSource = clase;
            listBoxClase.DisplayMember = "nombre";
            listBoxClase.ValueMember = "id";
        }

        private void buttonAnyadir_Click(object sender, EventArgs e)
        {
            Alumno alu = new Alumno();

            alu.id = int.Parse(textBoxIdAlumno.Text);
            alu.nombre = textBoxNombre.Text;
            alu.fechaNac = dateTimePickerFechaNac.Value;

            clase.Add(alu);

            refrescarLIstBox();

        }

        private void listBoxClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alumno alu = (Alumno) listBoxClase.SelectedItem;

            if (alu != null)
            {
                textBoxIdAlumno.Text = alu.id.ToString();
                textBoxNombre.Text = alu.nombre;
                dateTimePickerFechaNac.Value = alu.fechaNac;
                textBoxEdad.Text = alu.edad().ToString();
            }
            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Alumno alu = (Alumno)listBoxClase.SelectedItem;

            clase.Remove(alu);
            refrescarLIstBox();

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Alumno alu = (Alumno)listBoxClase.SelectedItem;

            alu.id = int.Parse(textBoxIdAlumno.Text);
            alu.nombre = textBoxNombre.Text;
            alu.fechaNac = dateTimePickerFechaNac.Value;

            refrescarLIstBox();
        }
    }
}
