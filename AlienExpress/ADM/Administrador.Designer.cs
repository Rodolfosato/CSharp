namespace AlienExpress
{
    partial class Administrador
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDICIONARPRODUTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTARPRODUTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETARPRODUTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXCLUIRPRODUTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDICIONARPRODUTOToolStripMenuItem,
            this.lISTARPRODUTOSToolStripMenuItem,
            this.dELETARPRODUTOSToolStripMenuItem,
            this.eXCLUIRPRODUTOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDICIONARPRODUTOToolStripMenuItem
            // 
            this.aDICIONARPRODUTOToolStripMenuItem.Name = "aDICIONARPRODUTOToolStripMenuItem";
            this.aDICIONARPRODUTOToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.aDICIONARPRODUTOToolStripMenuItem.Text = "ADICIONAR PRODUTO";
            this.aDICIONARPRODUTOToolStripMenuItem.Click += new System.EventHandler(this.aDICIONARPRODUTOToolStripMenuItem_Click);
            // 
            // lISTARPRODUTOSToolStripMenuItem
            // 
            this.lISTARPRODUTOSToolStripMenuItem.Name = "lISTARPRODUTOSToolStripMenuItem";
            this.lISTARPRODUTOSToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.lISTARPRODUTOSToolStripMenuItem.Text = "LISTAR PRODUTOS";
            this.lISTARPRODUTOSToolStripMenuItem.Click += new System.EventHandler(this.lISTARPRODUTOSToolStripMenuItem_Click);
            // 
            // dELETARPRODUTOSToolStripMenuItem
            // 
            this.dELETARPRODUTOSToolStripMenuItem.Name = "dELETARPRODUTOSToolStripMenuItem";
            this.dELETARPRODUTOSToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.dELETARPRODUTOSToolStripMenuItem.Text = "EDITAR PRODUTOS";
            this.dELETARPRODUTOSToolStripMenuItem.Click += new System.EventHandler(this.dELETARPRODUTOSToolStripMenuItem_Click);
            // 
            // eXCLUIRPRODUTOSToolStripMenuItem
            // 
            this.eXCLUIRPRODUTOSToolStripMenuItem.Name = "eXCLUIRPRODUTOSToolStripMenuItem";
            this.eXCLUIRPRODUTOSToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.eXCLUIRPRODUTOSToolStripMenuItem.Text = "EXCLUIR PRODUTOS";
            this.eXCLUIRPRODUTOSToolStripMenuItem.Click += new System.EventHandler(this.eXCLUIRPRODUTOSToolStripMenuItem_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlienExpress.Properties.Resources.ADM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 361);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDICIONARPRODUTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTARPRODUTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETARPRODUTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXCLUIRPRODUTOSToolStripMenuItem;
    }
}