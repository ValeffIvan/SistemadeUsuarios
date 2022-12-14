namespace Usuarios.Vistas
{
    partial class FormCrearUsuario
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
            this.btn_crear = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_pregunta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_respuesta = new System.Windows.Forms.TextBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.cb_admin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_crear
            // 
            this.btn_crear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear.Location = new System.Drawing.Point(179, 389);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(128, 60);
            this.btn_crear.TabIndex = 1;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.txt_nombre.Location = new System.Drawing.Point(35, 50);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(258, 39);
            this.txt_nombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // cb_pregunta
            // 
            this.cb_pregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pregunta.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.cb_pregunta.FormattingEnabled = true;
            this.cb_pregunta.Items.AddRange(new object[] {
            "Nombre de su primera mascota",
            "Cual fue tu primer auto",
            "Cual es tu pelicula favorita",
            "Nombre de tu hermano/a",
            "Banda favorita"});
            this.cb_pregunta.Location = new System.Drawing.Point(33, 207);
            this.cb_pregunta.Name = "cb_pregunta";
            this.cb_pregunta.Size = new System.Drawing.Size(258, 39);
            this.cb_pregunta.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.label3.Location = new System.Drawing.Point(29, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pregunta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.label4.Location = new System.Drawing.Point(29, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Respuesta";
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.txt_respuesta.Location = new System.Drawing.Point(33, 283);
            this.txt_respuesta.Multiline = true;
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.Size = new System.Drawing.Size(258, 39);
            this.txt_respuesta.TabIndex = 10;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(12, 389);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(128, 60);
            this.btn_cerrar.TabIndex = 12;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contraseña";
            // 
            // txt_contra
            // 
            this.txt_contra.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.txt_contra.Location = new System.Drawing.Point(33, 131);
            this.txt_contra.Multiline = true;
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(258, 39);
            this.txt_contra.TabIndex = 13;
            this.txt_contra.UseSystemPasswordChar = true;
            // 
            // cb_admin
            // 
            this.cb_admin.AutoSize = true;
            this.cb_admin.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.cb_admin.Location = new System.Drawing.Point(35, 337);
            this.cb_admin.Name = "cb_admin";
            this.cb_admin.Size = new System.Drawing.Size(167, 35);
            this.cb_admin.TabIndex = 15;
            this.cb_admin.Text = "Administrador";
            this.cb_admin.UseVisualStyleBackColor = true;
            // 
            // FormCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 461);
            this.ControlBox = false;
            this.Controls.Add(this.cb_admin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_respuesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_pregunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_crear);
            this.Name = "FormCrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCrearUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_pregunta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_respuesta;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.CheckBox cb_admin;
    }
}