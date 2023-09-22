using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperHerosTShits_PS
{
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
        }

        private void vendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.superHeroShirtsDBDataSet);

        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.ItensVenda' table. You can move, or remove it, as needed.
            this.itensVendaTableAdapter.Fill(this.superHeroShirtsDBDataSet.ItensVenda);
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.superHeroShirtsDBDataSet.Produto);
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.superHeroShirtsDBDataSet.Cliente);
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.superHeroShirtsDBDataSet.Funcionarios);
            // TODO: This line of code loads data into the 'superHeroShirtsDBDataSet.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.superHeroShirtsDBDataSet.Venda);

            //Colocando nosso form em modo de edção, ou seja,
            //limpando os campos e deixando para insirir novos
            this.vendaBindingSource.AddNew();
            //Coloca o id no campo ID
            int id = vendaTableAdapter.GetData().Select(v => v.VendaID).Max() + 1;
            txtID.Text = id.ToString();
            //Coloca a data de hoje no campo data
            dtpDataVenda.Value = DateTime.Now;
            //Coloca o o valor total da compra como 0
            txtTotalVenda.Text = "0";
        }

        private void btnCriarVenda_Click(object sender, EventArgs e)
        {
            //Codigo para salvar venda
            this.Validate();
            this.vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.superHeroShirtsDBDataSet);

            MessageBox.Show("Venda criada com sucesso, insira os intens de veda");
            //Coloca o painel que tem todos os itens da venda como visivel
            panelItensVenda.Visible = true;

            ItensVendaModoInserca();
        }

        public void ItensVendaModoInserca()
        {
            itensVendaBindingSource.Filter = "VendaId = " + txtID.Text;
            //Coloca Databindind em mod de inserção
            itensVendaBindingSource.AddNew();
            //Usar o Id de venda de cima
            txtIDItensVenda.Text = txtID.Text;
        }

        private void btnInserirItemVenda_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itensVendaBindingSource.EndEdit();
            this.itensVendaTableAdapter.Update(this.superHeroShirtsDBDataSet);

            MessageBox.Show("Intem adicionado com sucesso");

            ItensVendaModoInserca();

            int vendaId = Convert.ToInt32(txtID.Text);
            decimal totalVenda = 0;

            foreach (var item in itensVendaTableAdapter.GetData().
                Where(iv => iv.VendaId  ==  vendaId ))
            {
                decimal valorProtudo = produtoTableAdapter.GetData().
                    Where(p => p.ProdutoID == item.ProdutoId).First().Valor;

                int quantidade = 0;

                if (item.Quantidade != null)
                {
                    quantidade = item.Quantidade;
                }
                else
                {
                    quantidade = Convert.ToInt32(nudQuantidade.Value);
                }

                totalVenda += quantidade * valorProtudo;
            }
            txtTotalVenda.Text = totalVenda.ToString();

        }
    }
}
