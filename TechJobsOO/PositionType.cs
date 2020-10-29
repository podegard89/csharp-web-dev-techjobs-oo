﻿using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {
        public PositionType(string value) : base(value)
        {
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods. DONE
        
        public override bool Equals(object obj)
        {
            return obj is PositionType type &&
                   Id == type.Id;
        }
    }
}
