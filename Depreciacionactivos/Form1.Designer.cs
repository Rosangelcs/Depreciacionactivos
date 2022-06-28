namespace Depreciacionactivos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.Residual = new System.Windows.Forms.TextBox();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depreciacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Anual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.texttotal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor del Activo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(49, 63);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(100, 20);
            this.txtcosto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vida Util del Activo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Año,
            this.Depreciacion,
            this.Total_Anual});
            this.data.Location = new System.Drawing.Point(249, 33);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(341, 355);
            this.data.TabIndex = 13;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // Residual
            // 
            this.Residual.Location = new System.Drawing.Point(49, 117);
            this.Residual.Name = "Residual";
            this.Residual.Size = new System.Drawing.Size(100, 20);
            this.Residual.TabIndex = 3;
            // 
            // Año
            // 
            this.Año.HeaderText = "Valor del Activo";
            this.Año.Name = "Año";
            // 
            // Depreciacion
            // 
            this.Depreciacion.HeaderText = "Vida Util del Activo";
            this.Depreciacion.Name = "Depreciacion";
            // 
            // Total_Anual
            // 
            this.Total_Anual.HeaderText = "Depreciacion Anual";
            this.Total_Anual.Name = "Total_Anual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Depreciacion Anual:";
            // 
            // texttotal
            // 
            this.texttotal.Location = new System.Drawing.Point(49, 168);
            this.texttotal.Name = "texttotal";
            this.texttotal.Size = new System.Drawing.Size(100, 20);
            this.texttotal.TabIndex = 15;
            this.texttotal.TextChanged += new System.EventHandler(this.texttotal_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.texttotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Residual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Depreciacion Activo Fijos";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox Residual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depreciacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Anual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texttotal;
        private System.Windows.Forms.Button button2;
    }
}

