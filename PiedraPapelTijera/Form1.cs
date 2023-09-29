namespace PiedraPapelTijera
{
    public partial class Form1 : Form
    {
        // Variables fundamentales a declarar en este juego.

        string decisionJugador; // El jugador decide a su elección.
        string decisionOponente; // El oponente decide a su elección.
        string[] Opciones = { "R", "P", "S", "P", "S", "R" }; // Abreviaturas del juego en inglés (ROCK, PAPER AND SCISSORS, respectivamente).
        Random rand = new Random(); // Variable aleatoria.
        int puntuacionOponente; // Puntuación final del CPU.
        int puntuacionJugador; // Puntuación final del jugador.
        string empate; // Empate entre ambos jugadores.

        public Form1()
        {
            InitializeComponent();
        }

        private void EventoTomarDecisiones(object sender, EventArgs e)
        {
            // Evento en donde el jugador y el oponente tienen que tomar su decisión final.

            Button tempButton = sender as Button; // El jugador puede realizar cada acción manualmente con un botón.
            decisionJugador = (string)tempButton.Tag;

            int i = rand.Next(0, Opciones.Length); // El oponente realiza automáticamente su decisión sin realizar ninguna acción, ya que sólo actúa como una computadora.
            decisionOponente = Opciones[i];

            lblPlayer.Text = "USTED ESCOGIÓ: " + CargarTextoEImagen(decisionJugador, Jugador);
            lblCpu.Text = "SU RIVAL ESCOGIÓ: " + CargarTextoEImagen(decisionOponente, Rival);

            ChequearJuego();
        }

        private string CargarTextoEImagen(string texto, PictureBox imagen)
        {
            string letra = null; // Cada valor se le asigna a una letra de las opciones declaradas anteriormente.

            // Usaremos la iteración "switch" para clasificar letras con sentencias correspondientes.

            switch (texto)
            {
                case "R": // Si es una "R".
                    letra = "Piedra"; // Corresponde a la Piedra.
                    imagen.Image = Properties.Resources.ROCK;
                    break;

                case "P": // Si es una "P".
                    letra = "Papel"; // Corresponde al Papel.
                    imagen.Image = Properties.Resources.PAPER;
                    break;

                case "S": // Si es una "S".
                    letra = "Tijera"; // Corresponde a la Tijera.
                    imagen.Image = Properties.Resources.SCISSORS;
                    break;
            }

            return letra;
        }

        private void ChequearJuego()
        {
            // Con este método te permite revisar los resultados finales de cada jugador en general.

            // Usaremos una condición if para analizar los posibles resultados finales.

            if (decisionOponente == decisionJugador) // Si ganan entre ambos.
            {
                empate = "ES UN EMPATE!!!!"; // EMPATE.
            }

            // Si el oponente acierta, gana, en caso contrario gana 1 acierto para el jugador.

            else if (decisionJugador == "R" && decisionOponente == "P" || decisionJugador == "P" && decisionOponente == "S" || decisionJugador == "S" && decisionOponente == "R")
            {
                puntuacionOponente++; // El oponente acierta 1 punto por cada partida.
                empate = null; // No es un empate.
            }

            else
            {
                puntuacionJugador++; // El jugador acierta 1 punto por cada partida.
                empate = null; // No es un empate.
            }

            lblCpuResult.Text = "Puntuación del rival: " + puntuacionOponente + Environment.NewLine + empate; // Puntuación final del oponente.
            lblPlayerResult.Text = "Tu puntuación: " + puntuacionJugador + Environment.NewLine + empate; // Puntuación final del jugador.
        }
    }
}