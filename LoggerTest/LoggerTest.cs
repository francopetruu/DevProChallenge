using NUnit.Framework.Legacy;
using static Logger; 
using System;

namespace LoggerTest
{
    public class Tests
    {
        private string testFilePath;

        [SetUp]
        public void Setup()
        {
            testFilePath = Path.Combine(Path.GetTempPath(), "test.log");           
        }

        [TearDown]
        public void TearDown()
        {
            // Eliminar el archivo de prueba después de cada prueba
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }

        [Test]
        public void LogMessage_WritesCorrectMessage()
        {
            // Arrange
            string expectedMessage = "[INFO] Test message";

            // Act
            Logger.LogMessage(testFilePath, "Test message", LogLevel.INFO);

            // Assert
            string[] logContents = File.ReadAllLines(testFilePath);
            StringAssert.Contains(expectedMessage, logContents[0]);
        }

        [Test]
        public void LogMessage_AppendsMessage()
        {
            // Arrange
            Logger.LogMessage(testFilePath, "First message", Logger.LogLevel.INFO);
            Logger.LogMessage(testFilePath, "Second message", Logger.LogLevel.ERROR);

            // Act
            string[] logContents = File.ReadAllLines(testFilePath);

            // Assert
            Assert.That(logContents.Length, Is.EqualTo(2));
            StringAssert.Contains("[INFO] First message", logContents[0]);
            StringAssert.Contains("[ERROR] Second message", logContents[1]);
        }
    }
}