namespace pryEstructuraDatos
{
    partial class frmListaDoble
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
            this.gbListadoListaDoble = new System.Windows.Forms.GroupBox();
            this.dgvListaDoble = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListaDoble = new System.Windows.Forms.ListBox();
            this.gbElementoEliminadoListaDoble = new System.Windows.Forms.GroupBox();
            this.cbCodigoListaDoble = new System.Windows.Forms.ComboBox();
            this.btnEliminarListaDoble = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbNuevoElementoListaDoble = new System.Windows.Forms.GroupBox();
            this.btnAgregarListaDoble = new System.Windows.Forms.Button();
            this.txtTramiteListaDoble = new System.Windows.Forms.TextBox();
            this.txtNombreListaDoble = new System.Windows.Forms.TextBox();
            this.txtCodigoListaDoble = new System.Windows.Forms.TextBox();
            this.lblTramiteNuevoElemento = new System.Windows.Forms.Label();
            this.lblNombreNuevoElemento = new System.Windows.Forms.Label();
            this.lblCodNuevoElemento = new System.Windows.Forms.Label();
            this.gbListarDatosListaDoble = new System.Windows.Forms.GroupBox();
            this.optDescendente = new System.Windows.Forms.RadioButton();
            this.optAscendente = new System.Windows.Forms.RadioButton();
            this.pbListaDoble = new System.Windows.Forms.PictureBox();
            this.gbListadoListaDoble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).BeginInit();
            this.gbElementoEliminadoListaDoble.SuspendLayout();
            this.gbNuevoElementoListaDoble.SuspendLayout();
            this.gbListarDatosListaDoble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbListaDoble)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListadoListaDoble
            // 
            this.gbListadoListaDoble.Controls.Add(this.dgvListaDoble);
            this.gbListadoListaDoble.Controls.Add(this.lstListaDoble);
            this.gbListadoListaDoble.Location = new System.Drawing.Point(12, 238);
            this.gbListadoListaDoble.Name = "gbListadoListaDoble";
            this.gbListadoListaDoble.Size = new System.Drawing.Size(708, 200);
            this.gbListadoListaDoble.TabIndex = 11;
            this.gbListadoListaDoble.TabStop = false;
            this.gbListadoListaDoble.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvListaDoble
            // 
            this.dgvListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvListaDoble.Location = new System.Drawing.Point(224, 19);
            this.dgvListaDoble.Name = "dgvListaDoble";
            this.dgvListaDoble.Size = new System.Drawing.Size(445, 173);
            this.dgvListaDoble.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trámite";
            this.Column3.Name = "Column3";
            // 
            // lstListaDoble
            // 
            this.lstListaDoble.FormattingEnabled = true;
            this.lstListaDoble.Location = new System.Drawing.Point(6, 19);
            this.lstListaDoble.Name = "lstListaDoble";
            this.lstListaDoble.Size = new System.Drawing.Size(176, 173);
            this.lstListaDoble.TabIndex = 0;
            // 
            // gbElementoEliminadoListaDoble
            // 
            this.gbElementoEliminadoListaDoble.Controls.Add(this.cbCodigoListaDoble);
            this.gbElementoEliminadoListaDoble.Controls.Add(this.btnEliminarListaDoble);
            this.gbElementoEliminadoListaDoble.Controls.Add(this.label4);
            this.gbElementoEliminadoListaDoble.Location = new System.Drawing.Point(531, 12);
            this.gbElementoEliminadoListaDoble.Name = "gbElementoEliminadoListaDoble";
            this.gbElementoEliminadoListaDoble.Size = new System.Drawing.Size(189, 105);
            this.gbElementoEliminadoListaDoble.TabIndex = 10;
            this.gbElementoEliminadoListaDoble.TabStop = false;
            this.gbElementoEliminadoListaDoble.Text = "Elemento a eliminar";
            // 
            // cbCodigoListaDoble
            // 
            this.cbCodigoListaDoble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCodigoListaDoble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodigoListaDoble.FormattingEnabled = true;
            this.cbCodigoListaDoble.Location = new System.Drawing.Point(56, 24);
            this.cbCodigoListaDoble.Name = "cbCodigoListaDoble";
            this.cbCodigoListaDoble.Size = new System.Drawing.Size(121, 21);
            this.cbCodigoListaDoble.TabIndex = 7;
            this.cbCodigoListaDoble.SelectedIndexChanged += new System.EventHandler(this.cbCodigoListaDoble_SelectedIndexChanged);
            // 
            // btnEliminarListaDoble
            // 
            this.btnEliminarListaDoble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarListaDoble.Enabled = false;
            this.btnEliminarListaDoble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarListaDoble.Location = new System.Drawing.Point(10, 51);
            this.btnEliminarListaDoble.Name = "btnEliminarListaDoble";
            this.btnEliminarListaDoble.Size = new System.Drawing.Size(167, 45);
            this.btnEliminarListaDoble.TabIndex = 6;
            this.btnEliminarListaDoble.Text = "Eliminar";
            this.btnEliminarListaDoble.UseVisualStyleBackColor = true;
            this.btnEliminarListaDoble.Click += new System.EventHandler(this.btnEliminarListaDoble_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código:";
            // 
            // gbNuevoElementoListaDoble
            // 
            this.gbNuevoElementoListaDoble.Controls.Add(this.btnAgregarListaDoble);
            this.gbNuevoElementoListaDoble.Controls.Add(this.txtTramiteListaDoble);
            this.gbNuevoElementoListaDoble.Controls.Add(this.txtNombreListaDoble);
            this.gbNuevoElementoListaDoble.Controls.Add(this.txtCodigoListaDoble);
            this.gbNuevoElementoListaDoble.Controls.Add(this.lblTramiteNuevoElemento);
            this.gbNuevoElementoListaDoble.Controls.Add(this.lblNombreNuevoElemento);
            this.gbNuevoElementoListaDoble.Controls.Add(this.lblCodNuevoElemento);
            this.gbNuevoElementoListaDoble.Location = new System.Drawing.Point(337, 12);
            this.gbNuevoElementoListaDoble.Name = "gbNuevoElementoListaDoble";
            this.gbNuevoElementoListaDoble.Size = new System.Drawing.Size(172, 197);
            this.gbNuevoElementoListaDoble.TabIndex = 9;
            this.gbNuevoElementoListaDoble.TabStop = false;
            this.gbNuevoElementoListaDoble.Text = "Nuevo Elemento";
            // 
            // btnAgregarListaDoble
            // 
            this.btnAgregarListaDoble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarListaDoble.Enabled = false;
            this.btnAgregarListaDoble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarListaDoble.Location = new System.Drawing.Point(6, 135);
            this.btnAgregarListaDoble.Name = "btnAgregarListaDoble";
            this.btnAgregarListaDoble.Size = new System.Drawing.Size(149, 45);
            this.btnAgregarListaDoble.TabIndex = 6;
            this.btnAgregarListaDoble.Text = "Agregar";
            this.btnAgregarListaDoble.UseVisualStyleBackColor = true;
            this.btnAgregarListaDoble.Click += new System.EventHandler(this.btnAgregarListaDoble_Click);
            // 
            // txtTramiteListaDoble
            // 
            this.txtTramiteListaDoble.Location = new System.Drawing.Point(55, 99);
            this.txtTramiteListaDoble.Name = "txtTramiteListaDoble";
            this.txtTramiteListaDoble.Size = new System.Drawing.Size(100, 20);
            this.txtTramiteListaDoble.TabIndex = 5;
            this.txtTramiteListaDoble.TextChanged += new System.EventHandler(this.txtTramiteListaDoble_TextChanged);
            // 
            // txtNombreListaDoble
            // 
            this.txtNombreListaDoble.Location = new System.Drawing.Point(55, 61);
            this.txtNombreListaDoble.Name = "txtNombreListaDoble";
            this.txtNombreListaDoble.Size = new System.Drawing.Size(100, 20);
            this.txtNombreListaDoble.TabIndex = 4;
            this.txtNombreListaDoble.TextChanged += new System.EventHandler(this.txtNombreListaDoble_TextChanged);
            // 
            // txtCodigoListaDoble
            // 
            this.txtCodigoListaDoble.Location = new System.Drawing.Point(55, 23);
            this.txtCodigoListaDoble.Name = "txtCodigoListaDoble";
            this.txtCodigoListaDoble.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoListaDoble.TabIndex = 3;
            this.txtCodigoListaDoble.TextChanged += new System.EventHandler(this.txtCodigoListaDoble_TextChanged);
            // 
            // lblTramiteNuevoElemento
            // 
            this.lblTramiteNuevoElemento.AutoSize = true;
            this.lblTramiteNuevoElemento.Location = new System.Drawing.Point(6, 106);
            this.lblTramiteNuevoElemento.Name = "lblTramiteNuevoElemento";
            this.lblTramiteNuevoElemento.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteNuevoElemento.TabIndex = 2;
            this.lblTramiteNuevoElemento.Text = "Trámite:";
            // 
            // lblNombreNuevoElemento
            // 
            this.lblNombreNuevoElemento.AutoSize = true;
            this.lblNombreNuevoElemento.Location = new System.Drawing.Point(6, 68);
            this.lblNombreNuevoElemento.Name = "lblNombreNuevoElemento";
            this.lblNombreNuevoElemento.Size = new System.Drawing.Size(47, 13);
            this.lblNombreNuevoElemento.TabIndex = 1;
            this.lblNombreNuevoElemento.Text = "Nombre:";
            // 
            // lblCodNuevoElemento
            // 
            this.lblCodNuevoElemento.AutoSize = true;
            this.lblCodNuevoElemento.Location = new System.Drawing.Point(6, 30);
            this.lblCodNuevoElemento.Name = "lblCodNuevoElemento";
            this.lblCodNuevoElemento.Size = new System.Drawing.Size(43, 13);
            this.lblCodNuevoElemento.TabIndex = 0;
            this.lblCodNuevoElemento.Text = "Código:";
            // 
            // gbListarDatosListaDoble
            // 
            this.gbListarDatosListaDoble.Controls.Add(this.optDescendente);
            this.gbListarDatosListaDoble.Controls.Add(this.optAscendente);
            this.gbListarDatosListaDoble.Location = new System.Drawing.Point(531, 123);
            this.gbListarDatosListaDoble.Name = "gbListarDatosListaDoble";
            this.gbListarDatosListaDoble.Size = new System.Drawing.Size(189, 86);
            this.gbListarDatosListaDoble.TabIndex = 12;
            this.gbListarDatosListaDoble.TabStop = false;
            this.gbListarDatosListaDoble.Text = "Listar Datos";
            // 
            // optDescendente
            // 
            this.optDescendente.AutoSize = true;
            this.optDescendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optDescendente.Location = new System.Drawing.Point(10, 52);
            this.optDescendente.Name = "optDescendente";
            this.optDescendente.Size = new System.Drawing.Size(89, 17);
            this.optDescendente.TabIndex = 1;
            this.optDescendente.TabStop = true;
            this.optDescendente.Text = "Descendente";
            this.optDescendente.UseVisualStyleBackColor = true;
            this.optDescendente.CheckedChanged += new System.EventHandler(this.optDescendente_CheckedChanged);
            // 
            // optAscendente
            // 
            this.optAscendente.AutoSize = true;
            this.optAscendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optAscendente.Location = new System.Drawing.Point(10, 28);
            this.optAscendente.Name = "optAscendente";
            this.optAscendente.Size = new System.Drawing.Size(82, 17);
            this.optAscendente.TabIndex = 0;
            this.optAscendente.TabStop = true;
            this.optAscendente.Text = "Ascendente";
            this.optAscendente.UseVisualStyleBackColor = true;
            this.optAscendente.CheckedChanged += new System.EventHandler(this.optAscendente_CheckedChanged);
            // 
            // pbListaDoble
            // 
            this.pbListaDoble.Image = global::pryEstructuraDatos.Properties.Resources.Lista_doble;
            this.pbListaDoble.Location = new System.Drawing.Point(12, 63);
            this.pbListaDoble.Name = "pbListaDoble";
            this.pbListaDoble.Size = new System.Drawing.Size(319, 146);
            this.pbListaDoble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbListaDoble.TabIndex = 8;
            this.pbListaDoble.TabStop = false;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(733, 448);
            this.Controls.Add(this.gbListarDatosListaDoble);
            this.Controls.Add(this.gbListadoListaDoble);
            this.Controls.Add(this.gbElementoEliminadoListaDoble);
            this.Controls.Add(this.gbNuevoElementoListaDoble);
            this.Controls.Add(this.pbListaDoble);
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinámica Lineal - Lista Doble";
            this.gbListadoListaDoble.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).EndInit();
            this.gbElementoEliminadoListaDoble.ResumeLayout(false);
            this.gbElementoEliminadoListaDoble.PerformLayout();
            this.gbNuevoElementoListaDoble.ResumeLayout(false);
            this.gbNuevoElementoListaDoble.PerformLayout();
            this.gbListarDatosListaDoble.ResumeLayout(false);
            this.gbListarDatosListaDoble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbListaDoble)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListadoListaDoble;
        private System.Windows.Forms.DataGridView dgvListaDoble;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstListaDoble;
        private System.Windows.Forms.GroupBox gbElementoEliminadoListaDoble;
        private System.Windows.Forms.ComboBox cbCodigoListaDoble;
        private System.Windows.Forms.Button btnEliminarListaDoble;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbNuevoElementoListaDoble;
        private System.Windows.Forms.Button btnAgregarListaDoble;
        private System.Windows.Forms.TextBox txtTramiteListaDoble;
        private System.Windows.Forms.TextBox txtNombreListaDoble;
        private System.Windows.Forms.TextBox txtCodigoListaDoble;
        private System.Windows.Forms.Label lblTramiteNuevoElemento;
        private System.Windows.Forms.Label lblNombreNuevoElemento;
        private System.Windows.Forms.Label lblCodNuevoElemento;
        private System.Windows.Forms.PictureBox pbListaDoble;
        private System.Windows.Forms.GroupBox gbListarDatosListaDoble;
        private System.Windows.Forms.RadioButton optAscendente;
        private System.Windows.Forms.RadioButton optDescendente;
    }
}