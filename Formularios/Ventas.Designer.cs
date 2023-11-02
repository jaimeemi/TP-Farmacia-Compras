namespace TP_Farmacia_Compras.Formularios
{
    partial class Ventas
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
            this.pnNumeroReceta = new System.Windows.Forms.Panel();
            this.txtNumeroReceta = new System.Windows.Forms.TextBox();
            this.lblNumeroReceta = new System.Windows.Forms.Label();
            this.chReceta = new System.Windows.Forms.CheckBox();
            this.pnNumeroReceta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnNumeroReceta
            // 
            this.pnNumeroReceta.Controls.Add(this.txtNumeroReceta);
            this.pnNumeroReceta.Controls.Add(this.lblNumeroReceta);
            this.pnNumeroReceta.Location = new System.Drawing.Point(470, 117);
            this.pnNumeroReceta.Name = "pnNumeroReceta";
            this.pnNumeroReceta.Size = new System.Drawing.Size(294, 30);
            this.pnNumeroReceta.TabIndex = 12;
            this.pnNumeroReceta.Visible = false;
            // 
            // txtNumeroReceta
            // 
            this.txtNumeroReceta.Location = new System.Drawing.Point(82, 7);
            this.txtNumeroReceta.Name = "txtNumeroReceta";
            this.txtNumeroReceta.Size = new System.Drawing.Size(209, 20);
            this.txtNumeroReceta.TabIndex = 1;
            // 
            // lblNumeroReceta
            // 
            this.lblNumeroReceta.AutoSize = true;
            this.lblNumeroReceta.Location = new System.Drawing.Point(12, 10);
            this.lblNumeroReceta.Name = "lblNumeroReceta";
            this.lblNumeroReceta.Size = new System.Drawing.Size(60, 13);
            this.lblNumeroReceta.TabIndex = 0;
            this.lblNumeroReceta.Text = "N° Receta:";
            // 
            // chReceta
            // 
            this.chReceta.AutoSize = true;
            this.chReceta.Location = new System.Drawing.Point(385, 127);
            this.chReceta.Name = "chReceta";
            this.chReceta.Size = new System.Drawing.Size(91, 17);
            this.chReceta.TabIndex = 11;
            this.chReceta.Text = "Tiene Receta";
            this.chReceta.UseVisualStyleBackColor = true;
            this.chReceta.CheckedChanged += new System.EventHandler(this.chReceta_CheckedChanged);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnNumeroReceta);
            this.Controls.Add(this.chReceta);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.pnNumeroReceta.ResumeLayout(false);
            this.pnNumeroReceta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnNumeroReceta;
        private System.Windows.Forms.TextBox txtNumeroReceta;
        private System.Windows.Forms.Label lblNumeroReceta;
        private System.Windows.Forms.CheckBox chReceta;
    }
}