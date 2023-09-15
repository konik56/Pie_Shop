using System;
using BethanysPieShop.Models;
namespace BethanysPieShop.ViewModels
	
{
	public class PieListViewModel
	{
		public IEnumerable<Pie> Pies { get; }
		public string? currentCategory { get; }

		public PieListViewModel(IEnumerable<Pie> pies, string? category)
		{
			Pies = pies;
			currentCategory = category;
		}
	}
}

