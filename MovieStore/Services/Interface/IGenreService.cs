using MovieStore.Data;
using MovieStore.Models.ViewModel;

namespace MovieStore.Services.Interface
{
	public interface IGenreService
	{
		bool Add(Genre model);
		bool Update(Genre model);
		Genre GetById(int id);
		bool Delete(int id);
		IQueryable<Genre> List();

	}
}
