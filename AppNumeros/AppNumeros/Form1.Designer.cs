namespace AppNumeros
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumeroMayor = new System.Windows.Forms.Label();
            this.lblNumeroMenor = new System.Windows.Forms.Label();
            this.txtNumeroMayor = new System.Windows.Forms.TextBox();
            this.txtNumeroMenor = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rtbMostrarRango = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblNumeroMayor
            // 
            this.lblNumeroMayor.AutoSize = true;
            this.lblNumeroMayor.Location = new System.Drawing.Point(29, 35);
            this.lblNumeroMayor.Name = "lblNumeroMayor";
            this.lblNumeroMayor.Size = new System.Drawing.Size(73, 13);
            this.lblNumeroMayor.TabIndex = 0;
            this.lblNumeroMayor.Text = "numero mayor";
            // 
            // lblNumeroMenor
            // 
            this.lblNumeroMenor.AutoSize = true;
            this.lblNumeroMenor.Location = new System.Drawing.Point(32, 83);
            this.lblNumeroMenor.Name = "lblNumeroMenor";
            this.lblNumeroMenor.Size = new System.Drawing.Size(74, 13);
            this.lblNumeroMenor.TabIndex = 1;
            this.lblNumeroMenor.Text = "numero menor";
            // 
            // txtNumeroMayor
            // 
            this.txtNumeroMayor.Location = new System.Drawing.Point(121, 35);
            this.txtNumeroMayor.Name = "txtNumeroMayor";
            this.txtNumeroMayor.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroMayor.TabIndex = 2;
            // 
            // txtNumeroMenor
            // 
            this.txtNumeroMenor.Location = new System.Drawing.Point(121, 83);
            this.txtNumeroMenor.Name = "txtNumeroMenor";
            this.txtNumeroMenor.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroMenor.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(145, 175);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rtbMostrarRango
            // 
            this.rtbMostrarRango.Location = new System.Drawing.Point(32, 139);
            this.rtbMostrarRango.Name = "rtbMostrarRango";
            this.rtbMostrarRango.Size = new System.Drawing.Size(100, 96);
            this.rtbMostrarRango.TabIndex = 5;
            this.rtbMostrarRango.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rtbMostrarRango);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumeroMenor);
            this.Controls.Add(this.txtNumeroMayor);
            this.Controls.Add(this.lblNumeroMenor);
            this.Controls.Add(this.lblNumeroMayor);
            this.Name = "Form1";
            this.Text = "programa de rango";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroMayor;
        private System.Windows.Forms.Label lblNumeroMenor;
        private System.Windows.Forms.TextBox txtNumeroMayor;
        private System.Windows.Forms.TextBox txtNumeroMenor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RichTextBox rtbMostrarRango;
    }
}

