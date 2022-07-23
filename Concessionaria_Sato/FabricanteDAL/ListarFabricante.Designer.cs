namespace Concessionaria_Sato.FabricanteDAL
{
    partial class ListarFabricante
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
            this.dgvFabricante = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricante)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFabricante
            // 
            this.dgvFabricante.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFabricante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabricante.Location = new System.Drawing.Point(12, 12);
            this.dgvFabricante.Name = "dgvFabricante";
            this.dgvFabricante.Size = new System.Drawing.Size(524, 286);
            this.dgvFabricante.TabIndex = 0;
            // 
            // ListarFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 310);
            this.Controls.Add(this.dgvFabricante);
            this.Name = "ListarFabricante";
            this.Text = "ListarFabricante";
            this.Load += new System.EventHandler(this.ListarFabricante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFabricante;
    }
}