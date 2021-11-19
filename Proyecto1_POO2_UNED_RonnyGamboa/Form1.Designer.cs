
namespace Proyecto1_POO2_UNED_RonnyGamboa
{
    partial class FrmPrincipal
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtgAgenda = new System.Windows.Forms.DataGridView();
            this.cln1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cln4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(37, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(72, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = " Nombre:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(37, 81);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(70, 18);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Telefono:";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.Location = new System.Drawing.Point(35, 112);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(73, 18);
            this.lblCel.TabIndex = 3;
            this.lblCel.Text = "   Celular:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(35, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 18);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "     Email:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 51);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(115, 82);
            this.txtTel.MaxLength = 8;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(272, 20);
            this.txtTel.TabIndex = 7;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(114, 113);
            this.txtCel.MaxLength = 8;
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(272, 20);
            this.txtCel.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 150);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // dtgAgenda
            // 
            this.dtgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln1,
            this.cln2,
            this.cln3,
            this.Cln4});
            this.dtgAgenda.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtgAgenda.Location = new System.Drawing.Point(27, 203);
            this.dtgAgenda.Name = "dtgAgenda";
            this.dtgAgenda.Size = new System.Drawing.Size(742, 232);
            this.dtgAgenda.TabIndex = 10;
            this.dtgAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgenda_CellClick);
            this.dtgAgenda.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgenda_CellMouseEnter);
            // 
            // cln1
            // 
            this.cln1.FillWeight = 1000F;
            this.cln1.HeaderText = "Nombre";
            this.cln1.MaxInputLength = 50;
            this.cln1.Name = "cln1";
            this.cln1.ReadOnly = true;
            // 
            // cln2
            // 
            this.cln2.HeaderText = "Telefono";
            this.cln2.MaxInputLength = 8;
            this.cln2.Name = "cln2";
            // 
            // cln3
            // 
            this.cln3.HeaderText = "Celular";
            this.cln3.MaxInputLength = 8;
            this.cln3.Name = "cln3";
            // 
            // Cln4
            // 
            this.Cln4.HeaderText = "Email";
            this.Cln4.MaxInputLength = 50;
            this.Cln4.Name = "Cln4";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(421, 119);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 51);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(623, 119);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 51);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(24, 448);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(141, 18);
            this.lblinfo.TabIndex = 14;
            this.lblinfo.Text = "Total de Contactos:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(270, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(247, 32);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Agenda Personal ";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(421, 51);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(348, 51);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo Contacto";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 486);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgAgenda);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblNombre);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto1 POO2 UNED Ronny Gamboa Berrocal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dtgAgenda;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cln4;
        private System.Windows.Forms.Button btnNuevo;
    }
}

