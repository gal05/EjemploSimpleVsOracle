namespace ConectividadOracle.PresentacionWindows
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
            this.BtnListar = new System.Windows.Forms.Button();
            this.DgvMercado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMercado)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(72, 158);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(182, 26);
            this.BtnListar.TabIndex = 0;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // DgvMercado
            // 
            this.DgvMercado.AllowUserToAddRows = false;
            this.DgvMercado.AllowUserToDeleteRows = false;
            this.DgvMercado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMercado.Location = new System.Drawing.Point(12, 223);
            this.DgvMercado.Name = "DgvMercado";
            this.DgvMercado.ReadOnly = true;
            this.DgvMercado.Size = new System.Drawing.Size(468, 175);
            this.DgvMercado.TabIndex = 1;
            this.DgvMercado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMercado_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvMercado);
            this.Controls.Add(this.BtnListar);
            this.Name = "Form1";
            this.Text = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb" +
    "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb56";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMercado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.DataGridView DgvMercado;
        private System.Windows.Forms.Label label1;
    }
}

