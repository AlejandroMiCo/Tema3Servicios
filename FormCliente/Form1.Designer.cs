namespace FormCliente
{
    partial class ClienteSuperChulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteSuperChulo));
            this.btnTime = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfig = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(60, 274);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(75, 23);
            this.btnTime.TabIndex = 0;
            this.btnTime.Tag = "time";
            this.btnTime.Text = "Time";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.BtnGestion);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(158, 274);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 1;
            this.btnDate.Tag = "date";
            this.btnDate.Text = "Date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.BtnGestion);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(60, 333);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 2;
            this.btnAll.Tag = "all";
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.BtnGestion);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(158, 333);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Tag = "close";
            this.btnClose.Text = "Close server";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnGestion);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(60, 94);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(173, 20);
            this.txtPass.TabIndex = 4;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(422, 94);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(24, 13);
            this.lblinfo.TabIndex = 5;
            this.lblinfo.Text = "info";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(370, 332);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 23);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(60, 75);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Contraseña";
            // 
            // ClienteSuperChulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClienteSuperChulo";
            this.Text = "ClienteSuperChulo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lblPassword;
    }
}

