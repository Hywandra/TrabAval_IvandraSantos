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
    public partial class frm_Adicionar : Form
    {
        int idAluno;
        public frm_Adicionar(int id = -1)
        {
            InitializeComponent();

            idAluno = id;

            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (txt_nAluno.Text == "" || txt_Nome.Text == "" || txt_Telefone.Text == "" ||
                txt_Morada.Text == "" || dt_DataNasc.Text == "" || txt_NotaFinal.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            Alunos aluno = new Alunos();

            aluno.NumbAluno = Convert.ToInt16(this.txt_nAluno.Text);
            aluno.Nome = this.txt_Nome.Text;
            aluno.Morada = this.txt_Morada.Text;
            aluno.Telefone = this.txt_Telefone.Text;
            aluno.DataNasc = this.dt_DataNasc.Value;
            aluno.Nota = Convert.ToDouble(this.txt_NotaFinal.Text);

            try
            {
                if (DBConnect.AddAluno(aluno, idAluno))
                {
                    MessageBox.Show("Aluno adicionado.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Não foi possível adicionar aluno.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar registo: " + ex.Message);
                return;
            }
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
