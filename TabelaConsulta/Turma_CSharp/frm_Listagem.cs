using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turma_CSharp
{
    public partial class frm_Listagem : Form
    {
        string item = "";
        public frm_Listagem()
        {
            InitializeComponent();

            
            ListarAlunos();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            frm_Entrada entrada = new frm_Entrada();
            entrada.Show();
            this.Close();
        }

        private void ListarAlunos()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DBConnect.GetAlunos(item);
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
