namespace Usuarios.Vistas
{
    partial class FormModificarUsuario
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
            this.btn_volver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_respuesta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_pregunta = new System.Windows.Forms.ComboBox();
            this.btn_cambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(25, 220);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(128, 60);
            this.btn_volver.TabIndex = 23;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.label4.Location = new System.Drawing.Point(35, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Respuesta";
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.txt_respuesta.Location = new System.Drawing.Point(39, 134);
            this.txt_respuesta.Multiline = true;
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.Size = new System.Drawing.Size(258, 39);
            this.txt_respuesta.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.label3.Location = new System.Drawing.Point(35, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pregunta";
            // 
            // cb_pregunta
            // 
            this.cb_pregunta.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.cb_pregunta.FormattingEnabled = true;
            this.cb_pregunta.Location = new System.Drawing.Point(39, 58);
            this.cb_pregunta.Name = "cb_pregunta";
            this.cb_pregunta.Size = new System.Drawing.Size(258, 39);
            this.cb_pregunta.TabIndex = 19;
            // 
            // btn_cambiar
            // 
            this.btn_cambiar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cambiar.Location = new System.Drawing.Point(192, 220);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.Size = new System.Drawing.Size(128, 60);
            this.btn_cambiar.TabIndex = 16;
            this.btn_cambiar.Text = "Cambiar";
            this.btn_cambiar.UseVisualStyleBackColor = true;
            // 
            // FormModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 313);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_respuesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_pregunta);
            this.Controls.Add(this.btn_cambiar);
            this.Name = "FormModificarUsuario";
            this.Text = "FormModificarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_respuesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_pregunta;
        private System.Windows.Forms.Button btn_cambiar;
    }
}