using Something.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Something
{
    public partial class Form1 : Form
    {
        private PersonajeDB personaje;
        private string[] razasDragonBall = {
            "Android",
            "Bio-Android",
             "Humana",
             "Humano",
             "Majin",
             "Namekuseijin",
             "Saiyajin",
             "Saiyajin/Humano",
             "Saiyajin/Saiyajin"
        };
        public Form1()
        {
            InitializeComponent();
            personaje = new PersonajeDB();
        }

        private void buttonPrueba_Click(object sender, EventArgs e)
        {
            if (personaje.ProbarConexion())
            {
                MessageBox.Show("Si");
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            DataTable dt = personaje.LeerPersonajes();
            dataGridViewPersonajes.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string raza = comboBoxRaza.Text;
            int nivelPoder = (int)numericUpDownNivelPoder.Value;
            string fecha = maskedTextBox1.Text;
            string historia = textBoxHistoria.Text;
            int respuesta = personaje.CrearPersonaje(nombre, raza, nivelPoder, fecha, historia);
            if (respuesta > 0)
            {
                MessageBox.Show("Creado con exito");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Algo hiciste mal");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxRaza.Items.AddRange(razasDragonBall);
        }

        private void BuscarPorID()
        {
            int idPersonajeBuscar = int.Parse(textBoxID.Text);
            DataTable personajeEncontrado = personaje.BuscarPersonajePorId(idPersonajeBuscar);
            if (personajeEncontrado.Rows.Count > 0)
            {
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                string date = personajeEncontrado.Rows[0]["fecha_creacion"].ToString();
                string historia = personajeEncontrado.Rows[0]["historia"].ToString();

                textBoxNombre.Text = nombre;
                comboBoxRaza.Text = raza;
                numericUpDownNivelPoder.Value = nivelPoder;
                textBoxHistoria.Text = historia;
                string mask = "00/00/0000";
                string[] dateComponents = date.Split('/');

                for (int i = 0; i < dateComponents.Length; i++)
                {
                    if (dateComponents[i].Length == 1)
                    {
                        dateComponents[i] = "0" + dateComponents[i];
                    }
                }
                string processedDateString = string.Join("/", dateComponents);
                StringBuilder maskedString = new StringBuilder();
                int stringIndex = 0;

                foreach (char maskChar in mask)
                {
                    if (maskChar == '0')
                    {
                        if (stringIndex < date.Length)
                        {
                            maskedString.Append(processedDateString[stringIndex]);
                            stringIndex++;
                        }
                        else
                        {
                           
                            maskedString.Append(" "); 
                        }
                    }
                    else
                    {
                        maskedString.Append(maskChar); 
                    }
                }

              
               maskedTextBox1.Text = maskedString.ToString();

            }

            else
            {
                MessageBox.Show("no se encontro");
            }
        }

            private void buttonBuscar_Click(object sender, EventArgs e)
            {
                BuscarPorID();
            }

            private void textBoxID_Leave(object sender, EventArgs e)
            {
                BuscarPorID();
            }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            int respuesta = personaje.BorrarPersonaje(id);
            if (respuesta > 0)
            {
                MessageBox.Show("Personaje Borrado");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Algo hiciste mal");
            }
        }

        private void comboBoxRaza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
