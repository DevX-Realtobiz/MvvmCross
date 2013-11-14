using System;
using Cirrious.MvvmCross.Plugins.Sqlite;

namespace Cats.Core.Models
{
	public class Breed
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Wiki { get; set; }
		public string Country { get; set; }
		public string Origin { get; set; }
		public string BodyType { get; set; }
		public string Coat { get; set; }
		public string Pattern { get; set; }
		public string Image { get; set; }
	}
}

