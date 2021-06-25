using System;
using System.Collections.Generic;
using System.Text;

namespace juegosdelpoder
{
   
    public enum TiposPersonajes
    {
        orco,
        elfo,
        enano,
        humano,
        drenei,
        gnomo
    } 
    public class Personajes
    {
        //caracteristicas
        private string nombre;
        private string apodo;
        private TiposPersonajes tipos;
        private DateTime fecha;
        private int salud;
        private int edad;


        //datos
        private int fuerza;
        private int destreza;
        private int armadura;
        private int nivel;
        private int velocidad;

        
       
        
        public Personajes(TiposPersonajes tipos, string nombre, string apodo, DateTime fecha)
        {
            Random aleatorio = new Random();
            this.tipos = tipos;
            this.nombre = nombre;
            this.apodo = apodo;
            this.fecha = fecha;
            this.salud = 1000;
            this.velocidad = aleatorio.Next(1,15);
            this.destreza = aleatorio.Next(1,5);
            this.fuerza = aleatorio.Next(1,10);
            this.nivel = aleatorio.Next(1,10);
            this.armadura = aleatorio.Next(1, 10);
            this.edad = aleatorio.Next(0, 300);

        }


        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        internal TiposPersonajes Tipos { get => tipos; set => tipos = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Edad { get => edad; set => edad = value; }
       

       
       
    }
}
