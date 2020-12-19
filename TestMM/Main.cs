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

        private int Inclusions
        {
            get { return (int)this.InclusionsNumericUpDown.Value; }
        }

        private int InclusionsMinR
        {
            get { return (int)this.minRnumericUpDown.Value; }
        }

        private int InclusionsMaxR
        {
            get { return (int)this.maxRnumericUpDown.Value; }
        }

        //private int Propability
        //{
        //    get { return (int)this.GBCnumericUpDown.Value; }
        //}

        /*private bool DPcheck
        {
            get { return this.DPcheckBox.Checked; }
        }*/

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
            //this.ca.StartSelectGrains(this.DPcheck);
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




        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Board.Refresh();
        }

        private static Bitmap DrowControlToBitmap(Control control)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Rectangle rect = control.RectangleToScreen(control.ClientRectangle);
            graphics.CopyFromScreen(rect.Location, Point.Empty, control.Size);
            return bitmap;
        }

        private void saveBitmap_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Board.ClientSize.Width, Board.ClientSize.Height);
            Board.DrawToBitmap(bmp, Board.ClientRectangle);
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "BMP(*.BMP)|*.bmp";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sf.FileName, ImageFormat.Bmp);
                MessageBox.Show("File has been correctly Saved!");
            }
        }


        private void save_as_csv_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "CSV(*.CSV)|*.csv";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                string filepath = sf.FileName;
                System.IO.File.WriteAllBytes(filepath, new byte[0]);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    for (int x = 0; x < this.grid.Height; ++x)
                    {
                        for (int y = 0; y < this.grid.Width; ++y)
                        {
                            Cell c = this.grid.GetCell(x, y);
                            file.WriteLine(x + "," + y + "," + c.ID);
                        }
                    }
                MessageBox.Show("File has been correctly Saved!");
            }
            
            }
        }

        private void Upload_csv(object sender, EventArgs e)
        {
            OpenFileDialog sf = new OpenFileDialog();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                string path = sf.FileName;
                string line;

                if (System.IO.File.Exists(path))
                {
                    System.IO.StreamReader file = null;
                    try
                    {
                        file = new System.IO.StreamReader(path);
                        while ((line = file.ReadLine()) != null)
                        {
                            String[] coordinates = line.Split(',');
                            int tmp_x = System.Convert.ToInt32(coordinates[0]);
                            int tmp_y = System.Convert.ToInt32(coordinates[1]);
                            int tmp_id = System.Convert.ToInt32(coordinates[2]);

                            Cell c = this.grid.GetCell(tmp_x, tmp_y);
                            c.ID = tmp_id;
                            c.NewID = tmp_id;
                        }
                    }
                    finally
                    {
                        if (file != null)
                            file.Close();
                    }
                }
                Console.ReadLine();
                this.Board.Refresh();
            }

            }

        /*private void Load_Bitmap(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Board.ClientSize.Width, Board.ClientSize.Height);
            Board.DrawToBitmap(bmp, Board.ClientRectangle);
            OpenFileDialog sf = new OpenFileDialog();
            //sf.Filter = "BMP(*.BMP)|*.bmp";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                bmp.Open(sf.FileName, ImageFormat.Bmp);
                //MessageBox.Show("Plik zostal pomyslnie zapisany");
            }
        }*/

        private void addInclusionButton(object sender, EventArgs e)
        {


            if (checkBox1.Checked)
            {
                this.ca.AddRandomInclusions(this.Inclusions, this.InclusionsMinR, this.InclusionsMaxR);
            }
            else
                this.ca.AddRandomInclusionsRec(this.Inclusions, this.InclusionsMinR, this.InclusionsMaxR);

            this.Board.Refresh();
        }

    }

}
