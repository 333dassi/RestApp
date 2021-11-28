using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PersoneApi
{
    public class Person
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public Person(string ID, string Name, string Phone, int Age)
        {
            this.ID = ID;
            this.Name = Name;
            this.Phone = Phone;
            this.Age = Age;

        }
        public override string ToString()
        {
            return $"name: {Name} id: {ID} phone number: {Phone}, age: {Age}";
               
        }
        public void printTofile()
        {
            using (StreamWriter writetext = new StreamWriter(Program.FILPATH))
            {
                writetext.WriteLine(ToString());
            }
        }
    }
}
