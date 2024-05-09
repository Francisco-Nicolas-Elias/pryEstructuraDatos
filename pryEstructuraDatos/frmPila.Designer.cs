namespace pryEstructuraDatos
{
    partial class frmPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPila));
            this.gbListadoPila = new System.Windows.Forms.GroupBox();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.gbElementoEliminadoPila = new System.Windows.Forms.GroupBox();
            this.btnEliminarPila = new System.Windows.Forms.Button();
            this.lblTramitePila = new System.Windows.Forms.Label();
            this.lblNombrePila = new System.Windows.Forms.Label();
            this.lblCodigoPila = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbNuevoElementoPila = new System.Windows.Forms.GroupBox();
            this.btnAgregarPila = new System.Windows.Forms.Button();
            this.txtTramitePila = new System.Windows.Forms.TextBox();
            this.txtNombrePila = new System.Windows.Forms.TextBox();
            this.txtCodigoPila = new System.Windows.Forms.TextBox();
            this.lblTramiteNuevoElemento = new System.Windows.Forms.Label();
            this.lblNombreNuevoElemento = new System.Windows.Forms.Label();
            this.lblCodNuevoElemento = new System.Windows.Forms.Label();
            this.pbPila = new System.Windows.Forms.PictureBox();
            this.gbListadoPila.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            this.gbElementoEliminadoPila.SuspendLayout();
            this.gbNuevoElementoPila.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPila)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListadoPila
            // 
            this.gbListadoPila.Controls.Add(this.dgvPila);
            this.gbListadoPila.Controls.Add(this.lstPila);
            this.gbListadoPila.Location = new System.Drawing.Point(12, 258);
            this.gbListadoPila.Name = "gbListadoPila";
            this.gbListadoPila.Size = new System.Drawing.Size(702, 200);
            this.gbListadoPila.TabIndex = 7;
            this.gbListadoPila.TabStop = false;
            this.gbListadoPila.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvPila
            // 
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPila.Location = new System.Drawing.Point(224, 19);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.Size = new System.Drawing.Size(478, 173);
            this.dgvPila.TabIndex = 1;
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
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(6, 19);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(176, 173);
            this.lstPila.TabIndex = 0;
            // 
            // gbElementoEliminadoPila
            // 
            this.gbElementoEliminadoPila.Controls.Add(this.btnEliminarPila);
            this.gbElementoEliminadoPila.Controls.Add(this.lblTramitePila);
            this.gbElementoEliminadoPila.Controls.Add(this.lblNombrePila);
            this.gbElementoEliminadoPila.Controls.Add(this.lblCodigoPila);
            this.gbElementoEliminadoPila.Controls.Add(this.label6);
            this.gbElementoEliminadoPila.Controls.Add(this.label5);
            this.gbElementoEliminadoPila.Controls.Add(this.label4);
            this.gbElementoEliminadoPila.Location = new System.Drawing.Point(514, 22);
            this.gbElementoEliminadoPila.Name = "gbElementoEliminadoPila";
            this.gbElementoEliminadoPila.Size = new System.Drawing.Size(200, 218);
            this.gbElementoEliminadoPila.TabIndex = 6;
            this.gbElementoEliminadoPila.TabStop = false;
            this.gbElementoEliminadoPila.Text = "Elemento Eliminado";
            // 
            // btnEliminarPila
            // 
            this.btnEliminarPila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPila.Location = new System.Drawing.Point(13, 166);
            this.btnEliminarPila.Name = "btnEliminarPila";
            this.btnEliminarPila.Size = new System.Drawing.Size(146, 45);
            this.btnEliminarPila.TabIndex = 6;
            this.btnEliminarPila.Text = "Eliminar";
            this.btnEliminarPila.UseVisualStyleBackColor = true;
            this.btnEliminarPila.Click += new System.EventHandler(this.btnEliminarPila_Click);
            // 
            // lblTramitePila
            // 
            this.lblTramitePila.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramitePila.Location = new System.Drawing.Point(59, 89);
            this.lblTramitePila.Name = "lblTramitePila";
            this.lblTramitePila.Size = new System.Drawing.Size(100, 23);
            this.lblTramitePila.TabIndex = 5;
            // 
            // lblNombrePila
            // 
            this.lblNombrePila.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombrePila.Location = new System.Drawing.Point(59, 55);
            this.lblNombrePila.Name = "lblNombrePila";
            this.lblNombrePila.Size = new System.Drawing.Size(100, 23);
            this.lblNombrePila.TabIndex = 4;
            // 
            // lblCodigoPila
            // 
            this.lblCodigoPila.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoPila.Location = new System.Drawing.Point(59, 16);
            this.lblCodigoPila.Name = "lblCodigoPila";
            this.lblCodigoPila.Size = new System.Drawing.Size(100, 23);
            this.lblCodigoPila.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Trámite:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código:";
            // 
            // gbNuevoElementoPila
            // 
            this.gbNuevoElementoPila.Controls.Add(this.btnAgregarPila);
            this.gbNuevoElementoPila.Controls.Add(this.txtTramitePila);
            this.gbNuevoElementoPila.Controls.Add(this.txtNombrePila);
            this.gbNuevoElementoPila.Controls.Add(this.txtCodigoPila);
            this.gbNuevoElementoPila.Controls.Add(this.lblTramiteNuevoElemento);
            this.gbNuevoElementoPila.Controls.Add(this.lblNombreNuevoElemento);
            this.gbNuevoElementoPila.Controls.Add(this.lblCodNuevoElemento);
            this.gbNuevoElementoPila.Location = new System.Drawing.Point(276, 22);
            this.gbNuevoElementoPila.Name = "gbNuevoElementoPila";
            this.gbNuevoElementoPila.Size = new System.Drawing.Size(200, 218);
            this.gbNuevoElementoPila.TabIndex = 5;
            this.gbNuevoElementoPila.TabStop = false;
            this.gbNuevoElementoPila.Text = "Nuevo Elemento";
            // 
            // btnAgregarPila
            // 
            this.btnAgregarPila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPila.Enabled = false;
            this.btnAgregarPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPila.Location = new System.Drawing.Point(9, 167);
            this.btnAgregarPila.Name = "btnAgregarPila";
            this.btnAgregarPila.Size = new System.Drawing.Size(146, 45);
            this.btnAgregarPila.TabIndex = 6;
            this.btnAgregarPila.Text = "Agregar";
            this.btnAgregarPila.UseVisualStyleBackColor = true;
            this.btnAgregarPila.Click += new System.EventHandler(this.btnAgregarPila_Click);
            // 
            // txtTramitePila
            // 
            this.txtTramitePila.Location = new System.Drawing.Point(55, 99);
            this.txtTramitePila.Name = "txtTramitePila";
            this.txtTramitePila.Size = new System.Drawing.Size(100, 20);
            this.txtTramitePila.TabIndex = 5;
            this.txtTramitePila.TextChanged += new System.EventHandler(this.txtTramitePila_TextChanged);
            // 
            // txtNombrePila
            // 
            this.txtNombrePila.Location = new System.Drawing.Point(55, 61);
            this.txtNombrePila.Name = "txtNombrePila";
            this.txtNombrePila.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePila.TabIndex = 4;
            this.txtNombrePila.TextChanged += new System.EventHandler(this.txtNombrePila_TextChanged);
            // 
            // txtCodigoPila
            // 
            this.txtCodigoPila.Location = new System.Drawing.Point(55, 23);
            this.txtCodigoPila.Name = "txtCodigoPila";
            this.txtCodigoPila.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPila.TabIndex = 3;
            this.txtCodigoPila.TextChanged += new System.EventHandler(this.txtCodigoPila_TextChanged);
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
            // pbPila
            // 
            this.pbPila.Image = global::pryEstructuraDatos.Properties.Resources.Pila;
            this.pbPila.Location = new System.Drawing.Point(12, 22);
            this.pbPila.Name = "pbPila";
            this.pbPila.Size = new System.Drawing.Size(213, 218);
            this.pbPila.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPila.TabIndex = 4;
            this.pbPila.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(748, 473);
            this.Controls.Add(this.gbListadoPila);
            this.Controls.Add(this.gbElementoEliminadoPila);
            this.Controls.Add(this.gbNuevoElementoPila);
            this.Controls.Add(this.pbPila);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = resources.GetString("$this.Text");
            this.gbListadoPila.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            this.gbElementoEliminadoPila.ResumeLayout(false);
            this.gbElementoEliminadoPila.PerformLayout();
            this.gbNuevoElementoPila.ResumeLayout(false);
            this.gbNuevoElementoPila.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPila)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListadoPila;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.GroupBox gbElementoEliminadoPila;
        private System.Windows.Forms.Button btnEliminarPila;
        private System.Windows.Forms.Label lblTramitePila;
        private System.Windows.Forms.Label lblNombrePila;
        private System.Windows.Forms.Label lblCodigoPila;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbNuevoElementoPila;
        private System.Windows.Forms.Button btnAgregarPila;
        private System.Windows.Forms.TextBox txtTramitePila;
        private System.Windows.Forms.TextBox txtNombrePila;
        private System.Windows.Forms.TextBox txtCodigoPila;
        private System.Windows.Forms.Label lblTramiteNuevoElemento;
        private System.Windows.Forms.Label lblNombreNuevoElemento;
        private System.Windows.Forms.Label lblCodNuevoElemento;
        private System.Windows.Forms.PictureBox pbPila;
    }
}