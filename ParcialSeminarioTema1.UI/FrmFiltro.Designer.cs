namespace ParcialSeminarioTema1.UI
{
    partial class FrmFiltro
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
            button2 = new Button();
            button1 = new Button();
            TxtGenero = new TextBox();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Image = Properties.Resources.Cancelar;
            button2.Location = new Point(373, 146);
            button2.Name = "button2";
            button2.Size = new Size(75, 55);
            button2.TabIndex = 4;
            button2.Text = "Cancelar";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Aceptar;
            button1.Location = new Point(38, 146);
            button1.Name = "button1";
            button1.Size = new Size(75, 55);
            button1.TabIndex = 5;
            button1.Text = "OK";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // TxtGenero
            // 
            TxtGenero.Location = new Point(95, 54);
            TxtGenero.MaxLength = 255;
            TxtGenero.Name = "TxtGenero";
            TxtGenero.Size = new Size(353, 23);
            TxtGenero.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 57);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 6;
            label2.Text = "Género:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmFiltro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 229);
            Controls.Add(TxtGenero);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximumSize = new Size(509, 268);
            MinimumSize = new Size(509, 268);
            Name = "FrmFiltro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFiltro";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox TxtGenero;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}