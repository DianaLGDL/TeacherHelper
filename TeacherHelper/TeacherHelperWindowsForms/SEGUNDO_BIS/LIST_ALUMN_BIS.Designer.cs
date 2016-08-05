namespace TeacherHelperWindowsForms.SEGUNDO_BIS
{
    partial class LIST_ALUMN_BIS
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.Gb_opciones = new System.Windows.Forms.GroupBox();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Gb_listalumn = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Gb_opciones.SuspendLayout();
            this.Gb_listalumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(32, 366);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(159, 32);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_return
            // 
            this.btn_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_return.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(32, 304);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(159, 32);
            this.btn_return.TabIndex = 7;
            this.btn_return.Text = "Regresar";
            this.btn_return.UseVisualStyleBackColor = true;
            // 
            // Gb_opciones
            // 
            this.Gb_opciones.BackColor = System.Drawing.Color.Transparent;
            this.Gb_opciones.Controls.Add(this.btnLista);
            this.Gb_opciones.Controls.Add(this.btnEliminar);
            this.Gb_opciones.Controls.Add(this.btnModificar);
            this.Gb_opciones.Controls.Add(this.btnAgregar);
            this.Gb_opciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_opciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gb_opciones.Location = new System.Drawing.Point(12, 12);
            this.Gb_opciones.Name = "Gb_opciones";
            this.Gb_opciones.Size = new System.Drawing.Size(260, 222);
            this.Gb_opciones.TabIndex = 6;
            this.Gb_opciones.TabStop = false;
            this.Gb_opciones.Text = "Opciones";
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.SystemColors.Control;
            this.btnLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLista.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLista.Location = new System.Drawing.Point(49, 164);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(130, 24);
            this.btnLista.TabIndex = 7;
            this.btnLista.Text = "Mostrar lista\r\n";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(49, 122);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 24);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.Location = new System.Drawing.Point(49, 80);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 24);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(49, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 24);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // Gb_listalumn
            // 
            this.Gb_listalumn.BackColor = System.Drawing.Color.Transparent;
            this.Gb_listalumn.Controls.Add(this.dataGridView1);
            this.Gb_listalumn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_listalumn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gb_listalumn.Location = new System.Drawing.Point(278, 12);
            this.Gb_listalumn.Name = "Gb_listalumn";
            this.Gb_listalumn.Size = new System.Drawing.Size(1035, 597);
            this.Gb_listalumn.TabIndex = 5;
            this.Gb_listalumn.TabStop = false;
            this.Gb_listalumn.Text = "Lista de los alumnos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(21, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(989, 543);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LIST_ALUMN_BIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeacherHelperWindowsForms.Properties.Resources.mesh_1430108_960_720;
            this.ClientSize = new System.Drawing.Size(1348, 687);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.Gb_opciones);
            this.Controls.Add(this.Gb_listalumn);
            this.Name = "LIST_ALUMN_BIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIST_ALUMN_BIS";
            this.Load += new System.EventHandler(this.LIST_ALUMN_BIS_Load);
            this.Gb_opciones.ResumeLayout(false);
            this.Gb_listalumn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.GroupBox Gb_opciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox Gb_listalumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLista;
    }
}