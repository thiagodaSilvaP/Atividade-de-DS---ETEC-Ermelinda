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
    public partial class CadFuncionario : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["CrudDsLojaGitHub.Properties.Settings.Conexao"].ConnectionString;
        public CadFuncionario()
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
                string rg = txtbox_rg.Text;
                string cpf = txtbox_cpf.Text;
                string email = txtbox_email.Text;
                string senha = txtbox_senha.Text;
                string cargo = txtbox_cargo.Text;
                string nivel = txt_nvl.Text;
                string tel = txtbox_tel.Text;
                string cel = txtbox_cel.Text;
                string cep = txtbox_cep.Text;
                string endereco = txtbox_ende.Text;
                int num = int.Parse(txtbox_num.Text);
                string comple = txtbox_comp.Text;
                string bairro = txtbox_bairro.Text;
                string cidade = txtbox_cid.Text;
                string estado = txtbox_est.Text;

                string cmdInsert = @"insert into tb_funcionario
                                (
                                tb_funcionario_nome, tb_funcionario_rg, tb_funcionario_cpf, tb_funcionario_email,
                                tb_funcionario_senha, tb_funcionario_cargo, tb_funcionario_nivel, tb_funcionario_telefone,
                                tb_funcionario_celular, tb_funcionario_cep, tb_funcionario_endereco, tb_funcionario_numero,
                                tb_funcionario_complemento, tb_funcionario_bairro, tb_funcionario_cidade, tb_funcionario_estado
                                )
                                values
                                (
                                @nome, @rg, @cpf, @email, @senha, @cargo, @nivel, @tel, @cel, @cep, @endereco, @num,
                                @comple, @bairro, @cidade, @estado
                                );";
                SqlCommand cmd = new SqlCommand(cmdInsert, con);

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.Parameters.AddWithValue("@nivel", nivel);
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
                string rg = txtbox_rg.Text;
                string cpf = txtbox_cpf.Text;
                string email = txtbox_email.Text;
                string senha = txtbox_senha.Text;
                string cargo = txtbox_cargo.Text;
                string nivel = txt_nvl.Text;
                string tel = txtbox_tel.Text;
                string cel = txtbox_cel.Text;
                string cep = txtbox_cep.Text;
                string endereco = txtbox_ende.Text;
                int num = int.Parse(txtbox_num.Text);
                string comple = txtbox_comp.Text;
                string bairro = txtbox_bairro.Text;
                string cidade = txtbox_cid.Text;
                string estado = txtbox_est.Text;

                string cmdUpdate = @"update tb_funcionario
                                    set tb_funcionario_nome = @nome, tb_funcionario_rg = @rg, tb_funcionario_cpf = @cpf, 
                                    tb_funcionario_email = @email, tb_funcionario_senha = @senha, tb_funcionario_cargo = @cargo, 
                                    tb_funcionario_nivel = @nivel, tb_funcionario_telefone = @tel, tb_funcionario_celular = @cel, 
                                    tb_funcionario_cep = @cep, tb_funcionario_endereco = @endereco, 
                                    tb_funcionario_numero = @num, tb_funcionario_complemento = @comple, 
                                    tb_funcionario_bairro = @bairro, tb_funcionario_cidade = @cidade, tb_funcionario_estado = @estado
                                    where tb_funcionario_id = @id";
                SqlCommand cmd = new SqlCommand(cmdUpdate, con);

                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.Parameters.AddWithValue("@nivel", nivel);
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
                MessageBox.Show("Atualização om suceso");

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

                string cmdDelete = "delete tb_funcionario where tb_funcionario_id = @id";

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
                MessageBox.Show("O erro é: " + erro);
                throw;
            }
        }

        private void dgv_dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbox_id.Text = dgv_dados.CurrentRow.Cells[0].Value.ToString();
            txtbox_nome.Text = dgv_dados.CurrentRow.Cells[1].Value.ToString();
            txtbox_rg.Text = dgv_dados.CurrentRow.Cells[2].Value.ToString();
            txtbox_cpf.Text = dgv_dados.CurrentRow.Cells[3].Value.ToString();
            txtbox_email.Text = dgv_dados.CurrentRow.Cells[4].Value.ToString();
            txtbox_senha.Text = dgv_dados.CurrentRow.Cells[5].Value.ToString();
            txtbox_cargo.Text = dgv_dados.CurrentRow.Cells[6].Value.ToString();
            txt_nvl.Text = dgv_dados.CurrentRow.Cells[7].Value.ToString();
            txtbox_tel.Text = dgv_dados.CurrentRow.Cells[8].Value.ToString();
            txtbox_cel.Text = dgv_dados.CurrentRow.Cells[9].Value.ToString();
            txtbox_cep.Text = dgv_dados.CurrentRow.Cells[10].Value.ToString();
            txtbox_ende.Text = dgv_dados.CurrentRow.Cells[11].Value.ToString();
            txtbox_num.Text = dgv_dados.CurrentRow.Cells[12].Value.ToString();
            txtbox_comp.Text = dgv_dados.CurrentRow.Cells[13].Value.ToString();
            txtbox_bairro.Text = dgv_dados.CurrentRow.Cells[14].Value.ToString();
            txtbox_cid.Text = dgv_dados.CurrentRow.Cells[15].Value.ToString();
            txtbox_est.Text = dgv_dados.CurrentRow.Cells[16].Value.ToString();
        }

        void ListarDados()
        {
            SqlConnection con = new SqlConnection(constring);

            string cmdSelect = "select * from tb_funcionario";

            SqlCommand cmd = new SqlCommand(cmdSelect, con);

            con.Open();
            cmd.ExecuteNonQuery();

            DataTable tabela_funcionario = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela_funcionario);

            dgv_dados.DataSource = tabela_funcionario;

            con.Close();
        }

        private void CadFuncionario_Load(object sender, EventArgs e)
        {
            txtbox_id.Enabled = false;
            ListarDados();
        }
    }
}
