namespace Ionix.Data.Migration.SQLiteTests
{
    using FluentAssertions;
    using Xunit;

    public class MigrationInitializerTests
    {
        [Fact]
        public void ExecuteTest()
        {
            IonixFactory.InitMigration(true);
            true.Should().BeTrue();
        }
    }
}