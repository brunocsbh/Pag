namespace Pag_Gerenciador
{
    partial class FormPrincipal
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
            this.gerarConsumidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirConsumidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentaçõesToolStripMenuItem,
            this.gerarConsumidorToolStripMenuItem,
            this.imprimirConsumidoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerarConsumidorToolStripMenuItem
            // 
            this.gerarConsumidorToolStripMenuItem.Name = "gerarConsumidorToolStripMenuItem";
            this.gerarConsumidorToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.gerarConsumidorToolStripMenuItem.Text = "Gerar Consumidor";
            this.gerarConsumidorToolStripMenuItem.Click += new System.EventHandler(this.gerarConsumidorToolStripMenuItem_Click);
            // 
            // imprimirConsumidoresToolStripMenuItem
            // 
            this.imprimirConsumidoresToolStripMenuItem.Name = "imprimirConsumidoresToolStripMenuItem";
            this.imprimirConsumidoresToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.imprimirConsumidoresToolStripMenuItem.Text = "Imprimir Consumidores";
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            this.movimentaçõesToolStripMenuItem.Click += new System.EventHandler(this.movimentaçõesToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 472);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.Text = "Pag! Gerenciador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gerarConsumidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirConsumidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;

    }
}