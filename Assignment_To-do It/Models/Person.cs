using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_To_do_It.Models
{
    public class Person
    {
        private readonly int Id;
        private string FirstName;
        private string LastName;
        public Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;  
            this.LastName = lastName;    
        }
        public int id { 
            get { return Id; }

        }
        public string firstName
        {
            get { return FirstName; }
            set {
                if (string.IsNullOrEmpty(firstName))
                {
                    throw new ArgumentNullException(("This field can not be null or empty!"));
                }
                else
                {
                FirstName = firstName;}

                }

        }
        //}
        //public string lastName
        //{
        //    get { return LastName; }
        //    set {
        //    LastName = value; }
        //}
    }

}
