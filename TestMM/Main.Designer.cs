
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
            this.ResetButton = new System.Windows.Forms.Button();
            this.gridPeriodicCheckBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.maxRnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minRnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InclusionsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caGrainsNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxRnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InclusionsNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.Color.White;
            this.Board.Location = new System.Drawing.Point(154, 91);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(367, 336);
            this.Board.TabIndex = 0;
            this.Board.TabStop = false;
            this.Board.Paint += new System.Windows.Forms.PaintEventHandler(this.Board_Paint);
            // 
            // BoardWidthNumericUpDown
            // 
            this.BoardWidthNumericUpDown.Location = new System.Drawing.Point(59, 15);
            this.BoardWidthNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.BoardWidthNumericUpDown.Name = "BoardWidthNumericUpDown";
            this.BoardWidthNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.BoardWidthNumericUpDown.TabIndex = 1;
            this.BoardWidthNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // BoardHeightNumericUpDown
            // 
            this.BoardHeightNumericUpDown.Location = new System.Drawing.Point(59, 44);
            this.BoardHeightNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.BoardHeightNumericUpDown.Name = "BoardHeightNumericUpDown";
            this.BoardHeightNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.BoardHeightNumericUpDown.TabIndex = 2;
            this.BoardHeightNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // caGrainsNumericUpDown
            // 
            this.caGrainsNumericUpDown.Location = new System.Drawing.Point(6, 17);
            this.caGrainsNumericUpDown.Name = "caGrainsNumericUpDown";
            this.caGrainsNumericUpDown.Size = new System.Drawing.Size(74, 20);
            this.caGrainsNumericUpDown.TabIndex = 3;
            // 
            // caNeighborhoodComboBox
            // 
            this.caNeighborhoodComboBox.Items.AddRange(new object[] {
            "Moore",
            "Von Neumann"});
            this.caNeighborhoodComboBox.Location = new System.Drawing.Point(10, 88);
            this.caNeighborhoodComboBox.Name = "caNeighborhoodComboBox";
            this.caNeighborhoodComboBox.Size = new System.Drawing.Size(121, 21);
            this.caNeighborhoodComboBox.TabIndex = 24;
            // 
            // caAddRandomGrainsButton
            // 
            this.caAddRandomGrainsButton.Location = new System.Drawing.Point(108, 25);
            this.caAddRandomGrainsButton.Name = "caAddRandomGrainsButton";
            this.caAddRandomGrainsButton.Size = new System.Drawing.Size(64, 30);
            this.caAddRandomGrainsButton.TabIndex = 6;
            this.caAddRandomGrainsButton.Text = "Add ";
            this.caAddRandomGrainsButton.UseVisualStyleBackColor = true;
            this.caAddRandomGrainsButton.Click += new System.EventHandler(this.caAddRandomGrainsButton_Click);
            // 
            // caSimulateButton
            // 
            this.caSimulateButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.caSimulateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.caSimulateButton.Location = new System.Drawing.Point(363, 17);
            this.caSimulateButton.Name = "caSimulateButton";
            this.caSimulateButton.Size = new System.Drawing.Size(100, 30);
            this.caSimulateButton.TabIndex = 7;
            this.caSimulateButton.Text = "Start";
            this.caSimulateButton.UseVisualStyleBackColor = false;
            this.caSimulateButton.Click += new System.EventHandler(this.caSimulateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ResetButton.Location = new System.Drawing.Point(363, 51);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(100, 30);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // gridPeriodicCheckBox
            // 
            this.gridPeriodicCheckBox.AutoSize = true;
            this.gridPeriodicCheckBox.Location = new System.Drawing.Point(160, 53);
            this.gridPeriodicCheckBox.Name = "gridPeriodicCheckBox";
            this.gridPeriodicCheckBox.Size = new System.Drawing.Size(84, 17);
            this.gridPeriodicCheckBox.TabIndex = 25;
            this.gridPeriodicCheckBox.Text = "Periodyczne";
            this.gridPeriodicCheckBox.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 26;
            this.button1.Text = "Save as ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.saveBitmap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(8, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 180);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 30);
            this.button4.TabIndex = 29;
            this.button4.Text = "Upload Bitmap";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 30);
            this.button3.TabIndex = 28;
            this.button3.Text = "Upload from csv";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Upload_csv);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 30);
            this.button2.TabIndex = 27;
            this.button2.Text = "Save as csv";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.save_as_csv_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.maxRnumericUpDown);
            this.groupBox2.Controls.Add(this.minRnumericUpDown);
            this.groupBox2.Controls.Add(this.InclusionsNumericUpDown);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(8, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 121);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inclusions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "R Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "R Min";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Rectangle ON";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // maxRnumericUpDown
            // 
            this.maxRnumericUpDown.Location = new System.Drawing.Point(70, 100);
            this.maxRnumericUpDown.Name = "maxRnumericUpDown";
            this.maxRnumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.maxRnumericUpDown.TabIndex = 3;
            this.maxRnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minRnumericUpDown
            // 
            this.minRnumericUpDown.Location = new System.Drawing.Point(12, 100);
            this.minRnumericUpDown.Name = "minRnumericUpDown";
            this.minRnumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.minRnumericUpDown.TabIndex = 2;
            this.minRnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // InclusionsNumericUpDown
            // 
            this.InclusionsNumericUpDown.Location = new System.Drawing.Point(4, 24);
            this.InclusionsNumericUpDown.Name = "InclusionsNumericUpDown";
            this.InclusionsNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.InclusionsNumericUpDown.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(59, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Add Inc";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.addInclusionButton);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.BoardHeightNumericUpDown);
            this.groupBox3.Controls.Add(this.BoardWidthNumericUpDown);
            this.groupBox3.Controls.Add(this.caNeighborhoodComboBox);
            this.groupBox3.Location = new System.Drawing.Point(8, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 115);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Height";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.caGrainsNumericUpDown);
            this.groupBox4.Controls.Add(this.caAddRandomGrainsButton);
            this.groupBox4.Location = new System.Drawing.Point(154, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 70);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Grains";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Method";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridPeriodicCheckBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.caSimulateButton);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "Main";
            this.Text = "KK Form";
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caGrainsNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxRnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InclusionsNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.CheckBox gridPeriodicCheckBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown maxRnumericUpDown;
        private System.Windows.Forms.NumericUpDown minRnumericUpDown;
        private System.Windows.Forms.NumericUpDown InclusionsNumericUpDown;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
    }
}

