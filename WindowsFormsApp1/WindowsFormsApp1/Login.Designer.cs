namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contra = new System.Windows.Forms.Label();
            this.txt_usario = new System.Windows.Forms.TextBox();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.btm_log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_usuario.Location = new System.Drawing.Point(215, 152);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(100, 23);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario:";
            this.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_contra
            // 
            this.lbl_contra.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_contra.Location = new System.Drawing.Point(188, 209);
            this.lbl_contra.Name = "lbl_contra";
            this.lbl_contra.Size = new System.Drawing.Size(127, 23);
            this.lbl_contra.TabIndex = 1;
            this.lbl_contra.Text = "Contraseña:";
            this.lbl_contra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_usario
            // 
            this.txt_usario.Location = new System.Drawing.Point(321, 152);
            this.txt_usario.Name = "txt_usario";
            this.txt_usario.Size = new System.Drawing.Size(139, 23);
            this.txt_usario.TabIndex = 2;
            // 
            // txt_contra
            // 
            this.txt_contra.Location = new System.Drawing.Point(321, 209);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(139, 23);
            this.txt_contra.TabIndex = 3;
            // 
            // btm_log
            // 
            this.btm_log.Location = new System.Drawing.Point(298, 269);
            this.btm_log.Name = "btm_log";
            this.btm_log.Size = new System.Drawing.Size(85, 33);
            this.btm_log.TabIndex = 4;
            this.btm_log.Text = "INGRESAR";
            this.btm_log.UseVisualStyleBackColor = true;
            this.btm_log.Click += new System.EventHandler(this.btm_log_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btm_log);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.txt_usario);
            this.Controls.Add(this.lbl_contra);
            this.Controls.Add(this.lbl_usuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contra;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.TextBox txt_usario;
        private System.Windows.Forms.Button btm_log;
    }
}