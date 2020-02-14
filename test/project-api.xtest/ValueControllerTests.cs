using System.Collections.Generic;
using project_api.Controllers;
using Xunit;

namespace Aproject_api.xtest
{
    public class ValuesControllerTests
    {
        [Fact]
        public void ValuesController_GetWithoutId_ReturnsAllValues()
        {
            //arrange
            List<string> expectedResult = new List<string> { "value1", "value2" };
            var valuesController = new ValuesController();

            //act
            IEnumerable<string> actualResult = valuesController.Get();

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ValuesController_GetWithId_ReturnsAllValues()
        {
            //arrange
            string expectedResult = "value";
            const int itemId = 1;
            var valuesController = new ValuesController();

            //act
            string actualResult = valuesController.Get(itemId);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ValuesController_PostValue_DoesNotThrowException()
        {
            //arrange
            var valuesController = new ValuesController();

            //act
            var exception = Record.Exception(() => valuesController.Post("value"));

            //assert
            Assert.Null(exception);
        }

        [Fact]
        public void ValuesController_PutValue_DoesNotThrowException()
        {
            //arrange
            var valuesController = new ValuesController();

            //act
            var exception = Record.Exception(() => valuesController.Put(1, "value"));

            //assert
            Assert.Null(exception);
        }

        [Fact]
        public void ValuesController_DeleteValue_DoesNotThrowException()
        {
            //arrange
            var valuesController = new ValuesController();

            //act
            var exception = Record.Exception(() => valuesController.Delete(1));

            //assert
            Assert.Null(exception);
        }
    }
}