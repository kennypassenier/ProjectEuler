using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem15
    {
        private Random keuzeValue;

        public Random Keuze
        {
            get { return keuzeValue; }
            set { keuzeValue = value; }
        }

        private int xValue;

        public int X
        {
            get { return xValue; }
            set { xValue = value; }
        }
        private int yValue;

        public int Y
        {
            get { return yValue; }
            set { yValue = value; }
        }

        private List<string> successfullSequencesValue;

        public List<string> SuccesfullSequences
        {
            get { return successfullSequencesValue; }
            set { successfullSequencesValue = value; }
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
                List<string> Sequence = new List<string>();
                while ((X <= xCoordinateMax) && (Y <= yCoordinateMax) && (X >= 0) && (Y >= 0))
                {
                    Sequence.Add(Move());
                    if (X == limit && Y == limit) // If we succesfully travelled to the end. 
                    {
                        SuccesfullSequences.Add(Sequence.ToString());
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
