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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_eliminar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(679, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(727, 54);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(124, 69);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // txt_eliminar
            // 
            this.txt_eliminar.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.txt_eliminar.Location = new System.Drawing.Point(727, 180);
            this.txt_eliminar.Name = "txt_eliminar";
            this.txt_eliminar.Size = new System.Drawing.Size(124, 69);
            this.txt_eliminar.TabIndex = 2;
            this.txt_eliminar.Text = "Eliminar";
            this.txt_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btn_volver.Location = new System.Drawing.Point(727, 309);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(124, 69);
            this.btn_volver.TabIndex = 3;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            // 
            // FormListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 436);
            this.ControlBox = false;
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.txt_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormListarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormListarUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button txt_eliminar;
        private System.Windows.Forms.Button btn_volver;
    }
}