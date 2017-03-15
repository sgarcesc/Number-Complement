using Xunit;

namespace NumberComplement.UnitTest
{
    public class ProgramTest
    {
        [Theory]
        [InlineData(50,13)]
        [InlineData(100, 27)]
        [InlineData(401, 110)]
        [InlineData(8192, 8191)]
        [InlineData(65536, 65535)]
        [InlineData(76819, 54252)]
        [InlineData(43121, 22414)]
        [InlineData(91931, 39140)]
        public void GetIntegerComplementTest(int passed, int expected)
        {
            //Act
            var result = Program.GetIntegerComplement(passed);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
