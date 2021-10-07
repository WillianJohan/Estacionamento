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
        FileManager fileManager;
        Parking parking;

        public Form1()
        {
            InitializeComponent();
            InitializeForm1();
        }

        void InitializeForm1()
        {
            //inicializa fileManager
            //Verifica arquivo de cache
            //carrega ou cria txt de cache

            fileManager = new FileManager();
            parking = fileManager.LoadFile();
        }

        #region Interface Actions

        private void btnSaida_Click(object sender, EventArgs e)
        {
            //Garante que tenha algum veículo selecionado na lista
            if (dataGrid.SelectedRows.Count == 0)
                return;

            int rowIndex = dataGrid.CurrentCell.RowIndex;
            //dataGrid.Rows.RemoveAt(rowIndex);

            parking.Vagas.RemoveAt(rowIndex);
            fileManager.Save(parking);
            UpdateDataGrid();
        }

        private void btnAddVeicle_Click(object sender, EventArgs e)
        {
            //Pega o texto d
            string placa = txtBoxPlaca.Text.Trim();
            string modelo = txtBoxModelo.Text.Trim();
            string cor = txtBoxCor.Text.Trim();
            
            Carro newCar = new Carro(placa, modelo, cor);
            DateTime entrada = DateTime.Now;
            ParkingSpace newParkingSpace = new ParkingSpace(newCar, entrada);
            parking.Vagas.Add(newParkingSpace);
            
            fileManager.Save(parking);
            UpdateDataGrid();
            ClearTextBoxes();
        }

        #endregion

        #region Methods

        void UpdateDataGrid()
        {
            dataGrid.Rows.Clear();

            foreach(ParkingSpace space in parking.Vagas)
            {
                string placa = space.carro.Placa;
                string modelo = space.carro.Modelo;
                string cor = space.carro.Cor;
                string entrada = space.Entrada.ToString("hh:mm tt");

                //Separa as informações em array
                string[] linhaDados = new string[4];
                linhaDados[0] = placa;
                linhaDados[1] = modelo;
                linhaDados[2] = cor;
                linhaDados[3] = entrada;

                //Adiciona as informações ao dataGrid
                dataGrid.Rows.Add(linhaDados);
            }
        }

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
