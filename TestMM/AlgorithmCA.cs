using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMM
{
    public class AlgorithmCA
    {
        private const int MAX_GRAIN_ID = 150;
        public int Width { set; get; }
        public int Height { set; get; }
        protected Grid grid;
        protected int? idForSelectedGrain;
        private delegate bool ChooseFunction(Cell cell);

        private ChooseFunction selectedNeighborhood;

        public Grid Grid
        {
            get
            {
                return this.grid;
            }

            set
            {
                this.grid = value;
                this.Width = this.grid.Width;
                this.Height = this.grid.Height;
            }
        }

        public int[] GetNotUsedIds()
        {
            bool[] usesArr = Enumerable.Repeat(false, MAX_GRAIN_ID).ToArray();
            usesArr[0] = true; // empty
            usesArr[1] = true; // inclusion
            usesArr[2] = true; // Phase 1 for dualphase

            this.grid.ResetCurrentCellPosition();

            //Iterate cells line by line

            do
            {
                usesArr[this.grid.CurrentCell.ID] = true;
            } while (this.grid.Next());

            List<int> ret = new List<int>();

            for (int i = 0; i < usesArr.Length; ++i)
            {
                if (usesArr[i] == false)
                    ret.Add(i);
            }

            return ret.ToArray();

        }

        public void AddRandomGrains(int number)
        {
            int[] notUsedIds = this.GetNotUsedIds();

            for (int i = 0; i < number; ++i)
            {
                if (i < notUsedIds.Length)
                {
                    Cell c;

                    // Look for empty cell
                    do
                    {
                        c = this.grid.GetCell(RandomHelper.Next(this.Width), RandomHelper.Next(this.Height));
                    } while (c.ID != 0 || c.Selected);
                    c.ID = notUsedIds[i];
                    
                }

                else
                {
                    // No more id
                    break;
                }
            }

        }


        /*Adding random inclusion on the bouneries*/
        int lenx;
        int leny;
        public void AddRandomInclusionsTest(int number, int min_r, int max_r)
        {
            int length = 0;
            Random rnd = new Random();
            /*------------------------------*/
            List<int> setX = new List<int>();
            List<int> setY = new List<int>();
            /*------------------------------*/

            for (int y = 0; y < this.grid.Width - 1; ++y)
            {
                for (int x = 1; x < this.grid.Height; ++x)
                {
                    Cell c = this.grid.GetCell(x - 1, y);
                    Cell c2 = this.grid.GetCell(x, y);
                    Cell c3 = this.grid.GetCell(x, y + 1);

                    if (c.ID > 1 && (c.ID != c2.ID || c.ID != c3.ID))
                    {
                        int temp_x = x;
                        Console.WriteLine("X = " + temp_x);

                        setX.Add(temp_x);
                        lenx = setX.Count;

                        foreach (int nam in setX)
                        {
                            Console.WriteLine("Tabela" + nam);
                        }
                        Console.WriteLine("Dlugosc = " + lenx);
                        Console.WriteLine(setX);
                        Console.WriteLine("Przerywnik 1");

                        //c.ID = 1;
                        //c.NewID = 1;



                    }
                    int temp_y = y;
                    Console.WriteLine(setY);
                    Console.WriteLine("Przerywnik 2");
                    Console.WriteLine("Y = " + temp_y);
                    setY.Add(temp_y);
                    leny = setY.Count;
                    Console.WriteLine(setY);
                    Console.WriteLine("Przerywnik 2");


                }

            }
            while (number > 0)
            {
                int index_x = rnd.Next(setX.Count);// pick a random index
                Console.WriteLine("indeks" + index_x);
                int xvx = setX[index_x]; // a random value taken from that list
                int index_y = rnd.Next(setY.Count);// pick a random index
                int xvy = setY[index_y]; // a random value taken from that list

                //int xvx = rnd.Next(1, 100);
                //int xvy = rnd.Next(1, 100);
                Console.WriteLine(xvx);
                Console.WriteLine(xvy);
                Console.WriteLine("Przerywnik 3");

                int r = rnd.Next(min_r, max_r);
                AddCircleInclusion(xvx, xvy, r);
                number--;
            }
        }

            public void AddRandomInclusionsRec(int number, int min_r, int max_r)
        {
            Random rnd = new Random();
            for (int i = 0; i < number; i++)
            {
                Cell c;
                int temp_x = RandomHelper.Next(this.Width);
                int temp_y = RandomHelper.Next(this.Height);

                c = this.grid.GetCell(temp_x, temp_y);
                c.ID = 1;
                c.NewID = 1;

                int r = rnd.Next(min_r, max_r);
                /*Add ig while yhe check box is assigned*/
                AddCircleInclusion(temp_x, temp_y, r);
                //AddRectangleInclusion(temp_x, temp_y, r);
            }
        }
                /*Adding random inclusion*/
        public void AddRandomInclusions(int number, int min_r, int max_r)
        {
            Random rnd = new Random();
            for (int i = 0; i < number; i++)
            {
                Cell c;
                int temp_x = RandomHelper.Next(this.Width);
                int temp_y = RandomHelper.Next(this.Height);

                c = this.grid.GetCell(temp_x, temp_y);
                c.ID = 1;
                c.NewID = 1;

                int r = rnd.Next(min_r, max_r);
                /*Add ig while yhe check box is assigned*/
                //AddCircleInclusion(temp_x, temp_y, r);
                AddRectangleInclusion(temp_x, temp_y, r);
                /*--------------------------------------*/
                /*Bitmap bitmap = new Bitmap(Width, Height);
                Graphics rec = Graphics.FromImage(bitmap);
                rec.FillRectangle(Brushes.Red,10,20,1,1);*/
            }
        }
        /*Adding random inclusion rectangle*/



        private bool isInCircle(int r, int y, int x)
        {
            return ((x * x) + (y * y)) <= r * r;
        }
        /*--------------------------------------*/
        private bool isInRectangle(int a , int y, int x)
        {
            return (Math.Abs(x) <= (a / 2) & Math.Abs(y) <= (a / 2));
        }
        /*--------------------------------------*/
        public void AddCircleInclusion(int x, int y, int r)
        {
            for (int i = y - r; i <= y + r; i++)
            {
                for (int j = x - r; j <= x + r; j++)
                {

                    if (isInCircle(r, Math.Abs(y - i), Math.Abs(x - j)) && i >= 0 && j >= 0 && this.Width > j && this.Height > i)
                    {
                        this.AddInclusion(i, j);
                    }

                }
            }
        }
        /*--------------------------------------*/

        public void AddRectangleInclusion(int x, int y, int r)
        {
            for (int i = y - (r/2); i <= y + (r / 2); i++)
            {
                for (int j = x - (r / 2); j <= x + (r / 2); j++)
                {

                    if (isInRectangle((r / 2), Math.Abs(y - i), Math.Abs(x - j)) && i >= 0 && j >= 0 && this.Width > j && this.Height > i)
                    {
                        this.AddInclusion(i, j);
                    }

                }
            }
        }

 
        protected void AddInclusion(int x, int y)
        {
            Cell c = grid.GetCell(x, y);
            c.ID = 1;
            c.NewID = 1;
        }
        /*-------------------------------------Inclusion-------------------------*/
        public async Task StartAsync(string name, PictureBox board, CancellationToken ct)
        {
            if (name.Equals("Moore"))
                selectedNeighborhood = Moore;
            else if (name.Equals("Von Neumann"))
                selectedNeighborhood = VanNeuman;
            while (await StepAsync())
            {
                board.Invoke(new Action(delegate ()
                {
                    board.Refresh();
                }));
                if (ct.IsCancellationRequested)
                {
                    ct.ThrowIfCancellationRequested();
                }
            }
        }

        public async Task NextStepAns(string name, PictureBox board, CancellationToken ct)
        {
            if (name.Equals("Moore"))
                selectedNeighborhood = Moore;
            else if (name.Equals("Von Neumann"))
                selectedNeighborhood = VanNeuman;
            await StepAsync();
            board.Invoke(new Action(delegate ()
            {
                board.Refresh();
            }));

            if (ct.IsCancellationRequested)
            {
                ct.ThrowIfCancellationRequested();
            }
        }

        public async Task<bool> StepAsync()
        {

            for (int x = 0; x < this.grid.Width; x++)
            {
                for (int y = 0; y < this.grid.Width; y++)
                {
                    Cell c = this.grid.GetCell(x - 1, y);
                    if (c.ID == 2)
                    {
                        c.Selected = true;
                    }
                }
            }


            int changes = 0;
            grid.ResetCurrentCellPosition();
            //Iterate cells line by line
            do
            {

                //Grains growth only on empty cell
                if (grid.CurrentCell.ID == 0)
                {
                    if (selectedNeighborhood(grid.CurrentCell))
                    {
                        ++changes;
                    }
                }
            } while (grid.Next());

            if (changes > 0)
            {
                //Copying values
                this.grid.CopyNewIDtoID();
                return true;
            }
            return false;
        }
        /*--------------------------------------------------------------------------------------------*/

        /********************STEP_OF_GBC*******************************/
        public bool STEP_OF_GBC(int probability)
        {
            Random rnd = new Random();
            int changeRule = 0;
            this.grid.ResetCurrentCellPosition();
            //iteration of the specific Cell position
            do
            {
                //Checking if the cell is empty 
                if (this.grid.CurrentCell.ID == 0)
                {
                    //Rule number 1
                    int id = -1;
                    int max = -1;
                    var q = grid.CurrentCell.MoorNeighborhood.Where(n => !n.Selected).GroupBy(n => n.ID).Select(n => new { id = n.Key, Value = n.Count() }).ToList();
                    for (int i = 0; i < q.Count; i++)
                    {
                        if (q[i].id == 0 || q[i].id == 1 || q[i].id == 2)
                            continue;
                        if (q[i].Value > max)
                        {
                            id = q[i].id;
                            Console.WriteLine("Idik= " + id);
                            
                            max = q[i].Value;
                            Console.WriteLine("Max VAlue= " + max);
                        }

                    }
                    if (max >= 5 && id > 1)
                    {
                        ++changeRule;
                        grid.CurrentCell.NewID = id;
                        Console.WriteLine("--------------NEW ID_____________" + id);
                        continue;
                    }
                    //Rule number 2
                    id = -1;
                    max = -1;
                    q = grid.CurrentCell.VonNeumannNeighborhood.Where(n => !n.Selected).GroupBy(n => n.ID).Select(n => new { id = n.Key, Value = n.Count() }).ToList();
                    for(int i = 0; i < q.Count; i++)
                    {
                        if (q[i].id == 0 || q[i].id == 1 || q[i].id == 2)
                            continue;
                        if (q[i].Value > max)
                        {
                            id = q[i].id;
                            Console.WriteLine("Idik= " + id);

                            max = q[i].Value;
                            Console.WriteLine("Max VAlue= " + max);
                        }
                    }
                    if(max >= 3 && id > 1)
                    {
                        ++changeRule;
                        grid.CurrentCell.NewID = id;
                        continue;
                    }

                    //Rule number 3
                    id = -1;
                    max = -1;

                    q = grid.CurrentCell.FurtherMooreNeighborhood.Where(n => !n.Selected).GroupBy(n => n.ID).Select(n => new { id = n.Key, Value = n.Count() }).ToList();
                    for (int i = 0; i < q.Count; i++)
                    {
                        if (q[i].id == 0 || q[i].id == 1 || q[i].id == 2)
                            continue;
                        if (q[i].Value > max)
                        {
                            id = q[i].id;
                            Console.WriteLine("Idik= " + id);

                            max = q[i].Value;
                            Console.WriteLine("Max VAlue= " + max);
                        }
                    }
                    if (max >= 3 && id > 1)
                    {
                        ++changeRule;
                        grid.CurrentCell.NewID = id;
                        continue;
                    }




                    //Rule number 4 

                    id = -1;
                    max = -1;
                    q = grid.CurrentCell.MoorNeighborhood.Where(n => !n.Selected).GroupBy(n => n.ID).Select(n => new { id = n.Key, Value = n.Count() }).ToList();
                    for (int i = 0; i < q.Count; i++)
                    {
                        if (q[i].id == 0 || q[i].id == 1 || q[i].id == 2)
                            continue;
                        if (q[i].Value > max)
                        {
                            id = q[i].id;
                            max = q[i].Value;
                        }
                    }
                    int number = rnd.Next(0, 100);
                    if (id > 1 && number < probability)
                    {
                        ++changeRule;
                        grid.CurrentCell.NewID = id;
                        continue;
                    }


                }
            } while (this.grid.Next());

            if (changeRule > 0)
            {
                //Copying values
                this.grid.CopyNewIDtoID();
                return true;
            }
            return false;
        }
        /********************STEP_OF_GBC******************************/

        /********************SelectGrainFunctionality******************************/

        public void SelectGrainsStart(bool changeId)
        {
            if (changeId)
            {
                this.idForSelectedGrain = 2;
            }
            else
            {
                this.idForSelectedGrain = null;
            }

            this.grid.ResetCurrentCellPosition();

            // Reset selected state
            do
            {
                this.grid.CurrentCell.Selected = false;
            } while (this.grid.Next());
        }

        public void SelectGrain(int x, int y)
        {
            int selectedId = this.grid.GetCell(x, y).ID;
            this.grid.ResetCurrentCellPosition();

            do
            {
                if (this.grid.CurrentCell.ID == selectedId)
                {
                    this.grid.CurrentCell.Selected = true;

                    if (this.idForSelectedGrain.HasValue)
                    {
                        this.grid.CurrentCell.ID = this.idForSelectedGrain.Value;
                        this.grid.CurrentCell.NewID = this.idForSelectedGrain.Value;
                    }
                }
            } while (this.grid.Next());
        }


        public void SelectGrainsEnd()
        {
            this.grid.ResetCurrentCellPosition();

            do
            {
                if (!this.grid.CurrentCell.Selected && this.grid.CurrentCell.ID > 1) // 0 - empty cell, 1 - inclusion
                {
                    this.grid.CurrentCell.ID = 0;
                    this.grid.CurrentCell.NewID = 0;
                }
            } while (this.grid.Next());
        }


        /********************SelectGrainFunctionality******************************/


        //For Moore
        protected bool Moore(Cell c)
        {
            CounterReturn cr = this.MooreMostCommonCell(c);

            if (cr != null)
            {
                this.grid.CurrentCell.NewID = cr.ID;
                return true;
            }
            return false;
        }

        protected bool VanNeuman(Cell c)
        {
            CounterReturn cr = this.VanNeumanMostCommonCell(c);

            if (cr != null)
            {
                this.grid.CurrentCell.NewID = cr.ID;
                return true;
            }

            return false;
        }

        protected CounterReturn MooreMostCommonCell(Cell c)
        {
            Counter counter = new Counter();
            counter.AddCells(c.MoorNeighborhood);
            return counter.MostCommonID;
        }


        protected CounterReturn VanNeumanMostCommonCell(Cell c)
        {
            Counter counter = new Counter();
            counter.AddCells(c.VonNeumannNeighborhood);
            return counter.MostCommonID;
        }

    }

}




