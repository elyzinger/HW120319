using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTable
{
    class Knight : IComparable<Knight>
    {
        public string Name { get; private set; }
        public string BirthTown { get; private set; }
        public string Title { get; private set; }

        public Knight(string name, string birthTown, string title)
        {
            Name = name;
            BirthTown = birthTown;
            Title = title;
        }
        public string this[string fieldName]
        {

            get
            {
                string result=null;
                
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
                    case "title":
                        if (fieldName == "title")
                            result = this.Title;
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
            return $"name: {Name}  birthtown: {BirthTown}  title: {Title}";
        }

        public int CompareTo(Knight other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}


               
                
            
          
        

    

