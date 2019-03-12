using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTable 
{
    class Magician : IComparable<Magician>
    {
        public string Name { get; private set; }
        public string BirthTown { get; private set; }
        public string FavoriteSpell { get; private set; }

        public Magician(string name, string birthTown, string favoriteSpell)
        {
            Name = name;
            BirthTown = birthTown;
            FavoriteSpell = favoriteSpell;
        }
        public string this[string fieldName]
        {

            get
            {
                string result = null;

                switch (fieldName)
                {

                    case "name":
                        if (fieldName == "name")
                            result = this.Name;
                        break;
                    case "birthTown":
                        if (fieldName == "birthTown")
                            result = this.BirthTown;
                        break;
                    case "favoriteSpell":
                        if (fieldName == "favoriteSpell")
                            result = this.FavoriteSpell;
                        break;
                    default:
                        return "unknown";
                        //Console.WriteLine("unknown");
                        //break;
                }
                return result;
            }
        }

        public override string ToString()
        {
            return $"name: {Name}  birthtown: {BirthTown}  favoriteSpell: {FavoriteSpell}";
        }

        public int CompareTo(Magician other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
