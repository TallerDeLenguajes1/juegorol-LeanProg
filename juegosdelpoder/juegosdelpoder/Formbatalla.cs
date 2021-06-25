using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace juegosdelpoder
{
    public partial class Formbatalla : Form
    {
        public List<Personajes> _jugadores = new List<Personajes>(); //lista de personajes para recibirlos del form2
        public int b = 0; //bandera para iniciar la pelea
        public int playerAtack = 1;
        public int playerAtack2 = 1;
        public int cantidadAtaques = 0;//cantidad de ataques en total
        public Personajes jugador1, jugador2,ganador;//jugadores de la partida
        public int valorrandom, valorrandom2;//valores random para  determinar los jugadores
        public int contpeleas = 1;//contador de peleas
        public ListViewItem mostrarJugadores;

        public Formbatalla(List<Personajes> listapersonajes)
        {
            InitializeComponent();
            _jugadores.AddRange(listapersonajes);
            
        }

        private void Formbatalla_Load(object sender, EventArgs e)
        {
           
            for (int i=0; i<_jugadores.Count;i++)
            {
                
                mostrarJugadores = new ListViewItem(_jugadores[i].Nombre);
                mostrarJugadores.SubItems.Add(_jugadores[i].Apodo);
                mostrarJugadores.SubItems.Add(Convert.ToString(_jugadores[i].Salud));
                mostrarJugadores.SubItems.Add(Convert.ToString(_jugadores[i].Tipos));
                listView1.Items.Add(mostrarJugadores);
            }
            
            
             

        }

        private void label1Titulo_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridViewjugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonComenzar_Click(object sender, EventArgs e)
        {
            if (b==0 && _jugadores.Count>1) {
                b = 1;
                Jugar();
                buttonComenzar.Text = "Pelea " + Convert.ToString(contpeleas);
                contpeleas++;
                
            }
            else
            {
                buttonComenzar.Text = "FIN EnCUENTRO " ;
                MessageBox.Show("GANADOR DEL PODER ES!!!" + ganador.Apodo);
                label5Winner.Text = "Elganador es!!!!: "+ganador.Apodo;
            }

        }

        private void labelSaludjugador1_Click(object sender, EventArgs e)
        {

        }

        private void labelSaludJugador2_Click(object sender, EventArgs e)
        {

        }

        

        public void Jugar()
        {
                
            int cantidad = _jugadores.Count;

            if (cantidad > 1)
            {
                
                Random valor = new Random();
                do
                {


                    valorrandom = valor.Next(0, cantidad);
                    valorrandom2 = valor.Next(0, cantidad);

                } while (valorrandom == valorrandom2);

                jugador1 = _jugadores[valorrandom];
                jugador2 = _jugadores[valorrandom2];
                label2Apodo1.Text = jugador1.Apodo;
                labelSaludjugador1.Text = Convert.ToString(jugador1.Salud);
                labelapodo2.Text = jugador2.Apodo;
                labelSaludJugador2.Text = Convert.ToString(jugador2.Salud);

            }
            
           

        }

        private void listViewJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonjugador1_Click(object sender, EventArgs e)
        {
            
            if (cantidadAtaques<3 && b==1)
            {
                int saludpnj2=Pelea(jugador1,jugador2);
                cantidadAtaques++;
                labelDNTRj2.Text = Convert.ToString(jugador2.Salud - saludpnj2);
                jugador2.Salud = saludpnj2;
                labelSaludJugador2.Text = Convert.ToString(saludpnj2);
                buttonjugador1.Text = "Ataque"+Convert.ToString(playerAtack);
                playerAtack++;
            }


        }

        private void buttonAtaque2_Click(object sender, EventArgs e)
        {
            
            if (cantidadAtaques < 6 && b==1)
            {
                int saludpnj1 = Pelea(jugador2, jugador1);
                cantidadAtaques++;
                labelDTR1.Text = Convert.ToString(jugador1.Salud-saludpnj1);
                jugador1.Salud = saludpnj1;
                labelSaludjugador1.Text = Convert.ToString(saludpnj1);
                buttonAtaque2.Text = "Ataque"+Convert.ToString(playerAtack2);
                playerAtack2++;
            }
            if(cantidadAtaques==6)
            {
                cantidadAtaques = 0;
                playerAtack = 1;
                playerAtack2 = 1;
                b = 0;
                if (jugador1.Salud>jugador2.Salud)
                {
                    
                    MessageBox.Show("GANADOR DE LA RONDA " + jugador1.Apodo);
                    ganador = jugador1;
                    _jugadores.RemoveAt(valorrandom2);
                    //me falta borrar de la lista
                }
                else
                {
                    if(jugador1.Salud == jugador2.Salud)
                    {
                        MessageBox.Show("EMPATE");
                    }
                    else
                    {
                        MessageBox.Show("GANADOR DE LA RONDA " + jugador2.Apodo);
                        ganador = jugador2;
                        _jugadores.RemoveAt(valorrandom);
                    }
                   

                }

            }

        }

        public int Pelea(Personajes jugadoruno,Personajes jugadordos)
        {
            Random aleatorio = new Random();
            int mDP = 50000;
            //valor de ataque
            int poderDisparo = jugadoruno.Destreza * jugadoruno.Fuerza * jugadoruno.Nivel;
            int efectividadDisparo = aleatorio.Next(1,100);
            int valorDeAtaque = poderDisparo * efectividadDisparo;
            //valores de defensa
            int poderDefensa = jugadordos.Armadura * jugadordos.Velocidad;

            int danioProvocado= (((valorDeAtaque*efectividadDisparo)- poderDefensa)/mDP)*100;
            int nuevaSalud = jugadordos.Salud - danioProvocado;
 
            return nuevaSalud;
        }

    }
}
