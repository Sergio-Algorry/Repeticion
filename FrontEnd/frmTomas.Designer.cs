namespace FrontEnd
{
    partial class frmTomas
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
            this.txt = new System.Windows.Forms.TextBox();
            this.bt = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.btPalabra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(40, 48);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(748, 44);
            this.txt.TabIndex = 0;
            // 
            // bt
            // 
            this.bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt.Location = new System.Drawing.Point(579, 98);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(209, 44);
            this.bt.TabIndex = 1;
            this.bt.Text = "Deletrear";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.SkyBlue;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(48, 120);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 37);
            this.lbl.TabIndex = 2;
            // 
            // btPalabra
            // 
            this.btPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPalabra.Location = new System.Drawing.Point(579, 148);
            this.btPalabra.Name = "btPalabra";
            this.btPalabra.Size = new System.Drawing.Size(209, 44);
            this.btPalabra.TabIndex = 3;
            this.btPalabra.Text = "div.Palabra";
            this.btPalabra.UseVisualStyleBackColor = true;
            this.btPalabra.Click += new System.EventHandler(this.btPalabra_Click);
            // 
            // frmTomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.btPalabra);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.txt);
            this.Name = "frmTomas";
            this.Text = "Tomas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btPalabra;
    }
}