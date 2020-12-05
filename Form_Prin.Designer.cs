namespace JogoGourmet
{
    partial class Form_Prin
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
            this.lb_principal = new System.Windows.Forms.Label();
            this.bt_Iniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_principal
            // 
            this.lb_principal.AutoSize = true;
            this.lb_principal.Location = new System.Drawing.Point(110, 24);
            this.lb_principal.Margin = new System.Windows.Forms.Padding(101, 30, 101, 30);
            this.lb_principal.Name = "lb_principal";
            this.lb_principal.Size = new System.Drawing.Size(198, 17);
            this.lb_principal.TabIndex = 0;
            this.lb_principal.Text = "Pense em um prato que gosta";
            this.lb_principal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Iniciar
            // 
            this.bt_Iniciar.Location = new System.Drawing.Point(159, 73);
            this.bt_Iniciar.Margin = new System.Windows.Forms.Padding(150, 20, 150, 20);
            this.bt_Iniciar.Name = "bt_Iniciar";
            this.bt_Iniciar.Size = new System.Drawing.Size(50, 30);
            this.bt_Iniciar.TabIndex = 1;
            this.bt_Iniciar.Text = "Ok";
            this.bt_Iniciar.UseVisualStyleBackColor = true;
            this.bt_Iniciar.Click += new System.EventHandler(this.Bt_Iniciar_Click);
            // 
            // Form_Prin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(382, 123);
            this.Controls.Add(this.bt_Iniciar);
            this.Controls.Add(this.lb_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Prin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Gourmet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_principal;
        private System.Windows.Forms.Button bt_Iniciar;
    }
}

