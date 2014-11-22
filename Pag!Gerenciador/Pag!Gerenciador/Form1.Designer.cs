namespace Pag_Gerenciador
{
    partial class Form1
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
            this.btnGerarQrcode = new System.Windows.Forms.Button();
            this.txtIdConsumidor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoConsumidor = new System.Windows.Forms.ComboBox();
            this.picBoxCode = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblConteudoQrCode = new System.Windows.Forms.Label();
            this.btnGerarQrcodeArquivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerarQrcode
            // 
            this.btnGerarQrcode.Location = new System.Drawing.Point(6, 50);
            this.btnGerarQrcode.Name = "btnGerarQrcode";
            this.btnGerarQrcode.Size = new System.Drawing.Size(214, 23);
            this.btnGerarQrcode.TabIndex = 2;
            this.btnGerarQrcode.Text = "Gerar QRCode!";
            this.btnGerarQrcode.UseVisualStyleBackColor = true;
            this.btnGerarQrcode.Click += new System.EventHandler(this.btnGerarQrcode_Click);
            // 
            // txtIdConsumidor
            // 
            this.txtIdConsumidor.Location = new System.Drawing.Point(189, 23);
            this.txtIdConsumidor.Name = "txtIdConsumidor";
            this.txtIdConsumidor.Size = new System.Drawing.Size(211, 20);
            this.txtIdConsumidor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Consumidor (Ex: número da mesa):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo consumidor:";
            // 
            // cmbTipoConsumidor
            // 
            this.cmbTipoConsumidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoConsumidor.FormattingEnabled = true;
            this.cmbTipoConsumidor.Location = new System.Drawing.Point(6, 23);
            this.cmbTipoConsumidor.Name = "cmbTipoConsumidor";
            this.cmbTipoConsumidor.Size = new System.Drawing.Size(170, 21);
            this.cmbTipoConsumidor.TabIndex = 0;
            // 
            // picBoxCode
            // 
            this.picBoxCode.Location = new System.Drawing.Point(249, 120);
            this.picBoxCode.Name = "picBoxCode";
            this.picBoxCode.Size = new System.Drawing.Size(250, 250);
            this.picBoxCode.TabIndex = 7;
            this.picBoxCode.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(6, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gerar QRCode e Salvar Consumidor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblConteudoQrCode
            // 
            this.lblConteudoQrCode.AutoSize = true;
            this.lblConteudoQrCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteudoQrCode.Location = new System.Drawing.Point(132, 388);
            this.lblConteudoQrCode.Name = "lblConteudoQrCode";
            this.lblConteudoQrCode.Size = new System.Drawing.Size(0, 17);
            this.lblConteudoQrCode.TabIndex = 9;
            // 
            // btnGerarQrcodeArquivo
            // 
            this.btnGerarQrcodeArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGerarQrcodeArquivo.Location = new System.Drawing.Point(226, 50);
            this.btnGerarQrcodeArquivo.Name = "btnGerarQrcodeArquivo";
            this.btnGerarQrcodeArquivo.Size = new System.Drawing.Size(214, 23);
            this.btnGerarQrcodeArquivo.TabIndex = 10;
            this.btnGerarQrcodeArquivo.Text = "Gerar QRCode em arquivo";
            this.btnGerarQrcodeArquivo.UseVisualStyleBackColor = false;
            this.btnGerarQrcodeArquivo.Click += new System.EventHandler(this.btnGerarQrcodeArquivo_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGerarQrcode;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 436);
            this.Controls.Add(this.btnGerarQrcodeArquivo);
            this.Controls.Add(this.lblConteudoQrCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBoxCode);
            this.Controls.Add(this.cmbTipoConsumidor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdConsumidor);
            this.Controls.Add(this.btnGerarQrcode);
            this.Name = "Form1";
            this.Text = "Gerar QRCode";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarQrcode;
        private System.Windows.Forms.TextBox txtIdConsumidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoConsumidor;
        private System.Windows.Forms.PictureBox picBoxCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblConteudoQrCode;
        private System.Windows.Forms.Button btnGerarQrcodeArquivo;
    }
}

