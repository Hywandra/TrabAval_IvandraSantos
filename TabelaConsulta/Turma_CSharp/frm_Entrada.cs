namespace Turma_CSharp
{
    public partial class frm_Entrada : Form
    {
        public frm_Entrada()
        {
            InitializeComponent();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            frm_Adicionar adicionar = new frm_Adicionar();
            if (adicionar.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Aluno adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Operação cancelada.");
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            frm_Pesquisar pesquisar = new frm_Pesquisar();
            pesquisar.ShowDialog();
            this.Hide();
        }

        private void btn_Listagem_Click(object sender, EventArgs e)
        {
            frm_Listagem listagem = new frm_Listagem();
            listagem.ShowDialog();
            this.Hide();
        }

        private void btn_Notas_Click(object sender, EventArgs e)
        {
            frm_Notas notas = new frm_Notas();
            notas.ShowDialog();
            this.Hide();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que deseja fechar o programa?", "Fechar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Application.Exit();
        }
    }
}
