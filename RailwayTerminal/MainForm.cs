using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RailwayTerminal
{
    public partial class MainForm : Form
    {
        private BinaryTree _binaryTree;
        private SaveFileDialog _saveFileDialog;
        private OpenFileDialog _openFileDialog;
        public MainForm()
        {
            InitializeComponent();
            _binaryTree = new BinaryTree();
            _saveFileDialog = new SaveFileDialog();
            _openFileDialog = new OpenFileDialog();
            
            _openFileDialog.Filter = @"Text files(*.txt)|*.txt|All files(*.*)|*.*";
            _saveFileDialog.Filter = @"Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void PrintTrainsToListBox()
        {
            outputListBox.Items.Clear();
            List<string> trains = _binaryTree.GetStringsTree();
            if (trains == null)
            {
                MessageBox.Show(@"Поезда не найдены");
            }
            else
            {
                foreach (var t in trains)
                {
                    outputListBox.Items.Add(t);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(trainNumberTextBox.Text, out var trainNumber))
            {
                MessageBox.Show(@"Неверный номер поезда");
                return;
            }

            string destination = destinationTextBox.Text;

            if (destination == String.Empty)
            {
                MessageBox.Show(@"Введите станцию отправления");
                return;
            }
            
            DateTime departureTime = departureTimePicker.Value;

            Train train = new Train(trainNumber, destination, departureTime);
            _binaryTree.Insert(train);

            trainNumberTextBox.Clear();
            destinationTextBox.Clear();
            departureTimePicker.Value = DateTime.Now;
            
            PrintTrainsToListBox();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintTrainsToListBox();
        }

        private void findTrainButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(trainNumberSearchTextBox.Text, out var trainNumber))
            {
                MessageBox.Show(@"Неверный номер поезда");
                return;
            }
            
            string train = _binaryTree.FindTrain(trainNumber);
            if (train == null)
            {
                MessageBox.Show(@"Поезд не найден");
            }
            else
            {
                outputListBox.Items.Clear();
                outputListBox.Items.Add(train);
            }
        }

        private void findTrainsButton_Click(object sender, EventArgs e)
        {
            string destination = destinationSearchTextBox.Text;
            List<string> trains = _binaryTree.FindTrainsToDestination(destination);
            if (trains == null)
            {
                MessageBox.Show(@"Поезда не найдены");
            }
            else
            {
                outputListBox.Items.Clear();
                foreach (var t in trains)
                {
                    outputListBox.Items.Add(t);
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (_saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = _saveFileDialog.FileName;
            // сохраняем текст в файл
            List<Train> trains = _binaryTree.GetTrainsTree();
            
            if (trains == null)
            {
                MessageBox.Show(@"Поезда не найдены");
                return;
            }

            using (var streamWriter = new StreamWriter(filename))
            {
                foreach (var t in trains)
                {
                    streamWriter.WriteLine($"{t.TrainNumber};{t.DestinationStation};{t.DepartureTime}");
                }
            }
            MessageBox.Show(@"Файл сохранен");
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = _openFileDialog.FileName;
            
            _binaryTree.Clear();
            
            // читаем файл
            using (var streamReader = new StreamReader(filename))
            {
                while (!streamReader.EndOfStream)
                {
                    var trainString = streamReader.ReadLine().Split(';');
                    
                    if (int.TryParse(trainString[0], out int trainNumber) && DateTime.TryParse(trainString[2], out DateTime departureTime))
                    {
                        Train train = new Train(trainNumber, trainString[1], departureTime);
                        _binaryTree.Insert(train);
                    }
                    else
                    {
                        MessageBox.Show(@"Ошибка чтения файла");
                        return;
                    }
                    
                }
            }
            PrintTrainsToListBox();
            MessageBox.Show(@"Данные экспортированны");
        }
    }

}