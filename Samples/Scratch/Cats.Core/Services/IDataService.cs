using System;
using System.Collections.Generic;
using Cats.Core.Models;

namespace Cats.Core.Services
{
	public interface IDataService
	{
		List<Breed> BreedsMatching(string nameFilter);
		void Insert(Breed breed);
		void Update(Breed breed);
		void Delete(Breed breed);
		int Count { get; }
	}
}

