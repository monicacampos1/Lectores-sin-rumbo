
namespace Practica_semana_10
{
    partial class ventanaAyuda
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
            this.textContedor = new System.Windows.Forms.TextBox();
            this.bcerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textContedor
            // 
            this.textContedor.BackColor = System.Drawing.Color.LightYellow;
            this.textContedor.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.textContedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textContedor.Location = new System.Drawing.Point(15, 28);
            this.textContedor.Multiline = true;
            this.textContedor.Name = "textContedor";
            this.textContedor.Size = new System.Drawing.Size(915, 505);
            this.textContedor.TabIndex = 0;
            this.textContedor.TextChanged += new System.EventHandler(this.textContedor_TextChanged);
            // 
            // bcerrar
            // 
            this.bcerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.bcerrar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.bcerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bcerrar.Location = new System.Drawing.Point(992, 588);
            this.bcerrar.Name = "bcerrar";
            this.bcerrar.Size = new System.Drawing.Size(100, 33);
            this.bcerrar.TabIndex = 1;
            this.bcerrar.Text = "Cerrar";
            this.bcerrar.UseVisualStyleBackColor = false;
            this.bcerrar.Click += new System.EventHandler(this.bcerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.groupBox1.Controls.Add(this.textContedor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(144, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 557);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario de ayuda ";
            // 
            // ventanaAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1175, 686);
            this.Controls.Add(this.bcerrar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ventanaAyuda";
            this.Text = "ventanaAyuda";
            this.Load += new System.EventHandler(this.ventanaAyuda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textContedor;
        private System.Windows.Forms.Button bcerrar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}