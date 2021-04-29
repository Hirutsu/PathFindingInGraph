using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;


namespace PathFinding
{
    public partial class Form1 : Form
    {
        delegate void SetCallback(Cell cl1, Cell cl2, float penWidth);
        delegate void SetCallbackList(Cell cl, Color c);
        delegate void SetCallbackButtonCondition(Button btn, bool condition);
        delegate void SetCallbackData(List<Cell> path);

        private NewMapSettings newMapSettingsForm = new NewMapSettings();//Форма с установками параметров новой карты :
        AlgType algorithm = 0;//Тип используемого алгоритма 
        private GrInfo[] grInfo;//измнение стоимости клетки

        private byte labelColorIndex;
        // Для start и finish используются координаты в клетках, а не в пикселях!
        // Т.е. фактически это индексы элемента массива.
        private Cell start, finish;
        private  Map[,] map;
        private Cell nullCell;
        
        // Координаты старта и финиша в пикселях
        private Point startCoord, finishCoord;
        // Размеры карты в клетках!
        private  int MapWidth { get; set; }
        private  int MapHeight{ get; set; }
        private  int CellSize { get; set; }
        private PathFinder pathFinder;
         
        public Form1()
        {
            MapWidth = 5;
            MapHeight = 5;
            CellSize = 15;
            grInfo = new GrInfo[6];
            nullCell = new Cell(0, 0); 
            InitializeComponent(); 
            PicSelectType.BackColor = Pic1.BackColor;
            AddOwnedForm(newMapSettingsForm);
            pictureBox1.Width = MapWidth * (CellSize + 1) + 1;
            pictureBox1.Height = MapHeight * (CellSize + 1) + 1;
            newMapSettingsForm.numericUpDown1.Value = MapWidth;
            newMapSettingsForm.numericUpDown2.Value = MapHeight;
            newMapSettingsForm.numericUpDown3.Value = CellSize; 
            drawClearMap();
            MapInit();
        }

        //
        private void setData(List<Cell> data)
        {
            if (Results_dgv.InvokeRequired)
            {
                SetCallbackData d = new SetCallbackData(setData);
                this.Invoke(d, new object[] { data });
            }
            else
            {
                Results_dgv.RowCount = data.Count;

                int i = 0;
                foreach (Cell c in data)
                {
                    Results_dgv[0, i].Value = c.xIndex;
                    Results_dgv[1, i].Value = c.yIndex;
                    i++;
                }
            }
        }
        
        //Обнуление клеточного поля
        private void drawClearMap()
        {
            // Размер карты в пискелях.
            int mapWidthPxls = MapWidth * (CellSize + 1) + 1,
                mapHeightPxls = MapHeight * (CellSize + 1) + 1;
            Bitmap mapImg = new Bitmap(mapWidthPxls, mapHeightPxls);
            Graphics g = Graphics.FromImage(mapImg);
            
            // Заливаем весь битмап:
            g.Clear(Color.White);
            
            // Рисуем сетку:
            for (int x = 0; x <= MapWidth; x++)
                 g.DrawLine(Pens.LightGray, x * (CellSize + 1), 0, x * (CellSize + 1), mapHeightPxls);
            for (int y = 0; y <= MapHeight; y++)
                 g.DrawLine(Pens.LightGray, 0, y * (CellSize + 1), mapWidthPxls, y * (CellSize + 1));
            PictureBox p = pictureBox1;
            if (p.Image != null)
                p.Image.Dispose();

            pictureBox1.Image = mapImg;
            g.Dispose();
        }

        //инициализация клеточного поля
        private void MapInit()
        {
            // Иниацилизируем массив  пустой карты:
            try
            {
                map = new Map[MapWidth + 2, MapHeight + 2];
            }
            catch (OutOfMemoryException exc)
            {
                MessageBox.Show("Not enough memmory to create such huge map! Try enter smaller map size values.", exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MapWidth = 50;
                MapHeight = 43;
                CellSize = 13;
                map = new Map[MapWidth + 2, MapHeight + 2];
            }

            for (int i = 1; i <= MapWidth; i++)
                for (int j = 1; j <= MapHeight; j++)
                {
                    map[i, j].StepCoast = 1;
                    map[i, j].type = tType.Road;
                    map[i, j].cell = new Cell(i, j);
                }
            // Края карты обрамляем стенами:
            for (int i = 0; i <= MapWidth + 1; i++)
            {
                map[i, 0].StepCoast = -1;
                map[i, 0].type = tType.Wall;
                map[i, 0].cell = new Cell(i, 0);
                map[i, MapHeight + 1].StepCoast = -1;
                map[i, MapHeight + 1].type = tType.Wall;
                map[i, MapHeight + 1].cell = new Cell(i, MapHeight + 1);
            }
            for (int i = 0; i <= MapHeight + 1; i++)
            {
                map[0, i].StepCoast = -1;
                map[0, i].type = tType.Wall;
                map[0, i].cell = new Cell(0, i);
                map[MapWidth + 1, i].StepCoast = -1;
                map[MapWidth + 1, i].type = tType.Wall;
                map[MapWidth + 1, i].cell = new Cell(MapWidth + 1, i);
            }
            start = nullCell;
            finish = nullCell;
            grInfo = new GrInfo[6];
        }

        //Рисование точки начала
        private void drawStart(Point point)
        {
            if (start == nullCell)
                return;
            FillRegion(Color.White,  point);
            point.X = point.X - point.X % (CellSize + 1);
            point.Y = point.Y - point.Y % (CellSize + 1)-1;
            Rectangle rect = new Rectangle(point.X + 1, point.Y + 2, CellSize -1, CellSize - 1);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.FillEllipse(Brushes.LimeGreen, rect);
            g.Dispose();

        }

        //Рисование точки конца
        private void drawFinish(Point point)
        {
            if (finish == nullCell)
                return;
            FillRegion(Color.White,  point);
            point.X = point.X - point.X % (CellSize + 1);
            point.Y = point.Y - point.Y % (CellSize + 1) - 1;
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            Rectangle rect = new Rectangle(point.X + 1, point.Y + 2, CellSize - 1, CellSize - 1);
            g.FillEllipse(Brushes.Red, rect);
            g.Dispose();
        }

        // Заливает клетку, на которую кликнули.
        private void FillRegion(Color color, Point point)
        {
            SolidBrush brush = new SolidBrush(color);
            //Проверяем цвет кликнутого пикселя:
            Color c = (pictureBox1.Image as Bitmap).GetPixel(point.X, point.Y);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
                    
            point.X = point.X - point.X % (CellSize + 1) + 1;
            point.Y = point.Y - point.Y % (CellSize + 1) + 1;
            g.FillRectangle(brush, point.X, point.Y, CellSize, CellSize);
            brush.Dispose();
            g.Dispose();
        }

        // Возвращает индекс элемента массива, который определяет точка на карте:
        private Cell GetIndexByPozition(Point point)
        {
            Cell index = new Cell(0, 0);
            index.xIndex = (point.X / (CellSize + 1)) + 1;
            index.yIndex = (point.Y / (CellSize + 1)) + 1; 
            return index;
        }

        // Возвращает стоимость прохода по клетке:
        private int getCurrentCoast()
        {
            if (PicSelectType.BackColor == Pic1.BackColor) return -1;
            if (PicSelectType.BackColor == Pic2.BackColor) return (int)NumericForest.Value;
            if (PicSelectType.BackColor == Pic3.BackColor) return (int)NumericTaiga.Value;
            if (PicSelectType.BackColor == Pic4.BackColor) return (int)NumericRoad.Value;
            if (PicSelectType.BackColor == Pic5.BackColor) return (int)NumericLava.Value;
            if (PicSelectType.BackColor == Pic6.BackColor) return (int)NumericSand.Value;
            return 1;
        }

        // Используется вспомогательным потоком вычислений для отображения результатов:
        private void drawDir(Cell cl1, Cell cl2, float penWidth)
        {
           if ( (Math.Abs(cl1.xIndex - cl2.xIndex ) > 1) || (Math.Abs(cl1.yIndex - cl2.yIndex) > 1) )
             return;
            if (pictureBox1.InvokeRequired)
            {
                SetCallback d = new SetCallback(drawDir);
                this.Invoke(d, new object[] { cl1, cl2, penWidth });
            }
            else
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Pen pen = new Pen(Color.Red,penWidth);
                Point p1 = new Point();
                Point p2 = new Point();
                p1.X = (CellSize + 1) * (cl1.xIndex - 1) + (int)((CellSize + 1) / 2);
                p1.Y = (CellSize + 1) * (cl1.yIndex - 1) + (int)((CellSize + 1) / 2);
                
                p2.X = (CellSize + 1) * (cl2.xIndex - 1) + (int)((CellSize + 1) / 2);
                p2.Y = (CellSize + 1) * (cl2.yIndex - 1) + (int)((CellSize + 1) / 2);
                g.DrawLine(pen, p1, p2);
                pen.Dispose();
                g.Dispose();
                pictureBox1.Invalidate();
            }
        }

        // Обозначает рамками на карте точки в open и close списках :
        private void drawRect(Cell cl ,Color c)
        {
            if (this.pictureBox1.InvokeRequired)
            {
                SetCallbackList d = new SetCallbackList(drawRect);
                this.Invoke(d, new object[] {cl,c}); 
            }
            else
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Pen pen = new Pen(c, 1);
                Point p = new Point();
                p.X = (CellSize + 1) * (cl.xIndex - 1) + 1;
                p.Y = (CellSize + 1) * (cl.yIndex - 1) + 1;
                Rectangle rect = new Rectangle(p.X,p.Y,CellSize -1, CellSize -1);
                g.DrawRectangle(pen, rect);
                pen.Dispose();
                g.Dispose();
            }
        }

        //Задать стоимость стоимости клеток
        private void SetNewCoasts()
        {
            // Если после рисования препятствий стоимость не менялась, выходим:
            if ( (!grInfo[1].terrCoastWasChanged ) && (!grInfo[2].terrCoastWasChanged ) && (!grInfo[3].terrCoastWasChanged ) && (!grInfo[4].terrCoastWasChanged )&& (!grInfo[5].terrCoastWasChanged ) )
                return;
            NumericUpDown temp;

            for (int i = 1; i <= MapWidth; i++)
            {
                for (int j = 1; j <= MapHeight; j++)
                {
                    byte typeIndex = (byte)map[i, j].type;
                    if (grInfo[typeIndex].terrCoastWasChanged)
                    {
                        temp = MenuCell.Controls["numericUpDown" + (typeIndex + 1)] as NumericUpDown;
                        map[i, j].StepCoast = (int)temp.Value;
                    }

                }
            }
        }

        //Очищение карты
        private void button5_Click(object sender, EventArgs e)  
        {
            drawClearMap();
            MapInit();
        }

        //выбор типа клетки
        private void SelectCell_Click(object sender, EventArgs e) // Wall type of tile, Color Navy.
        {
            int i = (sender as Label).TabIndex + 1;
            PicSelectType.BackColor = MenuCell.Controls["Pic" + i].BackColor;
            PicSelectType.Text = "";
            labelColorIndex = (byte)(i - 1);
        }

        //выбор стартовый клетки
        private void SelectStartCell_Click(object sender, EventArgs e)
        {
            PicSelectType.BackColor = Color.White;
            PicSelectType.ForeColor = Color.Black;
            PicSelectType.Font = new Font("Verdana", 8, FontStyle.Bold);
            PicSelectType.Text = "S";
        }

        //выбор конечной клетки
        private void SelectEndCell_Click(object sender, EventArgs e)
        {
            PicSelectType.BackColor = Color.Black;
            PicSelectType.ForeColor = Color.White;
            PicSelectType.Font = new Font("Verdana", 8, FontStyle.Bold);
            PicSelectType.Text = "F";
        }

        //выбор алгортимов поиска
        private void SelectAlgorithm(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (!rb.Checked)
                return;
            algorithm = (AlgType)rb.TabIndex;
        }

        //выбор стоимости поля
        private void NumericValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = sender as NumericUpDown;
            int index = nud.TabIndex - 1;
            if (grInfo[index].terrTypeWasUsed)
                grInfo[index].terrCoastWasChanged = true;
        }

        //просмотр пройденного пути
        private void ViewResults(object sender, EventArgs e)
        {
            Results_pnl.Visible = !Results_pnl.Visible;
            if (Results_pnl.Visible)
                (sender as Button).Text = "Close results table";
            else
                (sender as Button).Text = "View results ";
        }

        //рисование типов клеток
        private void PaintCellFromType(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cell p = GetIndexByPozition(e.Location);
                switch (PicSelectType.Text) 
                {
                    case "S" :
                        if (start != nullCell)
                            FillRegion(Pic4.BackColor, startCoord);
                        
                        startCoord = e.Location;
                        start = p;
                        drawStart(startCoord);
                        if (start == finish)
                        {
                            finish = nullCell;
                        }
                        break;
                    case "F" :
                        if (finish != nullCell)
                           FillRegion(Pic4.BackColor, finishCoord);
                        finishCoord = e.Location;
                        finish = p;
                        drawFinish(finishCoord);
                        if (start == finish)
                        {
                            start = nullCell;
                        }
                        break;
                    case "" :
                        FillRegion(PicSelectType.BackColor,e.Location);
                        map[p.xIndex, p.yIndex].type = (tType)labelColorIndex;
                        grInfo[labelColorIndex].terrTypeWasUsed = true;
                        break;
                }
                map[p.xIndex , p.yIndex].StepCoast = getCurrentCoast();
                
                pictureBox1.Invalidate();
            }
            
        }

        // Кнопка старта поиска кратчайшего пути
        private void RunPathFind(object sender, EventArgs e)
        {
            ButtonRun.Enabled = false;
            if (start == nullCell || finish == nullCell )
            {
                MessageBox.Show("You must define START and FINISH points both!","Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ButtonRun.Enabled = true;
                return;
            }
            setData(new List<Cell> { nullCell });
            // Проверяем, не обновлялись ли стоимости прохода после прорисовки карты :
            SetNewCoasts();
            // оОбнуляем массив изменений стоимости прохода :
            for (int i = 0; i < grInfo.Length; i++)
                grInfo[i].terrCoastWasChanged = false;

            pathFinder = new PathFinder(start, finish, map, algorithm);//создание pathFinder
            pathFinder.PointCheked += new PointHandler(pathFinder_PointCheked);//отрисовка от родителя к потомку
            pathFinder.PopBestPointFromOpenList += new ListHandler(pathFinder_PopBestPointFromOpenList);
            pathFinder.PointAddedInOpenList += new ListHandler(pathFinder_PointAddedInOpenList);//добавление в закрытый список
            pathFinder.PathPoint += new PointHandler(pathFinder_PathPoint);//отрисовка кратчайшего пути
            pathFinder.SearchFinished += new SearchResultHandler(pathFinder_SearchFinished);// Обработчик окончания поиска пути:
        }

        //выстраивание пути для ViewResults
        void pathFinder_SearchFinished(object sender, SearchHandlerArgs args)
        {
            if (args.IsFinded)
            {
                setData(args.Path);
            }
            else
            {
                setData(new List<Cell> { nullCell });
            }
        }

        //отрисовка кратчайшего пути
        void pathFinder_PathPoint(object sender, PointEventArgs args)
        {
            drawDir(args.parent, args.succesor, 2);
        }

        //добавление в закрытый список
        void pathFinder_PointAddedInCloseList(object sender, ListEventArgs args)
        {
            drawRect(args.parent, Color.Black);
        }

        //добавление в открытый список
        void pathFinder_PointAddedInOpenList(object sender, ListEventArgs args)
        {
            drawRect(args.parent, Color.LightGreen);
        }
        
        //при обработке точки отрисовывает стреклу, указывающкю направление от род. точки к обрабатываемой:
        void pathFinder_PointCheked(object sender, PointEventArgs args)
        {
            drawDir(args.parent, args.succesor, 1);
        }

        //создание новой мапы
        private void SetMap(object sender, EventArgs e)
        {
            newMapSettingsForm.ActiveControl = newMapSettingsForm.numericUpDown1;
            if (newMapSettingsForm.ShowDialog() == DialogResult.OK)
            {
                MapWidth = (int)newMapSettingsForm.numericUpDown1.Value;
                MapHeight = (int)newMapSettingsForm.numericUpDown2.Value;
                CellSize = (int)newMapSettingsForm.numericUpDown3.Value;
                drawClearMap();
                MapInit();
            }
        }

        //
        void pathFinder_PopBestPointFromOpenList(object sender, ListEventArgs args)
        {
            drawRect(args.parent, Color.Black);
        }
   }
}