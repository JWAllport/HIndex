namespace HIndex
{
    public class HIndexTest
    {
        [Fact]
        public void Test1()
        {
            HIndex solution = new HIndex();
            int result = solution.hIndex(new int[] {3,0,6,1,5});
            Assert.Equal(3, result);
        }
        
        [Fact]
        public void Test2()
        {
            HIndex solution = new HIndex();
            int result = solution.hIndex(new int[] {1,3,1});
            Assert.Equal(1, result);
        }
        [Fact]
        public void Test3()
        {
            HIndex solution = new HIndex();
            int result = solution.hIndex(new int[] {100});
            Assert.Equal(1, result);
        }
    }
}