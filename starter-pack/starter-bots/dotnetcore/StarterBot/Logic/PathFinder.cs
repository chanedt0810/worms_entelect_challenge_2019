using StarterBot.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarterBot.Logic
{
    class PathFinder
    {
        public CellStateContainer StartPosition { get; set; }

        public CellStateContainer TargetPosition { get; set; }

        public int G { get; set; }

        public int H { get; set; }

        public int F { get; set; }

        public double EuclideanDistance { get; set; }

        public double ShortestDistance { get; set; }

        public Dictionary<int, CellStateContainer> OpenList { get; set; }

        public Dictionary<int, CellStateContainer> ClosedList { get; set; }

        public Dictionary<int, CellStateContainer> TempList { get; set; }

        public Dictionary<int, CellStateContainer> ValidAdjacentCells { get; set; }

        public PathFinder() { }

        public PathFinder(CellStateContainer startPosition, CellStateContainer targetPosition)
        {
            StartPosition = startPosition ?? throw new ArgumentNullException(nameof(startPosition));
            TargetPosition = targetPosition ?? throw new ArgumentNullException(nameof(targetPosition));
            G = 0;
            H = 0;
            F = 0;
            EuclideanDistance = 0d;
            ShortestDistance = 0d;
            OpenList = new Dictionary<int, CellStateContainer>();
            ClosedList = new Dictionary<int, CellStateContainer>();
            TempList = new Dictionary<int, CellStateContainer>();
            ValidAdjacentCells = new Dictionary<int, CellStateContainer>();
        }

        public MapPosition GetMovePosition()
        {
            var result = new MapPosition();

            Console.WriteLine("This works");

            return result;
        }
    }
}
