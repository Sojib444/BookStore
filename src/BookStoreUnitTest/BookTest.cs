using Acme.BookStore.Books;
using Moq;
using Volo.Abp.Application.Dtos;

namespace BookStoreUnitTest
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void GetBooks_Test()
        {
            //Arrange
            var mockBookService = new Mock<IBookAppService>();

            var inputRequest = new PagedAndSortedResultRequestDto { Sorting = "asc" };

            var bookService = new BookService(mockBookService.Object);

            //Act
            Task<PagedResultDto<BookDto>> pagedResultDto = bookService.GetBooks(inputRequest);

            //Assert
            Assert.IsNotNull(pagedResultDto);
        }
    }
}