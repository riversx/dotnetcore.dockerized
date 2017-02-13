using System.Collections.Generic;
using AspDotnetCoreProject.Controllers;
using Xunit;

namespace AspDotnetCoreProject.Tests
{
    public class ValuesControllerTests
    {
        [Fact]
        public void DoesSomethingCorrectly() 
        {
            List<string> expectedResult = new List<string> { "value1", "value2" };
            var valuesController = new ValuesController();

            IEnumerable<string> actualResult = valuesController.Get();

            Assert.Equal(expectedResult, actualResult);
        }
   }
}