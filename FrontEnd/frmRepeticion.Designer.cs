namespace FrontEnd
{
    partial class frmRepeticion
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblFigura = new System.Windows.Forms.Label();
            this.bt = new System.Windows.Forms.Button();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtcontador = new System.Windows.Forms.TextBox();
            this.btWhile = new System.Windows.Forms.Button();
            this.btUntil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFigura
            // 
            this.lblFigura.BackColor = System.Drawing.Color.Red;
            this.lblFigura.Location = new System.Drawing.Point(67, 143);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(20, 20);
            this.lblFigura.TabIndex = 1;
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(128, 28);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(75, 23);
            this.bt.TabIndex = 2;
            this.bt.Text = "Contador";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(12, 31);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 15);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(69, 13);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Repeticiones";
            // 
            // txtcontador
            // 
            this.txtcontador.Location = new System.Drawing.Point(128, 2);
            this.txtcontador.Name = "txtcontador";
            this.txtcontador.Size = new System.Drawing.Size(100, 20);
            this.txtcontador.TabIndex = 5;
            // 
            // btWhile
            // 
            this.btWhile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btWhile.Location = new System.Drawing.Point(128, 57);
            this.btWhile.Name = "btWhile";
            this.btWhile.Size = new System.Drawing.Size(75, 23);
            this.btWhile.TabIndex = 6;
            this.btWhile.Text = "While";
            this.btWhile.UseVisualStyleBackColor = true;
            this.btWhile.Click += new System.EventHandler(this.btWhile_Click);
            // 
            // btUntil
            // 
            this.btUntil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btUntil.Location = new System.Drawing.Point(128, 86);
            this.btUntil.Name = "btUntil";
            this.btUntil.Size = new System.Drawing.Size(75, 23);
            this.btUntil.TabIndex = 7;
            this.btUntil.Text = "Do while";
            this.btUntil.UseVisualStyleBackColor = true;
            this.btUntil.Click += new System.EventHandler(this.btUntil_Click);
            // 
            // frmRepeticion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.btUntil);
            this.Controls.Add(this.btWhile);
            this.Controls.Add(this.txtcontador);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.lblFigura);
            this.Controls.Add(this.button1);
            this.Name = "frmRepeticion";
            this.Text = "Repetición";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtcontador;
        private System.Windows.Forms.Button btWhile;
        private System.Windows.Forms.Button btUntil;
    }
}

