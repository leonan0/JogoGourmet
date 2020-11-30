namespace JogoGourmet
{
    partial class QstForm
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
            this.Bt_Iniciar = new System.Windows.Forms.Button();
            this.lb_Inicial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bt_Iniciar
            // 
            this.Bt_Iniciar.Location = new System.Drawing.Point(181, 80);
            this.Bt_Iniciar.Name = "Bt_Iniciar";
            this.Bt_Iniciar.Size = new System.Drawing.Size(98, 45);
            this.Bt_Iniciar.TabIndex = 0;
            this.Bt_Iniciar.Text = "Iniciar";
            this.Bt_Iniciar.UseVisualStyleBackColor = true;
            this.Bt_Iniciar.Click += new System.EventHandler(this.Bt_Iniciar_Click);
            // 
            // lb_Inicial
            // 
            this.lb_Inicial.AutoSize = true;
            this.lb_Inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Inicial.Location = new System.Drawing.Point(19, 28);
            this.lb_Inicial.Name = "lb_Inicial";
            this.lb_Inicial.Size = new System.Drawing.Size(421, 29);
            this.lb_Inicial.TabIndex = 1;
            this.lb_Inicial.Text = "Pense em um prato que você gosta!";
            // 
            // QstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 147);
            this.Controls.Add(this.lb_Inicial);
            this.Controls.Add(this.Bt_Iniciar);
            this.Name = "QstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Gourmet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Iniciar;
        private System.Windows.Forms.Label lb_Inicial;
    }
}