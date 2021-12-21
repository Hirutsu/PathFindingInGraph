using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace PathFinding
{
    delegate void PointHandler(object sender, PointEventArgs args);
    delegate void ListHandler(object sender, ListEventArgs args);
    delegate void SearchResultHandler(object sender, SearchHandlerArgs args); 

    class ListEventArgs : EventArgs
    {
        public Cell parent;
        public ListEventArgs( Cell parent)
        {
            this.parent = parent;
        }
    }

    class PointEventArgs : ListEventArgs
    {
        public Cell succesor;
        public PointEventArgs(Cell parent, Cell succesor) : base(parent)
        {
           this.succesor = succesor;
        }
    }

    class SearchHandlerArgs : EventArgs
    {
        public List<Cell> Path;
        public bool IsFinded;
        public string message;
        public SearchHandlerArgs() {}
        public SearchHandlerArgs(List<Cell> Path, string message, bool IsFinded)
        {
            this.Path = Path;
            this.message = message;
            this.IsFinded = IsFinded;
        }
    }

    class PathFinder
    {
        Cell nullPoint = new Cell(-1, -1);
        List<Map> OpenList ;
        List<Map> CloseList ;
        Cell start, finish;
        Map[,] map;
        AlgType algorithm;   // тип используемого алгоритма
        int time;
        public List<Cell> path;
        private Thread searchingThread;
        public PathFinder() { }
        public PathFinder(Cell start, Cell finish, Map[,] map, AlgType algorithm,int timeWait)
        {
            OpenList = new List<Map>(100);
            CloseList = new List<Map>(100);
            this.start = start;
            this.finish = finish;
            this.map = map;
            this.algorithm = algorithm;
            searchingThread = new Thread(this.Run);
            searchingThread.Start();
            time = timeWait;
        }

        public event PointHandler PointCheked;
        public event PointHandler PathPoint;
        public event ListHandler PopBestPointFromOpenList;
        public event ListHandler PointAddedInOpenList;
        public event ListHandler PointAddedInCloseList;
        public event SearchResultHandler SearchFinished;


        //Запуск поиска кратчайшего пути
        void Run()
        {
            GetPath();
        }

        //евристика для просчета длины между клетками
        private int Heruistic(Cell p1, Cell p2)
        {
            int dx =  Math.Abs (p1.xIndex - p2.xIndex);
            int dy = Math.Abs (p1.yIndex- p2.yIndex);

            return 10 * Math.Abs(dx-dy) + 14 * Math.Min(dx, dy);  
        }

        //Извлечение из открытого списка точку с наименьшей общей стоимость прохода до финиша
        private Cell popMinFromOpen(List<Map> OpenList)
        {
            
            if (OpenList.Count > 0)
            {
                int i = 0;
                for (int j = 0; j < OpenList.Count; j++)
                {
                    if (OpenList[j].fValue <= OpenList[i].fValue )
                      i = j;
                }
                return OpenList[i].cell; 
            }
            else
                return nullPoint;
        }

        //проверка на то что клетка в открытом списке
        private bool isPointInOpenList(Cell cell, List<Map> OpenList)
        {
            Thread.Sleep(Convert.ToInt32(time));
            foreach (Map m in OpenList)
                if (m.cell == cell) return true;
            return false;
        }

        //проверка на то что клетка в закрытом списке
        private bool isPointInCloseList(Cell cell, List<Map> CloseList)
        {
            Thread.Sleep(Convert.ToInt32(time));
            foreach (Map m in CloseList)
                if (m.cell == cell) return true;
            return false;
        }

        //удалить из открытого списка
        private void removeFromOpenList(Cell p)
        {
            for (int i = 0; i < OpenList.Count; i++)

                if (OpenList[i].cell.xIndex == p.xIndex && OpenList[i].cell.yIndex == p.yIndex)
                    OpenList.Remove(OpenList[i]);
        }

        //удалить из закрытого списка
        private void removeFromCloseList(Cell p)
        {
            for (int i = 0; i < CloseList.Count; i++)

                if (CloseList[i].cell.xIndex == p.xIndex && CloseList[i].cell.yIndex == p.yIndex)
                    CloseList.Remove(CloseList[i]);
        }

        private void getSuccesors(Cell cell, Map[,] map, out Cell[] succesors)
        {
             succesors = new Cell[8] { new Cell(0,-1), new Cell(1,-1), new Cell(1,0), new Cell(1,1), 
                                        new Cell(0,1), new Cell(-1,1), new Cell(-1,0), new Cell(-1,-1)};
             for (int i = 0; i < 8; i++)
             {
                 succesors[i].xIndex += cell.xIndex;
                 succesors[i].yIndex += cell.yIndex;
             }
        }
        //добавление в открытый список
        private void addToOpenList(Map mPoint)
        {
            OpenList.Add(mPoint);
            if (PointAddedInOpenList != null)
                PointAddedInOpenList(this, new ListEventArgs(mPoint.cell));
        }

        //добавление в закрытый список
        private void addToCloseList(Map mPoint)
        {
            CloseList.Add(mPoint);
            removeFromOpenList(mPoint.cell);
            if (PointAddedInCloseList != null)
                PointAddedInCloseList(this, new ListEventArgs(mPoint.cell));

        }

        //получение пути
        private bool GetPath( )
        {
            int ListCap = Math.Abs(start.xIndex-finish.xIndex) + Math.Abs(start.yIndex - finish.yIndex);
            Cell p = new Cell(start.xIndex, start.yIndex);
            Cell pTemp = p;
            map[p.xIndex, p.yIndex].cell = p;
            map[p.xIndex, p.yIndex].gValue = 0;

            if (algorithm == AlgType.Dijkstra)
                map[p.xIndex, p.yIndex].fValue = 0;
            else
                map[p.xIndex, p.yIndex].fValue = Heruistic(start, finish);
            map[p.xIndex, p.yIndex].parent = nullPoint;
          
            addToOpenList(map[p.xIndex, p.yIndex]);
            while (OpenList.Count != 0)
            {
                //Извлекаем из открытого списка точку с наименьшей общей стоимость прохода до финиша:
                p = popMinFromOpen(OpenList);
                if (PopBestPointFromOpenList != null)
                    PopBestPointFromOpenList(this, new ListEventArgs( p));
                // Если извлечённая точка - финишная, конструируем путь:
                if (p == finish)
                {
                    //Конструируем путь:
                    path = new List<Cell>(ListCap);
                    path.Add(finish);
                    Cell s = map[p.xIndex, p.yIndex].parent;
                    while (s != start)
                    {
                        path.Add(s);
                        s = map[s.xIndex, s.yIndex].parent;
                    }
                    path.Add(start);
                    for (int i = 0; i < path.Count - 1; i++)
                    {
                        if (PathPoint != null)
                            PathPoint(this, new PointEventArgs(path[i], path[i + 1]));
                    }
                    path.Reverse();

                    if (SearchFinished != null)
                        SearchFinished(this, new SearchHandlerArgs(path, "Path finded!",true));

                    return true;
                }
                // Исследуем соседей:
                Cell[] succesors = new Cell[8];
                
                getSuccesors(p, map, out  succesors);
                for (int i = 0; i < 8; i++)
                {
                    byte[] diagCoast =  {10,14};
                    int x = succesors[i].xIndex;
                    int y = succesors[i].yIndex;
                    // Если препятствие стена - пропускаем точку:
                    if (map[x,y].StepCoast == -1) continue;

                    switch (algorithm)
                    {
                        case AlgType.BestFirst:
                            {
                                if(isPointInCloseList(succesors[i], OpenList) || isPointInOpenList(succesors[i], CloseList))
                                    continue;
                                map[x, y].fValue = Heruistic(succesors[i], finish);
                                break;
                            }
                        case AlgType.Dijkstra:
                            {
                               //Считаем диагональный шаг дороже ортогонального в 1.4:
                               int newG = map[p.xIndex, p.yIndex].fValue + (diagCoast[i % 2]) * map[x, y].StepCoast;
                               if (((isPointInCloseList(succesors[i], OpenList)) || (isPointInOpenList(succesors[i], CloseList)))&& (map[x, y].fValue <= newG))
                                   continue;
                               map[x, y].fValue = newG ;
                               break;
                            }
                        case AlgType.AStar:
                           {
                               int newG = map[p.xIndex, p.yIndex].gValue + (diagCoast[i % 2]) * map[x, y].StepCoast;
                               if (((isPointInCloseList(succesors[i], OpenList)) || (isPointInOpenList(succesors[i], CloseList)))
                                   && (map[x, y].gValue <= newG))
                                   continue;
                               map[x, y].gValue = newG;
                               map[x, y].fValue = newG + Heruistic(succesors[i], finish);
                               break;
                           }
                    }

                    map[x, y].parent = p;

                    if(isPointInCloseList(succesors[i], CloseList))
                        removeFromCloseList(succesors[i]);

                      if (!isPointInOpenList(succesors[i], OpenList))
                      {
                          map[x, y].cell = succesors[i];
                          if (PointCheked != null)
                              PointCheked(this, new PointEventArgs(p, succesors[i]));
                          addToOpenList(map[x, y]);
                      }
                }
                map[p.xIndex, p.yIndex].cell = p;
                addToCloseList(map[p.xIndex, p.yIndex]);
                pTemp = p;
            }
            path = new List<Cell>(){nullPoint};
            if (SearchFinished != null)
                SearchFinished(this, new SearchHandlerArgs(path, "Where is no way finded!",false));
            return false;
        }
    }
}
