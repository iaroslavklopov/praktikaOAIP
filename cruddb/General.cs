using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cruddb
{
    public class General
    {
        [Key]
        public int WorkerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }

        public General()
        { }
        public General(int workerId, string lastName, string firstName, string middleName, string dateOfBirth, string gender)
        {
            WorkerId = workerId;
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
    }
}
