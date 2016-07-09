namespace TeacherHelperWindowsForms
{
    partial class ListaAlumnos
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
            this.Gb_listalumn = new System.Windows.Forms.GroupBox();
            this.Gb_opciones = new System.Windows.Forms.GroupBox();
            this.Rb_agregar = new System.Windows.Forms.RadioButton();
            this.Rb_modificar = new System.Windows.Forms.RadioButton();
            this.Rb_eliminar = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Btn_Acept = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Gb_listalumn.SuspendLayout();
            this.Gb_opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 543);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Gb_listalumn
            // 
            this.Gb_listalumn.Controls.Add(this.dataGridView1);
            this.Gb_listalumn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_listalumn.Location = new System.Drawing.Point(278, 12);
            this.Gb_listalumn.Name = "Gb_listalumn";
            this.Gb_listalumn.Size = new System.Drawing.Size(944, 597);
            this.Gb_listalumn.TabIndex = 1;
            this.Gb_listalumn.TabStop = false;
            this.Gb_listalumn.Text = "Lista de los alumnos";
            // 
            // Gb_opciones
            // 
            this.Gb_opciones.Controls.Add(this.Btn_Acept);
            this.Gb_opciones.Controls.Add(this.radioButton1);
            this.Gb_opciones.Controls.Add(this.Rb_eliminar);
            this.Gb_opciones.Controls.Add(this.Rb_modificar);
            this.Gb_opciones.Controls.Add(this.Rb_agregar);
            this.Gb_opciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_opciones.Location = new System.Drawing.Point(12, 12);
            this.Gb_opciones.Name = "Gb_opciones";
            this.Gb_opciones.Size = new System.Drawing.Size(260, 222);
            this.Gb_opciones.TabIndex = 2;
            this.Gb_opciones.TabStop = false;
            this.Gb_opciones.Text = "Opciones";
            // 
            // Rb_agregar
            // 
            this.Rb_agregar.AutoSize = true;
            this.Rb_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rb_agregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_agregar.Location = new System.Drawing.Point(20, 36);
            this.Rb_agregar.Name = "Rb_agregar";
            this.Rb_agregar.Size = new System.Drawing.Size(78, 21);
            this.Rb_agregar.TabIndex = 0;
            this.Rb_agregar.TabStop = true;
            this.Rb_agregar.Text = "Agregar";
            this.Rb_agregar.UseVisualStyleBackColor = true;
            // 
            // Rb_modificar
            // 
            this.Rb_modificar.AutoSize = true;
            this.Rb_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rb_modificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_modificar.Location = new System.Drawing.Point(20, 83);
            this.Rb_modificar.Name = "Rb_modificar";
            this.Rb_modificar.Size = new System.Drawing.Size(86, 21);
            this.Rb_modificar.TabIndex = 1;
            this.Rb_modificar.TabStop = true;
            this.Rb_modificar.Text = "Modificar";
            this.Rb_modificar.UseVisualStyleBackColor = true;
            // 
            // Rb_eliminar
            // 
            this.Rb_eliminar.AutoSize = true;
            this.Rb_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rb_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_eliminar.Location = new System.Drawing.Point(20, 128);
            this.Rb_eliminar.Name = "Rb_eliminar";
            this.Rb_eliminar.Size = new System.Drawing.Size(76, 21);
            this.Rb_eliminar.TabIndex = 2;
            this.Rb_eliminar.TabStop = true;
            this.Rb_eliminar.Text = "Eliminar";
            this.Rb_eliminar.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(20, 175);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Eliminar";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Btn_Acept
            // 
            this.Btn_Acept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Acept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Acept.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Acept.Location = new System.Drawing.Point(124, 36);
            this.Btn_Acept.Name = "Btn_Acept";
            this.Btn_Acept.Size = new System.Drawing.Size(130, 24);
            this.Btn_Acept.TabIndex = 4;
            this.Btn_Acept.Text = "Aceptar";
            this.Btn_Acept.UseVisualStyleBackColor = true;
            // 
            // btn_return
            // 
            this.btn_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_return.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(32, 304);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(159, 32);
            this.btn_return.TabIndex = 3;
            this.btn_return.Text = "Regresar";
            this.btn_return.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(32, 366);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(159, 32);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // ListaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 621);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.Gb_opciones);
            this.Controls.Add(this.Gb_listalumn);
            this.Name = "ListaAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaAlumnos";
            this.Load += new System.EventHandler(this.ListaAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Gb_listalumn.ResumeLayout(false);
            this.Gb_opciones.ResumeLayout(false);
            this.Gb_opciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Gb_listalumn;
        private System.Windows.Forms.GroupBox Gb_opciones;
        private System.Windows.Forms.Button Btn_Acept;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton Rb_eliminar;
        private System.Windows.Forms.RadioButton Rb_modificar;
        private System.Windows.Forms.RadioButton Rb_agregar;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_exit;
    }
}