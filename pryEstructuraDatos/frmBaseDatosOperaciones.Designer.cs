namespace pryEstructuraDatos
{
    partial class frmBaseDatosOperaciones
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
            this.dgvBaseDatosOperaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.btnProyeccionMultiatributo = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.btnSeleccionMultiatributo = new System.Windows.Forms.Button();
            this.btnSeleccionPorConvolucion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatosOperaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBaseDatosOperaciones
            // 
            this.dgvBaseDatosOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatosOperaciones.Location = new System.Drawing.Point(3, 12);
            this.dgvBaseDatosOperaciones.Name = "dgvBaseDatosOperaciones";
            this.dgvBaseDatosOperaciones.Size = new System.Drawing.Size(815, 248);
            this.dgvBaseDatosOperaciones.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJuntar);
            this.groupBox1.Controls.Add(this.btnProyeccionMultiatributo);
            this.groupBox1.Controls.Add(this.btnProyeccionSimple);
            this.groupBox1.Location = new System.Drawing.Point(3, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de Proyección - SELECT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSeleccionPorConvolucion);
            this.groupBox2.Controls.Add(this.btnSeleccionMultiatributo);
            this.groupBox2.Controls.Add(this.btnSeleccionSimple);
            this.groupBox2.Location = new System.Drawing.Point(286, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 109);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones de Selección - WHERE";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDiferencia);
            this.groupBox3.Controls.Add(this.btnInterseccion);
            this.groupBox3.Controls.Add(this.btnUnion);
            this.groupBox3.Location = new System.Drawing.Point(560, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 109);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones Algebraicas";
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyeccionSimple.Location = new System.Drawing.Point(10, 20);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(242, 23);
            this.btnProyeccionSimple.TabIndex = 0;
            this.btnProyeccionSimple.Text = "Proyección simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            // 
            // btnProyeccionMultiatributo
            // 
            this.btnProyeccionMultiatributo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyeccionMultiatributo.Location = new System.Drawing.Point(10, 49);
            this.btnProyeccionMultiatributo.Name = "btnProyeccionMultiatributo";
            this.btnProyeccionMultiatributo.Size = new System.Drawing.Size(242, 23);
            this.btnProyeccionMultiatributo.TabIndex = 1;
            this.btnProyeccionMultiatributo.Text = "Proyección multiatributo";
            this.btnProyeccionMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJuntar.Location = new System.Drawing.Point(9, 77);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(243, 23);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionSimple.Location = new System.Drawing.Point(6, 19);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(246, 23);
            this.btnSeleccionSimple.TabIndex = 0;
            this.btnSeleccionSimple.Text = "Selección simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionMultiatributo
            // 
            this.btnSeleccionMultiatributo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionMultiatributo.Location = new System.Drawing.Point(6, 49);
            this.btnSeleccionMultiatributo.Name = "btnSeleccionMultiatributo";
            this.btnSeleccionMultiatributo.Size = new System.Drawing.Size(246, 23);
            this.btnSeleccionMultiatributo.TabIndex = 1;
            this.btnSeleccionMultiatributo.Text = "Selección multiatributo";
            this.btnSeleccionMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionPorConvolucion
            // 
            this.btnSeleccionPorConvolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionPorConvolucion.Location = new System.Drawing.Point(6, 79);
            this.btnSeleccionPorConvolucion.Name = "btnSeleccionPorConvolucion";
            this.btnSeleccionPorConvolucion.Size = new System.Drawing.Size(246, 23);
            this.btnSeleccionPorConvolucion.TabIndex = 2;
            this.btnSeleccionPorConvolucion.Text = "Selección por convolución";
            this.btnSeleccionPorConvolucion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnion.Location = new System.Drawing.Point(6, 19);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(244, 23);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInterseccion.Location = new System.Drawing.Point(6, 48);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(244, 23);
            this.btnInterseccion.TabIndex = 1;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiferencia.Location = new System.Drawing.Point(6, 77);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(244, 23);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // frmBaseDatosOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBaseDatosOperaciones);
            this.Name = "frmBaseDatosOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatosOperaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDatosOperaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyeccionMultiatributo;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.Button btnSeleccionPorConvolucion;
        private System.Windows.Forms.Button btnSeleccionMultiatributo;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
    }
}