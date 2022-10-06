using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No7
{
    public class Department
    {
        private int id;
        private string name;
        private string location;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public override string ToString()
        {
            return $"Department Id {id} name {name} location {location}";
        }
    }
}
