using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            //Garante que tenha algum veículo selecionado na lista
            if (dataGrid.SelectedRows.Count == 0)
                return;

            int rowIndex = dataGrid.CurrentCell.RowIndex;
            dataGrid.Rows.RemoveAt(rowIndex);
        }

        private void btnAddVeicle_Click(object sender, EventArgs e)
        {
            //Codigo fonte que usei para estudar a dataGrid
            //http://www.macoratti.net/08/08/c_pdgv1.htm

            //define um array de strings com nCOlunas

            string[] linhaDados = new string[4];
            linhaDados[0] = "Colum 1";
            linhaDados[1] = "Colum 2";
            linhaDados[2] = "Colum 3";
            linhaDados[3] = "Colum 4";

            //dataGrid.Rows.Add(new DataGridViewRow());
            dataGrid.Rows.Add(linhaDados);
        }
    }
}
