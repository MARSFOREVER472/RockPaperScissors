namespace PiedraPapelTijera
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Jugador = new PictureBox();
            Rival = new PictureBox();
            lblCpu = new Label();
            lblPlayer = new Label();
            lblPlayerResult = new Label();
            lblCpuResult = new Label();
            ((System.ComponentModel.ISupportInitialize)Jugador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rival).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(100, 375);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 0;
            button1.Text = "Piedra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += EventoTomarDecisiones;
            // 
            // button2
            // 
            button2.Location = new Point(340, 375);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 1;
            button2.Text = "Papel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += EventoTomarDecisiones;
            // 
            // button3
            // 
            button3.Location = new Point(575, 375);
            button3.Name = "button3";
            button3.Size = new Size(100, 50);
            button3.TabIndex = 2;
            button3.Text = "Tijera";
            button3.UseVisualStyleBackColor = true;
            button3.Click += EventoTomarDecisiones;
            // 
            // Jugador
            // 
            Jugador.Location = new Point(340, 225);
            Jugador.Name = "Jugador";
            Jugador.Size = new Size(100, 100);
            Jugador.TabIndex = 3;
            Jugador.TabStop = false;
            // 
            // Rival
            // 
            Rival.Location = new Point(340, 75);
            Rival.Name = "Rival";
            Rival.Size = new Size(100, 100);
            Rival.TabIndex = 4;
            Rival.TabStop = false;
            // 
            // lblCpu
            // 
            lblCpu.AutoSize = true;
            lblCpu.Location = new Point(320, 33);
            lblCpu.Name = "lblCpu";
            lblCpu.Size = new Size(151, 25);
            lblCpu.TabIndex = 5;
            lblCpu.Text = "El rival lo decide...";
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Location = new Point(350, 337);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(80, 25);
            lblPlayer.TabIndex = 6;
            lblPlayer.Text = "Su turno";
            lblPlayer.Click += EventoTomarDecisiones;
            // 
            // lblPlayerResult
            // 
            lblPlayerResult.AutoSize = true;
            lblPlayerResult.Location = new Point(82, 180);
            lblPlayerResult.Name = "lblPlayerResult";
            lblPlayerResult.Size = new Size(110, 25);
            lblPlayerResult.TabIndex = 7;
            lblPlayerResult.Text = "Tu resultado";
            // 
            // lblCpuResult
            // 
            lblCpuResult.AutoSize = true;
            lblCpuResult.Location = new Point(575, 180);
            lblCpuResult.Name = "lblCpuResult";
            lblCpuResult.Size = new Size(127, 25);
            lblCpuResult.TabIndex = 8;
            lblCpuResult.Text = "Resultado rival";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCpuResult);
            Controls.Add(lblPlayerResult);
            Controls.Add(lblPlayer);
            Controls.Add(lblCpu);
            Controls.Add(Rival);
            Controls.Add(Jugador);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Piedra, Papel o Tijera";
            ((System.ComponentModel.ISupportInitialize)Jugador).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rival).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox Jugador;
        private PictureBox Rival;
        private Label lblCpu;
        private Label lblPlayer;
        private Label lblPlayerResult;
        private Label lblCpuResult;
    }
}