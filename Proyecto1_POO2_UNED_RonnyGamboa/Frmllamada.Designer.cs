
namespace Proyecto1_POO2_UNED_RonnyGamboa
{
    partial class Frmllamada
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
            this.lblmarcar = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmarcar
            // 
            this.lblmarcar.AutoSize = true;
            this.lblmarcar.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarcar.Location = new System.Drawing.Point(142, 13);
            this.lblmarcar.Name = "lblmarcar";
            this.lblmarcar.Size = new System.Drawing.Size(149, 33);
            this.lblmarcar.TabIndex = 0;
            this.lblmarcar.Text = "Llamando al:";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(151, 46);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(127, 33);
            this.lblnumero.TabIndex = 1;
            this.lblnumero.Text = "########";
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(136, 92);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(155, 32);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Frmllamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 136);
            this.ControlBox = false;
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.lblmarcar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmllamada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frmllamada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmarcar;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Button btncancelar;
    }
}