
namespace Practica_semana_10
{
    partial class agregareditoriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregareditoriales));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rnombre = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpais = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bcerrar = new System.Windows.Forms.Button();
            this.bactualizar = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bnuevo = new System.Windows.Forms.Button();
            this.txtdirecc = new System.Windows.Forms.TextBox();
            this.teditorialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Practica_semana_10.bibliotecaDataSet();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtcontac = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.teditorialesTableAdapter = new Practica_semana_10.bibliotecaDataSetTableAdapters.teditorialesTableAdapter();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teditorialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox2.Controls.Add(this.rnombre);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.txtbuscar);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(666, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 576);
            this.groupBox2.TabIndex = 212;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editorials registradas";
            // 
            // rnombre
            // 
            this.rnombre.AutoSize = true;
            this.rnombre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rnombre.Location = new System.Drawing.Point(95, 64);
            this.rnombre.Name = "rnombre";
            this.rnombre.Size = new System.Drawing.Size(94, 26);
            this.rnombre.TabIndex = 137;
            this.rnombre.TabStop = true;
            this.rnombre.Text = "Nombre ";
            this.rnombre.UseVisualStyleBackColor = true;
            this.rnombre.CheckedChanged += new System.EventHandler(this.rnombre_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(95, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 26);
            this.radioButton1.TabIndex = 135;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Codigo";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(531, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 133;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 422);
            this.dataGridView1.TabIndex = 132;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtbuscar.Location = new System.Drawing.Point(210, 46);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(315, 26);
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
            this.groupBox1.Controls.Add(this.txtpais);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtdirecc);
            this.groupBox1.Controls.Add(this.txtcorreo);
            this.groupBox1.Controls.Add(this.txtcontac);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 576);
            this.groupBox1.TabIndex = 211;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario agregar editoriales";
            // 
            // txtpais
            // 
            this.txtpais.FormattingEnabled = true;
            this.txtpais.Items.AddRange(new object[] {
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos"});
            this.txtpais.Location = new System.Drawing.Point(216, 232);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(294, 34);
            this.txtpais.TabIndex = 210;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bcerrar);
            this.groupBox4.Controls.Add(this.bactualizar);
            this.groupBox4.Controls.Add(this.bguardar);
            this.groupBox4.Controls.Add(this.bmodificar);
            this.groupBox4.Controls.Add(this.beliminar);
            this.groupBox4.Controls.Add(this.bnuevo);
            this.groupBox4.Location = new System.Drawing.Point(22, 354);
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
            this.bcerrar.Location = new System.Drawing.Point(494, 32);
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
            this.bactualizar.Location = new System.Drawing.Point(330, 85);
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
            this.bmodificar.Location = new System.Drawing.Point(331, 32);
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
            this.beliminar.Location = new System.Drawing.Point(189, 32);
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
            // txtdirecc
            // 
            this.txtdirecc.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.teditorialesBindingSource, "direccione", true));
            this.txtdirecc.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtdirecc.Location = new System.Drawing.Point(216, 165);
            this.txtdirecc.Multiline = true;
            this.txtdirecc.Name = "txtdirecc";
            this.txtdirecc.Size = new System.Drawing.Size(294, 22);
            this.txtdirecc.TabIndex = 203;
            // 
            // teditorialesBindingSource
            // 
            this.teditorialesBindingSource.DataMember = "teditoriales";
            this.teditorialesBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtcorreo
            // 
            this.txtcorreo.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.teditorialesBindingSource, "correoe", true));
            this.txtcorreo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtcorreo.Location = new System.Drawing.Point(215, 278);
            this.txtcorreo.Multiline = true;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(295, 22);
            this.txtcorreo.TabIndex = 202;
            // 
            // txtcontac
            // 
            this.txtcontac.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.teditorialesBindingSource, "contactose", true));
            this.txtcontac.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtcontac.Location = new System.Drawing.Point(215, 199);
            this.txtcontac.Multiline = true;
            this.txtcontac.Name = "txtcontac";
            this.txtcontac.Size = new System.Drawing.Size(295, 22);
            this.txtcontac.TabIndex = 201;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(32, 278);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 22);
            this.label17.TabIndex = 191;
            this.label17.Text = "Correo electrónico";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(33, 238);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 22);
            this.label18.TabIndex = 190;
            this.label18.Text = "Pais";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(34, 199);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 22);
            this.label19.TabIndex = 189;
            this.label19.Text = "Contacto";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(34, 165);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 22);
            this.label20.TabIndex = 188;
            this.label20.Text = "Dirección";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(34, 125);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(161, 22);
            this.label21.TabIndex = 187;
            this.label21.Text = "Nombre de editorial";
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
            // teditorialesTableAdapter
            // 
            this.teditorialesTableAdapter.ClearBeforeFill = true;
            // 
            // txtnome
            // 
            this.txtnome.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.teditorialesBindingSource, "nombree", true));
            this.txtnome.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(216, 125);
            this.txtnome.Multiline = true;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(294, 22);
            this.txtnome.TabIndex = 196;
            // 
            // agregareditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1329, 619);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregareditoriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agregareditoriales";
            this.Load += new System.EventHandler(this.agregareditoriales_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teditorialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button bcerrar;
        private System.Windows.Forms.TextBox txtdirecc;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtcontac;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox2;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource teditorialesBindingSource;
        private bibliotecaDataSetTableAdapters.teditorialesTableAdapter teditorialesTableAdapter;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox txtpais;
        private System.Windows.Forms.RadioButton rnombre;
        private System.Windows.Forms.TextBox txtnome;
    }
}