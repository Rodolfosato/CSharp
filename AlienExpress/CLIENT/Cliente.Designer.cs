﻿namespace AlienExpress
{
    partial class Cliente
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
            this.cARTEIRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cARRINHOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cARTEIRAToolStripMenuItem,
            this.cARRINHOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cARTEIRAToolStripMenuItem
            // 
            this.cARTEIRAToolStripMenuItem.Name = "cARTEIRAToolStripMenuItem";
            this.cARTEIRAToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.cARTEIRAToolStripMenuItem.Text = "LOJA";
            this.cARTEIRAToolStripMenuItem.Click += new System.EventHandler(this.cARTEIRAToolStripMenuItem_Click);
            // 
            // cARRINHOToolStripMenuItem
            // 
            this.cARRINHOToolStripMenuItem.Name = "cARRINHOToolStripMenuItem";
            this.cARRINHOToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.cARRINHOToolStripMenuItem.Text = "CARRINHO";
            this.cARRINHOToolStripMenuItem.Click += new System.EventHandler(this.cARRINHOToolStripMenuItem_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlienExpress.Properties.Resources.classificacao_do_cliente_icon_ilustracao_138676_400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cARTEIRAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cARRINHOToolStripMenuItem;
    }
}