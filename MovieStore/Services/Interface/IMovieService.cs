﻿using MovieStore.Data;
using MovieStore.Models.ViewModel;

namespace MovieStore.Services.Interface
{
	public interface IMovieService
	{
		bool Add(Movie model);
		bool Update(Movie model);
		Movie GetById(int id);
		bool Delete(int id);
		MovieListVm List(string term = "", bool paging = false, int currentPage = 0);
		List<int> GetGenreByMovieId(int movieId);

	}
}
