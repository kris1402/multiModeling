
namespace TestMM
{
    partial class Main
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
            this.Board = new System.Windows.Forms.PictureBox();
            this.BoardWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BoardHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.caGrainsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.caNeighborhoodComboBox = new System.Windows.Forms.ComboBox();
            this.caAddRandomGrainsButton = new System.Windows.Forms.Button();
            this.caSimulateButton = new System.Windows.Forms.Button();
            this.NextStep_Button = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.DPcheckBox = new System.Windows.Forms.CheckBox();
            this.gridPeriodicCheckBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caGrainsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.Color.White;
            this.Board.Location = new System.Drawing.Point(160, 82);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(367, 336);
            this.Board.TabIndex = 0;
            this.Board.TabStop = false;
            this.Board.Paint += new System.Windows.Forms.PaintEventHandler(this.Board_Paint);
            // 
            // BoardWidthNumericUpDown
            // 
            this.BoardWidthNumericUpDown.Location = new System.Drawing.Point(38, 15);
            this.BoardWidthNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.BoardWidthNumericUpDown.Name = "BoardWidthNumericUpDown";
            this.BoardWidthNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.BoardWidthNumericUpDown.TabIndex = 1;
            this.BoardWidthNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // BoardHeightNumericUpDown
            // 
            this.BoardHeightNumericUpDown.Location = new System.Drawing.Point(38, 47);
            this.BoardHeightNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.BoardHeightNumericUpDown.Name = "BoardHeightNumericUpDown";
            this.BoardHeightNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.BoardHeightNumericUpDown.TabIndex = 2;
            this.BoardHeightNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // caGrainsNumericUpDown
            // 
            this.caGrainsNumericUpDown.Location = new System.Drawing.Point(160, 9);
            this.caGrainsNumericUpDown.Name = "caGrainsNumericUpDown";
            this.caGrainsNumericUpDown.Size = new System.Drawing.Size(74, 20);
            this.caGrainsNumericUpDown.TabIndex = 3;
            // 
            // caNeighborhoodComboBox
            // 
            this.caNeighborhoodComboBox.Items.AddRange(new object[] {
            "Moore",
            "Von Neumann",
            "Left Pentagonal",
            "Right Pentagonal",
            "Left Hexagonal",
            "Right Hexagonal"});
            this.caNeighborhoodComboBox.Location = new System.Drawing.Point(230, 49);
            this.caNeighborhoodComboBox.Name = "caNeighborhoodComboBox";
            this.caNeighborhoodComboBox.Size = new System.Drawing.Size(121, 21);
            this.caNeighborhoodComboBox.TabIndex = 24;
            this.caNeighborhoodComboBox.SelectedIndexChanged += new System.EventHandler(this.caNeighborhoodComboBox_SelectedIndexChanged);
            // 
            // caAddRandomGrainsButton
            // 
            this.caAddRandomGrainsButton.Location = new System.Drawing.Point(260, 6);
            this.caAddRandomGrainsButton.Name = "caAddRandomGrainsButton";
            this.caAddRandomGrainsButton.Size = new System.Drawing.Size(91, 23);
            this.caAddRandomGrainsButton.TabIndex = 6;
            this.caAddRandomGrainsButton.Text = "Dodaj Ziarno";
            this.caAddRandomGrainsButton.UseVisualStyleBackColor = true;
            this.caAddRandomGrainsButton.Click += new System.EventHandler(this.caAddRandomGrainsButton_Click);
            // 
            // caSimulateButton
            // 
            this.caSimulateButton.Location = new System.Drawing.Point(373, 47);
            this.caSimulateButton.Name = "caSimulateButton";
            this.caSimulateButton.Size = new System.Drawing.Size(75, 23);
            this.caSimulateButton.TabIndex = 7;
            this.caSimulateButton.Text = "Start";
            this.caSimulateButton.UseVisualStyleBackColor = true;
            this.caSimulateButton.Click += new System.EventHandler(this.caSimulateButton_Click);
            // 
            // NextStep_Button
            // 
            this.NextStep_Button.Location = new System.Drawing.Point(471, 47);
            this.NextStep_Button.Name = "NextStep_Button";
            this.NextStep_Button.Size = new System.Drawing.Size(73, 23);
            this.NextStep_Button.TabIndex = 8;
            this.NextStep_Button.Text = "Kolejny Step";
            this.NextStep_Button.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(498, 9);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.SystemColors.Control;
            this.SelectButton.Location = new System.Drawing.Point(38, 188);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(76, 23);
            this.SelectButton.TabIndex = 22;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            // 
            // DPcheckBox
            // 
            this.DPcheckBox.AutoSize = true;
            this.DPcheckBox.Checked = true;
            this.DPcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DPcheckBox.Location = new System.Drawing.Point(38, 146);
            this.DPcheckBox.Name = "DPcheckBox";
            this.DPcheckBox.Size = new System.Drawing.Size(81, 17);
            this.DPcheckBox.TabIndex = 23;
            this.DPcheckBox.Text = "Dual-Phase";
            this.DPcheckBox.UseVisualStyleBackColor = true;
            // 
            // gridPeriodicCheckBox
            // 
            this.gridPeriodicCheckBox.AutoSize = true;
            this.gridPeriodicCheckBox.Location = new System.Drawing.Point(124, 47);
            this.gridPeriodicCheckBox.Name = "gridPeriodicCheckBox";
            this.gridPeriodicCheckBox.Size = new System.Drawing.Size(84, 17);
            this.gridPeriodicCheckBox.TabIndex = 25;
            this.gridPeriodicCheckBox.Text = "Periodyczne";
            this.gridPeriodicCheckBox.UseVisualStyleBackColor = true;
            this.gridPeriodicCheckBox.CheckedChanged += new System.EventHandler(this.gridPeriodicCheckBox_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.gridPeriodicCheckBox);
            this.Controls.Add(this.DPcheckBox);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.NextStep_Button);
            this.Controls.Add(this.caSimulateButton);
            this.Controls.Add(this.caAddRandomGrainsButton);
            this.Controls.Add(this.caNeighborhoodComboBox);
            this.Controls.Add(this.caGrainsNumericUpDown);
            this.Controls.Add(this.BoardHeightNumericUpDown);
            this.Controls.Add(this.BoardWidthNumericUpDown);
            this.Controls.Add(this.Board);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caGrainsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Board;
        private System.Windows.Forms.NumericUpDown BoardWidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown BoardHeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown caGrainsNumericUpDown;
        private System.Windows.Forms.ComboBox caNeighborhoodComboBox;
        private System.Windows.Forms.Button caAddRandomGrainsButton;
        private System.Windows.Forms.Button caSimulateButton;
        private System.Windows.Forms.Button NextStep_Button;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.CheckBox DPcheckBox;
        private System.Windows.Forms.CheckBox gridPeriodicCheckBox;
        private System.Windows.Forms.Timer timer1;
    }
}

