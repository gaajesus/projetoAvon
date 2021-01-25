namespace avon
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCod = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.rdbAvon = new System.Windows.Forms.RadioButton();
            this.rdbNatura = new System.Windows.Forms.RadioButton();
            this.rdbAbelha = new System.Windows.Forms.RadioButton();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblDescri = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.gbxCat = new System.Windows.Forms.GroupBox();
            this.lblComi = new System.Windows.Forms.Label();
            this.txtComi = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gbxCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(23, 69);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(99, 254);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(99, 66);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(23, 140);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Preço";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(23, 108);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(65, 13);
            this.lblQtd.TabIndex = 5;
            this.lblQtd.Text = "Quantidade:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(99, 137);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // rdbAvon
            // 
            this.rdbAvon.AutoSize = true;
            this.rdbAvon.Checked = true;
            this.rdbAvon.Location = new System.Drawing.Point(264, 43);
            this.rdbAvon.Name = "rdbAvon";
            this.rdbAvon.Size = new System.Drawing.Size(47, 17);
            this.rdbAvon.TabIndex = 7;
            this.rdbAvon.TabStop = true;
            this.rdbAvon.Text = "AVO";
            this.rdbAvon.UseVisualStyleBackColor = true;
            this.rdbAvon.CheckedChanged += new System.EventHandler(this.rdbAvon_CheckedChanged);
            // 
            // rdbNatura
            // 
            this.rdbNatura.AutoSize = true;
            this.rdbNatura.Location = new System.Drawing.Point(450, 43);
            this.rdbNatura.Name = "rdbNatura";
            this.rdbNatura.Size = new System.Drawing.Size(47, 17);
            this.rdbNatura.TabIndex = 8;
            this.rdbNatura.Text = "NAT";
            this.rdbNatura.UseVisualStyleBackColor = true;
            this.rdbNatura.CheckedChanged += new System.EventHandler(this.rdbNatura_CheckedChanged);
            // 
            // rdbAbelha
            // 
            this.rdbAbelha.AutoSize = true;
            this.rdbAbelha.Location = new System.Drawing.Point(355, 43);
            this.rdbAbelha.Name = "rdbAbelha";
            this.rdbAbelha.Size = new System.Drawing.Size(46, 17);
            this.rdbAbelha.TabIndex = 9;
            this.rdbAbelha.Text = "ABE";
            this.rdbAbelha.UseVisualStyleBackColor = true;
            this.rdbAbelha.CheckedChanged += new System.EventHandler(this.rdbAbelha_CheckedChanged);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(192, 254);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(273, 254);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lblDescri
            // 
            this.lblDescri.AutoSize = true;
            this.lblDescri.Location = new System.Drawing.Point(6, 16);
            this.lblDescri.Name = "lblDescri";
            this.lblDescri.Size = new System.Drawing.Size(35, 13);
            this.lblDescri.TabIndex = 12;
            this.lblDescri.Text = "label1";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(99, 101);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 20);
            this.txtQtd.TabIndex = 13;
            // 
            // gbxCat
            // 
            this.gbxCat.Controls.Add(this.lblDescri);
            this.gbxCat.Location = new System.Drawing.Point(264, 75);
            this.gbxCat.Name = "gbxCat";
            this.gbxCat.Size = new System.Drawing.Size(200, 125);
            this.gbxCat.TabIndex = 14;
            this.gbxCat.TabStop = false;
            this.gbxCat.Text = "Catálogo";
            // 
            // lblComi
            // 
            this.lblComi.AutoSize = true;
            this.lblComi.Location = new System.Drawing.Point(23, 219);
            this.lblComi.Name = "lblComi";
            this.lblComi.Size = new System.Drawing.Size(52, 13);
            this.lblComi.TabIndex = 15;
            this.lblComi.Text = "Comissão";
            // 
            // txtComi
            // 
            this.txtComi.Location = new System.Drawing.Point(99, 216);
            this.txtComi.Name = "txtComi";
            this.txtComi.Size = new System.Drawing.Size(100, 20);
            this.txtComi.TabIndex = 17;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(23, 193);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(99, 190);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtComi);
            this.Controls.Add(this.lblComi);
            this.Controls.Add(this.gbxCat);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.rdbAbelha);
            this.Controls.Add(this.rdbNatura);
            this.Controls.Add(this.rdbAvon);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxCat.ResumeLayout(false);
            this.gbxCat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.RadioButton rdbAvon;
        private System.Windows.Forms.RadioButton rdbNatura;
        private System.Windows.Forms.RadioButton rdbAbelha;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblDescri;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.GroupBox gbxCat;
        private System.Windows.Forms.Label lblComi;
        private System.Windows.Forms.TextBox txtComi;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

