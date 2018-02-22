using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
    // This would work if I had a MUCH more powerful computer. 
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
            const int limit = 20; // Determines the size of the grid.
            int xCoordinateMax = limit, yCoordinateMax = limit;
            Keuze = new Random();
            SuccesfullSequences = new List<string>();
            for (int teller = 1; teller < 1000000; teller++)
            {
                Console.Clear();
                Console.WriteLine(teller);
                X = 0;
                Y = 0;
                List<string> Sequence = new List<string>();
                while (X <= xCoordinateMax  && Y <= yCoordinateMax)
                {
                    Sequence.Add(Move());
                    Console.WriteLine(ToString());
                    if (X == limit && Y == limit) // If we succesfully travelled to the end. 
                    {
                        string succesfullString = String.Join(String.Empty, Sequence.ToArray());
                        if (SuccesfullSequences.Contains(succesfullString))
                        {
                            Console.WriteLine("Duplicate found");
                        }
                        else
                        {
                            SuccesfullSequences.Add(String.Join(String.Empty, Sequence.ToArray()));
                        }                        
                        break;
                    }
                }
            }
            if(SuccesfullSequences != null)
            {
                foreach (var item in SuccesfullSequences)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(SuccesfullSequences.Count);
            }
            else
            {
                Console.WriteLine("Nothing to write");
            }
            

        }

        public override string ToString()
        {
            return String.Format("X: {0}/t Y: {1}", X, Y);
        }

        private string Move()
        {
            // 1 is up, 2 is right, 3 is down, 4 is left.
            int direction = Keuze.Next(1, 3);
            if(direction == 1)
            {
                X += 1;
                return "E";
            }
            else if (direction == 2)
            {
                Y += 1;
                return "S";
            }
            else
            {
                throw new Exception("Wrong move, not allowed");
            }
        }
    }
}
