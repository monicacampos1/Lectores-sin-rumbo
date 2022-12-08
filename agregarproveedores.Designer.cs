
namespace Practica_semana_10
{
    partial class agregarproveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarproveedores));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rnombre = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.bbuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdistri = new System.Windows.Forms.TextBox();
            this.tproveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Practica_semana_10.bibliotecaDataSet();
            this.txtdirecc = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bcerrar = new System.Windows.Forms.Button();
            this.bactualizar = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bnuevo = new System.Windows.Forms.Button();
            this.txtprove = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tproveedoresTableAdapter = new Practica_semana_10.bibliotecaDataSetTableAdapters.tproveedoresTableAdapter();
            this.txtedi = new System.Windows.Forms.ComboBox();
            this.teditorialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teditorialesTableAdapter = new Practica_semana_10.bibliotecaDataSetTableAdapters.teditorialesTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tproveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teditorialesBindingSource)).BeginInit();
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
            this.groupBox2.Location = new System.Drawing.Point(666, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 571);
            this.groupBox2.TabIndex = 212;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar proveedores";
            // 
            // rnombre
            // 
            this.rnombre.AutoSize = true;
            this.rnombre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rnombre.Location = new System.Drawing.Point(100, 56);
            this.rnombre.Name = "rnombre";
            this.rnombre.Size = new System.Drawing.Size(94, 26);
            this.rnombre.TabIndex = 206;
            this.rnombre.TabStop = true;
            this.rnombre.Text = "Nombre ";
            this.rnombre.UseVisualStyleBackColor = true;
            this.rnombre.CheckedChanged += new System.EventHandler(this.rnombre_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(101, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 26);
            this.radioButton1.TabIndex = 205;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Codigo";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(27, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 431);
            this.dataGridView1.TabIndex = 132;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtbuscar.Location = new System.Drawing.Point(212, 46);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(313, 26);
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
            this.groupBox1.Controls.Add(this.txtedi);
            this.groupBox1.Controls.Add(this.txtdistri);
            this.groupBox1.Controls.Add(this.txtdirecc);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtprove);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 571);
            this.groupBox1.TabIndex = 211;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario agregar proveedores ";
            // 
            // txtdistri
            // 
            this.txtdistri.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tproveedoresBindingSource, "nomdistribuidorapro", true));
            this.txtdistri.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtdistri.Location = new System.Drawing.Point(214, 245);
            this.txtdistri.Multiline = true;
            this.txtdistri.Name = "txtdistri";
            this.txtdistri.Size = new System.Drawing.Size(294, 22);
            this.txtdistri.TabIndex = 204;
            // 
            // tproveedoresBindingSource
            // 
            this.tproveedoresBindingSource.DataMember = "tproveedores";
            this.tproveedoresBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtdirecc
            // 
            this.txtdirecc.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tproveedoresBindingSource, "direccionpro", true));
            this.txtdirecc.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtdirecc.Location = new System.Drawing.Point(214, 282);
            this.txtdirecc.Multiline = true;
            this.txtdirecc.Name = "txtdirecc";
            this.txtdirecc.Size = new System.Drawing.Size(294, 49);
            this.txtdirecc.TabIndex = 200;
            // 
            // txttelefono
            // 
            this.txttelefono.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tproveedoresBindingSource, "telefonopro", true));
            this.txttelefono.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txttelefono.Location = new System.Drawing.Point(214, 202);
            this.txttelefono.Multiline = true;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(294, 22);
            this.txttelefono.TabIndex = 203;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 202;
            this.label2.Text = "Distribuidora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 201;
            this.label1.Text = "Teléfono";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bcerrar);
            this.groupBox3.Controls.Add(this.bactualizar);
            this.groupBox3.Controls.Add(this.bguardar);
            this.groupBox3.Controls.Add(this.bmodificar);
            this.groupBox3.Controls.Add(this.beliminar);
            this.groupBox3.Controls.Add(this.bnuevo);
            this.groupBox3.Location = new System.Drawing.Point(14, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(612, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // bcerrar
            // 
            this.bcerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.bcerrar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.bcerrar.ForeColor = System.Drawing.Color.White;
            this.bcerrar.Location = new System.Drawing.Point(467, 32);
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
            this.bactualizar.Location = new System.Drawing.Point(322, 96);
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
            this.bguardar.Location = new System.Drawing.Point(24, 85);
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
            this.bmodificar.Location = new System.Drawing.Point(322, 32);
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
            this.beliminar.Location = new System.Drawing.Point(173, 32);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(101, 38);
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
            // txtprove
            // 
            this.txtprove.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tproveedoresBindingSource, "nombrepro", true));
            this.txtprove.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtprove.Location = new System.Drawing.Point(212, 153);
            this.txtprove.Multiline = true;
            this.txtprove.Name = "txtprove";
            this.txtprove.Size = new System.Drawing.Size(294, 22);
            this.txtprove.TabIndex = 199;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(31, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 22);
            this.label13.TabIndex = 195;
            this.label13.Text = "Nombre de proveedor";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(34, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 22);
            this.label16.TabIndex = 192;
            this.label16.Text = "Id editorial";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(34, 282);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 22);
            this.label18.TabIndex = 190;
            this.label18.Text = "Direción";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 186;
            this.pictureBox2.TabStop = false;
            // 
            // tproveedoresTableAdapter
            // 
            this.tproveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // txtedi
            // 
            this.txtedi.DataSource = this.teditorialesBindingSource;
            this.txtedi.DisplayMember = "ideditorial";
            this.txtedi.FormattingEnabled = true;
            this.txtedi.Location = new System.Drawing.Point(214, 105);
            this.txtedi.Name = "txtedi";
            this.txtedi.Size = new System.Drawing.Size(294, 34);
            this.txtedi.TabIndex = 205;
            // 
            // teditorialesBindingSource
            // 
            this.teditorialesBindingSource.DataMember = "teditoriales";
            this.teditorialesBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // teditorialesTableAdapter
            // 
            this.teditorialesTableAdapter.ClearBeforeFill = true;
            // 
            // agregarproveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1329, 619);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregarproveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agregarproveedores";
            this.Load += new System.EventHandler(this.agregarproveedores_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tproveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teditorialesBindingSource)).EndInit();
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
        private System.Windows.Forms.Button bcerrar;
        private System.Windows.Forms.TextBox txtdistri;
        private System.Windows.Forms.TextBox txtdirecc;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.TextBox txtprove;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox2;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource tproveedoresBindingSource;
        private bibliotecaDataSetTableAdapters.tproveedoresTableAdapter tproveedoresTableAdapter;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rnombre;
        private System.Windows.Forms.ComboBox txtedi;
        private System.Windows.Forms.BindingSource teditorialesBindingSource;
        private bibliotecaDataSetTableAdapters.teditorialesTableAdapter teditorialesTableAdapter;
    }
}