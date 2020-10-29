using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    abstract class JobFields
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobFields()
        {
            Id = nextId;
            nextId++;
        }

        public JobFields(string value) : this()
        {
            Value = value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
