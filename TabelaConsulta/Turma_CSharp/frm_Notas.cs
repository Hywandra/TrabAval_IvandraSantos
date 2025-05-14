using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turma_CSharp
{
    public partial class frm_Notas : Form
    {
        public frm_Notas()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            frm_Entrada entrada = new frm_Entrada();
            entrada.Show();
            this.Close();
        }

        private void btn_Media_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A média da turma é: " + DBConnect.MediaAlunos());

        }

        private void btn_MaxNota_Click(object sender, EventArgs e)
        {
            try
            {
                dtGV_Alunos.Visible = true;
                DataTable dt = new DataTable();
                dt = DBConnect.NotaMax();
                dtGV_Alunos.DataSource = dt;

                dtGV_Alunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtGV_Alunos.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
            
        }

        private void btn_MinNota_Click(object sender, EventArgs e)
        {
            try
            {
                dtGV_Alunos.Visible = true;
                DataTable dt = new DataTable();
                dt = DBConnect.NotaMin();
                dtGV_Alunos.DataSource = dt;

                dtGV_Alunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtGV_Alunos.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
        }

        private void btn_Reprovados_Click(object sender, EventArgs e)
        {
            try
            {
                dtGV_Alunos.Visible = true;
                DataTable dt = new DataTable();
                dt = DBConnect.Reprovados();
                dtGV_Alunos.DataSource = dt;

                dtGV_Alunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtGV_Alunos.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
        }
    }
}
