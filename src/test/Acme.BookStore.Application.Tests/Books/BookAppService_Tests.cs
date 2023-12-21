using Shouldly;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Xunit;

namespace Acme.BookStore.Books;


public class BookAppService_Tests 
{
    private readonly IBookAppService _bookAppService;

    public BookAppService_Tests()
    {
        
    }

    [Fact]
    public async Task Should_Get_List_Of_Books()
    {
        //Act
        var result = await _bookAppService.GetListAsync(
            new PagedAndSortedResultRequestDto()
        );

        //Assert
        result.TotalCount.ShouldBeGreaterThan(0);
        result.Items.ShouldContain(b => b.Name == "1984");
    }
}
