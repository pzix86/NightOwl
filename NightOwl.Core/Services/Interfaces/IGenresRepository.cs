﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Core.Services.Interfaces
{
    public interface IGenresRepository
    {
        List<Genres> GetAllGenres();
        string GetGenreNameByGenreId(int genreId);
        void AddNewGenre(Genres genre);
        Genres GetGenreByGenreId(int genreId);
        void UpdateGenre(Genres genre);
        Genres GetGenreAsNoTracking(int genreId);
        void RemoveGenre(Genres genre);
    }
}
