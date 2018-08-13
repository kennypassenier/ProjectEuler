using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem15
    {
        private Random _keuzeValue;

        public Random Keuze
        {
            get { return _keuzeValue; }
            set { _keuzeValue = value; }
        }

        private int _xValue;

        public int X
        {
            get { return _xValue; }
            set { _xValue = value; }
        }
        private int _yValue;

        public int Y
        {
            get { return _yValue; }
            set { _yValue = value; }
        }

        private List<string> _successfullSequencesValue;

        public List<string> SuccesfullSequences
        {
            get { return _successfullSequencesValue; }
            set { _successfullSequencesValue = value; }
        }
        
        // Constructor
        public Problem15()
        {
            const int limit = 2; // Determines the size of the grid.
            int xCoordinateMax = limit, yCoordinateMax = limit;
            Keuze = new Random();
            X = 0;
            Y = 0;
            SuccesfullSequences = new List<string>();
            for (int teller = 1; teller < 1000000; teller++)
            {
                List<string> sequence = new List<string>();
                while ((X <= xCoordinateMax) && (Y <= yCoordinateMax) && (X >= 0) && (Y >= 0))
                {
                    sequence.Add(Move());
                    if (X == limit && Y == limit) // If we succesfully travelled to the end. 
                    {
                        SuccesfullSequences.Add(sequence.ToString());
                    }
                }
            }
            Console.WriteLine("Debug");
            if(SuccesfullSequences != null)
            {
                foreach (var item in SuccesfullSequences)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Nothing to write");
            }
            

        }

        private string Move()
        {
            // 1 is up, 2 is right, 3 is down, 4 is left.
            int direction = Keuze.Next(1, 5);
            if (direction == 1)
            {
                Y -= 1;
                return "N";
            }
            else if(direction == 2)
            {
                X += 1;
                return "E";
            }
            else if (direction == 3)
            {
                Y += 1;
                return "S";
            }
            else if (direction == 4)
            {
                X -= 1;
                return "W";
            }
            else
            {
                throw new Exception("Wrong move, not allowed");
            }
        }
    }
}
