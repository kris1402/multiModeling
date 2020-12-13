using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Drawing.Imaging;
using System.Threading;


namespace TestMM
{
    public partial class Main : Form
    {
        private int GridWidth
        {
            get { return (int)this.BoardWidthNumericUpDown.Value; }
        }

        private int GridHeight
        {
            get { return (int)this.BoardHeightNumericUpDown.Value; }
        }

        private bool GridPeriodic
        {
            get { return this.gridPeriodicCheckBox.Checked; }
        }

        private int CAGrains
        {
            get { return (int)this.caGrainsNumericUpDown.Value; }
        }

        //private int Inclusions
        //{
        //    get { return (int)this.InclusionsNumericUpDown.Value; }
        //}

        //private int InclusionsMinR
        //{
        //    get { return (int)this.minRnumericUpDown.Value; }
        //}

        //private int InclusionsMaxR
        //{
        //    get { return (int)this.maxRnumericUpDown.Value; }
        //}

        //private int Propability
        //{
        //    get { return (int)this.GBCnumericUpDown.Value; }
        //}

        private bool DPcheck
        {
            get { return this.DPcheckBox.Checked; }
        }

        private Grid grid;
        private AlgorithmCA ca;
        private List<Brush> brushes;
        private Task t;
        private CancellationTokenSource tokenSource = new CancellationTokenSource();

        //Storing all UI stateButtons
        //private Dictionary<Button, EventsOfButton> stateButtons;
        //private Button activeStateButton = null;

        public Main()
        {
            this.ca = new AlgorithmCA();

            InitializeComponent();
            this.SetupUI();
            this.SetupBrushes();
            this.SetupGrid();
            //this.SetupStateButtons();
            timer1.Interval = 100;
            this.timer1.Start();
            
        }

        private void SetupUI()
        {
            this.caNeighborhoodComboBox.SelectedIndex = 0;
        }

        private void SetupGrid()
        {
            this.grid = new Grid(this.GridWidth, this.GridHeight, this.GridPeriodic);
            this.ca.Grid = this.grid;
            this.SetupBoard();
        }

        private void SetupBoard()
        {
            this.Board.Width = this.GridWidth;
            this.Board.Height = this.GridHeight;
            this.Board.Refresh();
        }

        private void SetupBrushes()
        {
            this.brushes = new List<Brush>();
            this.brushes.Add(Brushes.Black);
            this.brushes.Add(Brushes.Red);
            //this.brushes.Add(Brushes.Gray);
            //this.brushes.Add(Brushes.White);
            foreach (PropertyInfo pf in typeof(Brushes).GetProperties().Where(p => p.Name != "Black" && p.Name != "Red"))// && p.Name != "Gray" && p.Name != "White"))
            {
            
                this.brushes.Add(pf.GetValue(null, null) as Brush);
            }


            this.brushes.Insert(0, Brushes.Black);
        }

        //private void SetupStateButtons()
        //{
        //    this.stateButtons = new Dictionary<Button, EventsOfButton>();

        //    this.stateButtons.Add(this.SelectButton, new EventsOfButton { BoardClick = SelectGrain, On = SelectGrain_Start, Off = SelectGrain_End });
        //}

        private void Board_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Gray);

            for (int y = 0; y < this.grid.Height; ++y)
            {
                for (int x = 0; x < this.grid.Width; ++x)
                {
                    Cell c = this.grid.GetCell(x, y);
                    if (c.ID != 1)
                    {
                        e.Graphics.FillRectangle(this.brushes[c.ID], x, y, 1, 1);
                    }
                }
            }
        }

        private void caAddRandomGrainsButton_Click(object sender, EventArgs e)
        {
            this.ca.AddRandomGrains(this.CAGrains);
            this.Board.Refresh();
        }

        private void caSimulateButton_Click(object sender, EventArgs e)
        {

            var name = caNeighborhoodComboBox.SelectedItem.ToString();
            tokenSource = new CancellationTokenSource();

            t = Task.Run(async () =>
            {
                try
                {
                    await ca.StartAsync(name, Board, tokenSource.Token);
                }
                catch (OperationCanceledException)
                {
                    Debug.WriteLine($"\n{nameof(OperationCanceledException)} thrown\n");
                }
            }, tokenSource.Token);
        }

        private void SelectGrain_Start()
        {
            this.ca.StartSelectGrains(this.DPcheck);
            this.ca.StartSelectGrains(true);
        }

        private void SelectGrain(int x, int y)
        {
            this.ca.SelectGrain(x, y);
            this.Board.Refresh();
        }

        private void SelectGrain_End()
        {
            this.ca.EndSelectGrains();
            this.Board.Refresh();
        }


        //#endregion BoardClickLogic

        private void ResetButton_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            this.SetupGrid();
            this.SetupBoard();
        }




        //private void Board_Click(object sender, EventArgs e)
        //{

        //    MouseEventArgs me = (MouseEventArgs)e;
        //    int x = me.X;
        //    int y = me.Y;

        //    if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].BoardClick != null)
        //    {
        //        this.stateButtons[activeStateButton].BoardClick(x, y);
        //        this.Board.Refresh();
        //    }
        //}

        private void caNeighborhoodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridPeriodicCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Board.Refresh();
        }
    }
}
