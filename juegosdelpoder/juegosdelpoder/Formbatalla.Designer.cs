
namespace juegosdelpoder
{
    partial class Formbatalla
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
            this.label1Titulo = new System.Windows.Forms.Label();
            this.buttonComenzar = new System.Windows.Forms.Button();
            this.label1Nombre1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSaludjugador1 = new System.Windows.Forms.Label();
            this.label2Apodo1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDTR1 = new System.Windows.Forms.Label();
            this.buttonjugador1 = new System.Windows.Forms.Button();
            this.labelDNTRj2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelapodo2 = new System.Windows.Forms.Label();
            this.labelSaludJugador2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAtaque2 = new System.Windows.Forms.Button();
            this.label5Winner = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderNombre = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderApodos = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSalud = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderEstado = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1Titulo
            // 
            this.label1Titulo.AutoSize = true;
            this.label1Titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1Titulo.Location = new System.Drawing.Point(319, 3);
            this.label1Titulo.Name = "label1Titulo";
            this.label1Titulo.Size = new System.Drawing.Size(122, 32);
            this.label1Titulo.TabIndex = 1;
            this.label1Titulo.Text = "Jugadores";
            this.label1Titulo.Click += new System.EventHandler(this.label1Titulo_Click);
            // 
            // buttonComenzar
            // 
            this.buttonComenzar.Location = new System.Drawing.Point(319, 150);
            this.buttonComenzar.Name = "buttonComenzar";
            this.buttonComenzar.Size = new System.Drawing.Size(116, 44);
            this.buttonComenzar.TabIndex = 3;
            this.buttonComenzar.Text = "PLAY!";
            this.buttonComenzar.UseVisualStyleBackColor = true;
            this.buttonComenzar.Click += new System.EventHandler(this.buttonComenzar_Click);
            // 
            // label1Nombre1
            // 
            this.label1Nombre1.AutoSize = true;
            this.label1Nombre1.Location = new System.Drawing.Point(32, 220);
            this.label1Nombre1.Name = "label1Nombre1";
            this.label1Nombre1.Size = new System.Drawing.Size(112, 15);
            this.label1Nombre1.TabIndex = 4;
            this.label1Nombre1.Text = "APODO JUGADOR 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "SALUD PLAYER 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSaludjugador1
            // 
            this.labelSaludjugador1.AutoSize = true;
            this.labelSaludjugador1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSaludjugador1.Location = new System.Drawing.Point(214, 169);
            this.labelSaludjugador1.Name = "labelSaludjugador1";
            this.labelSaludjugador1.Size = new System.Drawing.Size(23, 28);
            this.labelSaludjugador1.TabIndex = 6;
            this.labelSaludjugador1.Text = "0";
            this.labelSaludjugador1.Click += new System.EventHandler(this.labelSaludjugador1_Click);
            // 
            // label2Apodo1
            // 
            this.label2Apodo1.AutoSize = true;
            this.label2Apodo1.Location = new System.Drawing.Point(215, 220);
            this.label2Apodo1.Name = "label2Apodo1";
            this.label2Apodo1.Size = new System.Drawing.Size(13, 15);
            this.label2Apodo1.TabIndex = 7;
            this.label2Apodo1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "DAÑO RECIBIDO";
            // 
            // labelDTR1
            // 
            this.labelDTR1.AutoSize = true;
            this.labelDTR1.Location = new System.Drawing.Point(215, 256);
            this.labelDTR1.Name = "labelDTR1";
            this.labelDTR1.Size = new System.Drawing.Size(13, 15);
            this.labelDTR1.TabIndex = 9;
            this.labelDTR1.Text = "0";
            // 
            // buttonjugador1
            // 
            this.buttonjugador1.Location = new System.Drawing.Point(75, 287);
            this.buttonjugador1.Name = "buttonjugador1";
            this.buttonjugador1.Size = new System.Drawing.Size(162, 38);
            this.buttonjugador1.TabIndex = 10;
            this.buttonjugador1.Text = "ATACAR";
            this.buttonjugador1.UseVisualStyleBackColor = true;
            this.buttonjugador1.Click += new System.EventHandler(this.buttonjugador1_Click);
            // 
            // labelDNTRj2
            // 
            this.labelDNTRj2.AutoSize = true;
            this.labelDNTRj2.Location = new System.Drawing.Point(734, 256);
            this.labelDNTRj2.Name = "labelDNTRj2";
            this.labelDNTRj2.Size = new System.Drawing.Size(13, 15);
            this.labelDNTRj2.TabIndex = 16;
            this.labelDNTRj2.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "DAÑO RECIBIDO";
            // 
            // labelapodo2
            // 
            this.labelapodo2.AutoSize = true;
            this.labelapodo2.Location = new System.Drawing.Point(734, 220);
            this.labelapodo2.Name = "labelapodo2";
            this.labelapodo2.Size = new System.Drawing.Size(13, 15);
            this.labelapodo2.TabIndex = 14;
            this.labelapodo2.Text = "0";
            // 
            // labelSaludJugador2
            // 
            this.labelSaludJugador2.AutoSize = true;
            this.labelSaludJugador2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSaludJugador2.Location = new System.Drawing.Point(734, 172);
            this.labelSaludJugador2.Name = "labelSaludJugador2";
            this.labelSaludJugador2.Size = new System.Drawing.Size(23, 28);
            this.labelSaludJugador2.TabIndex = 13;
            this.labelSaludJugador2.Text = "0";
            this.labelSaludJugador2.Click += new System.EventHandler(this.labelSaludJugador2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(550, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "SALUD PLAYER 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(550, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "APODO JUGADOR 2";
            // 
            // buttonAtaque2
            // 
            this.buttonAtaque2.Location = new System.Drawing.Point(550, 287);
            this.buttonAtaque2.Name = "buttonAtaque2";
            this.buttonAtaque2.Size = new System.Drawing.Size(168, 38);
            this.buttonAtaque2.TabIndex = 17;
            this.buttonAtaque2.Text = "ATACAR";
            this.buttonAtaque2.UseVisualStyleBackColor = true;
            this.buttonAtaque2.Click += new System.EventHandler(this.buttonAtaque2_Click);
            // 
            // label5Winner
            // 
            this.label5Winner.AutoSize = true;
            this.label5Winner.Location = new System.Drawing.Point(344, 230);
            this.label5Winner.Name = "label5Winner";
            this.label5Winner.Size = new System.Drawing.Size(69, 15);
            this.label5Winner.TabIndex = 18;
            this.label5Winner.Text = "GANADOR?";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNombre,
            this.columnHeaderApodos,
            this.columnHeaderSalud,
            this.columnHeaderEstado});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(150, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(480, 97);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNombre
            // 
            this.columnHeaderNombre.Text = "NOMBRE";
            this.columnHeaderNombre.Width = 150;
            // 
            // columnHeaderApodos
            // 
            this.columnHeaderApodos.Text = "APODO";
            this.columnHeaderApodos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderApodos.Width = 150;
            // 
            // columnHeaderSalud
            // 
            this.columnHeaderSalud.Text = "SALUD";
            this.columnHeaderSalud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSalud.Width = 100;
            // 
            // columnHeaderEstado
            // 
            this.columnHeaderEstado.Text = "RAZA";
            this.columnHeaderEstado.Width = 100;
            // 
            // Formbatalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 337);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5Winner);
            this.Controls.Add(this.buttonAtaque2);
            this.Controls.Add(this.labelDNTRj2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelapodo2);
            this.Controls.Add(this.labelSaludJugador2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonjugador1);
            this.Controls.Add(this.labelDTR1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2Apodo1);
            this.Controls.Add(this.labelSaludjugador1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1Nombre1);
            this.Controls.Add(this.buttonComenzar);
            this.Controls.Add(this.label1Titulo);
            this.Name = "Formbatalla";
            this.Text = "Formbatalla";
            this.Load += new System.EventHandler(this.Formbatalla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1Titulo;
        private System.Windows.Forms.Button buttonComenzar;
        private System.Windows.Forms.Label label1Nombre1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSaludjugador1;
        private System.Windows.Forms.Label label2Apodo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDTR1;
        private System.Windows.Forms.Button buttonjugador1;
        private System.Windows.Forms.Label labelDNTRj2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelapodo2;
        private System.Windows.Forms.Label labelSaludJugador2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAtaque2;
        private System.Windows.Forms.Label label5Winner;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderNombre;
        private System.Windows.Forms.ColumnHeader columnHeaderApodos;
        private System.Windows.Forms.ColumnHeader columnHeaderSalud;
        private System.Windows.Forms.ColumnHeader columnHeaderEstado;
    }
}