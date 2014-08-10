namespace Mixy
{
    partial class Opciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Caracteres = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_categoria = new System.Windows.Forms.TextBox();
            this.textBox_comentarios = new System.Windows.Forms.TextBox();
            this.textBox_asignacion = new System.Windows.Forms.TextBox();
            this.panel_Caracteres.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // panel_Caracteres
            // 
            this.panel_Caracteres.Controls.Add(this.textBox_asignacion);
            this.panel_Caracteres.Controls.Add(this.textBox_comentarios);
            this.panel_Caracteres.Controls.Add(this.textBox_categoria);
            this.panel_Caracteres.Controls.Add(this.label3);
            this.panel_Caracteres.Controls.Add(this.label2);
            this.panel_Caracteres.Controls.Add(this.label1);
            this.panel_Caracteres.Location = new System.Drawing.Point(12, 12);
            this.panel_Caracteres.Name = "panel_Caracteres";
            this.panel_Caracteres.Size = new System.Drawing.Size(191, 100);
            this.panel_Caracteres.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comentarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asignacion";
            // 
            // textBox_categoria
            // 
            this.textBox_categoria.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_categoria.Location = new System.Drawing.Point(104, 13);
            this.textBox_categoria.Name = "textBox_categoria";
            this.textBox_categoria.Size = new System.Drawing.Size(59, 20);
            this.textBox_categoria.TabIndex = 3;
            this.textBox_categoria.Text = "[]";
            this.textBox_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_categoria.TextChanged += new System.EventHandler(this.textBox_categoria_TextChanged);
            // 
            // textBox_comentarios
            // 
            this.textBox_comentarios.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_comentarios.Location = new System.Drawing.Point(104, 37);
            this.textBox_comentarios.Name = "textBox_comentarios";
            this.textBox_comentarios.Size = new System.Drawing.Size(59, 20);
            this.textBox_comentarios.TabIndex = 4;
            this.textBox_comentarios.Text = ";";
            this.textBox_comentarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_comentarios.TextChanged += new System.EventHandler(this.textBox_comentarios_TextChanged);
            // 
            // textBox_asignacion
            // 
            this.textBox_asignacion.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_asignacion.Location = new System.Drawing.Point(104, 64);
            this.textBox_asignacion.Name = "textBox_asignacion";
            this.textBox_asignacion.Size = new System.Drawing.Size(59, 20);
            this.textBox_asignacion.TabIndex = 5;
            this.textBox_asignacion.Text = "=";
            this.textBox_asignacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_asignacion.TextChanged += new System.EventHandler(this.textBox_asignacion_TextChanged);
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 123);
            this.Controls.Add(this.panel_Caracteres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Opciones_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Opciones_FormClosed);
            this.panel_Caracteres.ResumeLayout(false);
            this.panel_Caracteres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Caracteres;
        private System.Windows.Forms.TextBox textBox_asignacion;
        private System.Windows.Forms.TextBox textBox_comentarios;
        private System.Windows.Forms.TextBox textBox_categoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}