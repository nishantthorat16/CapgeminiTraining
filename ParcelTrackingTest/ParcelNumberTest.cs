using SampleLibrary;
using System;
using Xunit;

namespace ParcelTrackingTest
{
    public class ParcelNumberTest
    {
        //[Fact]
        //public void CheckParcelNumber_ValidData_ReturnsTrue()
        //{
        //    //Arrange
        //    string parcelNumber     = "BLR1234569";
        //    ParcelTracking tracking = new ParcelTracking();

        //    //Act
        //    var isValidNumber       = tracking.CheckParcelNumber(parcelNumber);

        //    //Assert
        //    Assert.True(isValidNumber);
        //}

        //[Fact]
        //public void CheckParcelNumber_LowerCaseData_ReturnsTrue()
        //{
        //    //Arrange
        //    string parcelNumber = "BlR1234569";
        //    ParcelTracking tracking = new ParcelTracking();

        //    //Act
        //    var isValidNumber = tracking.CheckParcelNumber(parcelNumber);

        //    //Assert
        //    Assert.True(isValidNumber);
        //}

        [Fact]
        public void CheckParcelNumber_InValidData_ReturnsFalse()
        {
            //Arrange
            string parcelNumber     = "AAA1234569";
            ParcelTracking tracking = new ParcelTracking();

            //Act
            var isValidNumber = tracking.CheckParcelNumber(parcelNumber);

            //Assert
            Assert.False(isValidNumber);
        }

        [Theory]
        [InlineData("BLR1234546")]
        [InlineData("BLr1234546")]
        [InlineData("blr1234546")]
        [InlineData("blR1234546")]
        public void CheckParcelNumber_ValidData_ReturnsTrue(string parcelNumber)
        {
            //Arrange
            ParcelTracking tracking = new ParcelTracking();

            //Act
            var isValidNumber = tracking.CheckParcelNumber(parcelNumber);

            //Assert
            Assert.True(isValidNumber);
        }
    }
}
