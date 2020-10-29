using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        private readonly Dictionary<string, string> jobData = new Dictionary<string, string>();

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }
        //public Dictionary<string, string> JobData { get; set; }
        

        
        // TODO: Add the two necessary constructors. DONE
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
            jobData.Add("ID", Id.ToString());
            jobData.Add("Name", Name);
            jobData.Add("Employer", EmployerName.Value);
            jobData.Add("Location", EmployerLocation.Value);
            jobData.Add("Position Type", JobType.Value);
            jobData.Add("Core Competency", JobCoreCompetency.Value);
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Generate Equals() and GetHashCode() methods. DONE

        public override string ToString()
        {
            string outputString = "";
            
            foreach (KeyValuePair<string, string> dataPoint in jobData)
            {
                if (dataPoint.Value == "")
                {
                    outputString += $"{dataPoint.Key}: Data not available\n";
                }
                else
                {
                    outputString += $"{dataPoint.Key}: {dataPoint.Value}\n";
                }
            }
            return $"\n{outputString}";
        }

    }
}
