using System.Collections.Generic;
using AspDotnetCoreProject.Controllers;
using Xunit;

namespace AspDotnetCoreProject.Tests
{
    public class ValuesControllerTests
    {
        [Fact]
        public void ValuesController_GetWithoutId_ReturnsAllValues() 
        {
            List<string> expectedResult = new List<string> { "value1", "value2" };
            var valuesController = new ValuesController();

            IEnumerable<string> actualResult = valuesController.Get();

            Assert.Equal(expectedResult, actualResult);
        }

       [Fact]
       public void ValuesController_GetWithId_ReturnsAllValues() 
        {
            string expectedResult = "value";
            const int itemId = 1;
            var valuesController = new ValuesController();

            string actualResult = valuesController.Get(itemId);

            Assert.Equal(expectedResult, actualResult);
        }

       [Fact]
       public void ValuesController_PostValue_DoesNotThrowException() 
        {
            var valuesController = new ValuesController();

            var exception = Record.Exception(() => valuesController.Post("value"));

            Assert.Null(exception);
        }

       [Fact]
       public void ValuesController_PutValue_DoesNotThrowException() 
        {
            var valuesController = new ValuesController();

            var exception = Record.Exception(() => valuesController.Put(1,"value"));

            Assert.Null(exception);
        }

       [Fact]
       public void ValuesController_DeleteValue_DoesNotThrowException() 
        {
            var valuesController = new ValuesController();

            var exception = Record.Exception(() => valuesController.Delete(1));

            Assert.Null(exception);
        }
   }
}