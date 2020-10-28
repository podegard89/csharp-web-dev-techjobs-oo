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
        public void TestJobConstructorSetsAllField()
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
    }
}
