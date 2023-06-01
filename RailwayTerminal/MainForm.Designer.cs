using System.ComponentModel;
using System.Windows.Forms;

namespace RailwayTerminal
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.trainNumberTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.trainNumberSearchTextBox = new System.Windows.Forms.TextBox();
            this.destinationSearchTextBox = new System.Windows.Forms.TextBox();
            this.trainNumberLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.departureTimeLabel = new System.Windows.Forms.Label();
            this.trainNumberSearchLabel = new System.Windows.Forms.Label();
            this.destinationSearchLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.findTrainButton = new System.Windows.Forms.Button();
            this.findTrainsButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.departureTimePicker = new System.Windows.Forms.DateTimePicker();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trainNumberTextBox
            // 
            this.trainNumberTextBox.Location = new System.Drawing.Point(19, 36);
            this.trainNumberTextBox.Name = "trainNumberTextBox";
            this.trainNumberTextBox.Size = new System.Drawing.Size(82, 20);
            this.trainNumberTextBox.TabIndex = 0;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(107, 36);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(150, 20);
            this.destinationTextBox.TabIndex = 1;
            // 
            // trainNumberSearchTextBox
            // 
            this.trainNumberSearchTextBox.Location = new System.Drawing.Point(55, 182);
            this.trainNumberSearchTextBox.Name = "trainNumberSearchTextBox";
            this.trainNumberSearchTextBox.Size = new System.Drawing.Size(82, 20);
            this.trainNumberSearchTextBox.TabIndex = 4;
            // 
            // destinationSearchTextBox
            // 
            this.destinationSearchTextBox.Location = new System.Drawing.Point(223, 182);
            this.destinationSearchTextBox.Name = "destinationSearchTextBox";
            this.destinationSearchTextBox.Size = new System.Drawing.Size(140, 20);
            this.destinationSearchTextBox.TabIndex = 5;
            // 
            // trainNumberLabel
            // 
            this.trainNumberLabel.Location = new System.Drawing.Point(19, 19);
            this.trainNumberLabel.Name = "trainNumberLabel";
            this.trainNumberLabel.Size = new System.Drawing.Size(82, 17);
            this.trainNumberLabel.TabIndex = 6;
            this.trainNumberLabel.Text = "Номер поезда";
            // 
            // destinationLabel
            // 
            this.destinationLabel.Location = new System.Drawing.Point(128, 19);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(114, 17);
            this.destinationLabel.TabIndex = 7;
            this.destinationLabel.Text = "Станция назначения";
            // 
            // departureTimeLabel
            // 
            this.departureTimeLabel.Location = new System.Drawing.Point(263, 19);
            this.departureTimeLabel.Name = "departureTimeLabel";
            this.departureTimeLabel.Size = new System.Drawing.Size(114, 14);
            this.departureTimeLabel.TabIndex = 8;
            this.departureTimeLabel.Text = "Время отправления";
            // 
            // trainNumberSearchLabel
            // 
            this.trainNumberSearchLabel.Location = new System.Drawing.Point(30, 162);
            this.trainNumberSearchLabel.Name = "trainNumberSearchLabel";
            this.trainNumberSearchLabel.Size = new System.Drawing.Size(135, 17);
            this.trainNumberSearchLabel.TabIndex = 9;
            this.trainNumberSearchLabel.Text = "Поиск по номеру поезда";
            // 
            // destinationSearchLabel
            // 
            this.destinationSearchLabel.Location = new System.Drawing.Point(211, 162);
            this.destinationSearchLabel.Name = "destinationSearchLabel";
            this.destinationSearchLabel.Size = new System.Drawing.Size(166, 17);
            this.destinationSearchLabel.TabIndex = 10;
            this.destinationSearchLabel.Text = "Поиск по станции назначения";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(19, 62);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(154, 40);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Добавить / Обновить значение";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(258, 288);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(119, 70);
            this.printButton.TabIndex = 12;
            this.printButton.Text = "Вывести все поезда";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // findTrainButton
            // 
            this.findTrainButton.Location = new System.Drawing.Point(40, 208);
            this.findTrainButton.Name = "findTrainButton";
            this.findTrainButton.Size = new System.Drawing.Size(112, 35);
            this.findTrainButton.TabIndex = 13;
            this.findTrainButton.Text = "Найти поезд по номеру";
            this.findTrainButton.UseVisualStyleBackColor = true;
            this.findTrainButton.Click += new System.EventHandler(this.findTrainButton_Click);
            // 
            // findTrainsButton
            // 
            this.findTrainsButton.Location = new System.Drawing.Point(211, 208);
            this.findTrainsButton.Name = "findTrainsButton";
            this.findTrainsButton.Size = new System.Drawing.Size(166, 35);
            this.findTrainsButton.TabIndex = 14;
            this.findTrainsButton.Text = "Найти поезда по станции назначения";
            this.findTrainsButton.UseVisualStyleBackColor = true;
            this.findTrainsButton.Click += new System.EventHandler(this.findTrainsButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(383, 16);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(585, 342);
            this.outputListBox.TabIndex = 15;
            // 
            // departureTimePicker
            // 
            this.departureTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.departureTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.departureTimePicker.Location = new System.Drawing.Point(263, 36);
            this.departureTimePicker.Name = "departureTimePicker";
            this.departureTimePicker.Size = new System.Drawing.Size(114, 20);
            this.departureTimePicker.TabIndex = 16;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(103, 288);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(139, 31);
            this.importButton.TabIndex = 17;
            this.importButton.Text = "Импорт данных";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(103, 327);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(139, 31);
            this.exportButton.TabIndex = 18;
            this.exportButton.Text = "Экспорт данных";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 372);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.departureTimePicker);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.findTrainsButton);
            this.Controls.Add(this.findTrainButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.destinationSearchLabel);
            this.Controls.Add(this.trainNumberSearchLabel);
            this.Controls.Add(this.departureTimeLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.trainNumberLabel);
            this.Controls.Add(this.destinationSearchTextBox);
            this.Controls.Add(this.trainNumberSearchTextBox);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.trainNumberTextBox);
            this.Name = "MainForm";
            this.Text = "RailwayTerminal";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportButton;

        private System.Windows.Forms.DateTimePicker departureTimePicker;

        private System.Windows.Forms.ListBox outputListBox;

        private System.Windows.Forms.Button findTrainsButton;

        private System.Windows.Forms.Button findTrainButton;

        private System.Windows.Forms.Button printButton;

        private System.Windows.Forms.Button addButton;

        private System.Windows.Forms.Label departureTimeLabel;
        private System.Windows.Forms.Label trainNumberSearchLabel;
        private System.Windows.Forms.Label destinationSearchLabel;

        private System.Windows.Forms.Label destinationLabel;

        private System.Windows.Forms.Label trainNumberLabel;

        private System.Windows.Forms.TextBox trainNumberSearchTextBox;
        private System.Windows.Forms.TextBox destinationSearchTextBox;

        private System.Windows.Forms.TextBox trainNumberTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;

        #endregion
    }
}