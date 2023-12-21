using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System.Threading.Tasks;

namespace Acme.BookStore.Books
{
    [TestClass]
    public class BookAppService_Tests
    {
        private readonly IBookAppService _bookAppService;

        [TestMethod]
        public async Task Should_Get_List_Of_Books()
        {
            //Act
            int a = 0;

            //Assert
            a.ShouldBeGreaterThan(0);
            //result.Items.ShouldContain(b => b.Name == "1984");
        }
    }
}
