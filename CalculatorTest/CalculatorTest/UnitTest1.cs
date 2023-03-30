using Domain;
namespace CalculatorTest

{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculator cal = new Calculator();
            if(cal.Sum(2,2)!=4) { throw  new Exception(); }
        }
    }
}