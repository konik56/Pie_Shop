using System;
using BethanysPieShop.Controllers;
using BethanysPieShop.ViewModels;
using BethanysPieShopTests.Mocks;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShopTests.Controllers
{
	public class PieControllerTest
	{
		[Fact]
		public void List_Empty_Category_ReturnAllPies()
		{
			//arrange
			var mockPieRepository = RepositoryMocks.GetPieRepository();
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();

			PieController pieController = new PieController(mockPieRepository.Object, mockCategoryRepository.Object);

			//act
			var result = pieController.List("");

			// assert
			var viewResult = Assert.IsType<ViewResult>(result);

			var pieListViewModel = Assert.IsAssignableFrom<PieListViewModel>
				(viewResult.ViewData.Model);

			Assert.Equal(10, pieListViewModel.Pies.Count());
        }


    }
}

