namespace CRUD
{
    partial class Form1
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
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcion2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidad2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCosto2 = new System.Windows.Forms.TextBox();
            this.btnAgregarInicio = new System.Windows.Forms.Button();
            this.btnEliminarPrimero = new System.Windows.Forms.Button();
            this.btnInvertirLista = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnEliminarUltimo = new System.Windows.Forms.Button();
            this.btnReporteInverso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.Location = new System.Drawing.Point(125, 50);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nombre";
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(125, 76);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(100, 20);
            this.txtNombre2.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Descripción";
            // 
            // txtDescripcion2
            // 
            this.txtDescripcion2.Location = new System.Drawing.Point(125, 102);
            this.txtDescripcion2.Name = "txtDescripcion2";
            this.txtDescripcion2.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cantidad";
            // 
            // txtCantidad2
            // 
            this.txtCantidad2.Location = new System.Drawing.Point(125, 128);
            this.txtCantidad2.Name = "txtCantidad2";
            this.txtCantidad2.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad2.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Costo";
            // 
            // txtCosto2
            // 
            this.txtCosto2.Location = new System.Drawing.Point(125, 154);
            this.txtCosto2.Name = "txtCosto2";
            this.txtCosto2.Size = new System.Drawing.Size(100, 20);
            this.txtCosto2.TabIndex = 8;
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.Location = new System.Drawing.Point(323, 46);
            this.btnAgregarInicio.Name = "btnAgregarInicio";
            this.btnAgregarInicio.Size = new System.Drawing.Size(98, 23);
            this.btnAgregarInicio.TabIndex = 10;
            this.btnAgregarInicio.Text = "Agregar Inicio";
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            this.btnAgregarInicio.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // btnEliminarPrimero
            // 
            this.btnEliminarPrimero.Location = new System.Drawing.Point(323, 75);
            this.btnEliminarPrimero.Name = "btnEliminarPrimero";
            this.btnEliminarPrimero.Size = new System.Drawing.Size(98, 23);
            this.btnEliminarPrimero.TabIndex = 12;
            this.btnEliminarPrimero.Text = "Eliminar primero";
            this.btnEliminarPrimero.UseVisualStyleBackColor = true;
            this.btnEliminarPrimero.Click += new System.EventHandler(this.btnEliminar2_Click);
            // 
            // btnInvertirLista
            // 
            this.btnInvertirLista.Location = new System.Drawing.Point(323, 162);
            this.btnInvertirLista.Name = "btnInvertirLista";
            this.btnInvertirLista.Size = new System.Drawing.Size(98, 23);
            this.btnInvertirLista.TabIndex = 14;
            this.btnInvertirLista.Text = "Invertir lista";
            this.btnInvertirLista.UseVisualStyleBackColor = true;
            this.btnInvertirLista.Click += new System.EventHandler(this.btnListar2_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(31, 202);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(491, 240);
            this.txtResultado.TabIndex = 17;
            // 
            // btnEliminarUltimo
            // 
            this.btnEliminarUltimo.Location = new System.Drawing.Point(323, 104);
            this.btnEliminarUltimo.Name = "btnEliminarUltimo";
            this.btnEliminarUltimo.Size = new System.Drawing.Size(98, 23);
            this.btnEliminarUltimo.TabIndex = 18;
            this.btnEliminarUltimo.Text = "Eliminar último";
            this.btnEliminarUltimo.UseVisualStyleBackColor = true;
            this.btnEliminarUltimo.Click += new System.EventHandler(this.btnEliminarUltimo_Click);
            // 
            // btnReporteInverso
            // 
            this.btnReporteInverso.Location = new System.Drawing.Point(323, 133);
            this.btnReporteInverso.Name = "btnReporteInverso";
            this.btnReporteInverso.Size = new System.Drawing.Size(98, 23);
            this.btnReporteInverso.TabIndex = 19;
            this.btnReporteInverso.Text = "ReporteInverso";
            this.btnReporteInverso.UseVisualStyleBackColor = true;
            this.btnReporteInverso.Click += new System.EventHandler(this.btnReporteInverso_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(548, 465);
            this.Controls.Add(this.btnReporteInverso);
            this.Controls.Add(this.btnEliminarUltimo);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnInvertirLista);
            this.Controls.Add(this.btnEliminarPrimero);
            this.Controls.Add(this.btnAgregarInicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCosto2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCantidad2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescripcion2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodigo2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCodigo2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcion2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidad2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCosto2;
        private System.Windows.Forms.Button btnAgregarInicio;
        private System.Windows.Forms.Button btnEliminarPrimero;
        private System.Windows.Forms.Button btnInvertirLista;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnEliminarUltimo;
        private System.Windows.Forms.Button btnReporteInverso;
    }
}

