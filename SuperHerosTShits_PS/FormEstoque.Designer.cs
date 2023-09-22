﻿namespace SuperHerosTShits_PS
{
    partial class FormEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoque));
            this.superHeroShirtsDBDataSet = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSet();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTableAdapter = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.EstoqueTableAdapter();
            this.tableAdapterManager = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager();
            this.estoqueBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.estoqueBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.estoqueDataGridView = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbProtudo = new System.Windows.Forms.ComboBox();
            this.nupQuatidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.ProdutoTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.superHeroShirtsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingNavigator)).BeginInit();
            this.estoqueBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuatidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // superHeroShirtsDBDataSet
            // 
            this.superHeroShirtsDBDataSet.DataSetName = "SuperHeroShirtsDBDataSet";
            this.superHeroShirtsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "Estoque";
            this.estoqueBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.EstoqueTableAdapter = this.estoqueTableAdapter;
            this.tableAdapterManager.FuncionariosTableAdapter = null;
            this.tableAdapterManager.ItensVendaTableAdapter = null;
            this.tableAdapterManager.ItnesVendaTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // estoqueBindingNavigator
            // 
            this.estoqueBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.estoqueBindingNavigator.BindingSource = this.estoqueBindingSource;
            this.estoqueBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.estoqueBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.estoqueBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.estoqueBindingNavigatorSaveItem});
            this.estoqueBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estoqueBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.estoqueBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.estoqueBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.estoqueBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.estoqueBindingNavigator.Name = "estoqueBindingNavigator";
            this.estoqueBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.estoqueBindingNavigator.Size = new System.Drawing.Size(524, 25);
            this.estoqueBindingNavigator.TabIndex = 0;
            this.estoqueBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // estoqueBindingNavigatorSaveItem
            // 
            this.estoqueBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estoqueBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estoqueBindingNavigatorSaveItem.Image")));
            this.estoqueBindingNavigatorSaveItem.Name = "estoqueBindingNavigatorSaveItem";
            this.estoqueBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.estoqueBindingNavigatorSaveItem.Text = "Save Data";
            this.estoqueBindingNavigatorSaveItem.Click += new System.EventHandler(this.estoqueBindingNavigatorSaveItem_Click);
            // 
            // estoqueDataGridView
            // 
            this.estoqueDataGridView.AllowUserToAddRows = false;
            this.estoqueDataGridView.AutoGenerateColumns = false;
            this.estoqueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estoqueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.estoqueDataGridView.DataSource = this.estoqueBindingSource;
            this.estoqueDataGridView.Location = new System.Drawing.Point(39, 218);
            this.estoqueDataGridView.Name = "estoqueDataGridView";
            this.estoqueDataGridView.Size = new System.Drawing.Size(360, 220);
            this.estoqueDataGridView.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "Id", true));
            this.txtID.Location = new System.Drawing.Point(273, 80);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(126, 20);
            this.txtID.TabIndex = 2;
            // 
            // cmbProtudo
            // 
            this.cmbProtudo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estoqueBindingSource, "ProdutoID", true));
            this.cmbProtudo.DataSource = this.produtoBindingSource;
            this.cmbProtudo.DisplayMember = "NomeProduto";
            this.cmbProtudo.FormattingEnabled = true;
            this.cmbProtudo.Location = new System.Drawing.Point(39, 79);
            this.cmbProtudo.Name = "cmbProtudo";
            this.cmbProtudo.Size = new System.Drawing.Size(197, 21);
            this.cmbProtudo.TabIndex = 3;
            this.cmbProtudo.ValueMember = "ProdutoID";
            // 
            // nupQuatidade
            // 
            this.nupQuatidade.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.estoqueBindingSource, "Quantidade", true));
            this.nupQuatidade.Location = new System.Drawing.Point(36, 148);
            this.nupQuatidade.Name = "nupQuatidade";
            this.nupQuatidade.Size = new System.Drawing.Size(204, 20);
            this.nupQuatidade.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantidade";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdutoID";
            this.dataGridViewTextBoxColumn2.DataSource = this.produtoBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "NomeProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ProdutoID";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupQuatidade);
            this.Controls.Add(this.cmbProtudo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.estoqueDataGridView);
            this.Controls.Add(this.estoqueBindingNavigator);
            this.Name = "FormEstoque";
            this.Text = "FormEstoque";
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.superHeroShirtsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingNavigator)).EndInit();
            this.estoqueBindingNavigator.ResumeLayout(false);
            this.estoqueBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuatidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperHeroShirtsDBDataSet superHeroShirtsDBDataSet;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.EstoqueTableAdapter estoqueTableAdapter;
        private SuperHeroShirtsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estoqueBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton estoqueBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView estoqueDataGridView;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbProtudo;
        private System.Windows.Forms.NumericUpDown nupQuatidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SuperHeroShirtsDBDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}