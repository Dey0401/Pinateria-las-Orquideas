namespace appPractica1
{
    partial class frmPedido
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
            this.Title = new System.Windows.Forms.Label();
            this.productoText = new System.Windows.Forms.Label();
            this.labelVA = new System.Windows.Forms.Label();
            this.labelCant = new System.Windows.Forms.Label();
            this.vrDocenaText = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVrDocena = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.grbAPagar = new System.Windows.Forms.GroupBox();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSubTot = new System.Windows.Forms.Label();
            this.lblVrIVA = new System.Windows.Forms.Label();
            this.lblTotAPag = new System.Windows.Forms.Label();
            this.lblVrDscto = new System.Windows.Forms.Label();
            this.lblPorcDscto = new System.Windows.Forms.Label();
            this.grbAPagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.Control;
            this.Title.CausesValidation = false;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(50, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(285, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "Piñata las Orquídeas";
            // 
            // productoText
            // 
            this.productoText.AutoSize = true;
            this.productoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoText.Location = new System.Drawing.Point(124, 78);
            this.productoText.Name = "productoText";
            this.productoText.Size = new System.Drawing.Size(77, 20);
            this.productoText.TabIndex = 1;
            this.productoText.Text = "Producto:";
            // 
            // labelVA
            // 
            this.labelVA.AutoSize = true;
            this.labelVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVA.Location = new System.Drawing.Point(143, 176);
            this.labelVA.Name = "labelVA";
            this.labelVA.Size = new System.Drawing.Size(58, 20);
            this.labelVA.TabIndex = 2;
            this.labelVA.Text = "% IVA:";
            // 
            // labelCant
            // 
            this.labelCant.AutoSize = true;
            this.labelCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCant.Location = new System.Drawing.Point(69, 143);
            this.labelCant.Name = "labelCant";
            this.labelCant.Size = new System.Drawing.Size(132, 20);
            this.labelCant.TabIndex = 3;
            this.labelCant.Text = "Cantidad (Unids):";
            // 
            // vrDocenaText
            // 
            this.vrDocenaText.AutoSize = true;
            this.vrDocenaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vrDocenaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrDocenaText.Location = new System.Drawing.Point(46, 108);
            this.vrDocenaText.Name = "vrDocenaText";
            this.vrDocenaText.Size = new System.Drawing.Size(155, 22);
            this.vrDocenaText.TabIndex = 4;
            this.vrDocenaText.Text = "               Vr. Docena:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.AutoCompleteCustomSource.AddRange(new string[] {
            "Producto 1",
            "Producto 2",
            "Otro Producto"});
            this.cmbProducto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Items.AddRange(new object[] {
            "Producto 1",
            "Producto 2",
            "Otro Producto"});
            this.cmbProducto.Location = new System.Drawing.Point(214, 77);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // txtVrDocena
            // 
            this.txtVrDocena.BackColor = System.Drawing.SystemColors.Menu;
            this.txtVrDocena.Location = new System.Drawing.Point(214, 109);
            this.txtVrDocena.Name = "txtVrDocena";
            this.txtVrDocena.Size = new System.Drawing.Size(121, 20);
            this.txtVrDocena.TabIndex = 7;
            // 
            // txtCant
            // 
            this.txtCant.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCant.Location = new System.Drawing.Point(214, 145);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(121, 20);
            this.txtCant.TabIndex = 8;
            // 
            // txtIVA
            // 
            this.txtIVA.BackColor = System.Drawing.SystemColors.Menu;
            this.txtIVA.Location = new System.Drawing.Point(214, 178);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(121, 20);
            this.txtIVA.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(46, 234);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(214, 234);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(116, 23);
            this.btnFacturar.TabIndex = 11;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            // 
            // grbAPagar
            // 
            this.grbAPagar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbAPagar.Controls.Add(this.lblPorcDscto);
            this.grbAPagar.Controls.Add(this.lblVrDscto);
            this.grbAPagar.Controls.Add(this.lblTotAPag);
            this.grbAPagar.Controls.Add(this.lblVrIVA);
            this.grbAPagar.Controls.Add(this.lblSubTot);
            this.grbAPagar.Controls.Add(this.label7);
            this.grbAPagar.Controls.Add(this.label5);
            this.grbAPagar.Controls.Add(this.label4);
            this.grbAPagar.Controls.Add(this.label3);
            this.grbAPagar.Controls.Add(this.label2);
            this.grbAPagar.Location = new System.Drawing.Point(21, 280);
            this.grbAPagar.Name = "grbAPagar";
            this.grbAPagar.Size = new System.Drawing.Size(340, 186);
            this.grbAPagar.TabIndex = 12;
            this.grbAPagar.TabStop = false;
            this.grbAPagar.Text = "A Pagar";
            this.grbAPagar.Visible = false;
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(219, 489);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(116, 23);
            this.btnTerminar.TabIndex = 13;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "               Sub Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "            Porc. Dscto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "            Valor Dscto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "                    Vr. IVA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "        Total A Pagar:";
            // 
            // lblSubTot
            // 
            this.lblSubTot.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblSubTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTot.Location = new System.Drawing.Point(176, 26);
            this.lblSubTot.Name = "lblSubTot";
            this.lblSubTot.Size = new System.Drawing.Size(138, 16);
            this.lblSubTot.TabIndex = 6;
            // 
            // lblVrIVA
            // 
            this.lblVrIVA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblVrIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrIVA.Location = new System.Drawing.Point(176, 121);
            this.lblVrIVA.Name = "lblVrIVA";
            this.lblVrIVA.Size = new System.Drawing.Size(138, 16);
            this.lblVrIVA.TabIndex = 11;
            // 
            // lblTotAPag
            // 
            this.lblTotAPag.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblTotAPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotAPag.Location = new System.Drawing.Point(176, 153);
            this.lblTotAPag.Name = "lblTotAPag";
            this.lblTotAPag.Size = new System.Drawing.Size(138, 16);
            this.lblTotAPag.TabIndex = 12;
            // 
            // lblVrDscto
            // 
            this.lblVrDscto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblVrDscto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrDscto.Location = new System.Drawing.Point(176, 89);
            this.lblVrDscto.Name = "lblVrDscto";
            this.lblVrDscto.Size = new System.Drawing.Size(138, 16);
            this.lblVrDscto.TabIndex = 13;
            // 
            // lblPorcDscto
            // 
            this.lblPorcDscto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPorcDscto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcDscto.Location = new System.Drawing.Point(176, 59);
            this.lblPorcDscto.Name = "lblPorcDscto";
            this.lblPorcDscto.Size = new System.Drawing.Size(138, 16);
            this.lblPorcDscto.TabIndex = 14;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(390, 534);
            this.ControlBox = false;
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.grbAPagar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtVrDocena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.vrDocenaText);
            this.Controls.Add(this.labelCant);
            this.Controls.Add(this.labelVA);
            this.Controls.Add(this.productoText);
            this.Controls.Add(this.Title);
            this.Name = "frmPedido";
            this.Text = "frmPedido";
            this.grbAPagar.ResumeLayout(false);
            this.grbAPagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label productoText;
        private System.Windows.Forms.Label labelVA;
        private System.Windows.Forms.Label labelCant;
        private System.Windows.Forms.Label vrDocenaText;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVrDocena;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.GroupBox grbAPagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label lblSubTot;
        private System.Windows.Forms.Label lblPorcDscto;
        private System.Windows.Forms.Label lblVrDscto;
        private System.Windows.Forms.Label lblTotAPag;
        private System.Windows.Forms.Label lblVrIVA;
    }
}

