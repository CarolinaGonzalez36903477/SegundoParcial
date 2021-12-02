
namespace SegundoParcial.cosola
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
            this.cmbTipoPF = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTasainteres = new System.Windows.Forms.TextBox();
            this.tbCapital = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbdias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbinteres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMontoFinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstboxPlazo = new System.Windows.Forms.ListBox();
            this.txbtMontototal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbComisionTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTipoPF
            // 
            this.cmbTipoPF.FormattingEnabled = true;
            this.cmbTipoPF.Location = new System.Drawing.Point(168, 57);
            this.cmbTipoPF.Name = "cmbTipoPF";
            this.cmbTipoPF.Size = new System.Drawing.Size(180, 28);
            this.cmbTipoPF.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo Plazo Fijo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tasa Interes";
            // 
            // txbTasainteres
            // 
            this.txbTasainteres.Location = new System.Drawing.Point(168, 114);
            this.txbTasainteres.Name = "txbTasainteres";
            this.txbTasainteres.Size = new System.Drawing.Size(180, 26);
            this.txbTasainteres.TabIndex = 3;
            // 
            // tbCapital
            // 
            this.tbCapital.Location = new System.Drawing.Point(168, 168);
            this.tbCapital.Name = "tbCapital";
            this.tbCapital.Size = new System.Drawing.Size(180, 26);
            this.tbCapital.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Capital a invertir";
            // 
            // txbdias
            // 
            this.txbdias.Location = new System.Drawing.Point(168, 224);
            this.txbdias.Name = "txbdias";
            this.txbdias.Size = new System.Drawing.Size(180, 26);
            this.txbdias.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dias";
            // 
            // txbinteres
            // 
            this.txbinteres.Location = new System.Drawing.Point(168, 276);
            this.txbinteres.Name = "txbinteres";
            this.txbinteres.Size = new System.Drawing.Size(180, 26);
            this.txbinteres.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Interes a recibir";
            // 
            // txbMontoFinal
            // 
            this.txbMontoFinal.Location = new System.Drawing.Point(168, 334);
            this.txbMontoFinal.Name = "txbMontoFinal";
            this.txbMontoFinal.Size = new System.Drawing.Size(180, 26);
            this.txbMontoFinal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Monto Final";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(110, 438);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 14;
            this.btnSimular.Text = "button1";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(260, 438);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "button2";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(183, 493);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "button3";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstboxPlazo
            // 
            this.lstboxPlazo.FormattingEnabled = true;
            this.lstboxPlazo.ItemHeight = 20;
            this.lstboxPlazo.Location = new System.Drawing.Point(477, 65);
            this.lstboxPlazo.Name = "lstboxPlazo";
            this.lstboxPlazo.Size = new System.Drawing.Size(281, 324);
            this.lstboxPlazo.TabIndex = 17;
            // 
            // txbtMontototal
            // 
            this.txbtMontototal.Location = new System.Drawing.Point(578, 435);
            this.txbtMontototal.Name = "txbtMontototal";
            this.txbtMontototal.Size = new System.Drawing.Size(180, 26);
            this.txbtMontototal.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Monto Total";
            // 
            // txbComisionTotal
            // 
            this.txbComisionTotal.Location = new System.Drawing.Point(578, 480);
            this.txbComisionTotal.Name = "txbComisionTotal";
            this.txbComisionTotal.Size = new System.Drawing.Size(180, 26);
            this.txbComisionTotal.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Comision Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.txbComisionTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbtMontototal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstboxPlazo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.txbMontoFinal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbinteres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbdias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCapital);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTasainteres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoPF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTasainteres;
        private System.Windows.Forms.TextBox tbCapital;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbdias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbinteres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbMontoFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstboxPlazo;
        private System.Windows.Forms.TextBox txbtMontototal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbComisionTotal;
        private System.Windows.Forms.Label label9;
    }
}

