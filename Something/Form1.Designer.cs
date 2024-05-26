namespace Something
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
            this.buttonPrueba = new System.Windows.Forms.Button();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.numericUpDownNivelPoder = new System.Windows.Forms.NumericUpDown();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.comboBoxRaza = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHistoria = new System.Windows.Forms.Label();
            this.textBoxHistoria = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelPoder)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrueba
            // 
            this.buttonPrueba.Location = new System.Drawing.Point(772, 352);
            this.buttonPrueba.Name = "buttonPrueba";
            this.buttonPrueba.Size = new System.Drawing.Size(132, 45);
            this.buttonPrueba.TabIndex = 0;
            this.buttonPrueba.Text = "Probar Conexion";
            this.buttonPrueba.UseVisualStyleBackColor = true;
            this.buttonPrueba.Click += new System.EventHandler(this.buttonPrueba_Click);
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(49, 219);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.RowHeadersWidth = 51;
            this.dataGridViewPersonajes.RowTemplate.Height = 24;
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(677, 246);
            this.dataGridViewPersonajes.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(763, 242);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(152, 35);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "Cargar Datos";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Power";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(154, 39);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 7;
            this.textBoxID.Leave += new System.EventHandler(this.textBoxID_Leave);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(154, 77);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombre.TabIndex = 8;
            // 
            // numericUpDownNivelPoder
            // 
            this.numericUpDownNivelPoder.Location = new System.Drawing.Point(154, 141);
            this.numericUpDownNivelPoder.Maximum = new decimal(new int[] {
            1700000,
            0,
            0,
            0});
            this.numericUpDownNivelPoder.Name = "numericUpDownNivelPoder";
            this.numericUpDownNivelPoder.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownNivelPoder.TabIndex = 10;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(69, 182);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(153, 31);
            this.buttonCrear.TabIndex = 11;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(154, 111);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRaza.TabIndex = 12;
            this.comboBoxRaza.SelectedIndexChanged += new System.EventHandler(this.comboBoxRaza_SelectedIndexChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(485, 182);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(153, 31);
            this.buttonBuscar.TabIndex = 13;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(338, 42);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(122, 16);
            this.labelFecha.TabIndex = 14;
            this.labelFecha.Text = "Fecha de creacion:";
            // 
            // labelHistoria
            // 
            this.labelHistoria.AutoSize = true;
            this.labelHistoria.Location = new System.Drawing.Point(338, 119);
            this.labelHistoria.Name = "labelHistoria";
            this.labelHistoria.Size = new System.Drawing.Size(56, 16);
            this.labelHistoria.TabIndex = 15;
            this.labelHistoria.Text = "Historia:";
            // 
            // textBoxHistoria
            // 
            this.textBoxHistoria.Location = new System.Drawing.Point(485, 111);
            this.textBoxHistoria.Multiline = true;
            this.textBoxHistoria.Name = "textBoxHistoria";
            this.textBoxHistoria.Size = new System.Drawing.Size(149, 47);
            this.textBoxHistoria.TabIndex = 16;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(485, 39);
            this.maskedTextBox1.Mask = "00/00/00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 17;
            this.maskedTextBox1.Text = "000000";
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(283, 182);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(153, 31);
            this.buttonBorrar.TabIndex = 18;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 551);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBoxHistoria);
            this.Controls.Add(this.labelHistoria);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBoxRaza);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.numericUpDownNivelPoder);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.buttonPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelPoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrueba;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.NumericUpDown numericUpDownNivelPoder;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.ComboBox comboBoxRaza;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHistoria;
        private System.Windows.Forms.TextBox textBoxHistoria;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonBorrar;
    }
}

