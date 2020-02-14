using System.Collections.Generic;
using project_api.Controllers;
using NUnit.Framework;
using System;

namespace Aproject_api.ntest
{
    public class ValuesControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValuesController_GetWithoutId_ReturnsAllValues()
        {
            //arrange
            List<string> expectedResult = new List<string> { "value1", "value2" };
            var valuesController = new ValuesController();

            //act
            IEnumerable<string> actualResult = valuesController.Get();

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ValuesController_GetWithId_ReturnsAllValues()
        {
            //arrange
            string expectedResult = "value";
            const int itemId = 1;
            var valuesController = new ValuesController();

            //act
            string actualResult = valuesController.Get(itemId);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ValuesController_PostValue_DoesNotThrowException()
        {
            //arrange
            var valuesController = new ValuesController();

            //act & assert
            Assert.DoesNotThrow(() => valuesController.Post("value"));
        }

        [Test]
        public void ValuesController_PutValue_DoesNotThrowException()
        {
            //arrange
            var valuesController = new ValuesController();

            //act & assert
            Assert.DoesNotThrow(() => valuesController.Put(1, "value"));
        }

        [Test]
        public void ValuesController_DeleteValue_DoesNotThrowException()
        {
            //arrange
            var valuesController = new ValuesController();

            //act & assert
            Assert.DoesNotThrow(() => valuesController.Delete(1));
        }
    }
}