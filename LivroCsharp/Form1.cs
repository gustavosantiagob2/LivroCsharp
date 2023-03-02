using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivroCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("contact list 1.0.\nWritten by: Gustavo", "About");
        }

        private void pessoasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.conectDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'conectDBDataSet.pessoas'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoasTableAdapter.Fill(this.conectDBDataSet.pessoas);

        }

        private void pessoasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void telefoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clienteCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clienteLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
