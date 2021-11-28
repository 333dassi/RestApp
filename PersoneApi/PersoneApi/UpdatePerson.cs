using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PersoneApi
{
    public class UpdatePerson:Person
    {
        public string Gender { get; set; }
        public string Email { get; set; }
        public UpdatePerson(string ID, string Name, string Phone, int Age, string Gender, string Email) : base(ID,Name,Phone,Age)
        {
            this.Gender = Gender;
            this.Email = Email;
        }
        public override string ToString()
        {
            return base.ToString() + $"gender: {Gender} , email: {Email}";

        }
        public new void printTofile()
        {
            base.printTofile();
            using (StreamWriter writetext = new StreamWriter(Program.FILPATH))
            {
                writetext.WriteLine(ToString());
            }
        }
    }
}
