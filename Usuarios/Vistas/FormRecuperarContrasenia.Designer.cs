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
            this.SuspendLayout();
            // 
            // cb_nombre
            // 
            this.cb_nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nombre.FormattingEnabled = true;
            this.cb_nombre.Location = new System.Drawing.Point(44, 60);
            this.cb_nombre.Name = "cb_nombre";
            this.cb_nombre.Size = new System.Drawing.Size(224, 21);
            this.cb_nombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pregunta";
            // 
            // txt_pregunta
            // 
            this.txt_pregunta.Location = new System.Drawing.Point(44, 135);
            this.txt_pregunta.Name = "txt_pregunta";
            this.txt_pregunta.ReadOnly = true;
            this.txt_pregunta.Size = new System.Drawing.Size(224, 20);
            this.txt_pregunta.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Respuesta";
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txt_respuesta.Location = new System.Drawing.Point(44, 213);
            this.txt_respuesta.Multiline = true;
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.Size = new System.Drawing.Size(224, 39);
            this.txt_respuesta.TabIndex = 13;
            // 
            // btn_corroborar
            // 
            this.btn_corroborar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_corroborar.Location = new System.Drawing.Point(184, 294);
            this.btn_corroborar.Name = "btn_corroborar";
            this.btn_corroborar.Size = new System.Drawing.Size(128, 60);
            this.btn_corroborar.TabIndex = 14;
            this.btn_corroborar.Text = "Corroborar";
            this.btn_corroborar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(12, 294);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(128, 60);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // FormRecuperarContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 367);
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
    }
}