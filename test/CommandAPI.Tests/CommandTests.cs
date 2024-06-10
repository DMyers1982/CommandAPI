using System;
using Xunit;
using CommandAPI.Models;
namespace CommandAPI.Tests
{
    public class CommandTests
    {
        [Fact]
        public void CanChangeHowTo()
        {
            //Arrange
            var testCommand = new Command
            {
                HowTo = "Do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
            //Act
            testCommand.HowTo = "Do something awesome";
            //Assert
            Assert.Equal("Do something awesome", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            //Arrange
            var testCommand = new Command
            {
                HowTo = "Do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
            //Act
            testCommand.Platform = "xUnit";
            //Assert
            Assert.Equal("xUnit", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            //Arrange
            var testCommand = new Command
            {
                HowTo = "Do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
            //Act
            testCommand.CommandLine = "dotnet test";
            //Assert
            Assert.Equal("dotnet test", testCommand.CommandLine);
        }
    }
}