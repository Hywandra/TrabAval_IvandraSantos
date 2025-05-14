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
    public partial class frm_Editar : Form
    {
        int idAluno;
        public frm_Editar(int id = -1)
        {
            InitializeComponent();

            idAluno = id;

            LoadAluno();

            this.DialogResult = DialogResult.Cancel;
        }

        private void LoadAluno()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = DBConnect.GetAluno(idAluno);

                txt_nAluno.Text = dt.Rows[0]["N_Aluno"].ToString();
                txt_Nome.Text = dt.Rows[0]["Nome"].ToString();
                txt_Telefone.Text = dt.Rows[0]["Morada"].ToString();
                txt_Morada.Text = dt.Rows[0]["Telefone"].ToString();
                dt_DataNasc.Text = dt.Rows[0]["Data_Nasc"].ToString();
                txt_NotaFinal.Text = dt.Rows[0]["Nota_Final"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a carregar registo! " + ex.Message);
            }

        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_nAluno.Text == "" || txt_Nome.Text == "" || txt_Telefone.Text == "" ||
                txt_Morada.Text == "" || dt_DataNasc.Text == "" || txt_NotaFinal.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            Alunos aluno = new Alunos();

            aluno.NumbAluno = Convert.ToInt16(txt_nAluno.Text);
            aluno.Nome = txt_Nome.Text;
            aluno.Morada = txt_Morada.Text;
            aluno.Telefone = txt_Telefone.Text;
            aluno.DataNasc = dt_DataNasc.Value;
            aluno.Nota = Convert.ToDouble(txt_NotaFinal.Text);

            try
            {
                if (DBConnect.UpdateAluno(aluno, idAluno))
                {
                    MessageBox.Show("Aluno editado.");
                }
                else
                {
                    MessageBox.Show("Não foi possível editar aluno.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar registo: " + ex.Message);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Morada.Clear();
            txt_Nome.Clear();
            txt_nAluno.Clear();
            txt_Telefone.Clear();
            txt_NotaFinal.Clear();
            dt_DataNasc.Value = new DateTime(2020, 12, 31);
        }
    }
}
