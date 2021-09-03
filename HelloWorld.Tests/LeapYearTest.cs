using System;
using Xunit;

namespace HelloWorld.Tests
{
    public class LeapYearTest
    {

        [Fact]
        public void userGetsNayPrompted() 
        {
            var p = new Program();
            var res =  p.getUserPromt(1700);
            Assert.Equal("nay", res);
        }

         [Fact]
        public void userGetsYayPrompted() 
        {
            var p = new Program();
            var res =  p.getUserPromt(1600);
            Assert.Equal("yay", res);
        }

        [Fact]
        public void DivisibleByFour1700()
        {
            //Arrange 
            var p = new Program();
            
            //Act 
            var res = p.isLeapYear(1700);

            //Assert 
            Assert.Equal(false, res);
        }

         [Fact]
        public void DivisibleByFour1800()
        {
            //Arrange 
            var p = new Program();
            
            //Act 
            var res = p.isLeapYear(1800);

            //Assert 
            Assert.Equal(false, res);
        }

         [Fact]
        public void DivisibleByFour1900()
        {
            //Arrange 
            var p = new Program();
            
            //Act 
            var res = p.isLeapYear(1900);

            //Assert 
            Assert.Equal(false, res);
        }

         [Fact]
        public void DivisibleByFour1600()
        {
            //Arrange 
            var p = new Program();
            
            //Act 
            var res = p.isLeapYear(1600);

            //Assert 
            Assert.Equal(true, res);
        }

          [Fact]
        public void DivisibleByFour2000()
        {
            //Arrange 
            var p = new Program();
            
            //Act 
            var res = p.isLeapYear(2000);

            //Assert 
            Assert.Equal(true, res);
        }

    }
}
