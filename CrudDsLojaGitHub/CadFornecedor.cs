using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudDsLojaGitHub
{
    public partial class CadFornecedor : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["CrudDsLojaGitHub.Properties.Settings.Conexao"].ConnectionString;
        public CadFornecedor()
        {
            InitializeComponent();
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constring);

                string id = txtbox_id.Text;
                string nome = txtbox_nome.Text;
                string cnpj = txtbox_cnpj.Text;
                string email = txtbox_email.Text;
                string tel = txtbox_tel.Text;
                string cel = txtbox_cel.Text;
                string cep = txtbox_cep.Text;
                string endereco = txtbox_ende.Text;
                int num = int.Parse(txtbox_num.Text);
                string comple = txtbox_comp.Text;
                string bairro = txtbox_bairro.Text;
                string cidade = txtbox_cid.Text;
                string estado = txtbox_est.Text;

                string cmdInsert = @"insert into tb_fornecedores
                                (
                                tb_fornecedores_nome, tb_fornecedores_cnpj, tb_fornecedores_email,
                                tb_fornecedores_telefone, tb_fornecedores_celular, tb_fornecedores_cep, tb_fornecedores_endereco, 
                                tb_fornecedores_numero, tb_fornecedores_complemento, tb_fornecedores_bairro, 
                                tb_fornecedores_cidade, tb_fornecedores_estado
                                )
                                values
                                (
                                @nome, @cnpj, @email, @tel, @cel, @cep, @endereco, @num,
                                @comple, @bairro, @cidade, @estado
                                );";
                SqlCommand cmd = new SqlCommand(cmdInsert, con);

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@cel", cel);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@num", num);
                cmd.Parameters.AddWithValue("@comple", comple);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@estado", estado);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Cadastro com sucesso");

                ListarDados();
            }
            catch (Exception erro)
            {
                MessageBox.Show("O erro foi: " + erro);
                throw;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constring);

                string id = txtbox_id.Text;
                string nome = txtbox_nome.Text;
                string cnpj = txtbox_cnpj.Text;
                string email = txtbox_email.Text;
                string tel = txtbox_tel.Text;
                string cel = txtbox_cel.Text;
                string cep = txtbox_cep.Text;
                string endereco = txtbox_ende.Text;
                int num = int.Parse(txtbox_num.Text);
                string comple = txtbox_comp.Text;
                string bairro = txtbox_bairro.Text;
                string cidade = txtbox_cid.Text;
                string estado = txtbox_est.Text;

                string cmdInsert = @"update tb_fornecedores
                                set tb_fornecedores_nome = @nome, tb_fornecedores_cnpj = @cnpj, tb_fornecedores_email = @email,
                                tb_fornecedores_telefone = @tel, tb_fornecedores_celular = @cel, tb_fornecedores_cep = @cep, 
                                tb_fornecedores_endereco = @endereco, tb_fornecedores_numero = @num, 
                                tb_fornecedores_complemento = @comple, tb_fornecedores_bairro = @bairro, tb_fornecedores_cidade = @cidade, 
                                tb_fornecedores_estado = @estado
                                where tb_fornecedores_id = @id;";
                SqlCommand cmd = new SqlCommand(cmdInsert, con);

                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@cel", cel);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@num", num);
                cmd.Parameters.AddWithValue("@comple", comple);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@estado", estado);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Cadastro com sucesso");

                ListarDados();
            }
            catch (Exception erro)
            {
                MessageBox.Show("O erro foi: " + erro);
                throw;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constring);

                string id = txtbox_id.Text;

                string cmdDelete = "delete from tb_fornecedores where tb_fornecedores_id = @id";

                SqlCommand cmd = new SqlCommand(cmdDelete, con);

                cmd.Parameters.AddWithValue("id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Deleção com sucesso");

                ListarDados();
            }
            catch (Exception erro)
            {
                MessageBox.Show("O erro foi: " + erro);
                throw;
            }
        }
        void ListarDados()
        {
            SqlConnection con = new SqlConnection(constring);

            string cmdSelect = "select * from tb_fornecedores";

            SqlCommand cmd = new SqlCommand(cmdSelect, con);

            con.Open();
            cmd.ExecuteNonQuery();

            DataTable tabela_fornecedores = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela_fornecedores);

            dgv_dados.DataSource = tabela_fornecedores;

            con.Close();
        }

        private void CadFornecedor_Load(object sender, EventArgs e)
        {
            txtbox_id.Enabled = false;
            ListarDados();
        }

        private void dgv_dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbox_id.Text = dgv_dados.CurrentRow.Cells[0].Value.ToString();
            txtbox_nome.Text = dgv_dados.CurrentRow.Cells[1].Value.ToString();
            txtbox_cnpj.Text = dgv_dados.CurrentRow.Cells[2].Value.ToString();
            txtbox_email.Text = dgv_dados.CurrentRow.Cells[3].Value.ToString();
            txtbox_tel.Text = dgv_dados.CurrentRow.Cells[4].Value.ToString();
            txtbox_cel.Text = dgv_dados.CurrentRow.Cells[5].Value.ToString();
            txtbox_cep.Text = dgv_dados.CurrentRow.Cells[6].Value.ToString();
            txtbox_ende.Text = dgv_dados.CurrentRow.Cells[7].Value.ToString();
            txtbox_num.Text = dgv_dados.CurrentRow.Cells[8].Value.ToString();
            txtbox_comp.Text = dgv_dados.CurrentRow.Cells[9].Value.ToString();
            txtbox_bairro.Text = dgv_dados.CurrentRow.Cells[10].Value.ToString();
            txtbox_cid.Text = dgv_dados.CurrentRow.Cells[11].Value.ToString();
            txtbox_est.Text = dgv_dados.CurrentRow.Cells[12].Value.ToString();
        }
    }
}
