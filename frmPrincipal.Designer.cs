namespace winHamburguesa
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ckbCebolla = new System.Windows.Forms.CheckBox();
            this.ckbPepinillo = new System.Windows.Forms.CheckBox();
            this.ckbTocineta = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // ckbCebolla
            // 
            this.ckbCebolla.AutoSize = true;
            this.ckbCebolla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCebolla.Location = new System.Drawing.Point(88, 63);
            this.ckbCebolla.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ckbCebolla.Name = "ckbCebolla";
            this.ckbCebolla.Size = new System.Drawing.Size(148, 40);
            this.ckbCebolla.TabIndex = 0;
            this.ckbCebolla.Text = "Cebolla";
            this.ckbCebolla.UseVisualStyleBackColor = true;
            // 
            // ckbPepinillo
            // 
            this.ckbPepinillo.AutoSize = true;
            this.ckbPepinillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPepinillo.Location = new System.Drawing.Point(88, 142);
            this.ckbPepinillo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ckbPepinillo.Name = "ckbPepinillo";
            this.ckbPepinillo.Size = new System.Drawing.Size(162, 40);
            this.ckbPepinillo.TabIndex = 1;
            this.ckbPepinillo.Text = "Pepinillo";
            this.ckbPepinillo.UseVisualStyleBackColor = true;
            // 
            // ckbTocineta
            // 
            this.ckbTocineta.AutoSize = true;
            this.ckbTocineta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTocineta.Location = new System.Drawing.Point(88, 223);
            this.ckbTocineta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ckbTocineta.Name = "ckbTocineta";
            this.ckbTocineta.Size = new System.Drawing.Size(161, 40);
            this.ckbTocineta.TabIndex = 2;
            this.ckbTocineta.Text = "Tocineta";
            this.ckbTocineta.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(468, 63);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(260, 150);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular Orden";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(174, 335);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(89, 36);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(314, 321);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(196, 41);
            this.txtTotal.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(264, 431);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(262, 85);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(804, 23);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(40, 38);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(814, 554);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 600);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.ckbTocineta);
            this.Controls.Add(this.ckbPepinillo);
            this.Controls.Add(this.ckbCebolla);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmPrincipal";
            this.Text = "Hamburguesa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbCebolla;
        private System.Windows.Forms.CheckBox ckbPepinillo;
        private System.Windows.Forms.CheckBox ckbTocineta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

