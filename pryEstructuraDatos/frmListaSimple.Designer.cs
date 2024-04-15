namespace pryEstructuraDatos
{
    partial class frmListaSimple
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
            this.gbListadoListaSimple = new System.Windows.Forms.GroupBox();
            this.dgvListaSimple = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListaSimple = new System.Windows.Forms.ListBox();
            this.gbElementoEliminadoListaSimple = new System.Windows.Forms.GroupBox();
            this.cbCodigoListaSimple = new System.Windows.Forms.ComboBox();
            this.btnEliminarListaSimple = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbNuevoElementoListaSimple = new System.Windows.Forms.GroupBox();
            this.btnAgregarListaSimple = new System.Windows.Forms.Button();
            this.txtTramiteListaSimple = new System.Windows.Forms.TextBox();
            this.txtNombreListaSimple = new System.Windows.Forms.TextBox();
            this.txtCodigoListaSimple = new System.Windows.Forms.TextBox();
            this.lblTramiteNuevoElemento = new System.Windows.Forms.Label();
            this.lblNombreNuevoElemento = new System.Windows.Forms.Label();
            this.lblCodNuevoElemento = new System.Windows.Forms.Label();
            this.pbListaSimple = new System.Windows.Forms.PictureBox();
            this.gbListadoListaSimple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).BeginInit();
            this.gbElementoEliminadoListaSimple.SuspendLayout();
            this.gbNuevoElementoListaSimple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbListaSimple)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListadoListaSimple
            // 
            this.gbListadoListaSimple.Controls.Add(this.dgvListaSimple);
            this.gbListadoListaSimple.Controls.Add(this.lstListaSimple);
            this.gbListadoListaSimple.Location = new System.Drawing.Point(12, 259);
            this.gbListadoListaSimple.Name = "gbListadoListaSimple";
            this.gbListadoListaSimple.Size = new System.Drawing.Size(702, 200);
            this.gbListadoListaSimple.TabIndex = 7;
            this.gbListadoListaSimple.TabStop = false;
            this.gbListadoListaSimple.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvListaSimple
            // 
            this.dgvListaSimple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSimple.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvListaSimple.Location = new System.Drawing.Point(224, 19);
            this.dgvListaSimple.Name = "dgvListaSimple";
            this.dgvListaSimple.Size = new System.Drawing.Size(455, 173);
            this.dgvListaSimple.TabIndex = 1;
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
            // lstListaSimple
            // 
            this.lstListaSimple.FormattingEnabled = true;
            this.lstListaSimple.Location = new System.Drawing.Point(6, 19);
            this.lstListaSimple.Name = "lstListaSimple";
            this.lstListaSimple.Size = new System.Drawing.Size(176, 173);
            this.lstListaSimple.TabIndex = 0;
            // 
            // gbElementoEliminadoListaSimple
            // 
            this.gbElementoEliminadoListaSimple.Controls.Add(this.cbCodigoListaSimple);
            this.gbElementoEliminadoListaSimple.Controls.Add(this.btnEliminarListaSimple);
            this.gbElementoEliminadoListaSimple.Controls.Add(this.label4);
            this.gbElementoEliminadoListaSimple.Location = new System.Drawing.Point(514, 23);
            this.gbElementoEliminadoListaSimple.Name = "gbElementoEliminadoListaSimple";
            this.gbElementoEliminadoListaSimple.Size = new System.Drawing.Size(200, 218);
            this.gbElementoEliminadoListaSimple.TabIndex = 6;
            this.gbElementoEliminadoListaSimple.TabStop = false;
            this.gbElementoEliminadoListaSimple.Text = "Elemento a eliminar";
            // 
            // cbCodigoListaSimple
            // 
            this.cbCodigoListaSimple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCodigoListaSimple.FormattingEnabled = true;
            this.cbCodigoListaSimple.Location = new System.Drawing.Point(56, 98);
            this.cbCodigoListaSimple.Name = "cbCodigoListaSimple";
            this.cbCodigoListaSimple.Size = new System.Drawing.Size(121, 21);
            this.cbCodigoListaSimple.TabIndex = 7;
            this.cbCodigoListaSimple.SelectedIndexChanged += new System.EventHandler(this.cbCodigoListaSimple_SelectedIndexChanged);
            // 
            // btnEliminarListaSimple
            // 
            this.btnEliminarListaSimple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarListaSimple.Enabled = false;
            this.btnEliminarListaSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarListaSimple.Location = new System.Drawing.Point(10, 145);
            this.btnEliminarListaSimple.Name = "btnEliminarListaSimple";
            this.btnEliminarListaSimple.Size = new System.Drawing.Size(167, 45);
            this.btnEliminarListaSimple.TabIndex = 6;
            this.btnEliminarListaSimple.Text = "Eliminar";
            this.btnEliminarListaSimple.UseVisualStyleBackColor = true;
            this.btnEliminarListaSimple.Click += new System.EventHandler(this.btnEliminarListaSimple_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código:";
            // 
            // gbNuevoElementoListaSimple
            // 
            this.gbNuevoElementoListaSimple.Controls.Add(this.btnAgregarListaSimple);
            this.gbNuevoElementoListaSimple.Controls.Add(this.txtTramiteListaSimple);
            this.gbNuevoElementoListaSimple.Controls.Add(this.txtNombreListaSimple);
            this.gbNuevoElementoListaSimple.Controls.Add(this.txtCodigoListaSimple);
            this.gbNuevoElementoListaSimple.Controls.Add(this.lblTramiteNuevoElemento);
            this.gbNuevoElementoListaSimple.Controls.Add(this.lblNombreNuevoElemento);
            this.gbNuevoElementoListaSimple.Controls.Add(this.lblCodNuevoElemento);
            this.gbNuevoElementoListaSimple.Location = new System.Drawing.Point(276, 23);
            this.gbNuevoElementoListaSimple.Name = "gbNuevoElementoListaSimple";
            this.gbNuevoElementoListaSimple.Size = new System.Drawing.Size(177, 218);
            this.gbNuevoElementoListaSimple.TabIndex = 5;
            this.gbNuevoElementoListaSimple.TabStop = false;
            this.gbNuevoElementoListaSimple.Text = "Nuevo Elemento";
            // 
            // btnAgregarListaSimple
            // 
            this.btnAgregarListaSimple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarListaSimple.Enabled = false;
            this.btnAgregarListaSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarListaSimple.Location = new System.Drawing.Point(9, 145);
            this.btnAgregarListaSimple.Name = "btnAgregarListaSimple";
            this.btnAgregarListaSimple.Size = new System.Drawing.Size(146, 45);
            this.btnAgregarListaSimple.TabIndex = 6;
            this.btnAgregarListaSimple.Text = "Agregar";
            this.btnAgregarListaSimple.UseVisualStyleBackColor = true;
            this.btnAgregarListaSimple.Click += new System.EventHandler(this.btnAgregarListaSimple_Click);
            // 
            // txtTramiteListaSimple
            // 
            this.txtTramiteListaSimple.Location = new System.Drawing.Point(55, 99);
            this.txtTramiteListaSimple.Name = "txtTramiteListaSimple";
            this.txtTramiteListaSimple.Size = new System.Drawing.Size(100, 20);
            this.txtTramiteListaSimple.TabIndex = 5;
            this.txtTramiteListaSimple.TextChanged += new System.EventHandler(this.txtTramiteListaSimple_TextChanged);
            // 
            // txtNombreListaSimple
            // 
            this.txtNombreListaSimple.Location = new System.Drawing.Point(55, 61);
            this.txtNombreListaSimple.Name = "txtNombreListaSimple";
            this.txtNombreListaSimple.Size = new System.Drawing.Size(100, 20);
            this.txtNombreListaSimple.TabIndex = 4;
            this.txtNombreListaSimple.TextChanged += new System.EventHandler(this.txtNombreListaSimple_TextChanged);
            // 
            // txtCodigoListaSimple
            // 
            this.txtCodigoListaSimple.Location = new System.Drawing.Point(55, 23);
            this.txtCodigoListaSimple.Name = "txtCodigoListaSimple";
            this.txtCodigoListaSimple.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoListaSimple.TabIndex = 3;
            this.txtCodigoListaSimple.TextChanged += new System.EventHandler(this.txtCodigoListaSimple_TextChanged);
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
            // pbListaSimple
            // 
            this.pbListaSimple.Image = global::pryEstructuraDatos.Properties.Resources.Lista_simple;
            this.pbListaSimple.Location = new System.Drawing.Point(12, 23);
            this.pbListaSimple.Name = "pbListaSimple";
            this.pbListaSimple.Size = new System.Drawing.Size(243, 218);
            this.pbListaSimple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbListaSimple.TabIndex = 4;
            this.pbListaSimple.TabStop = false;
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 474);
            this.Controls.Add(this.gbListadoListaSimple);
            this.Controls.Add(this.gbElementoEliminadoListaSimple);
            this.Controls.Add(this.gbNuevoElementoListaSimple);
            this.Controls.Add(this.pbListaSimple);
            this.Name = "frmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinámica Lineal - Lista Simple";
            this.gbListadoListaSimple.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).EndInit();
            this.gbElementoEliminadoListaSimple.ResumeLayout(false);
            this.gbElementoEliminadoListaSimple.PerformLayout();
            this.gbNuevoElementoListaSimple.ResumeLayout(false);
            this.gbNuevoElementoListaSimple.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbListaSimple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListadoListaSimple;
        private System.Windows.Forms.DataGridView dgvListaSimple;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstListaSimple;
        private System.Windows.Forms.GroupBox gbElementoEliminadoListaSimple;
        private System.Windows.Forms.Button btnEliminarListaSimple;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbNuevoElementoListaSimple;
        private System.Windows.Forms.Button btnAgregarListaSimple;
        private System.Windows.Forms.TextBox txtTramiteListaSimple;
        private System.Windows.Forms.TextBox txtNombreListaSimple;
        private System.Windows.Forms.TextBox txtCodigoListaSimple;
        private System.Windows.Forms.Label lblTramiteNuevoElemento;
        private System.Windows.Forms.Label lblNombreNuevoElemento;
        private System.Windows.Forms.Label lblCodNuevoElemento;
        private System.Windows.Forms.PictureBox pbListaSimple;
        private System.Windows.Forms.ComboBox cbCodigoListaSimple;
    }
}