using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Model
{
        [Table("tblEmployee")]
        public class Employee
        {
            private int _id;
            private string _name;
            private string _gender;
            private DateTime _dateOfBirth;

            
            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }

            
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            
            public string Gender
            {
                get { return _gender; }
                set { _gender = value; }
            }

            
            public DateTime DateOfBirth
            {
                get { return _dateOfBirth; }
                set { _dateOfBirth = value; }
            }
        }
}
