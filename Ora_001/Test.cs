using NUnit.Framework;

namespace Ora_001
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void CutSalaryNotThrows()
        {
            Manager manager = new Manager(4, "Géza", "Kedves", 252510.24);

            manager.CutSalary(10000);

            Assert.That(() => manager.CutSalary(10000), Throws.Nothing);
        }

        [Test]
        public void CutSalaryCorrectly()
        {
            // Arrange
            int teamSize = 5;
            string firstName = "John";
            string lastName = "Doe";
            double initialSalary = 10000;
            double cut = 1000; //mennyivel csökkentsük

            Manager manager = new Manager(teamSize, firstName, lastName, initialSalary);

            // Act
            manager.CutSalary(cut);

            double expectedSalary = Math.Round(initialSalary - (cut * 0.9f));
            // Assert

            Assert.That(manager.Salary, Is.EqualTo(expectedSalary));
        }
    }
}
