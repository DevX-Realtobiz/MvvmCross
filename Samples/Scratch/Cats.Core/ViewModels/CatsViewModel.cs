using System;
using Cirrious.MvvmCross.ViewModels;
using Cats.Core.Services;
using Cats.Core.Models;
using System.Collections.Generic;

namespace Cats.Core.ViewModels
{
	public class CatsViewModel : MvxViewModel
	{	
		private string _title;
		public string Title
		{
			get { return _title; }
			set { _title = value; RaisePropertyChanged(() => Title); }
		}

		private string _filter = "";
		public string Filter
		{
			get { return _filter; }
			set { _filter = value; RaisePropertyChanged(() => Filter); }
		}

		private List<Breed> _breeds;
		public List<Breed> Breeds
		{
			get { return _breeds; }
			set { _breeds = value; RaisePropertyChanged(() => Breeds); }
		}

		private readonly IDataService _dataService;
	
		private void DoApplyFilter()
		{
			Breeds = _dataService.BreedsMatching (Filter);
		}

		public CatsViewModel (IDataService dataService)
		{
			_dataService = dataService;
			_title = "Cats";

			if (_dataService.Count == 0) {
				_dataService.Insert (new Breed () {
					Name = "Abyssinian",
					Wiki = "Abyssinian_(cat)",
					Country = "Egypt",
					Origin = "Natural",
					BodyType = "Oriental",
					Coat = "Short",
					Pattern = "Ticked",
					Image = "Gustav chocolate.jpg",
				});
				_dataService.Insert (new Breed () {
					Name = "Aegean",
					Wiki = "Aegean_cat",
					Country = "Greece",
					Origin = "Natural/Standard",
					BodyType = "",
					Coat = "Semi-long",
					Pattern = "Bi- or tri-colored",
					Image = "Aegean cat.jpg",
				});
			}

			DoApplyFilter ();
		}
	}
}

