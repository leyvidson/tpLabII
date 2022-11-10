namespace PyCINE_01.Forms
{
    partial class FormConsultas
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
            this.panelContenedorConsultas = new System.Windows.Forms.Panel();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.lblCerrarConsultas = new System.Windows.Forms.Label();
            this.cmbConsultas = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelContenedorConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedorConsultas
            // 
            this.panelContenedorConsultas.Controls.Add(this.dataGridView1);
            this.panelContenedorConsultas.Controls.Add(this.cmbConsultas);
            this.panelContenedorConsultas.Controls.Add(this.lblCerrarConsultas);
            this.panelContenedorConsultas.Controls.Add(this.lblConsultas);
            this.panelContenedorConsultas.Location = new System.Drawing.Point(1, 2);
            this.panelContenedorConsultas.Name = "panelContenedorConsultas";
            this.panelContenedorConsultas.Size = new System.Drawing.Size(686, 448);
            this.panelContenedorConsultas.TabIndex = 0;
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblConsultas.Location = new System.Drawing.Point(297, 36);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(90, 22);
            this.lblConsultas.TabIndex = 0;
            this.lblConsultas.Text = "Consultas";
            // 
            // lblCerrarConsultas
            // 
            this.lblCerrarConsultas.AutoSize = true;
            this.lblCerrarConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblCerrarConsultas.Location = new System.Drawing.Point(664, 0);
            this.lblCerrarConsultas.Name = "lblCerrarConsultas";
            this.lblCerrarConsultas.Size = new System.Drawing.Size(22, 22);
            this.lblCerrarConsultas.TabIndex = 1;
            this.lblCerrarConsultas.Text = "X";
            this.lblCerrarConsultas.Click += new System.EventHandler(this.lblCerrarConsultas_Click);
            // 
            // cmbConsultas
            // 
            this.cmbConsultas.FormattingEnabled = true;
            this.cmbConsultas.Location = new System.Drawing.Point(53, 72);
            this.cmbConsultas.Name = "cmbConsultas";
            this.cmbConsultas.Size = new System.Drawing.Size(121, 21);
            this.cmbConsultas.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 272);
            this.dataGridView1.TabIndex = 3;
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 451);
            this.Controls.Add(this.panelContenedorConsultas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultas";
            this.Text = "Consultas";
            this.panelContenedorConsultas.ResumeLayout(false);
            this.panelContenedorConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedorConsultas;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.Label lblCerrarConsultas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbConsultas;
    }
}