namespace Turma_CSharp
{
    partial class frm_Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Editar));
            dt_DataNasc = new DateTimePicker();
            txt_NotaFinal = new TextBox();
            txt_Telefone = new TextBox();
            txt_Morada = new TextBox();
            txt_Nome = new TextBox();
            txt_nAluno = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btn_Voltar = new Button();
            btn_Limpar = new Button();
            btn_Guardar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dt_DataNasc
            // 
            dt_DataNasc.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_DataNasc.CalendarMonthBackground = Color.FromArgb(224, 224, 224);
            dt_DataNasc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_DataNasc.Location = new Point(181, 299);
            dt_DataNasc.Margin = new Padding(5, 3, 3, 3);
            dt_DataNasc.MaxDate = new DateTime(2020, 12, 31, 0, 0, 0, 0);
            dt_DataNasc.MinDate = new DateTime(1925, 1, 1, 0, 0, 0, 0);
            dt_DataNasc.Name = "dt_DataNasc";
            dt_DataNasc.Size = new Size(200, 29);
            dt_DataNasc.TabIndex = 5;
            dt_DataNasc.Value = new DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // txt_NotaFinal
            // 
            txt_NotaFinal.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_NotaFinal.AutoCompleteSource = AutoCompleteSource.HistoryList;
            txt_NotaFinal.BackColor = Color.FromArgb(224, 224, 224);
            txt_NotaFinal.BorderStyle = BorderStyle.FixedSingle;
            txt_NotaFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_NotaFinal.ForeColor = Color.Black;
            txt_NotaFinal.Location = new Point(181, 345);
            txt_NotaFinal.Margin = new Padding(5, 2, 2, 2);
            txt_NotaFinal.Name = "txt_NotaFinal";
            txt_NotaFinal.Size = new Size(320, 29);
            txt_NotaFinal.TabIndex = 6;
            txt_NotaFinal.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Telefone
            // 
            txt_Telefone.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Telefone.AutoCompleteSource = AutoCompleteSource.HistoryList;
            txt_Telefone.BackColor = Color.FromArgb(224, 224, 224);
            txt_Telefone.BorderStyle = BorderStyle.FixedSingle;
            txt_Telefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Telefone.ForeColor = Color.Black;
            txt_Telefone.Location = new Point(181, 253);
            txt_Telefone.Margin = new Padding(5, 2, 2, 2);
            txt_Telefone.Name = "txt_Telefone";
            txt_Telefone.Size = new Size(320, 29);
            txt_Telefone.TabIndex = 4;
            txt_Telefone.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Morada
            // 
            txt_Morada.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Morada.AutoCompleteSource = AutoCompleteSource.HistoryList;
            txt_Morada.BackColor = Color.FromArgb(224, 224, 224);
            txt_Morada.BorderStyle = BorderStyle.FixedSingle;
            txt_Morada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Morada.ForeColor = Color.Black;
            txt_Morada.Location = new Point(181, 207);
            txt_Morada.Margin = new Padding(5, 2, 2, 2);
            txt_Morada.Name = "txt_Morada";
            txt_Morada.Size = new Size(320, 29);
            txt_Morada.TabIndex = 3;
            txt_Morada.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Nome
            // 
            txt_Nome.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Nome.AutoCompleteSource = AutoCompleteSource.HistoryList;
            txt_Nome.BackColor = Color.FromArgb(224, 224, 224);
            txt_Nome.BorderStyle = BorderStyle.FixedSingle;
            txt_Nome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Nome.ForeColor = Color.Black;
            txt_Nome.Location = new Point(181, 161);
            txt_Nome.Margin = new Padding(5, 2, 2, 2);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(320, 29);
            txt_Nome.TabIndex = 2;
            txt_Nome.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_nAluno
            // 
            txt_nAluno.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_nAluno.AutoCompleteSource = AutoCompleteSource.HistoryList;
            txt_nAluno.BackColor = Color.FromArgb(224, 224, 224);
            txt_nAluno.BorderStyle = BorderStyle.FixedSingle;
            txt_nAluno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_nAluno.ForeColor = Color.Black;
            txt_nAluno.Location = new Point(181, 115);
            txt_nAluno.Margin = new Padding(5, 2, 2, 2);
            txt_nAluno.Name = "txt_nAluno";
            txt_nAluno.Size = new Size(320, 29);
            txt_nAluno.TabIndex = 1;
            txt_nAluno.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(15, 15, 15);
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(91, 353);
            label8.Name = "label8";
            label8.Size = new Size(81, 21);
            label8.TabIndex = 17;
            label8.Text = "Nota Final";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(15, 15, 15);
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(43, 307);
            label7.Name = "label7";
            label7.Size = new Size(129, 21);
            label7.TabIndex = 11;
            label7.Text = "Data Nascimento";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(15, 15, 15);
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(105, 261);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 18;
            label6.Text = "Telefone";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(15, 15, 15);
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(108, 215);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 15;
            label5.Text = "Morada";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(15, 15, 15);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(119, 169);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 14;
            label4.Text = "Nome";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(15, 15, 15);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(98, 123);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 13;
            label3.Text = "Nº Aluno";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btn_Voltar);
            panel2.Controls.Add(btn_Limpar);
            panel2.Controls.Add(btn_Guardar);
            panel2.Location = new Point(641, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(110, 154);
            panel2.TabIndex = 13;
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
            btn_Voltar.TabIndex = 9;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = true;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // btn_Limpar
            // 
            btn_Limpar.FlatAppearance.BorderColor = Color.White;
            btn_Limpar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btn_Limpar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Limpar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            btn_Limpar.FlatStyle = FlatStyle.Flat;
            btn_Limpar.ForeColor = Color.White;
            btn_Limpar.Location = new Point(5, 57);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(100, 40);
            btn_Limpar.TabIndex = 8;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Cursor = Cursors.Hand;
            btn_Guardar.FlatAppearance.BorderColor = Color.White;
            btn_Guardar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btn_Guardar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Guardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            btn_Guardar.FlatStyle = FlatStyle.Flat;
            btn_Guardar.ForeColor = Color.White;
            btn_Guardar.Location = new Point(5, 6);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(100, 40);
            btn_Guardar.TabIndex = 7;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 30);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 12;
            label1.Text = "Turma C-Sharp - Editar Aluno";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // frm_Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(dt_DataNasc);
            Controls.Add(txt_NotaFinal);
            Controls.Add(txt_Telefone);
            Controls.Add(txt_Morada);
            Controls.Add(txt_Nome);
            Controls.Add(txt_nAluno);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Editar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Editar";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dt_DataNasc;
        private TextBox txt_NotaFinal;
        private TextBox txt_Telefone;
        private TextBox txt_Morada;
        private TextBox txt_Nome;
        private TextBox txt_nAluno;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Button btn_Voltar;
        private Button btn_Limpar;
        private Button btn_Guardar;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}