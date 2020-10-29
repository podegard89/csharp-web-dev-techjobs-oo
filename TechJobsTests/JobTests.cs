using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
        { 
    
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();
            Assert.IsTrue(testJob2.Id - testJob1.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual($"{testJob.Name} {testJob.EmployerName.Value} {testJob.EmployerLocation.Value} {testJob.JobType.Value} {testJob.JobCoreCompetency.Value}", "Product tester ACME Desert Quality control Persistence");
            Assert.IsNotNull(testJob.Id);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job testJob2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(testJob1.Equals(testJob2));
        }

        [TestMethod]
        public void ToStringReturnsBlankLinesAroundString()
        {
            Job testJob1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string testString = testJob1.ToString();
            Assert.IsTrue(testString.StartsWith("\n"));
            Assert.IsTrue(testString.EndsWith("\n"));
            
        }

        [TestMethod]
        public void ToStringReturnsFormattedData()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(testJob.ToString().Contains(
                $"ID: {testJob.Id}\n" +
                $"Name: {testJob.Name}\n" +
                $"Employer: {testJob.EmployerName.Value}\n" +
                $"Location: {testJob.EmployerLocation.Value}\n" +
                $"Position Type: {testJob.JobType.Value}\n" +
                $"Core Competency: {testJob.JobCoreCompetency.Value}\n"
                ));
        }

        [TestMethod]
        public void EmptyParameterReturnsDataNotAvailable()
        {
            Job testJob = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            Assert.IsTrue(testJob.ToString().Contains("Employer: Data not available"));
        }
    }
}
