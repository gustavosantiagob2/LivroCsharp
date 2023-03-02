namespace LivroCsharp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_ContatoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label companhiaLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label ultimo_contatoLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conectDBDataSet = new LivroCsharp.conectDBDataSet();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasTableAdapter = new LivroCsharp.conectDBDataSetTableAdapters.pessoasTableAdapter();
            this.tableAdapterManager = new LivroCsharp.conectDBDataSetTableAdapters.TableAdapterManager();
            this.pessoasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pessoasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_ContatoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.companhiaTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.clienteCheckBox = new System.Windows.Forms.CheckBox();
            this.ultimo_contatoTextBox = new System.Windows.Forms.TextBox();
            id_ContatoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            companhiaLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            ultimo_contatoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingNavigator)).BeginInit();
            this.pessoasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_ContatoLabel
            // 
            id_ContatoLabel.AutoSize = true;
            id_ContatoLabel.Location = new System.Drawing.Point(55, 57);
            id_ContatoLabel.Name = "id_ContatoLabel";
            id_ContatoLabel.Size = new System.Drawing.Size(70, 16);
            id_ContatoLabel.TabIndex = 2;
            id_ContatoLabel.Text = "id Contato:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(78, 92);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(47, 16);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome:";
            // 
            // companhiaLabel
            // 
            companhiaLabel.AutoSize = true;
            companhiaLabel.Location = new System.Drawing.Point(46, 126);
            companhiaLabel.Name = "companhiaLabel";
            companhiaLabel.Size = new System.Drawing.Size(79, 16);
            companhiaLabel.TabIndex = 6;
            companhiaLabel.Text = "Companhia:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(61, 168);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(64, 16);
            telefoneLabel.TabIndex = 8;
            telefoneLabel.Text = "Telefone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(81, 205);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(577, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // conectDBDataSet
            // 
            this.conectDBDataSet.DataSetName = "conectDBDataSet";
            this.conectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataMember = "pessoas";
            this.pessoasBindingSource.DataSource = this.conectDBDataSet;
            // 
            // pessoasTableAdapter
            // 
            this.pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pessoasTableAdapter = this.pessoasTableAdapter;
            this.tableAdapterManager.UpdateOrder = LivroCsharp.conectDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pessoasBindingNavigator
            // 
            this.pessoasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoasBindingNavigator.BindingSource = this.pessoasBindingSource;
            this.pessoasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pessoasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pessoasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pessoasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pessoasBindingNavigatorSaveItem});
            this.pessoasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pessoasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pessoasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pessoasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pessoasBindingNavigator.Name = "pessoasBindingNavigator";
            this.pessoasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pessoasBindingNavigator.Size = new System.Drawing.Size(1017, 31);
            this.pessoasBindingNavigator.TabIndex = 1;
            this.pessoasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // pessoasBindingNavigatorSaveItem
            // 
            this.pessoasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoasBindingNavigatorSaveItem.Image")));
            this.pessoasBindingNavigatorSaveItem.Name = "pessoasBindingNavigatorSaveItem";
            this.pessoasBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pessoasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pessoasBindingNavigatorSaveItem.Click += new System.EventHandler(this.pessoasBindingNavigatorSaveItem_Click);
            // 
            // id_ContatoTextBox
            // 
            this.id_ContatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "id_Contato", true));
            this.id_ContatoTextBox.Location = new System.Drawing.Point(131, 51);
            this.id_ContatoTextBox.Name = "id_ContatoTextBox";
            this.id_ContatoTextBox.Size = new System.Drawing.Size(267, 22);
            this.id_ContatoTextBox.TabIndex = 3;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(128, 86);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(270, 22);
            this.nomeTextBox.TabIndex = 5;
            // 
            // companhiaTextBox
            // 
            this.companhiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Companhia", true));
            this.companhiaTextBox.Location = new System.Drawing.Point(131, 123);
            this.companhiaTextBox.Name = "companhiaTextBox";
            this.companhiaTextBox.Size = new System.Drawing.Size(267, 22);
            this.companhiaTextBox.TabIndex = 7;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(131, 162);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(267, 22);
            this.telefoneTextBox.TabIndex = 9;
            this.telefoneTextBox.TextChanged += new System.EventHandler(this.telefoneTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(128, 199);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(270, 22);
            this.emailTextBox.TabIndex = 11;
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Location = new System.Drawing.Point(74, 250);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(51, 16);
            clienteLabel.TabIndex = 13;
            clienteLabel.Text = "Cliente:";
            clienteLabel.Click += new System.EventHandler(this.clienteLabel_Click);
            // 
            // clienteCheckBox
            // 
            this.clienteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pessoasBindingSource, "Cliente", true));
            this.clienteCheckBox.Location = new System.Drawing.Point(158, 247);
            this.clienteCheckBox.Name = "clienteCheckBox";
            this.clienteCheckBox.Size = new System.Drawing.Size(240, 24);
            this.clienteCheckBox.TabIndex = 14;
            this.clienteCheckBox.Text = "Empresa de Papel Vila Object";
            this.clienteCheckBox.UseVisualStyleBackColor = true;
            this.clienteCheckBox.CheckedChanged += new System.EventHandler(this.clienteCheckBox_CheckedChanged);
            // 
            // ultimo_contatoLabel
            // 
            ultimo_contatoLabel.AutoSize = true;
            ultimo_contatoLabel.Location = new System.Drawing.Point(30, 283);
            ultimo_contatoLabel.Name = "ultimo_contatoLabel";
            ultimo_contatoLabel.Size = new System.Drawing.Size(95, 16);
            ultimo_contatoLabel.TabIndex = 14;
            ultimo_contatoLabel.Text = "Ultimo contato:";
            // 
            // ultimo_contatoTextBox
            // 
            this.ultimo_contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "Ultimo_contato", true));
            this.ultimo_contatoTextBox.Location = new System.Drawing.Point(131, 283);
            this.ultimo_contatoTextBox.Name = "ultimo_contatoTextBox";
            this.ultimo_contatoTextBox.Size = new System.Drawing.Size(267, 22);
            this.ultimo_contatoTextBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 581);
            this.Controls.Add(ultimo_contatoLabel);
            this.Controls.Add(this.ultimo_contatoTextBox);
            this.Controls.Add(clienteLabel);
            this.Controls.Add(this.clienteCheckBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(companhiaLabel);
            this.Controls.Add(this.companhiaTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(id_ContatoLabel);
            this.Controls.Add(this.id_ContatoTextBox);
            this.Controls.Add(this.pessoasBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingNavigator)).EndInit();
            this.pessoasBindingNavigator.ResumeLayout(false);
            this.pessoasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private conectDBDataSet conectDBDataSet;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private conectDBDataSetTableAdapters.pessoasTableAdapter pessoasTableAdapter;
        private conectDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pessoasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_ContatoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox companhiaTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox clienteCheckBox;
        private System.Windows.Forms.TextBox ultimo_contatoTextBox;
    }
}

