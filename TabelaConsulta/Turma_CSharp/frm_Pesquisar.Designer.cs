namespace Turma_CSharp
{
    partial class frm_Pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Pesquisar));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            txt_Pesquisar = new TextBox();
            dtGV_Alunos = new DataGridView();
            panel2 = new Panel();
            btn_Voltar = new Button();
            btn_Remover = new Button();
            btn_Editar = new Button();
            btn_Pesquisar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGV_Alunos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 30);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 15);
            label1.TabIndex = 11;
            label1.Text = "Turma C-Sharp - Pesquisar Aluno";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(20, 20, 20);
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(40, 77);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 9;
            label7.Text = "Pesquisar";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Pesquisar
            // 
            txt_Pesquisar.BackColor = Color.FromArgb(224, 224, 224);
            txt_Pesquisar.BorderStyle = BorderStyle.FixedSingle;
            txt_Pesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Pesquisar.ForeColor = Color.Black;
            txt_Pesquisar.Location = new Point(121, 73);
            txt_Pesquisar.Margin = new Padding(5, 2, 2, 2);
            txt_Pesquisar.Name = "txt_Pesquisar";
            txt_Pesquisar.Size = new Size(417, 29);
            txt_Pesquisar.TabIndex = 1;
            txt_Pesquisar.KeyPress += txt_Pesquisar_KeyPress;
            // 
            // dtGV_Alunos
            // 
            dtGV_Alunos.AllowUserToAddRows = false;
            dtGV_Alunos.AllowUserToDeleteRows = false;
            dtGV_Alunos.AllowUserToResizeRows = false;
            dtGV_Alunos.BackgroundColor = Color.FromArgb(15, 15, 15);
            dtGV_Alunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGV_Alunos.Location = new Point(43, 118);
            dtGV_Alunos.MultiSelect = false;
            dtGV_Alunos.Name = "dtGV_Alunos";
            dtGV_Alunos.ReadOnly = true;
            dtGV_Alunos.RowHeadersVisible = false;
            dtGV_Alunos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtGV_Alunos.RowTemplate.ReadOnly = true;
            dtGV_Alunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGV_Alunos.Size = new Size(541, 264);
            dtGV_Alunos.TabIndex = 5;
            dtGV_Alunos.Visible = false;
            dtGV_Alunos.CellClick += dtGV_Alunos_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btn_Voltar);
            panel2.Controls.Add(btn_Remover);
            panel2.Controls.Add(btn_Editar);
            panel2.Location = new Point(641, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(110, 154);
            panel2.TabIndex = 12;
            // 
            // btn_Voltar
            // 
            btn_Voltar.FlatAppearance.BorderColor = Color.White;
            btn_Voltar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btn_Voltar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Voltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            btn_Voltar.FlatStyle = FlatStyle.Flat;
            btn_Voltar.ForeColor = Color.White;
            btn_Voltar.Location = new Point(5, 108);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(100, 40);
            btn_Voltar.TabIndex = 4;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = true;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // btn_Remover
            // 
            btn_Remover.FlatAppearance.BorderColor = Color.White;
            btn_Remover.FlatAppearance.CheckedBackColor = Color.Transparent;
            btn_Remover.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Remover.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            btn_Remover.FlatStyle = FlatStyle.Flat;
            btn_Remover.ForeColor = Color.White;
            btn_Remover.Location = new Point(5, 57);
            btn_Remover.Name = "btn_Remover";
            btn_Remover.Size = new Size(100, 40);
            btn_Remover.TabIndex = 3;
            btn_Remover.Text = "Remover";
            btn_Remover.UseVisualStyleBackColor = true;
            btn_Remover.Click += btn_Remover_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Cursor = Cursors.Hand;
            btn_Editar.FlatAppearance.BorderColor = Color.White;
            btn_Editar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btn_Editar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Editar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            btn_Editar.FlatStyle = FlatStyle.Flat;
            btn_Editar.ForeColor = Color.White;
            btn_Editar.Location = new Point(5, 6);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(100, 40);
            btn_Editar.TabIndex = 2;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.Cursor = Cursors.Hand;
            btn_Pesquisar.FlatAppearance.BorderSize = 0;
            btn_Pesquisar.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            btn_Pesquisar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Pesquisar.FlatStyle = FlatStyle.Flat;
            btn_Pesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Pesquisar.ForeColor = Color.Gray;
            btn_Pesquisar.Image = (Image)resources.GetObject("btn_Pesquisar.Image");
            btn_Pesquisar.Location = new Point(534, 61);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(50, 50);
            btn_Pesquisar.TabIndex = 13;
            btn_Pesquisar.UseVisualStyleBackColor = true;
            btn_Pesquisar.Click += btn_Pesquisar_Click;
            // 
            // frm_Pesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Pesquisar);
            Controls.Add(panel2);
            Controls.Add(dtGV_Alunos);
            Controls.Add(txt_Pesquisar);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Pesquisar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Pesquisar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGV_Alunos).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox txt_Pesquisar;
        private DataGridView dtGV_Alunos;
        private Panel panel2;
        private Button btn_Voltar;
        private Button btn_Remover;
        private Button btn_Editar;
        private Button btn_Pesquisar;
    }
}