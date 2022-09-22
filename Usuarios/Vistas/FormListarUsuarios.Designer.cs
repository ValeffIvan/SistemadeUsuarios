namespace Usuarios.Vistas
{
    partial class FormListarUsuarios
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
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_eliminar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.panel_modificar = new System.Windows.Forms.Panel();
            this.cb_pregunta = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_respuesta = new System.Windows.Forms.TextBox();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.cb_admin = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.panel_modificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            this.dgv_usuarios.AllowUserToOrderColumns = true;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(12, 12);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(679, 412);
            this.dgv_usuarios.TabIndex = 0;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(712, 54);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(112, 55);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // txt_eliminar
            // 
            this.txt_eliminar.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.txt_eliminar.Location = new System.Drawing.Point(712, 180);
            this.txt_eliminar.Name = "txt_eliminar";
            this.txt_eliminar.Size = new System.Drawing.Size(104, 60);
            this.txt_eliminar.TabIndex = 2;
            this.txt_eliminar.Text = "Eliminar";
            this.txt_eliminar.UseVisualStyleBackColor = true;
            this.txt_eliminar.Click += new System.EventHandler(this.txt_eliminar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btn_volver.Location = new System.Drawing.Point(712, 309);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(104, 46);
            this.btn_volver.TabIndex = 3;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // panel_modificar
            // 
            this.panel_modificar.Controls.Add(this.cb_pregunta);
            this.panel_modificar.Controls.Add(this.btn_aceptar);
            this.panel_modificar.Controls.Add(this.txt_respuesta);
            this.panel_modificar.Controls.Add(this.txt_contra);
            this.panel_modificar.Controls.Add(this.cb_admin);
            this.panel_modificar.Controls.Add(this.label2);
            this.panel_modificar.Controls.Add(this.label4);
            this.panel_modificar.Controls.Add(this.label3);
            this.panel_modificar.Controls.Add(this.label1);
            this.panel_modificar.Controls.Add(this.txt_nombre);
            this.panel_modificar.Location = new System.Drawing.Point(830, 12);
            this.panel_modificar.Name = "panel_modificar";
            this.panel_modificar.Size = new System.Drawing.Size(158, 412);
            this.panel_modificar.TabIndex = 4;
            this.panel_modificar.Visible = false;
            // 
            // cb_pregunta
            // 
            this.cb_pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_pregunta.FormattingEnabled = true;
            this.cb_pregunta.Items.AddRange(new object[] {
            "Nombre de su primera mascota",
            "Cual fue tu primer auto",
            "Cual es tu pelicula favorita",
            "Nombre de tu hermano/a",
            "Banda favorita"});
            this.cb_pregunta.Location = new System.Drawing.Point(17, 194);
            this.cb_pregunta.Name = "cb_pregunta";
            this.cb_pregunta.Size = new System.Drawing.Size(125, 21);
            this.cb_pregunta.TabIndex = 28;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(17, 343);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(125, 54);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_respuesta.Location = new System.Drawing.Point(17, 257);
            this.txt_respuesta.Multiline = true;
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.Size = new System.Drawing.Size(125, 24);
            this.txt_respuesta.TabIndex = 27;
            // 
            // txt_contra
            // 
            this.txt_contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_contra.Location = new System.Drawing.Point(17, 125);
            this.txt_contra.Multiline = true;
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(125, 24);
            this.txt_contra.TabIndex = 25;
            // 
            // cb_admin
            // 
            this.cb_admin.AutoSize = true;
            this.cb_admin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_admin.Location = new System.Drawing.Point(17, 297);
            this.cb_admin.Name = "cb_admin";
            this.cb_admin.Size = new System.Drawing.Size(114, 23);
            this.cb_admin.TabIndex = 24;
            this.cb_admin.Text = "Administrador";
            this.cb_admin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Respuesta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pregunta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_nombre.Location = new System.Drawing.Point(17, 54);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(125, 24);
            this.txt_nombre.TabIndex = 16;
            // 
            // FormListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 436);
            this.ControlBox = false;
            this.Controls.Add(this.panel_modificar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.txt_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dgv_usuarios);
            this.Name = "FormListarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormListarUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.panel_modificar.ResumeLayout(false);
            this.panel_modificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button txt_eliminar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Panel panel_modificar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_respuesta;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.CheckBox cb_admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cb_pregunta;
    }
}