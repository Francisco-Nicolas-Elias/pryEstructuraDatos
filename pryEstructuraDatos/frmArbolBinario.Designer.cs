namespace pryEstructuraDatos
{
    partial class frmArbolBinario
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
            this.gbListadoArbolBinario = new System.Windows.Forms.GroupBox();
            this.dgvArbolBinario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbElementoEliminadoArbolBinario = new System.Windows.Forms.GroupBox();
            this.cbCodigoArbolBinario = new System.Windows.Forms.ComboBox();
            this.btnEliminarArbolBinario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbNuevoElementoArbolBinario = new System.Windows.Forms.GroupBox();
            this.btnAgregarArbolBinario = new System.Windows.Forms.Button();
            this.txtTramiteArbolBinario = new System.Windows.Forms.TextBox();
            this.txtNombreArbolBinario = new System.Windows.Forms.TextBox();
            this.txtCodigoArbolBinario = new System.Windows.Forms.TextBox();
            this.lblTramiteNuevoElemento = new System.Windows.Forms.Label();
            this.lblNombreNuevoElemento = new System.Windows.Forms.Label();
            this.lblCodNuevoElemento = new System.Windows.Forms.Label();
            this.tvArbolBinario = new System.Windows.Forms.TreeView();
            this.optInOrdenAsc = new System.Windows.Forms.RadioButton();
            this.optInOrdenDesc = new System.Windows.Forms.RadioButton();
            this.optPreOrden = new System.Windows.Forms.RadioButton();
            this.optPostOrden = new System.Windows.Forms.RadioButton();
            this.btnEquilibrarArbolBinario = new System.Windows.Forms.Button();
            this.gbListadoArbolBinario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).BeginInit();
            this.gbElementoEliminadoArbolBinario.SuspendLayout();
            this.gbNuevoElementoArbolBinario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListadoArbolBinario
            // 
            this.gbListadoArbolBinario.Controls.Add(this.optPostOrden);
            this.gbListadoArbolBinario.Controls.Add(this.optPreOrden);
            this.gbListadoArbolBinario.Controls.Add(this.optInOrdenDesc);
            this.gbListadoArbolBinario.Controls.Add(this.optInOrdenAsc);
            this.gbListadoArbolBinario.Controls.Add(this.dgvArbolBinario);
            this.gbListadoArbolBinario.Location = new System.Drawing.Point(12, 235);
            this.gbListadoArbolBinario.Name = "gbListadoArbolBinario";
            this.gbListadoArbolBinario.Size = new System.Drawing.Size(627, 200);
            this.gbListadoArbolBinario.TabIndex = 16;
            this.gbListadoArbolBinario.TabStop = false;
            this.gbListadoArbolBinario.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvArbolBinario
            // 
            this.dgvArbolBinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbolBinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvArbolBinario.Location = new System.Drawing.Point(224, 19);
            this.dgvArbolBinario.Name = "dgvArbolBinario";
            this.dgvArbolBinario.Size = new System.Drawing.Size(403, 173);
            this.dgvArbolBinario.TabIndex = 1;
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
            // gbElementoEliminadoArbolBinario
            // 
            this.gbElementoEliminadoArbolBinario.Controls.Add(this.cbCodigoArbolBinario);
            this.gbElementoEliminadoArbolBinario.Controls.Add(this.btnEliminarArbolBinario);
            this.gbElementoEliminadoArbolBinario.Controls.Add(this.label4);
            this.gbElementoEliminadoArbolBinario.Location = new System.Drawing.Point(450, 17);
            this.gbElementoEliminadoArbolBinario.Name = "gbElementoEliminadoArbolBinario";
            this.gbElementoEliminadoArbolBinario.Size = new System.Drawing.Size(189, 105);
            this.gbElementoEliminadoArbolBinario.TabIndex = 15;
            this.gbElementoEliminadoArbolBinario.TabStop = false;
            this.gbElementoEliminadoArbolBinario.Text = "Elemento a eliminar";
            // 
            // cbCodigoArbolBinario
            // 
            this.cbCodigoArbolBinario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCodigoArbolBinario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodigoArbolBinario.FormattingEnabled = true;
            this.cbCodigoArbolBinario.Location = new System.Drawing.Point(56, 24);
            this.cbCodigoArbolBinario.Name = "cbCodigoArbolBinario";
            this.cbCodigoArbolBinario.Size = new System.Drawing.Size(121, 21);
            this.cbCodigoArbolBinario.TabIndex = 7;
            // 
            // btnEliminarArbolBinario
            // 
            this.btnEliminarArbolBinario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarArbolBinario.Enabled = false;
            this.btnEliminarArbolBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArbolBinario.Location = new System.Drawing.Point(10, 51);
            this.btnEliminarArbolBinario.Name = "btnEliminarArbolBinario";
            this.btnEliminarArbolBinario.Size = new System.Drawing.Size(167, 45);
            this.btnEliminarArbolBinario.TabIndex = 6;
            this.btnEliminarArbolBinario.Text = "Eliminar";
            this.btnEliminarArbolBinario.UseVisualStyleBackColor = true;
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
            // gbNuevoElementoArbolBinario
            // 
            this.gbNuevoElementoArbolBinario.Controls.Add(this.btnAgregarArbolBinario);
            this.gbNuevoElementoArbolBinario.Controls.Add(this.txtTramiteArbolBinario);
            this.gbNuevoElementoArbolBinario.Controls.Add(this.txtNombreArbolBinario);
            this.gbNuevoElementoArbolBinario.Controls.Add(this.txtCodigoArbolBinario);
            this.gbNuevoElementoArbolBinario.Controls.Add(this.lblTramiteNuevoElemento);
            this.gbNuevoElementoArbolBinario.Controls.Add(this.lblNombreNuevoElemento);
            this.gbNuevoElementoArbolBinario.Controls.Add(this.lblCodNuevoElemento);
            this.gbNuevoElementoArbolBinario.Location = new System.Drawing.Point(256, 17);
            this.gbNuevoElementoArbolBinario.Name = "gbNuevoElementoArbolBinario";
            this.gbNuevoElementoArbolBinario.Size = new System.Drawing.Size(172, 197);
            this.gbNuevoElementoArbolBinario.TabIndex = 14;
            this.gbNuevoElementoArbolBinario.TabStop = false;
            this.gbNuevoElementoArbolBinario.Text = "Nuevo Elemento";
            // 
            // btnAgregarArbolBinario
            // 
            this.btnAgregarArbolBinario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarArbolBinario.Enabled = false;
            this.btnAgregarArbolBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArbolBinario.Location = new System.Drawing.Point(6, 135);
            this.btnAgregarArbolBinario.Name = "btnAgregarArbolBinario";
            this.btnAgregarArbolBinario.Size = new System.Drawing.Size(149, 45);
            this.btnAgregarArbolBinario.TabIndex = 6;
            this.btnAgregarArbolBinario.Text = "Agregar";
            this.btnAgregarArbolBinario.UseVisualStyleBackColor = true;
            this.btnAgregarArbolBinario.Click += new System.EventHandler(this.btnAgregarArbolBinario_Click);
            // 
            // txtTramiteArbolBinario
            // 
            this.txtTramiteArbolBinario.Location = new System.Drawing.Point(55, 99);
            this.txtTramiteArbolBinario.Name = "txtTramiteArbolBinario";
            this.txtTramiteArbolBinario.Size = new System.Drawing.Size(100, 20);
            this.txtTramiteArbolBinario.TabIndex = 5;
            // 
            // txtNombreArbolBinario
            // 
            this.txtNombreArbolBinario.Location = new System.Drawing.Point(55, 61);
            this.txtNombreArbolBinario.Name = "txtNombreArbolBinario";
            this.txtNombreArbolBinario.Size = new System.Drawing.Size(100, 20);
            this.txtNombreArbolBinario.TabIndex = 4;
            // 
            // txtCodigoArbolBinario
            // 
            this.txtCodigoArbolBinario.Location = new System.Drawing.Point(55, 23);
            this.txtCodigoArbolBinario.Name = "txtCodigoArbolBinario";
            this.txtCodigoArbolBinario.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoArbolBinario.TabIndex = 3;
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
            // tvArbolBinario
            // 
            this.tvArbolBinario.Location = new System.Drawing.Point(12, 17);
            this.tvArbolBinario.Name = "tvArbolBinario";
            this.tvArbolBinario.Size = new System.Drawing.Size(197, 197);
            this.tvArbolBinario.TabIndex = 18;
            // 
            // optInOrdenAsc
            // 
            this.optInOrdenAsc.AutoSize = true;
            this.optInOrdenAsc.Location = new System.Drawing.Point(17, 34);
            this.optInOrdenAsc.Name = "optInOrdenAsc";
            this.optInOrdenAsc.Size = new System.Drawing.Size(126, 17);
            this.optInOrdenAsc.TabIndex = 2;
            this.optInOrdenAsc.TabStop = true;
            this.optInOrdenAsc.Text = "In-Orden Ascendente";
            this.optInOrdenAsc.UseVisualStyleBackColor = true;
            // 
            // optInOrdenDesc
            // 
            this.optInOrdenDesc.AutoSize = true;
            this.optInOrdenDesc.Location = new System.Drawing.Point(17, 67);
            this.optInOrdenDesc.Name = "optInOrdenDesc";
            this.optInOrdenDesc.Size = new System.Drawing.Size(133, 17);
            this.optInOrdenDesc.TabIndex = 3;
            this.optInOrdenDesc.TabStop = true;
            this.optInOrdenDesc.Text = "In-Orden Descendente";
            this.optInOrdenDesc.UseVisualStyleBackColor = true;
            // 
            // optPreOrden
            // 
            this.optPreOrden.AutoSize = true;
            this.optPreOrden.Location = new System.Drawing.Point(17, 100);
            this.optPreOrden.Name = "optPreOrden";
            this.optPreOrden.Size = new System.Drawing.Size(73, 17);
            this.optPreOrden.TabIndex = 4;
            this.optPreOrden.TabStop = true;
            this.optPreOrden.Text = "Pre-Orden";
            this.optPreOrden.UseVisualStyleBackColor = true;
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Location = new System.Drawing.Point(17, 133);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(78, 17);
            this.optPostOrden.TabIndex = 5;
            this.optPostOrden.TabStop = true;
            this.optPostOrden.Text = "Post-Orden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            // 
            // btnEquilibrarArbolBinario
            // 
            this.btnEquilibrarArbolBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquilibrarArbolBinario.Location = new System.Drawing.Point(450, 152);
            this.btnEquilibrarArbolBinario.Name = "btnEquilibrarArbolBinario";
            this.btnEquilibrarArbolBinario.Size = new System.Drawing.Size(189, 45);
            this.btnEquilibrarArbolBinario.TabIndex = 19;
            this.btnEquilibrarArbolBinario.Text = "Equilibrar";
            this.btnEquilibrarArbolBinario.UseVisualStyleBackColor = true;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.btnEquilibrarArbolBinario);
            this.Controls.Add(this.tvArbolBinario);
            this.Controls.Add(this.gbListadoArbolBinario);
            this.Controls.Add(this.gbElementoEliminadoArbolBinario);
            this.Controls.Add(this.gbNuevoElementoArbolBinario);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinámica No Lineal - Árbol Binario";
            this.gbListadoArbolBinario.ResumeLayout(false);
            this.gbListadoArbolBinario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).EndInit();
            this.gbElementoEliminadoArbolBinario.ResumeLayout(false);
            this.gbElementoEliminadoArbolBinario.PerformLayout();
            this.gbNuevoElementoArbolBinario.ResumeLayout(false);
            this.gbNuevoElementoArbolBinario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbListadoArbolBinario;
        private System.Windows.Forms.RadioButton optPostOrden;
        private System.Windows.Forms.RadioButton optPreOrden;
        private System.Windows.Forms.RadioButton optInOrdenDesc;
        private System.Windows.Forms.RadioButton optInOrdenAsc;
        private System.Windows.Forms.DataGridView dgvArbolBinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox gbElementoEliminadoArbolBinario;
        private System.Windows.Forms.ComboBox cbCodigoArbolBinario;
        private System.Windows.Forms.Button btnEliminarArbolBinario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbNuevoElementoArbolBinario;
        private System.Windows.Forms.Button btnAgregarArbolBinario;
        private System.Windows.Forms.TextBox txtTramiteArbolBinario;
        private System.Windows.Forms.TextBox txtNombreArbolBinario;
        private System.Windows.Forms.TextBox txtCodigoArbolBinario;
        private System.Windows.Forms.Label lblTramiteNuevoElemento;
        private System.Windows.Forms.Label lblNombreNuevoElemento;
        private System.Windows.Forms.Label lblCodNuevoElemento;
        private System.Windows.Forms.TreeView tvArbolBinario;
        private System.Windows.Forms.Button btnEquilibrarArbolBinario;
    }
}