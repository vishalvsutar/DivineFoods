using System;
using CommunityToolkit.Mvvm.ComponentModel;
using DivineFoods.Models;

namespace DivineFoods.ViewModels
{
	public partial class MainViewModel : ObservableObject
	{
		[ObservableProperty]
		private IEnumerable<Category> _categories;
		private static IEnumerable<Category> LoadCategories()
		{
			return new List<Category>
			{
			};
		}

	}
}

