namespace Usuarios.Vistas
{
    partial class FormContraNueva
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_contravieja = new System.Windows.Forms.TextBox();
            this.txt_contranueva = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_repetircontra = new System.Windows.Forms.TextBox();
            this.btn_cambiar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.lbl_nombre.Location = new System.Drawing.Point(29, 38);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(72, 31);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.label1.Location = new System.Drawing.Point(29, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Contraseña vieja";
            // 
            // txt_contravieja
            // 
            this.txt_contravieja.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.txt_contravieja.Location = new System.Drawing.Point(33, 126);
            this.txt_contravieja.Multiline = true;
            this.txt_contravieja.Name = "txt_contravieja";
            this.txt_contravieja.Size = new System.Drawing.Size(198, 39);
            this.txt_contravieja.TabIndex = 6;
            // 
            // txt_contranueva
            // 
            this.txt_contranueva.AutoSize = true;
            this.txt_contranueva.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.txt_contranueva.Location = new System.Drawing.Point(29, 179);
            this.txt_contranueva.Name = "txt_contranueva";
            this.txt_contranueva.Size = new System.Drawing.Size(144, 31);
            this.txt_contranueva.TabIndex = 9;
            this.txt_contranueva.Text = "Contra nueva";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.textBox1.Location = new System.Drawing.Point(33, 213);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 39);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.label2.Location = new System.Drawing.Point(29, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Repetir Contraseña";
            // 
            // txt_repetircontra
            // 
            this.txt_repetircontra.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.txt_repetircontra.Location = new System.Drawing.Point(33, 289);
            this.txt_repetircontra.Multiline = true;
            this.txt_repetircontra.Name = "txt_repetircontra";
            this.txt_repetircontra.Size = new System.Drawing.Size(198, 39);
            this.txt_repetircontra.TabIndex = 10;
            // 
            // btn_cambiar
            // 
            this.btn_cambiar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cambiar.Location = new System.Drawing.Point(179, 349);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.Size = new System.Drawing.Size(128, 60);
            this.btn_cambiar.TabIndex = 12;
            this.btn_cambiar.Text = "Cambiar";
            this.btn_cambiar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(12, 349);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(128, 60);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // FormContraNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 421);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_cambiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_repetircontra);
            this.Controls.Add(this.txt_contranueva);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contravieja);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "FormContraNueva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormContraNueva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_contravieja;
        private System.Windows.Forms.Label txt_contranueva;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_repetircontra;
        private System.Windows.Forms.Button btn_cambiar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}