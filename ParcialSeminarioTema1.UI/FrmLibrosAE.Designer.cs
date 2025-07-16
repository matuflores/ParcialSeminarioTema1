namespace ParcialSeminarioTema1.UI
{
    partial class FrmLibrosAE
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            TxtCodigo = new TextBox();
            label2 = new Label();
            TxtTitulo = new TextBox();
            label3 = new Label();
            TxtSinopsis = new TextBox();
            label4 = new Label();
            CboGeneros = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 68);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(135, 64);
            TxtCodigo.Margin = new Padding(3, 4, 3, 4);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.ReadOnly = true;
            TxtCodigo.Size = new Size(151, 27);
            TxtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 120);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "Título:";
            // 
            // TxtTitulo
            // 
            TxtTitulo.Location = new Point(135, 116);
            TxtTitulo.Margin = new Padding(3, 4, 3, 4);
            TxtTitulo.MaxLength = 255;
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(514, 27);
            TxtTitulo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 175);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 0;
            label3.Text = "Sinopsis:";
            // 
            // TxtSinopsis
            // 
            TxtSinopsis.Location = new Point(135, 171);
            TxtSinopsis.Margin = new Padding(3, 4, 3, 4);
            TxtSinopsis.Multiline = true;
            TxtSinopsis.Name = "TxtSinopsis";
            TxtSinopsis.Size = new Size(514, 127);
            TxtSinopsis.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 341);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 0;
            label4.Text = "Género:";
            // 
            // CboGeneros
            // 
            CboGeneros.DropDownStyle = ComboBoxStyle.DropDownList;
            CboGeneros.FormattingEnabled = true;
            CboGeneros.Location = new Point(138, 336);
            CboGeneros.Margin = new Padding(3, 4, 3, 4);
            CboGeneros.Name = "CboGeneros";
            CboGeneros.Size = new Size(223, 28);
            CboGeneros.TabIndex = 2;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Aceptar;
            button1.Location = new Point(82, 405);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 73);
            button1.TabIndex = 3;
            button1.Text = "OK";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.Cancelar;
            button2.Location = new Point(563, 405);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 73);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmLibrosAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 504);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CboGeneros);
            Controls.Add(TxtSinopsis);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TxtTitulo);
            Controls.Add(label2);
            Controls.Add(TxtCodigo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(736, 551);
            MinimumSize = new Size(736, 551);
            Name = "FrmLibrosAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLibrosAE";
            Load += FrmLibrosAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private TextBox TxtSinopsis;
        private Label label4;
        private Label label3;
        private TextBox TxtTitulo;
        private Label label2;
        private TextBox TxtCodigo;
        private Label label1;
        private Button button2;
        private Button button1;
        private ComboBox CboGeneros;
    }
}