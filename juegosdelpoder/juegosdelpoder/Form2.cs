using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace juegosdelpoder
{
    public partial class Form2 : Form
    {
        TiposPersonajes valor;
        List<String> datosLista = new List<string>();
        List<Personajes> jugadores = new List<Personajes>();
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1CreacionPJ_Click(object sender, EventArgs e)
        {
          
           TiposPersonajes mitipo = valordetipos(comboBox1.Text);
           Personajes nuevoPersonaje = new Personajes(mitipo,textboxnombre.Text,textBoxapodo.Text,fechaNac.Value);
            labeledad.Text = Convert.ToString(nuevoPersonaje.Edad);
            labelsalud.Text = Convert.ToString(nuevoPersonaje.Salud);
            labelvelocidad.Text = Convert.ToString(nuevoPersonaje.Velocidad);
            labeldestreza.Text = Convert.ToString(nuevoPersonaje.Destreza);
            llabelfuerza.Text = Convert.ToString(nuevoPersonaje.Fuerza);
            labelNivel.Text = Convert.ToString(nuevoPersonaje.Nivel);
            labelArmadura.Text = Convert.ToString(nuevoPersonaje.Armadura);
            jugadores.Add(nuevoPersonaje);
            datosLista.Add(fechaNac.Value+"<>"+textboxnombre.Text+ "<>"+textBoxapodo.Text+ "<>"+ Convert.ToString(mitipo));
            
            listBox1.DataSource = null;
            listBox1.DataSource = datosLista;
           
           
        }
       
        

        public TiposPersonajes valordetipos(string tipo)
        {
           

            if (string.Compare(tipo, "orco") == 0)
            {
                valor = TiposPersonajes.orco;
            }
            if (string.Compare(tipo, "humano") == 0)
            {
                valor = TiposPersonajes.humano;
            }
            if (string.Compare(tipo, "enano") == 0)
            {
                valor = TiposPersonajes.enano;
            }
            if (string.Compare(tipo,"elfo")==0)
                {
                valor = TiposPersonajes.elfo;
                }
            if (string.Compare(tipo, "drenei") == 0)
            {
                valor = TiposPersonajes.drenei;
            }
            if (string.Compare(tipo, "gnomo") == 0)
            {
                valor = TiposPersonajes.gnomo;
            }

            return valor;
        }
        private void Fecha_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             comboBox1.Items.Add(TiposPersonajes.drenei);
             comboBox1.Items.Add(TiposPersonajes.elfo);
             comboBox1.Items.Add(TiposPersonajes.enano);
             comboBox1.Items.Add(TiposPersonajes.gnomo);
             comboBox1.Items.Add(TiposPersonajes.humano);
             comboBox1.Items.Add(TiposPersonajes.orco);
             labeledad.Text = "0";
             labelsalud.Text = "0";
             labelvelocidad.Text = "0";
             llabelfuerza.Text = "0";
             labeldestreza.Text = "0";
             labelNivel.Text = "0";
             labelArmadura.Text = "0";
            
        }

        private void listBoxPersonajes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBatalla_Click(object sender, EventArgs e)
        {
            if (datosLista.Count>1)
            {
            Formbatalla batallaformu = new Formbatalla(jugadores);
            batallaformu.ShowDialog();
            this.Close();
            }
            else
            {
                MessageBox.Show("DEBE CREAR AL MENOS 2 JUGADORES");
            }
        }
    }
}
