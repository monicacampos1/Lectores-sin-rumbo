
namespace Practica_semana_10
{
    partial class agregarempleados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarempleados));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rnombre = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.bbuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpuesto = new System.Windows.Forms.ComboBox();
            this.tpuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Practica_semana_10.bibliotecaDataSet();
            this.txtgenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtobser = new System.Windows.Forms.TextBox();
            this.templeadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtafp = new System.Windows.Forms.TextBox();
            this.txtis = new System.Windows.Forms.TextBox();
            this.txtdui = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bcerrar = new System.Windows.Forms.Button();
            this.bactualizar = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bnuevo = new System.Windows.Forms.Button();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdirec = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.templeadosTableAdapter = new Practica_semana_10.bibliotecaDataSetTableAdapters.templeadosTableAdapter();
            this.tpuestosTableAdapter = new Practica_semana_10.bibliotecaDataSetTableAdapters.tpuestosTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeadosBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox2.Controls.Add(this.rnombre);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.bbuscar);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.txtbuscar);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(666, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 584);
            this.groupBox2.TabIndex = 214;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empleados registrados";
            // 
            // rnombre
            // 
            this.rnombre.AutoSize = true;
            this.rnombre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rnombre.Location = new System.Drawing.Point(99, 64);
            this.rnombre.Name = "rnombre";
            this.rnombre.Size = new System.Drawing.Size(94, 26);
            this.rnombre.TabIndex = 137;
            this.rnombre.TabStop = true;
            this.rnombre.Text = "Nombre ";
            this.rnombre.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(99, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 26);
            this.radioButton1.TabIndex = 135;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Código";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // bbuscar
            // 
            this.bbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.bbuscar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.bbuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bbuscar.Location = new System.Drawing.Point(531, 37);
            this.bbuscar.Name = "bbuscar";
            this.bbuscar.Size = new System.Drawing.Size(87, 35);
            this.bbuscar.TabIndex = 133;
            this.bbuscar.Text = "Buscar";
            this.bbuscar.UseVisualStyleBackColor = false;
            this.bbuscar.Click += new System.EventHandler(this.bbuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 447);
            this.dataGridView1.TabIndex = 132;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtbuscar.Location = new System.Drawing.Point(222, 46);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(303, 26);
            this.txtbuscar.TabIndex = 131;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 130;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox1.Controls.Add(this.txtpuesto);
            this.groupBox1.Controls.Add(this.txtgenero);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtobser);
            this.groupBox1.Controls.Add(this.txtafp);
            this.groupBox1.Controls.Add(this.txtis);
            this.groupBox1.Controls.Add(this.txtdui);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtcorreo);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.txtdirec);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 588);
            this.groupBox1.TabIndex = 213;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario agregar empleados";
            // 
            // txtpuesto
            // 
            this.txtpuesto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tpuestosBindingSource, "nombrepu", true));
            this.txtpuesto.FormattingEnabled = true;
            this.txtpuesto.Items.AddRange(new object[] {
            "Gerente ",
            "Superior ",
            "Responsable de las Personas",
            "Encargados de gestion ",
            "Limpieza ",
            "Inventario "});
            this.txtpuesto.Location = new System.Drawing.Point(207, 218);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.Size = new System.Drawing.Size(294, 34);
            this.txtpuesto.TabIndex = 218;
            // 
            // tpuestosBindingSource
            // 
            this.tpuestosBindingSource.DataMember = "tpuestos";
            this.tpuestosBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtgenero
            // 
            this.txtgenero.FormattingEnabled = true;
            this.txtgenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino ",
            "Otros"});
            this.txtgenero.Location = new System.Drawing.Point(208, 144);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.Size = new System.Drawing.Size(293, 34);
            this.txtgenero.TabIndex = 217;
            this.txtgenero.SelectedIndexChanged += new System.EventHandler(this.txtgenero_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(29, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 22);
            this.label5.TabIndex = 216;
            this.label5.Text = "Observaciones ";
            // 
            // txtobser
            // 
            this.txtobser.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.templeadosBindingSource, "observacionesem", true));
            this.txtobser.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtobser.Location = new System.Drawing.Point(206, 355);
            this.txtobser.Multiline = true;
            this.txtobser.Name = "txtobser";
            this.txtobser.Size = new System.Drawing.Size(295, 63);
            this.txtobser.TabIndex = 215;
            // 
            // templeadosBindingSource
            // 
            this.templeadosBindingSource.DataMember = "templeados";
            this.templeadosBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // txtafp
            // 
            this.txtafp.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.templeadosBindingSource, "afpem", true));
            this.txtafp.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtafp.Location = new System.Drawing.Point(208, 323);
            this.txtafp.Multiline = true;
            this.txtafp.Name = "txtafp";
            this.txtafp.Size = new System.Drawing.Size(295, 22);
            this.txtafp.TabIndex = 214;
            // 
            // txtis
            // 
            this.txtis.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.templeadosBindingSource, "isssem", true));
            this.txtis.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtis.Location = new System.Drawing.Point(208, 292);
            this.txtis.Multiline = true;
            this.txtis.Name = "txtis";
            this.txtis.Size = new System.Drawing.Size(295, 22);
            this.txtis.TabIndex = 213;
            // 
            // txtdui
            // 
            this.txtdui.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.templeadosBindingSource, "duiem", true));
            this.txtdui.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtdui.Location = new System.Drawing.Point(207, 260);
            this.txtdui.Multiline = true;
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(295, 22);
            this.txtdui.TabIndex = 212;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(24, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 210;
            this.label4.Text = "Puesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 209;
            this.label3.Text = "AFP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 208;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 207;
            this.label1.Text = "ISSS";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bcerrar);
            this.groupBox4.Controls.Add(this.bactualizar);
            this.groupBox4.Controls.Add(this.bguardar);
            this.groupBox4.Controls.Add(this.bmodificar);
            this.groupBox4.Controls.Add(this.beliminar);
            this.groupBox4.Controls.Add(this.bnuevo);
            this.groupBox4.Location = new System.Drawing.Point(6, 414);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(612, 142);
            this.groupBox4.TabIndex = 206;
            this.groupBox4.TabStop = false;
            // 
            // bcerrar
            // 
            this.bcerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.bcerrar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.bcerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bcerrar.Location = new System.Drawing.Point(480, 32);
            this.bcerrar.Name = "bcerrar";
            this.bcerrar.Size = new System.Drawing.Size(100, 33);
            this.bcerrar.TabIndex = 0;
            this.bcerrar.Text = "Cerrar";
            this.bcerrar.UseVisualStyleBackColor = false;
            this.bcerrar.Click += new System.EventHandler(this.bcerrar_Click);
            // 
            // bactualizar
            // 
            this.bactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.bactualizar.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.bactualizar.ForeColor = System.Drawing.Color.White;
            this.bactualizar.Location = new System.Drawing.Point(320, 85);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(101, 40);
            this.bactualizar.TabIndex = 110;
            this.bactualizar.Text = "Actualizar ";
            this.bactualizar.UseVisualStyleBackColor = false;
            this.bactualizar.Visible = false;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // bguardar
            // 
            this.bguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.bguardar.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.bguardar.ForeColor = System.Drawing.Color.White;
            this.bguardar.Location = new System.Drawing.Point(27, 85);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(89, 40);
            this.bguardar.TabIndex = 109;
            this.bguardar.Text = "Guardar ";
            this.bguardar.UseVisualStyleBackColor = false;
            this.bguardar.Visible = false;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // bmodificar
            // 
            this.bmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.bmodificar.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.bmodificar.ForeColor = System.Drawing.Color.White;
            this.bmodificar.Location = new System.Drawing.Point(320, 32);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(100, 38);
            this.bmodificar.TabIndex = 108;
            this.bmodificar.Text = "Modificar";
            this.bmodificar.UseVisualStyleBackColor = false;
            this.bmodificar.Click += new System.EventHandler(this.bmodificar_Click);
            // 
            // beliminar
            // 
            this.beliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.beliminar.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.beliminar.ForeColor = System.Drawing.Color.White;
            this.beliminar.Location = new System.Drawing.Point(174, 32);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(89, 38);
            this.beliminar.TabIndex = 107;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = false;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // bnuevo
            // 
            this.bnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.bnuevo.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.bnuevo.ForeColor = System.Drawing.Color.White;
            this.bnuevo.Location = new System.Drawing.Point(24, 32);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(89, 38);
            this.bnuevo.TabIndex = 106;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = false;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // txtcorreo
            // 
            this.txtcorreo.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.templeadosBindingSource, "correoem", true));
            this.txtcorreo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtcorreo.Location = new System.Drawing.Point(208, 77);
            this.txtcorreo.Multiline = true;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(294, 22);
            this.txtcorreo.TabIndex = 203;
            // 
            // txttelefono
            // 
            this.txttelefono.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.templeadosBindingSource, "telefonoem", true));
            this.txttelefono.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txttelefono.Location = new System.Drawing.Point(206, 190);
            this.txttelefono.Multiline = true;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(297, 22);
            this.txttelefono.TabIndex = 202;
            // 
            // txtdirec
            // 
            this.txtdirec.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.templeadosBindingSource, "direccionem", true));
            this.txtdirec.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtdirec.Location = new System.Drawing.Point(207, 111);
            this.txtdirec.Multiline = true;
            this.txtdirec.Name = "txtdirec";
            this.txtdirec.Size = new System.Drawing.Size(295, 22);
            this.txtdirec.TabIndex = 201;
            // 
            // txtnom
            // 
            this.txtnom.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.templeadosBindingSource, "nombreem", true));
            this.txtnom.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(208, 37);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(294, 22);
            this.txtnom.TabIndex = 196;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(25, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 22);
            this.label17.TabIndex = 191;
            this.label17.Text = "DUI";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(25, 150);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 22);
            this.label18.TabIndex = 190;
            this.label18.Text = "Género";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(26, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(147, 22);
            this.label19.TabIndex = 189;
            this.label19.Text = "Correo electrónico";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(26, 190);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 22);
            this.label20.TabIndex = 188;
            this.label20.Text = "Teléfono ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(26, 37);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(171, 22);
            this.label21.TabIndex = 187;
            this.label21.Text = "Nombre de empleado";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(577, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 186;
            this.pictureBox2.TabStop = false;
            // 
            // templeadosTableAdapter
            // 
            this.templeadosTableAdapter.ClearBeforeFill = true;
            // 
            // tpuestosTableAdapter
            // 
            this.tpuestosTableAdapter.ClearBeforeFill = true;
            // 
            // agregarempleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1329, 619);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregarempleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agregarempleados";
            this.Load += new System.EventHandler(this.agregarempleados_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeadosBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtafp;
        private System.Windows.Forms.TextBox txtis;
        private System.Windows.Forms.TextBox txtdui;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button bcerrar;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtdirec;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtobser;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource templeadosBindingSource;
        private bibliotecaDataSetTableAdapters.templeadosTableAdapter templeadosTableAdapter;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox txtgenero;
        private System.Windows.Forms.ComboBox txtpuesto;
        private System.Windows.Forms.BindingSource tpuestosBindingSource;
        private bibliotecaDataSetTableAdapters.tpuestosTableAdapter tpuestosTableAdapter;
        private System.Windows.Forms.RadioButton rnombre;
    }
}