using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Persoon
    {
        private List<string> voornaamValue;
        public List<string> Voornaam
        {
            get
            {
                return voornaamValue;
            }
            set
            {
                foreach (var item in value)
                {
                    if (item == String.Empty)
                        throw new ArgumentNullException();
                    if (voornaamValue.Contains(item))
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        voornaamValue.Add(item);
                    }
                }
            }
        }
        public Persoon(List<string> naam)
        {
            if(naam.Count != naam.Distinct().Count())
            {
                // Duplicates exist
                throw new ArgumentException();
            }
            if (naam.Contains(String.Empty))
            {
                // Empty name exists
                throw new ArgumentNullException();
            }
            Voornaam = naam;
        }
        public override string ToString()
        {
            return String.Join(" ", Voornaam);
        }
    }
}
