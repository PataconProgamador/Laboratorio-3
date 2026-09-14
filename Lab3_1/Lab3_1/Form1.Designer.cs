namespace Lab3_1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtNombres = new TextBox();
            lblApe = new Label();
            txtApellidos = new TextBox();
            lblcorreo = new Label();
            txtCorreo = new TextBox();
            lblNac = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblSalario = new Label();
            txtSalario = new TextBox();
            dgvdatos = new DataGridView();
            toolStrip1 = new ToolStrip();
            tsbGuardar = new ToolStripButton();
            errorProvider1 = new ErrorProvider(components);
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvdatos).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(42, 54);
            lblId.Name = "lblId";
            lblId.Size = new Size(140, 32);
            lblId.TabIndex = 0;
            lblId.Text = "IdEmpleado";
            lblId.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(265, 51);
            txtId.Name = "txtId";
            txtId.Size = new Size(448, 39);
            txtId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(47, 101);
            lblName.Name = "lblName";
            lblName.Size = new Size(102, 32);
            lblName.TabIndex = 2;
            lblName.Text = "Nombre";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(265, 101);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(448, 39);
            txtNombres.TabIndex = 3;
            // 
            // lblApe
            // 
            lblApe.AutoSize = true;
            lblApe.Location = new Point(47, 157);
            lblApe.Name = "lblApe";
            lblApe.Size = new Size(102, 32);
            lblApe.TabIndex = 4;
            lblApe.Text = "Apellido";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(265, 156);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(449, 39);
            txtApellidos.TabIndex = 5;
            // 
            // lblcorreo
            // 
            lblcorreo.AutoSize = true;
            lblcorreo.Location = new Point(47, 210);
            lblcorreo.Name = "lblcorreo";
            lblcorreo.Size = new Size(71, 32);
            lblcorreo.TabIndex = 6;
            lblcorreo.Text = "Email";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(266, 211);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(449, 39);
            txtCorreo.TabIndex = 7;
            // 
            // lblNac
            // 
            lblNac.AutoSize = true;
            lblNac.Location = new Point(46, 264);
            lblNac.Name = "lblNac";
            lblNac.Size = new Size(232, 32);
            lblNac.TabIndex = 8;
            lblNac.Text = "fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(311, 265);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(400, 39);
            dtpFechaNacimiento.TabIndex = 9;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(52, 321);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(85, 32);
            lblSalario.TabIndex = 10;
            lblSalario.Text = "Salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(269, 322);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(200, 39);
            txtSalario.TabIndex = 11;
            // 
            // dgvdatos
            // 
            dgvdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdatos.Location = new Point(146, 390);
            dgvdatos.Name = "dgvdatos";
            dgvdatos.RowHeadersWidth = 82;
            dgvdatos.Size = new Size(784, 300);
            dgvdatos.TabIndex = 12;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbGuardar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1084, 42);
            toolStrip1.TabIndex = 13;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            tsbGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbGuardar.Image = (Image)resources.GetObject("tsbGuardar.Image");
            tsbGuardar.ImageTransparentColor = Color.Magenta;
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(46, 36);
            tsbGuardar.Text = "toolStripButton1";
            tsbGuardar.Click += toolStripButton1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(845, 149);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 46);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 631);
            Controls.Add(btnLimpiar);
            Controls.Add(toolStrip1);
            Controls.Add(dgvdatos);
            Controls.Add(txtSalario);
            Controls.Add(lblSalario);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblNac);
            Controls.Add(txtCorreo);
            Controls.Add(lblcorreo);
            Controls.Add(txtApellidos);
            Controls.Add(lblApe);
            Controls.Add(txtNombres);
            Controls.Add(lblName);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdatos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Label lblName;
        private TextBox txtNombres;
        private Label lblApe;
        private TextBox txtApellidos;
        private Label lblcorreo;
        private TextBox txtCorreo;
        private Label lblNac;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblSalario;
        private TextBox txtSalario;
        private DataGridView dgvdatos;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbGuardar;
        private ErrorProvider errorProvider1;
        private Button btnLimpiar;
    }
}
