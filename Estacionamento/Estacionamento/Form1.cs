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

        #region Interface Actions

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

            //Pega o texto d
            string placa    = txtBoxPlaca.Text.Trim();
            string modelo   = txtBoxModelo.Text.Trim();
            string cor      = txtBoxCor.Text.Trim();

            //Separa as informações em array
            string[] linhaDados = new string[4];
            linhaDados[0] = placa;
            linhaDados[1] = modelo;
            linhaDados[2] = cor;
            linhaDados[3] = "Not Implemented Yet";

            //Adiciona as informações ao dataGrid
            dataGrid.Rows.Add(linhaDados);
            ClearTextBoxes();
        }

        #endregion

        #region Methods

        void ClearTextBoxes()
        {
            txtBoxPlaca.Clear();
            txtBoxModelo.Clear();
            txtBoxCor.Clear();
        }

        void ClearDataGridSelection() => dataGrid.ClearSelection();


        #endregion

    }
}
