namespace Turma_CSharp
{
    partial class frm_Listagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Listagem));
            panel2 = new Panel();
            btn_Voltar = new Button();
            dtGV_Alunos = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGV_Alunos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btn_Voltar);
            panel2.Location = new Point(641, 185);
            panel2.Name = "panel2";
            panel2.Size = new Size(110, 50);
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
            btn_Voltar.Location = new Point(5, 5);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(100, 40);
            btn_Voltar.TabIndex = 2;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = true;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // dtGV_Alunos
            // 
            dtGV_Alunos.AllowDrop = true;
            dtGV_Alunos.AllowUserToAddRows = false;
            dtGV_Alunos.AllowUserToDeleteRows = false;
            dtGV_Alunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dtGV_Alunos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtGV_Alunos.BackgroundColor = Color.FromArgb(15, 15, 15);
            dtGV_Alunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGV_Alunos.Location = new Point(43, 83);
            dtGV_Alunos.MultiSelect = false;
            dtGV_Alunos.Name = "dtGV_Alunos";
            dtGV_Alunos.ReadOnly = true;
            dtGV_Alunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGV_Alunos.Size = new Size(541, 286);
            dtGV_Alunos.TabIndex = 1;
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
            label1.Size = new Size(203, 15);
            label1.TabIndex = 11;
            label1.Text = "Turma C-Sharp - Listagem de Alunos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // frm_Listagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(dtGV_Alunos);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Listagem";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGV_Alunos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btn_Voltar;
        private DataGridView dtGV_Alunos;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}