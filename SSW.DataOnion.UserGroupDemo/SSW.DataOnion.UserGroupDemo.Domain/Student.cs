﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SSW.DataOnion.UserGroupDemo.Domain
{
    public class Student
    {

        public int Id { get; set; }

        [MaxLength(111)]
        public string FirstName { get; set; }


        public string LastName { get; set; }


        public DateTime DateOfBirth { get; set; }


        public virtual ICollection<Enrolment> Enrolments { get; set; }

    }
}