namespace Capa_Presentacion_Proyecto_Final
{
    partial class FrmLogin
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
            txt_nombre = new TextBox();
            txt_clave = new TextBox();
            label1 = new Label();
            lbl_nombre = new Label();
            lbl_Clave = new Label();
            txt_entrar = new Button();
            SuspendLayout();
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(331, 148);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(144, 23);
            txt_nombre.TabIndex = 0;
            // 
            // txt_clave
            // 
            txt_clave.Location = new Point(331, 201);
            txt_clave.Name = "txt_clave";
            txt_clave.Size = new Size(144, 23);
            txt_clave.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Stencil", 14.25F);
            lbl_nombre.Location = new Point(226, 148);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(87, 22);
            lbl_nombre.TabIndex = 6;
            lbl_nombre.Text = "NOMBRE";
            // 
            // lbl_Clave
            // 
            lbl_Clave.AutoSize = true;
            lbl_Clave.Font = new Font("Stencil", 14.25F);
            lbl_Clave.Location = new Point(245, 201);
            lbl_Clave.Name = "lbl_Clave";
            lbl_Clave.Size = new Size(65, 22);
            lbl_Clave.TabIndex = 7;
            lbl_Clave.Text = "CLave";
            // 
            // txt_entrar
            // 
            txt_entrar.Location = new Point(353, 281);
            txt_entrar.Name = "txt_entrar";
            txt_entrar.Size = new Size(122, 36);
            txt_entrar.TabIndex = 11;
            txt_entrar.Text = "Entrar";
            txt_entrar.UseVisualStyleBackColor = true;
            txt_entrar.Click += txt_entrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_entrar);
            Controls.Add(lbl_Clave);
            Controls.Add(lbl_nombre);
            Controls.Add(label1);
            Controls.Add(txt_clave);
            Controls.Add(txt_nombre);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_nombre;
        private TextBox txt_clave;
        private Label label1;
        private Label lbl_nombre;
        private Label lbl_Clave;
        private Button txt_entrar;
    }
}