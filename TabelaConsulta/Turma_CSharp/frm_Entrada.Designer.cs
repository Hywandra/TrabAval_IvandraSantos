namespace Turma_CSharp
{
    partial class frm_Entrada
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Entrada));
            panel1 = new Panel();
            btn_Sair = new Button();
            label1 = new Label();
            btn_Adicionar = new Button();
            panel2 = new Panel();
            btn_Notas = new Button();
            btn_Listagem = new Button();
            btn_Pesquisar = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btn_Sair);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 30);
            panel1.TabIndex = 10;
            // 
            // btn_Sair
            // 
            btn_Sair.Cursor = Cursors.Hand;
            btn_Sair.Dock = DockStyle.Right;
            btn_Sair.FlatAppearance.BorderSize = 0;
            btn_Sair.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btn_Sair.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_Sair.FlatStyle = FlatStyle.Flat;
            btn_Sair.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Sair.ForeColor = Color.Gray;
            btn_Sair.ImageAlign = ContentAlignment.TopLeft;
            btn_Sair.Location = new Point(770, 0);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(30, 30);
            btn_Sair.TabIndex = 5;
            btn_Sair.Text = "X";
            btn_Sair.UseVisualStyleBackColor = true;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 11;
            label1.Text = "Turma C-Sharp";
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.Cursor = Cursors.Hand;
            btn_Adicionar.FlatAppearance.BorderColor = Color.White;
            btn_Adicionar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            btn_Adicionar.FlatStyle = FlatStyle.Flat;
            btn_Adicionar.ForeColor = Color.White;
            btn_Adicionar.Location = new Point(7, 50);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(100, 40);
            btn_Adicionar.TabIndex = 1;
            btn_Adicionar.Text = "Adicionar";
            btn_Adicionar.UseVisualStyleBackColor = true;
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btn_Notas);
            panel2.Controls.Add(btn_Listagem);
            panel2.Controls.Add(btn_Pesquisar);
            panel2.Controls.Add(btn_Adicionar);
            panel2.Location = new Point(343, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(114, 271);
            panel2.TabIndex = 12;
            // 
            // btn_Notas
            // 
            btn_Notas.FlatAppearance.BorderColor = Color.White;
            btn_Notas.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            btn_Notas.FlatStyle = FlatStyle.Flat;
            btn_Notas.ForeColor = Color.White;
            btn_Notas.Location = new Point(7, 218);
            btn_Notas.Name = "btn_Notas";
            btn_Notas.Size = new Size(100, 40);
            btn_Notas.TabIndex = 4;
            btn_Notas.Text = "Notas";
            btn_Notas.UseVisualStyleBackColor = true;
            btn_Notas.Click += btn_Notas_Click;
            // 
            // btn_Listagem
            // 
            btn_Listagem.FlatAppearance.BorderColor = Color.White;
            btn_Listagem.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            btn_Listagem.FlatStyle = FlatStyle.Flat;
            btn_Listagem.ForeColor = Color.White;
            btn_Listagem.Location = new Point(7, 162);
            btn_Listagem.Name = "btn_Listagem";
            btn_Listagem.Size = new Size(100, 40);
            btn_Listagem.TabIndex = 3;
            btn_Listagem.Text = "Listagem";
            btn_Listagem.UseVisualStyleBackColor = true;
            btn_Listagem.Click += btn_Listagem_Click;
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.FlatAppearance.BorderColor = Color.White;
            btn_Pesquisar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            btn_Pesquisar.FlatStyle = FlatStyle.Flat;
            btn_Pesquisar.ForeColor = Color.White;
            btn_Pesquisar.Location = new Point(7, 106);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(100, 40);
            btn_Pesquisar.TabIndex = 2;
            btn_Pesquisar.Text = "Pesquisar";
            btn_Pesquisar.UseVisualStyleBackColor = true;
            btn_Pesquisar.Click += btn_Pesquisar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frm_Entrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Entrada";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_Sair;
        private Label label1;
        private Button btn_Adicionar;
        private Panel panel2;
        private Button btn_Notas;
        private Button btn_Listagem;
        private Button btn_Pesquisar;
        private PictureBox pictureBox1;
    }
}
