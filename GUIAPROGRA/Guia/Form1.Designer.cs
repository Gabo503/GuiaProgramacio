namespace Guia
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
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            dgvDatos = new DataGridView();
            btnCrear = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtIdAlumno = new TextBox();
            label1 = new Label();
            btnLeer = new Button();
            btnGuardar = new Button();
            cbxCarrera = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(196, 239);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(170, 23);
            txtTelefono.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(196, 196);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(170, 23);
            txtCorreo.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(196, 151);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(170, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(196, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 23);
            txtNombre.TabIndex = 7;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(411, 46);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(663, 334);
            dgvDatos.TabIndex = 9;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(309, 357);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 10;
            btnCrear.Text = "crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(110, 357);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "cargar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 357);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 110);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 15;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 151);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 16;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 199);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 17;
            label4.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 247);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 18;
            label5.Text = "Telefono";
            // 
            // txtIdAlumno
            // 
            txtIdAlumno.Location = new Point(196, 63);
            txtIdAlumno.Name = "txtIdAlumno";
            txtIdAlumno.ReadOnly = true;
            txtIdAlumno.Size = new Size(170, 23);
            txtIdAlumno.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 66);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 14;
            label1.Text = "IdALumno";
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(12, 12);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(67, 31);
            btnLeer.TabIndex = 21;
            btnLeer.Text = "refresh";
            btnLeer.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(196, 357);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbxCarrera
            // 
            cbxCarrera.FormattingEnabled = true;
            cbxCarrera.Location = new Point(196, 284);
            cbxCarrera.Name = "cbxCarrera";
            cbxCarrera.Size = new Size(170, 23);
            cbxCarrera.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 287);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 24;
            label6.Text = "Carrera";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1104, 420);
            Controls.Add(label6);
            Controls.Add(cbxCarrera);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrear);
            Controls.Add(dgvDatos);
            Controls.Add(txtIdAlumno);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Name = "Form1";
            Text = "Guillermo Gabriel Castro Lopez  25-0160-2023";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private DataGridView dgvDatos;
        private Button btnCrear;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIdAlumno;
        private Label label1;
        private Button btnLeer;
        private Button btnGuardar;
        private ComboBox cbxCarrera;
        private Label label6;
    }
}