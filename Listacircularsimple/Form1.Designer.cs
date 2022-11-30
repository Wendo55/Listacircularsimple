namespace Listacircularsimple
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
      this.btnGuardar = new System.Windows.Forms.Button();
      this.txtNodo = new System.Windows.Forms.TextBox();
      this.lblLista = new System.Windows.Forms.Label();
      this.btnEliminarNodo = new System.Windows.Forms.Button();
      this.txtEliminar = new System.Windows.Forms.TextBox();
      this.btnContar = new System.Windows.Forms.Button();
      this.btnVaciarLista = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnGuardar
      // 
      this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGuardar.Location = new System.Drawing.Point(148, 63);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(89, 30);
      this.btnGuardar.TabIndex = 0;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
      // 
      // txtNodo
      // 
      this.txtNodo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNodo.Location = new System.Drawing.Point(28, 65);
      this.txtNodo.Name = "txtNodo";
      this.txtNodo.Size = new System.Drawing.Size(114, 26);
      this.txtNodo.TabIndex = 1;
      // 
      // lblLista
      // 
      this.lblLista.AutoSize = true;
      this.lblLista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLista.Location = new System.Drawing.Point(248, 65);
      this.lblLista.Name = "lblLista";
      this.lblLista.Size = new System.Drawing.Size(14, 20);
      this.lblLista.TabIndex = 2;
      this.lblLista.Text = "-";
      // 
      // btnEliminarNodo
      // 
      this.btnEliminarNodo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEliminarNodo.Location = new System.Drawing.Point(148, 102);
      this.btnEliminarNodo.Name = "btnEliminarNodo";
      this.btnEliminarNodo.Size = new System.Drawing.Size(89, 30);
      this.btnEliminarNodo.TabIndex = 3;
      this.btnEliminarNodo.Text = "Eliminar dato";
      this.btnEliminarNodo.UseVisualStyleBackColor = true;
      this.btnEliminarNodo.Click += new System.EventHandler(this.BtnEliminarNodo_Click);
      // 
      // txtEliminar
      // 
      this.txtEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEliminar.Location = new System.Drawing.Point(28, 102);
      this.txtEliminar.Name = "txtEliminar";
      this.txtEliminar.Size = new System.Drawing.Size(114, 26);
      this.txtEliminar.TabIndex = 4;
      // 
      // btnContar
      // 
      this.btnContar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnContar.Location = new System.Drawing.Point(148, 135);
      this.btnContar.Name = "btnContar";
      this.btnContar.Size = new System.Drawing.Size(89, 30);
      this.btnContar.TabIndex = 5;
      this.btnContar.Text = "Contar";
      this.btnContar.UseVisualStyleBackColor = true;
      this.btnContar.Click += new System.EventHandler(this.BtnContar_Click);
      // 
      // btnVaciarLista
      // 
      this.btnVaciarLista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnVaciarLista.Location = new System.Drawing.Point(148, 207);
      this.btnVaciarLista.Name = "btnVaciarLista";
      this.btnVaciarLista.Size = new System.Drawing.Size(89, 53);
      this.btnVaciarLista.TabIndex = 10;
      this.btnVaciarLista.Text = "Vaciar lista";
      this.btnVaciarLista.UseVisualStyleBackColor = true;
      this.btnVaciarLista.Click += new System.EventHandler(this.BtnVaciarLista_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 403);
      this.Controls.Add(this.btnVaciarLista);
      this.Controls.Add(this.btnContar);
      this.Controls.Add(this.txtEliminar);
      this.Controls.Add(this.btnEliminarNodo);
      this.Controls.Add(this.lblLista);
      this.Controls.Add(this.txtNodo);
      this.Controls.Add(this.btnGuardar);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Lista Circular";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btnEliminarNodo;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnVaciarLista;
    }
}


