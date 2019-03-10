namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnconsultar = new System.Windows.Forms.Button();
            this.dgvlistado = new System.Windows.Forms.DataGridView();
            this.dcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(138, 24);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(154, 44);
            this.btnconsultar.TabIndex = 0;
            this.btnconsultar.Text = "CONSULTAR";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // dgvlistado
            // 
            this.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcCodigo,
            this.dcNombre});
            this.dgvlistado.Location = new System.Drawing.Point(23, 99);
            this.dgvlistado.Name = "dgvlistado";
            this.dgvlistado.Size = new System.Drawing.Size(765, 407);
            this.dgvlistado.TabIndex = 1;
            this.dgvlistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistado_CellContentClick);
            // 
            // dcCodigo
            // 
            this.dcCodigo.DataPropertyName = "ArtistId";
            this.dcCodigo.HeaderText = "Codigo";
            this.dcCodigo.Name = "dcCodigo";
            // 
            // dcNombre
            // 
            this.dcNombre.DataPropertyName = "Name";
            this.dcNombre.HeaderText = "Nombre";
            this.dcNombre.Name = "dcNombre";
            this.dcNombre.Width = 300;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 44);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 604);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvlistado);
            this.Controls.Add(this.btnconsultar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcNombre;
        private System.Windows.Forms.TextBox textBox1;
    }
}

