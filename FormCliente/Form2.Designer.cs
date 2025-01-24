namespace FormCliente
{
    partial class Form2
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
            this.lbIp = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.lbPuerto = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIp
            // 
            this.lbIp.AutoSize = true;
            this.lbIp.Location = new System.Drawing.Point(77, 70);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(74, 13);
            this.lbIp.TabIndex = 0;
            this.lbIp.Text = "Ip de servidor:";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(192, 67);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 20);
            this.txtIp.TabIndex = 1;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(192, 115);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(100, 20);
            this.txtPuerto.TabIndex = 3;
            // 
            // lbPuerto
            // 
            this.lbPuerto.AutoSize = true;
            this.lbPuerto.Location = new System.Drawing.Point(77, 118);
            this.lbPuerto.Name = "lbPuerto";
            this.lbPuerto.Size = new System.Drawing.Size(98, 13);
            this.lbPuerto.TabIndex = 2;
            this.lbPuerto.Text = "Puerto del servidor:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(145, 176);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 232);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.lbPuerto);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.lbIp);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIp;
        private System.Windows.Forms.Label lbPuerto;
        public System.Windows.Forms.TextBox txtIp;
        public System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Button btnConfirm;
    }
}