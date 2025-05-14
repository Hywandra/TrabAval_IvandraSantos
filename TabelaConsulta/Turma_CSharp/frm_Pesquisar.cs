using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turma_CSharp
{
    public partial class frm_Pesquisar : Form
    {
        int idAluno;
        string item;
        public frm_Pesquisar(string pesquisa = "")
        {
            InitializeComponent();

            item = pesquisa;
            ViewTable();
        }

        private void ViewTable()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DBConnect.GetAlunos(item);

                dtGV_Alunos.DataSource = dt;

                dtGV_Alunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtGV_Alunos.RowHeadersVisible = false;

                btn_Editar.Enabled = false;
                btn_Remover.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
        }

        private void txt_Pesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_Pesquisar.Text == "")
                {
                    MessageBox.Show("Por favor, preencha o campo de pesquisa.");
                    return;
                }
                item = txt_Pesquisar.Text;
                dtGV_Alunos.Visible = true;
                ViewTable();
            }
        }

        private void dtGV_Alunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idAluno = Convert.ToInt32(dtGV_Alunos.Rows[e.RowIndex].Cells["ID_Aluno"].Value);
            btn_Editar.Enabled = true;
            btn_Remover.Enabled = true;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            frm_Editar editar = new frm_Editar(idAluno);
            if (editar.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Aluno adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Operação cancelada.");
            }

            ViewTable();
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que deseja remover o aluno?", "Remover",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                if (DBConnect.DeleteAluno(idAluno))
                {
                    ViewTable();
                    MessageBox.Show("Aluno removido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível remover aluno.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover aluno: " + ex.Message);
            }
        }
        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            frm_Entrada entrada = new frm_Entrada();
            entrada.Show();
            this.Close();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (txt_Pesquisar.Text == "")
            {
                MessageBox.Show("Por favor, preencha o campo de pesquisa.");
                return;
            }
            item = txt_Pesquisar.Text;
            dtGV_Alunos.Visible = true;
            ViewTable();
        }
    }
}
