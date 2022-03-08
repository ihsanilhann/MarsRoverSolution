using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MarsRoverProject.Exceptions;

namespace MarsRoverProject.Tests
{
    [TestClass()]
    public class MarsRoverTests
    {
        [TestMethod(), TestCategory("Exceptions")]
        [ExpectedExceptionAttribute(typeof(NullReferenceException))]
        public void CreateSurfaceTest_EmptyInput_ThowsInsufficientArgumentException()
        {
            // Arrange
            var m1 = new MarsRover();

            // Act
            m1.CreateSurface("");

        }

        [TestMethod(), TestCategory("Exceptions")]
        [ExpectedExceptionAttribute(typeof(NullReferenceException))]
        public void CreateSurfaceTest_UndefinedInput_ThrowsNullReferenceException()
        {
            // Arrange
            var m1 = new MarsRover();

            // Act
            m1.CreateSurface(null);
        }

        [TestMethod(), TestCategory("Exceptions")]
        [ExpectedExceptionAttribute(typeof(NotEnoughArgumentException))]
        public void CreateSurfaceTest_MissingSpace_ThrowsNotEnoughArgumentException()
        {
            // Arrange
            var m1 = new MarsRover();

            // Act
            m1.CreateSurface("45");

        }


        [TestMethod(), TestCategory("Exceptions")]
        [ExpectedExceptionAttribute(typeof(WrongParameterException))]
        public void CreateSurfaceTest_SurfaceLimit_ThrowsWrongParameterException()
        {
            // Arrange
            var m1 = new MarsRover();

            // Act
            m1.CreateSurface("-1 -1");
        }

        [TestMethod(), TestCategory("Exceptions")]
        [ExpectedExceptionAttribute(typeof(OutOfSurfaceException))]
        public void SetPositionTest_OutOfBoundary_ThrowsOutOfSurfaceException()
        {
            // Arrange
            var m1 = new MarsRover();
            m1.CreateSurface("2 2");

            // Act
            m1.SetPosition("3 5 N");

        }

        [TestMethod(), TestCategory("Exceptions")]
        [ExpectedExceptionAttribute(typeof(SurfaceNotCreatedException))]
        public void ActionTest_Move_ThrowsSurfaceNotCreatedException()
        {
            // Arrange
            var m1 = new MarsRover();

            // Act
            m1.Action("LM");

        }

        [TestMethod(), TestCategory("Exceptions")]
        [ExpectedExceptionAttribute(typeof(RotationNotInitializedException))]
        public void ActionTest_Move_ThrowsRotationNotInitializedException()
        {
            // Arrange
            var m1 = new MarsRover();
            m1.CreateSurface("2 2");

            // Act
            m1.Action("LM");

        }


        [TestMethod(), TestCategory("Exceptions")]
        [ExpectedExceptionAttribute(typeof(InvalidCommandException))]
        public void ActionTest_Move_ThrowsInvalidCommandException()
        {
            // Arrange
            var m1 = new MarsRover();
            m1.CreateSurface("2 2");
            m1.SetPosition("1 2 N");

            // Act
            m1.Action("PM");

        }


        [TestMethod(), TestCategory("Exceptions")]
        [ExpectedExceptionAttribute(typeof(OutOfSurfaceException))]
        public void ActionTest_MoveBackward_ThrowsOutOfSurfaceException()
        {
            // Arrange
            var m1 = new MarsRover();
            m1.CreateSurface("2 2");
            m1.SetPosition("0 0 N");

            // Act
            m1.Action("LM");

        }


        [TestMethod(), TestCategory("Exceptions")]
        [ExpectedExceptionAttribute(typeof(OutOfSurfaceException))]
        public void ActionTest_MoveForward_ThrowsOutOfSurfaceException()
        {
            // Arrange
            var m1 = new MarsRover();
            m1.CreateSurface("2 2");
            m1.SetPosition("1 2 N");

            // Act
            m1.Action("LMRM");

        }

        
        [TestMethod(), TestCategory("Move and Settlement")]
        public void SetPositionTest_NoMove_SettledExpectedPoint()
        {
            // Arrange
            var m1 = new MarsRover();
            m1.CreateSurface("3 3");

            // Act
            Int32 xTest = 1, yTest = 0;
            string rot = "e", input = xTest.ToString() + " " + yTest.ToString() + " " + rot;

            m1.SetPosition(input);

            // Asset
            Assert.IsTrue(m1.GetPosition()[0] == xTest);
            Assert.IsTrue(m1.GetPosition()[1] == yTest);
            Assert.IsTrue((m1.GetRotation() == rot.ToLower()) || (m1.GetRotation() == rot.ToUpper()));

        }


        [TestMethod(), TestCategory("Move and Settlement")]
        public void ActionTest_Move_AccessExpectedPoint()
        {
            // Arrange
            var m1 = new MarsRover();
            m1.CreateSurface("3 3");
            Int32 xTest = 1, yTest = 1;
            string rot = "n", input = xTest.ToString() + " " + yTest.ToString() + " " + rot;
            m1.SetPosition(input);

            // Act
            m1.Action("MRM");
            xTest++;
            yTest++;

            // Asset
            Assert.IsTrue(m1.GetPosition()[0] == xTest);
            Assert.IsTrue(m1.GetPosition()[1] == yTest);
        }

        [TestMethod(), TestCategory("Move and Settlement")]
        public void ActionTest_NoMove_RotateExpectedPoint()
        {
            // Arrange
            var m1 = new MarsRover();
            m1.CreateSurface("3 3");
            Int32 xTest = 1, yTest = 1;
            string rot = "n", input = xTest.ToString() + " " + yTest.ToString() + " " + rot;
            m1.SetPosition(input);

            // Act
            m1.Action("RRLRRLRR");

            // Asset
            Assert.IsTrue((m1.GetRotation() == rot.ToLower()) || (m1.GetRotation() == rot.ToUpper()));
        }
    }
}