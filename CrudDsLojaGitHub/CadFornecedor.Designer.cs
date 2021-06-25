
namespace CrudDsLojaGitHub
{
    partial class CadFornecedor
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
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cad = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_est = new System.Windows.Forms.TextBox();
            this.txtbox_cid = new System.Windows.Forms.TextBox();
            this.txtbox_bairro = new System.Windows.Forms.TextBox();
            this.txtbox_comp = new System.Windows.Forms.TextBox();
            this.txtbox_num = new System.Windows.Forms.TextBox();
            this.txtbox_ende = new System.Windows.Forms.TextBox();
            this.txtbox_cep = new System.Windows.Forms.TextBox();
            this.txtbox_cel = new System.Windows.Forms.TextBox();
            this.txtbox_tel = new System.Windows.Forms.TextBox();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_cnpj = new System.Windows.Forms.TextBox();
            this.txtbox_nome = new System.Windows.Forms.TextBox();
            this.txtbox_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dados
            // 
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Location = new System.Drawing.Point(19, 305);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.RowHeadersWidth = 51;
            this.dgv_dados.RowTemplate.Height = 24;
            this.dgv_dados.Size = new System.Drawing.Size(881, 224);
            this.dgv_dados.TabIndex = 75;
            this.dgv_dados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellClick);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(439, 241);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(180, 48);
            this.btn_del.TabIndex = 74;
            this.btn_del.Text = "button3";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(221, 241);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(212, 48);
            this.btn_update.TabIndex = 73;
            this.btn_update.Text = "button2";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cad
            // 
            this.btn_cad.Location = new System.Drawing.Point(18, 241);
            this.btn_cad.Name = "btn_cad";
            this.btn_cad.Size = new System.Drawing.Size(197, 48);
            this.btn_cad.TabIndex = 72;
            this.btn_cad.Text = "button1";
            this.btn_cad.UseVisualStyleBackColor = true;
            this.btn_cad.Click += new System.EventHandler(this.btn_cad_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(727, 171);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 17);
            this.label17.TabIndex = 71;
            this.label17.Text = "Estado: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(400, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 17);
            this.label16.TabIndex = 70;
            this.label16.Text = "Cidade";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 17);
            this.label15.TabIndex = 69;
            this.label15.Text = "Bairro";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(619, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 68;
            this.label14.Text = "Complemento: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(455, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 17);
            this.label13.TabIndex = 67;
            this.label13.Text = "Número";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 66;
            this.label12.Text = "Endereço: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(524, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 65;
            this.label11.Text = "Cep: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 64;
            this.label10.Text = "Celular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 63;
            this.label9.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 59;
            this.label5.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Cnpj: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Id: ";
            // 
            // txtbox_est
            // 
            this.txtbox_est.Location = new System.Drawing.Point(788, 167);
            this.txtbox_est.Name = "txtbox_est";
            this.txtbox_est.Size = new System.Drawing.Size(112, 22);
            this.txtbox_est.TabIndex = 54;
            // 
            // txtbox_cid
            // 
            this.txtbox_cid.Location = new System.Drawing.Point(458, 168);
            this.txtbox_cid.Name = "txtbox_cid";
            this.txtbox_cid.Size = new System.Drawing.Size(267, 22);
            this.txtbox_cid.TabIndex = 53;
            // 
            // txtbox_bairro
            // 
            this.txtbox_bairro.Location = new System.Drawing.Point(74, 167);
            this.txtbox_bairro.Name = "txtbox_bairro";
            this.txtbox_bairro.Size = new System.Drawing.Size(320, 22);
            this.txtbox_bairro.TabIndex = 52;
            // 
            // txtbox_comp
            // 
            this.txtbox_comp.Location = new System.Drawing.Point(727, 124);
            this.txtbox_comp.Name = "txtbox_comp";
            this.txtbox_comp.Size = new System.Drawing.Size(173, 22);
            this.txtbox_comp.TabIndex = 51;
            // 
            // txtbox_num
            // 
            this.txtbox_num.Location = new System.Drawing.Point(527, 124);
            this.txtbox_num.Name = "txtbox_num";
            this.txtbox_num.Size = new System.Drawing.Size(72, 22);
            this.txtbox_num.TabIndex = 50;
            // 
            // txtbox_ende
            // 
            this.txtbox_ende.Location = new System.Drawing.Point(98, 121);
            this.txtbox_ende.Name = "txtbox_ende";
            this.txtbox_ende.Size = new System.Drawing.Size(348, 22);
            this.txtbox_ende.TabIndex = 49;
            // 
            // txtbox_cep
            // 
            this.txtbox_cep.Location = new System.Drawing.Point(562, 61);
            this.txtbox_cep.Name = "txtbox_cep";
            this.txtbox_cep.Size = new System.Drawing.Size(336, 22);
            this.txtbox_cep.TabIndex = 48;
            // 
            // txtbox_cel
            // 
            this.txtbox_cel.Location = new System.Drawing.Point(321, 61);
            this.txtbox_cel.Name = "txtbox_cel";
            this.txtbox_cel.Size = new System.Drawing.Size(188, 22);
            this.txtbox_cel.TabIndex = 47;
            // 
            // txtbox_tel
            // 
            this.txtbox_tel.Location = new System.Drawing.Point(85, 61);
            this.txtbox_tel.Name = "txtbox_tel";
            this.txtbox_tel.Size = new System.Drawing.Size(172, 22);
            this.txtbox_tel.TabIndex = 46;
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(644, 13);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(255, 22);
            this.txtbox_email.TabIndex = 42;
            // 
            // txtbox_cnpj
            // 
            this.txtbox_cnpj.Location = new System.Drawing.Point(428, 14);
            this.txtbox_cnpj.Name = "txtbox_cnpj";
            this.txtbox_cnpj.Size = new System.Drawing.Size(143, 22);
            this.txtbox_cnpj.TabIndex = 40;
            // 
            // txtbox_nome
            // 
            this.txtbox_nome.Location = new System.Drawing.Point(169, 11);
            this.txtbox_nome.Name = "txtbox_nome";
            this.txtbox_nome.Size = new System.Drawing.Size(193, 22);
            this.txtbox_nome.TabIndex = 39;
            // 
            // txtbox_id
            // 
            this.txtbox_id.Location = new System.Drawing.Point(61, 12);
            this.txtbox_id.Name = "txtbox_id";
            this.txtbox_id.Size = new System.Drawing.Size(48, 22);
            this.txtbox_id.TabIndex = 38;
            // 
            // CadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 557);
            this.Controls.Add(this.dgv_dados);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_cad);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_est);
            this.Controls.Add(this.txtbox_cid);
            this.Controls.Add(this.txtbox_bairro);
            this.Controls.Add(this.txtbox_comp);
            this.Controls.Add(this.txtbox_num);
            this.Controls.Add(this.txtbox_ende);
            this.Controls.Add(this.txtbox_cep);
            this.Controls.Add(this.txtbox_cel);
            this.Controls.Add(this.txtbox_tel);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.txtbox_cnpj);
            this.Controls.Add(this.txtbox_nome);
            this.Controls.Add(this.txtbox_id);
            this.Name = "CadFornecedor";
            this.Text = "CadFornecedor";
            this.Load += new System.EventHandler(this.CadFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_cad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_est;
        private System.Windows.Forms.TextBox txtbox_cid;
        private System.Windows.Forms.TextBox txtbox_bairro;
        private System.Windows.Forms.TextBox txtbox_comp;
        private System.Windows.Forms.TextBox txtbox_num;
        private System.Windows.Forms.TextBox txtbox_ende;
        private System.Windows.Forms.TextBox txtbox_cep;
        private System.Windows.Forms.TextBox txtbox_cel;
        private System.Windows.Forms.TextBox txtbox_tel;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_cnpj;
        private System.Windows.Forms.TextBox txtbox_nome;
        private System.Windows.Forms.TextBox txtbox_id;
    }
}