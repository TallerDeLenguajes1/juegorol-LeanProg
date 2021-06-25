
namespace juegosdelpoder
{
    partial class FormJDP
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
            this.label1Titulo = new System.Windows.Forms.Label();
            this.botonJugar = new System.Windows.Forms.Button();
            this.botonSALIR = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1Titulo
            // 
            this.label1Titulo.AutoSize = true;
            this.label1Titulo.Location = new System.Drawing.Point(213, 19);
            this.label1Titulo.Name = "label1Titulo";
            this.label1Titulo.Size = new System.Drawing.Size(198, 15);
            this.label1Titulo.TabIndex = 0;
            this.label1Titulo.Text = "BIENVENIDOS A JUEGOS DEL PODER";
            // 
            // botonJugar
            // 
            this.botonJugar.BackColor = System.Drawing.Color.White;
            this.botonJugar.Location = new System.Drawing.Point(29, 244);
            this.botonJugar.Name = "botonJugar";
            this.botonJugar.Size = new System.Drawing.Size(212, 102);
            this.botonJugar.TabIndex = 1;
            this.botonJugar.Text = "JUGAR";
            this.botonJugar.UseVisualStyleBackColor = false;
            this.botonJugar.Click += new System.EventHandler(this.botonJugar_Click);
            // 
            // botonSALIR
            // 
            this.botonSALIR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonSALIR.Location = new System.Drawing.Point(329, 244);
            this.botonSALIR.Name = "botonSALIR";
            this.botonSALIR.Size = new System.Drawing.Size(197, 99);
            this.botonSALIR.TabIndex = 2;
            this.botonSALIR.Text = "SALIR";
            this.botonSALIR.UseVisualStyleBackColor = false;
            this.botonSALIR.Click += new System.EventHandler(this.botonSALIR_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(166, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(267, 139);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "RAZAS PARAA ELEGIR";
            // 
            // FormJDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(629, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.botonSALIR);
            this.Controls.Add(this.botonJugar);
            this.Controls.Add(this.label1Titulo);
            this.Name = "FormJDP";
            this.Text = "JuegoDelPoder";
            this.Load += new System.EventHandler(this.FormJDP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Titulo;
        private System.Windows.Forms.Button botonJugar;
        private System.Windows.Forms.Button botonSALIR;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

