using System.Collections.Generic;

namespace P000_Data.DataModel
{
    public class Person
    {
        public string Name { get; set; }

        public Profession Profession { get; set; }

        private List<Person> m_children = new List<Person>();

        public IList<Person> Children => m_children;
    }
}
