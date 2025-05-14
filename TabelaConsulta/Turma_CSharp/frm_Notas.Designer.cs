namespace Turma_CSharp
{
    partial class frm_Notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Notas));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btn_Voltar = new Button();
            btn_Reprovados = new Button();
            btn_MinNota = new Button();
            btn_MaxNota = new Button();
            btn_Media = new Button();
            pictureBox1 = new PictureBox();
            dtGV_Alunos = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGV_Alunos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 30);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 15);
            label1.TabIndex = 1;
            label1.Text = "Turma C-Sharp - Relatório de Notas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btn_Voltar);
            panel2.Controls.Add(btn_Reprovados);
            panel2.Controls.Add(btn_MinNota);
            panel2.Controls.Add(btn_MaxNota);
            panel2.Controls.Add(btn_Media);
            panel2.Location = new Point(641, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(110, 253);
            panel2.TabIndex = 16;
            // 
            // btn_Voltar
            // 
            btn_Voltar.FlatAppearance.BorderColor = Color.White;
            btn_Voltar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btn_Voltar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Voltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            btn_Voltar.FlatStyle = FlatStyle.Flat;
            btn_Voltar.ForeColor = Color.White;
            btn_Voltar.Location = new Point(5, 208);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(100, 40);
            btn_Voltar.TabIndex = 2;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = true;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // btn_Reprovados
            // 
            btn_Reprovados.FlatAppearance.BorderColor = Color.White;
            btn_Reprovados.FlatAppearance.CheckedBackColor = Color.Transparent;
            btn_Reprovados.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Reprovados.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            btn_Reprovados.FlatStyle = FlatStyle.Flat;
            btn_Reprovados.ForeColor = Color.White;
            btn_Reprovados.Location = new Point(5, 157);
            btn_Reprovados.Name = "btn_Reprovados";
            btn_Reprovados.Size = new Size(100, 40);
            btn_Reprovados.TabIndex = 2;
            btn_Reprovados.Text = "Reprovados";
            btn_Reprovados.UseVisualStyleBackColor = true;
            btn_Reprovados.Click += btn_Reprovados_Click;
            // 
            // btn_MinNota
            // 
            btn_MinNota.FlatAppearance.BorderColor = Color.White;
            btn_MinNota.FlatAppearance.CheckedBackColor = Color.Transparent;
            btn_MinNota.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_MinNota.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            btn_MinNota.FlatStyle = FlatStyle.Flat;
            btn_MinNota.ForeColor = Color.White;
            btn_MinNota.Location = new Point(5, 108);
            btn_MinNota.Name = "btn_MinNota";
            btn_MinNota.Size = new Size(100, 40);
            btn_MinNota.TabIndex = 2;
            btn_MinNota.Text = "Nota Mínima";
            btn_MinNota.UseVisualStyleBackColor = true;
            btn_MinNota.Click += btn_MinNota_Click;
            // 
            // btn_MaxNota
            // 
            btn_MaxNota.FlatAppearance.BorderColor = Color.White;
            btn_MaxNota.FlatAppearance.CheckedBackColor = Color.Transparent;
            btn_MaxNota.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_MaxNota.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            btn_MaxNota.FlatStyle = FlatStyle.Flat;
            btn_MaxNota.ForeColor = Color.White;
            btn_MaxNota.Location = new Point(5, 57);
            btn_MaxNota.Name = "btn_MaxNota";
            btn_MaxNota.Size = new Size(100, 40);
            btn_MaxNota.TabIndex = 2;
            btn_MaxNota.Text = "Nota Máxima";
            btn_MaxNota.UseVisualStyleBackColor = true;
            btn_MaxNota.Click += btn_MaxNota_Click;
            // 
            // btn_Media
            // 
            btn_Media.Cursor = Cursors.Hand;
            btn_Media.FlatAppearance.BorderColor = Color.White;
            btn_Media.FlatAppearance.CheckedBackColor = Color.Transparent;
            btn_Media.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Media.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            btn_Media.FlatStyle = FlatStyle.Flat;
            btn_Media.ForeColor = Color.White;
            btn_Media.Location = new Point(5, 6);
            btn_Media.Name = "btn_Media";
            btn_Media.Size = new Size(100, 40);
            btn_Media.TabIndex = 2;
            btn_Media.Text = "Média";
            btn_Media.UseVisualStyleBackColor = true;
            btn_Media.Click += btn_Media_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // dtGV_Alunos
            // 
            dtGV_Alunos.AllowUserToAddRows = false;
            dtGV_Alunos.AllowUserToDeleteRows = false;
            dtGV_Alunos.AllowUserToResizeColumns = false;
            dtGV_Alunos.AllowUserToResizeRows = false;
            dtGV_Alunos.BackgroundColor = Color.FromArgb(15, 15, 15);
            dtGV_Alunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGV_Alunos.Location = new Point(50, 93);
            dtGV_Alunos.MultiSelect = false;
            dtGV_Alunos.Name = "dtGV_Alunos";
            dtGV_Alunos.ReadOnly = true;
            dtGV_Alunos.RowHeadersVisible = false;
            dtGV_Alunos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtGV_Alunos.RowTemplate.ReadOnly = true;
            dtGV_Alunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGV_Alunos.Size = new Size(541, 264);
            dtGV_Alunos.TabIndex = 19;
            dtGV_Alunos.Visible = false;
            // 
            // frm_Notas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(dtGV_Alunos);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Notas";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Notas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGV_Alunos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btn_MinNota;
        private Button btn_MaxNota;
        private Button btn_Media;
        private Button btn_Voltar;
        private Button btn_Reprovados;
        private PictureBox pictureBox1;
        private DataGridView dtGV_Alunos;
    }
}