namespace Usuarios.Vistas
{
    partial class FormRecuperarContrasenia
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
            this.cb_nombre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pregunta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_respuesta = new System.Windows.Forms.TextBox();
            this.btn_corroborar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.panel_contra = new System.Windows.Forms.Panel();
            this.lbl_contranueva = new System.Windows.Forms.Label();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.panel_contra.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_nombre
            // 
            this.cb_nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nombre.FormattingEnabled = true;
            this.cb_nombre.Location = new System.Drawing.Point(16, 37);
            this.cb_nombre.Name = "cb_nombre";
            this.cb_nombre.Size = new System.Drawing.Size(208, 21);
            this.cb_nombre.TabIndex = 0;
            this.cb_nombre.TextChanged += new System.EventHandler(this.cb_nombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pregunta";
            // 
            // txt_pregunta
            // 
            this.txt_pregunta.Location = new System.Drawing.Point(22, 98);
            this.txt_pregunta.Name = "txt_pregunta";
            this.txt_pregunta.ReadOnly = true;
            this.txt_pregunta.Size = new System.Drawing.Size(202, 20);
            this.txt_pregunta.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Respuesta";
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txt_respuesta.Location = new System.Drawing.Point(9, 158);
            this.txt_respuesta.Multiline = true;
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.Size = new System.Drawing.Size(131, 44);
            this.txt_respuesta.TabIndex = 13;
            // 
            // btn_corroborar
            // 
            this.btn_corroborar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_corroborar.Location = new System.Drawing.Point(160, 158);
            this.btn_corroborar.Name = "btn_corroborar";
            this.btn_corroborar.Size = new System.Drawing.Size(132, 44);
            this.btn_corroborar.TabIndex = 14;
            this.btn_corroborar.Text = "Corroborar";
            this.btn_corroborar.UseVisualStyleBackColor = true;
            this.btn_corroborar.Click += new System.EventHandler(this.btn_corroborar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(16, 327);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(128, 60);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // panel_contra
            // 
            this.panel_contra.Controls.Add(this.lbl_contranueva);
            this.panel_contra.Controls.Add(this.txt_contra);
            this.panel_contra.Location = new System.Drawing.Point(9, 217);
            this.panel_contra.Name = "panel_contra";
            this.panel_contra.Size = new System.Drawing.Size(215, 88);
            this.panel_contra.TabIndex = 16;
            this.panel_contra.Visible = false;
            // 
            // lbl_contranueva
            // 
            this.lbl_contranueva.AutoSize = true;
            this.lbl_contranueva.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contranueva.Location = new System.Drawing.Point(8, 13);
            this.lbl_contranueva.Name = "lbl_contranueva";
            this.lbl_contranueva.Size = new System.Drawing.Size(119, 25);
            this.lbl_contranueva.TabIndex = 15;
            this.lbl_contranueva.Text = "Contra nueva";
            // 
            // txt_contra
            // 
            this.txt_contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_contra.Location = new System.Drawing.Point(12, 47);
            this.txt_contra.Multiline = true;
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(185, 22);
            this.txt_contra.TabIndex = 14;
            this.txt_contra.UseSystemPasswordChar = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(164, 327);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(128, 60);
            this.btn_aceptar.TabIndex = 17;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // FormRecuperarContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 397);
            this.ControlBox = false;
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.panel_contra);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_corroborar);
            this.Controls.Add(this.txt_respuesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pregunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_nombre);
            this.Name = "FormRecuperarContrasenia";
            this.Text = "FormRecuperarContrasenia";
            this.panel_contra.ResumeLayout(false);
            this.panel_contra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pregunta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_respuesta;
        private System.Windows.Forms.Button btn_corroborar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Panel panel_contra;
        private System.Windows.Forms.Label lbl_contranueva;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.Button btn_aceptar;
    }
}