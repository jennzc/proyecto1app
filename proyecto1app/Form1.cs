using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1app
{
    public partial class Form1 : Form
    {
        // variables globales para la operación matemática
        float num1, num2, resultado;
        char operador;

        // genera numeros aleatorios para las operaciones
        Random aleatorio = new Random();

        int errores = 0;
        int aciertos = 0;
        int nivel = 1;
        int N = 10;

        // Estadisticas
        string[] nombres = new string[50];
        int[] puntajes = new int[50];
        int posicion = 0;

        // nombres de los jugadores y sus puntajes
        string jugador1;
        string jugador2;

        int puntosj1 = 0;
        int puntosj2 = 0;

        // control de turnos para el juego de dos jugadores
        int turno = 1;


        public Form1()
        {
            InitializeComponent();
        }

        public void GenerarOperacion()
        {
            if (aciertos == 3)
            {
                MessageBox.Show("¡Felicidades! Has pasado al nivel 2.");
            }
            if (aciertos == 6)
            {
                MessageBox.Show("¡Felicidades! Has pasado al nivel 3.");
            }
            // cambio de dificultad según el número de aciertos
            if (aciertos >= 3 && aciertos < 6)
            { 
                nivel = 2;
                N = 101; // rango de números del 1 al 100
            }
            else if (aciertos >= 6)
            {
                nivel = 3;
                N = 1001; // rango de números del 1 al 1000
            }
            else
            {
                nivel = 1;
                N = 11; // rango de números del 1 al 10
            }

            num1 = aleatorio.Next(1, N);
            num2 = aleatorio.Next(1, N);

            int op = aleatorio.Next(1, 5);

            switch (op)
            {
                case 1:
                    operador = '+';
                    resultado = num1 + num2;
                    break;
                case 2:
                    operador = '-';
                    resultado = num1 - num2;
                    break;
                case 3:
                    operador = '*';
                    resultado = num1 * num2;
                    break;
                case 4:
                    operador = '/';
                    resultado = (float)Math.Round(num1 / num2, 2); // redondear a 2 decimales
                    break;
            }

            // muestar la operación en los labels correspondientes
            lnum1.Text = num1.ToString();
            loperador.Text = operador.ToString();
            lnum2.Text = num2.ToString();

            // actualiza los labels de nivel, aciertos y errores
            lnivel.Text = nivel.ToString();
            laciertos.Text = aciertos.ToString();
            lerrores.Text = errores.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // boton verificar
        {
            float respuesta;

            if (!float.TryParse(trespuesta.Text, out respuesta)) // Validar que la respuesta ingresada sea un número válido
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
                return;
            }
            if (Math.Round(respuesta, 2) == resultado) // comparar la respuesta con el resultado correcto
            {
                aciertos++;

                if (rdosjugadores.Checked) // si es un juego de dos jugadores, se asigna el punto al jugador correspondiente
                {
                    if (turno == 1)
                    {
                        puntosj1++;
                    }
                    else
                    {
                        puntosj2++;
                    }
                }

                MessageBox.Show("¡Correcto!");
            }
            else
            {
                errores++;
                MessageBox.Show("Incorrecto. La respuesta correcta es: " + resultado);
            }

            // actualizar los labels de nivel, aciertos y errores
            lnivel.Text = nivel.ToString();
            laciertos.Text = aciertos.ToString();
            lerrores.Text = errores.ToString();

            if (errores >= 3) // si se llega a 3 errores se termina el juego
            {
                // guardar el nombre del jugador y su puntaje en los arreglos de estadísticas
                nombres[posicion] = tnombre.Text;
                puntajes[posicion] = aciertos;
                lstestadisticas.Items.Add(nombres[posicion] + " - " + puntajes[posicion] + " puntos");
                posicion++;

                // si se juega con dos jugadores, se determina el ganador según los puntajes
                if (rdosjugadores.Checked)
                {
                    if (puntosj1 > puntosj2)
                    {
                        MessageBox.Show("Ganador: " + jugador1);
                    }
                    else if (puntosj2 > puntosj1)
                    {
                        MessageBox.Show("Ganador: " + jugador2);
                    }
                    else
                    {
                        MessageBox.Show("Empate");
                    }
                }
                MessageBox.Show("Has perdido el juego.");
                biniciar.Enabled = true;
                bverificar.Enabled = false;
                return;
            }

            // cambiar de turno si es un juego de dos jugadores
            if (rdosjugadores.Checked)
            {
                if (turno == 1)
                {
                    turno = 2;
                    MessageBox.Show("Turno de " + jugador2);
                }
                else
                {
                    turno = 1;
                    MessageBox.Show("Turno de " + jugador1);
                }
            }

            // esto limpia la caja de texto de respuesta y generar una nueva operación
            trespuesta.Clear();
            GenerarOperacion();
        }

        private void biniciar_Click(object sender, EventArgs e) // boton iniciar
        {
            if (tnombre.Text == "") // Validar que se ingrese el nombre del jugador
            {
                MessageBox.Show("Por favor, ingrese el nombre del jugador.");
                return;
            }

            if (rdosjugadores.Checked) // Validar que se ingresen los nombres de ambos jugadores si es un juego de dos jugadores
            {
                if (tnombre.Text == "" || tnombre2.Text == "")
                {
                    MessageBox.Show("Ingrese los nombres de ambos jugadores.");
                    return;
                }

                jugador1 = tnombre.Text;
                jugador2 = tnombre2.Text;

                puntosj1 = 0;
                puntosj2 = 0;
                turno = 1;

                MessageBox.Show("Empieza el turno de " + jugador1);
            }

            // se llama el método para generar la primera operación
            GenerarOperacion();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) // evento que se ejecuta al cargar el formulario
        {
            lnivel.Text = "1"; // inicializa el nivel en 1
            laciertos.Text = "0"; // inicializa los aciertos en 0
            lerrores.Text = "0"; // inicializa los errores en 0
        }
    }
}