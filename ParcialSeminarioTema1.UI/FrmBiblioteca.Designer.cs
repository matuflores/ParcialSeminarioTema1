namespace ParcialSeminarioTema1.UI
{
    partial class FrmBiblioteca
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitulo = new DataGridViewTextBoxColumn();
            colGenero = new DataGridViewTextBoxColumn();
            TxtRegistros = new TextBox();
            label1 = new Label();
            TsbNuevo = new ToolStripButton();
            TsbBorrar = new ToolStripButton();
            TsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TsbFiltrar = new ToolStripButton();
            TsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            TsbCerrar = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 67);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtRegistros);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(914, 756);
            splitContainer1.SplitterDistance = 604;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 5;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, colTitulo, colGenero });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(914, 604);
            dgvDatos.TabIndex = 2;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            colId.Width = 125;
            // 
            // colTitulo
            // 
            colTitulo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTitulo.HeaderText = "Título";
            colTitulo.MinimumWidth = 6;
            colTitulo.Name = "colTitulo";
            colTitulo.ReadOnly = true;
            // 
            // colGenero
            // 
            colGenero.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colGenero.HeaderText = "Género";
            colGenero.MinimumWidth = 6;
            colGenero.Name = "colGenero";
            colGenero.ReadOnly = true;
            // 
            // TxtRegistros
            // 
            TxtRegistros.Location = new Point(112, 51);
            TxtRegistros.Margin = new Padding(3, 4, 3, 4);
            TxtRegistros.Name = "TxtRegistros";
            TxtRegistros.ReadOnly = true;
            TxtRegistros.Size = new Size(97, 27);
            TxtRegistros.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 55);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 17;
            label1.Text = "Registros:";
            // 
            // TsbNuevo
            // 
            TsbNuevo.Image = Properties.Resources.Nuevo;
            TsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            TsbNuevo.ImageTransparentColor = Color.Magenta;
            TsbNuevo.Name = "TsbNuevo";
            TsbNuevo.Size = new Size(56, 64);
            TsbNuevo.Text = "Nuevo";
            TsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // TsbBorrar
            // 
            TsbBorrar.Image = Properties.Resources.Delete;
            TsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbBorrar.ImageTransparentColor = Color.Magenta;
            TsbBorrar.Name = "TsbBorrar";
            TsbBorrar.Size = new Size(54, 64);
            TsbBorrar.Text = "Borrar";
            TsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // TsbEditar
            // 
            TsbEditar.Image = Properties.Resources.Edit;
            TsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            TsbEditar.ImageTransparentColor = Color.Magenta;
            TsbEditar.Name = "TsbEditar";
            TsbEditar.Size = new Size(52, 64);
            TsbEditar.Text = "Editar";
            TsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 67);
            // 
            // TsbFiltrar
            // 
            TsbFiltrar.Image = Properties.Resources.filter_40px;
            TsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbFiltrar.ImageTransparentColor = Color.Magenta;
            TsbFiltrar.Name = "TsbFiltrar";
            TsbFiltrar.Size = new Size(51, 64);
            TsbFiltrar.Text = "Filtrar";
            TsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // TsbActualizar
            // 
            TsbActualizar.Image = Properties.Resources.Update;
            TsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            TsbActualizar.ImageTransparentColor = Color.Magenta;
            TsbActualizar.Name = "TsbActualizar";
            TsbActualizar.Size = new Size(79, 64);
            TsbActualizar.Text = "Actualizar";
            TsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 67);
            // 
            // TsbCerrar
            // 
            TsbCerrar.Image = Properties.Resources.Close;
            TsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbCerrar.ImageTransparentColor = Color.Magenta;
            TsbCerrar.Name = "TsbCerrar";
            TsbCerrar.Size = new Size(53, 64);
            TsbCerrar.Text = "Cerrar";
            TsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbCerrar.Click += TsbCerrar_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbNuevo, TsbBorrar, TsbEditar, toolStripSeparator1, TsbFiltrar, TsbActualizar, toolStripSeparator2, TsbCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 67);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // FrmBiblioteca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 823);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmBiblioteca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca";
            Load += FrmBiblioteca_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private TextBox TxtRegistros;
        private Label label1;
        private ToolStripButton TsbNuevo;
        private ToolStripButton TsbBorrar;
        private ToolStripButton TsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsbFiltrar;
        private ToolStripButton TsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton TsbCerrar;
        private ToolStrip toolStrip1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitulo;
        private DataGridViewTextBoxColumn colGenero;
    }
}