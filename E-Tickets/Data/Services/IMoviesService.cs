﻿using E_Tickets.Data.Base;
using E_Tickets.Models;

namespace E_Tickets.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);

        Task DeleteMovieAsync(int id);



    }
}