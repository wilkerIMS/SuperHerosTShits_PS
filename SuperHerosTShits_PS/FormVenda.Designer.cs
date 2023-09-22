namespace SuperHerosTShits_PS
{
    partial class FormVenda
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
            this.components = new System.ComponentModel.Container();
            this.superHeroShirtsDBDataSet = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSet();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.VendaTableAdapter();
            this.tableAdapterManager = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.ClienteTableAdapter();
            this.funcionariosTableAdapter = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.FuncionariosTableAdapter();
            this.itensVendaTableAdapter = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.ItensVendaTableAdapter();
            this.produtoTableAdapter = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.ProdutoTableAdapter();
            this.panelItensVenda = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produtoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInserirItemVenda = new System.Windows.Forms.Button();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCriarVenda = new System.Windows.Forms.Button();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.vendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDItensVenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.superHeroShirtsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.panelItensVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // superHeroShirtsDBDataSet
            // 
            this.superHeroShirtsDBDataSet.DataSetName = "SuperHeroShirtsDBDataSet";
            this.superHeroShirtsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.EstoqueTableAdapter = null;
            this.tableAdapterManager.FuncionariosTableAdapter = this.funcionariosTableAdapter;
            this.tableAdapterManager.ItensVendaTableAdapter = this.itensVendaTableAdapter;
            this.tableAdapterManager.ItnesVendaTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaTableAdapter = this.vendaTableAdapter;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // itensVendaTableAdapter
            // 
            this.itensVendaTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // panelItensVenda
            // 
            this.panelItensVenda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelItensVenda.Controls.Add(this.btnInserirItemVenda);
            this.panelItensVenda.Controls.Add(this.txtIDItensVenda);
            this.panelItensVenda.Controls.Add(this.dataGridView1);
            this.panelItensVenda.Controls.Add(this.label6);
            this.panelItensVenda.Controls.Add(this.label5);
            this.panelItensVenda.Controls.Add(this.label4);
            this.panelItensVenda.Controls.Add(this.nudQuantidade);
            this.panelItensVenda.Controls.Add(this.cmbProduto);
            this.panelItensVenda.Location = new System.Drawing.Point(41, 282);
            this.panelItensVenda.Name = "panelItensVenda";
            this.panelItensVenda.Size = new System.Drawing.Size(519, 313);
            this.panelItensVenda.TabIndex = 2;
            this.panelItensVenda.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produtoIdDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itensVendaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // produtoIdDataGridViewTextBoxColumn
            // 
            this.produtoIdDataGridViewTextBoxColumn.DataPropertyName = "ProdutoId";
            this.produtoIdDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produtoIdDataGridViewTextBoxColumn.Name = "produtoIdDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "ProdutoId";
            this.quantidadeDataGridViewTextBoxColumn.DataSource = this.produtoBindingSource;
            this.quantidadeDataGridViewTextBoxColumn.DisplayMember = "NomeProduto";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.quantidadeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.quantidadeDataGridViewTextBoxColumn.ValueMember = "ProdutoID";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataMember = "ItensVenda";
            this.itensVendaBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(179, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Itens da venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Produto";
            // 
            // btnInserirItemVenda
            // 
            this.btnInserirItemVenda.Location = new System.Drawing.Point(359, 84);
            this.btnInserirItemVenda.Name = "btnInserirItemVenda";
            this.btnInserirItemVenda.Size = new System.Drawing.Size(100, 35);
            this.btnInserirItemVenda.TabIndex = 4;
            this.btnInserirItemVenda.Text = "Inserir";
            this.btnInserirItemVenda.UseVisualStyleBackColor = true;
            this.btnInserirItemVenda.Click += new System.EventHandler(this.btnInserirItemVenda_Click);
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.itensVendaBindingSource, "Quantidade", true));
            this.nudQuantidade.Location = new System.Drawing.Point(359, 51);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 20);
            this.nudQuantidade.TabIndex = 3;
            // 
            // cmbProduto
            // 
            this.cmbProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVendaBindingSource, "ProdutoId", true));
            this.cmbProduto.DataSource = this.produtoBindingSource;
            this.cmbProduto.DisplayMember = "NomeProduto";
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(18, 50);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(324, 21);
            this.cmbProduto.TabIndex = 2;
            this.cmbProduto.ValueMember = "ProdutoID";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "ClienteID", true));
            this.cmbCliente.DataSource = this.clienteBindingSource;
            this.cmbCliente.DisplayMember = "Nome";
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(38, 203);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(200, 21);
            this.cmbCliente.TabIndex = 3;
            this.cmbCliente.ValueMember = "ClienteID";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "FuncionarioID", true));
            this.cmbVendedor.DataSource = this.funcionariosBindingSource;
            this.cmbVendedor.DisplayMember = "Nome";
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(38, 134);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(200, 21);
            this.cmbVendedor.TabIndex = 4;
            this.cmbVendedor.ValueMember = "FuncionarioID";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "VendaID", true));
            this.txtID.Location = new System.Drawing.Point(460, 78);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 5;
            // 
            // btnCriarVenda
            // 
            this.btnCriarVenda.Location = new System.Drawing.Point(471, 226);
            this.btnCriarVenda.Name = "btnCriarVenda";
            this.btnCriarVenda.Size = new System.Drawing.Size(89, 37);
            this.btnCriarVenda.TabIndex = 6;
            this.btnCriarVenda.Text = "Criar Venda";
            this.btnCriarVenda.UseVisualStyleBackColor = true;
            this.btnCriarVenda.Click += new System.EventHandler(this.btnCriarVenda_Click);
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendaBindingSource1, "DataVenda", true));
            this.dtpDataVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "DataVenda", true));
            this.dtpDataVenda.Location = new System.Drawing.Point(38, 75);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(200, 20);
            this.dtpDataVenda.TabIndex = 7;
            // 
            // vendaBindingSource1
            // 
            this.vendaBindingSource1.DataMember = "Venda";
            this.vendaBindingSource1.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data da Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(290, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Venda";
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "TotalVenda", true));
            this.txtTotalVenda.Location = new System.Drawing.Point(460, 200);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(100, 20);
            this.txtTotalVenda.TabIndex = 12;
            this.txtTotalVenda.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Valor total da venda";
            // 
            // txtIDItensVenda
            // 
            this.txtIDItensVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "VendaId", true));
            this.txtIDItensVenda.Location = new System.Drawing.Point(359, 92);
            this.txtIDItensVenda.Name = "txtIDItensVenda";
            this.txtIDItensVenda.Size = new System.Drawing.Size(100, 20);
            this.txtIDItensVenda.TabIndex = 9;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 592);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalVenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(this.btnCriarVenda);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.panelItensVenda);
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.superHeroShirtsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.panelItensVenda.ResumeLayout(false);
            this.panelItensVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperHeroShirtsDBDataSet superHeroShirtsDBDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.VendaTableAdapter vendaTableAdapter;
        private SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panelItensVenda;
        private System.Windows.Forms.Button btnInserirItemVenda;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnCriarVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SuperHeroShirtsDBDataSetTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.BindingSource vendaBindingSource1;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.ItensVendaTableAdapter itensVendaTableAdapter;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtIDItensVenda;
    }
}