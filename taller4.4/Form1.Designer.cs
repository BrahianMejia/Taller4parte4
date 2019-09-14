namespace taller4._4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ltbnumeros = new System.Windows.Forms.ListBox();
            this.btnir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltbnumeros
            // 
            this.ltbnumeros.FormattingEnabled = true;
            this.ltbnumeros.Location = new System.Drawing.Point(173, 48);
            this.ltbnumeros.Name = "ltbnumeros";
            this.ltbnumeros.Size = new System.Drawing.Size(63, 212);
            this.ltbnumeros.TabIndex = 0;
            // 
            // btnir
            // 
            this.btnir.Location = new System.Drawing.Point(183, 266);
            this.btnir.Name = "btnir";
            this.btnir.Size = new System.Drawing.Size(43, 33);
            this.btnir.TabIndex = 1;
            this.btnir.Text = "Ir";
            this.btnir.UseVisualStyleBackColor = true;
            this.btnir.Click += new System.EventHandler(this.btnir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Multiplos de 7 apartir de 50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnir);
            this.Controls.Add(this.ltbnumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltbnumeros;
        private System.Windows.Forms.Button btnir;
        private System.Windows.Forms.Label label1;
    }
}

