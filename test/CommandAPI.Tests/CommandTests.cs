using System;
using Xunit;
using System.Collections.Generic;
using Moq;
using AutoMapper;
using CommandAPI.Models;
using CommandAPI.Data;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand;
        public CommandTests()
        {
            testCommand = new Command
            {
            HowTo = "Do something",
            Platform = "Some platform",
            CommandLine = "Some commandline"
            };
        }

        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            //Arrange
            //var testCommand = new Command
            //{
            //    HowTo = "Do something awesome",
            //    Platform = "xUnit",
            //    CommandLine = "dotnet test"
            //};

            //Act
            testCommand.HowTo = "Execute Unit Tests";
            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            //Arrange
            //var testCommand = new Command
            //{
            //    HowTo = "Do something awesome",
            //    Platform = "xUnit",
            //    CommandLine = "dotnet test"
            //};

            //Act
            testCommand.Platform = "xUnit";
            //Assert
            Assert.Equal("xUnit", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            //Arrange
            //var testCommand = new Command
            //{
            //    HowTo = "Do something awesome",
            //    Platform = "xUnit",
            //    CommandLine = "dotnet test"
            //};
            
            //Act
            testCommand.CommandLine = "dotnet test";
            //Assert
            Assert.Equal("dotnet test", testCommand.CommandLine);
        }
    }
}