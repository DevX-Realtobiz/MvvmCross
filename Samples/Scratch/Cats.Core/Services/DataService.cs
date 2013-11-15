using System;
using System.Collections.Generic;
using Cirrious.MvvmCross.Plugins.Sqlite;
using Cats.Core.Models;
using System.Linq;

namespace Cats.Core.Services
{
	public class DataService : IDataService
	{
		private readonly ISQLiteConnection _connection;

		public DataService(ISQLiteConnectionFactory factory)
		{
			_connection = factory.Create("breeds.sql");
			_connection.CreateTable<Breed>();
		}

		public List<Breed> BreedsMatching(string nameFilter)
		{
			return _connection.Table<Breed>()
					.OrderBy(x => x.Name)
					.Where(x => x.Name.Contains(nameFilter))
					.ToList();
		}

		public void Insert(Breed breed)
		{
			_connection.Insert(breed);
		}

		public void Update(Breed breed)
		{
			_connection.Update(breed);
		}

		public void Delete(Breed breed)
		{
			_connection.Delete(breed);
		}

		public int Count
		{
			get
			{
				return _connection.Table<Breed>().Count();
			}
		}	}
}

