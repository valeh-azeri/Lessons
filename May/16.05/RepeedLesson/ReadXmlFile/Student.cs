﻿using System;

namespace ReadXmlFile
{
    internal class Student
    {
        public Student()
        {
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}