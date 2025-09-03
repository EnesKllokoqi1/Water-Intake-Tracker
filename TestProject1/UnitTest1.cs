using ClassLibrary2;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 0;
            int b = 10;
            for(int k = 0; k < 10; k++)
            {
                a++;
            }
            Assert.Equal(a, b);
        }
    }
}