﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Core.Services.Interfaces
{
    public interface IMovieRepository
    {
        List<Items> GetMoviesByCategoryId(int categoryId);
        List<Items> GetLatestMovies();
        Items GetMovieDetailsByItemId(int itemId);
        List<Items> GetSimilarMovies(int genreId);
        List<Items> GetLatest();
        List<Items> GetMoviesByAge(string ageRating);
        List<Items> GetMoviesByQuality(string quality);
        List<Items> GetMoviesByGenreId(int genreId);
        List<Items> GetMoviesByReleaseYear(string year);
        List<Items> GetMoviesByActorName(string actorName);
        List<Items> GetMoviesBySearchPhrase(string searchPhrase);
        List<Items> GetNewMovies();
        List<Items> GetNewSeries();
        List<Items> GetNewAnimations();
        List<Items> GetComingSoon();
        int GetTotalMovies();
        int GetTotalSeries();
        int GetTotalComingSoon();
        Items GetItemByItemId(int itemId);
        void AddNewItem(Items item);
        void SaveChanges();
        Items GetItemAsNoTracking(int itemId);
        void UpdateItem(Items item);
        void Remove(Items item);
        IEnumerable<Download> GetDownloadLinksByItemId(int itemId);
        Download GetDownloadLinkDetails(int downloadId);
        void UpdateDownloadDetails(Download download);
        void UploadNewDownload(Download download);
        void RemoveDownloadLink(Download download);
        Download GetDownloadAsNoTracking(int downloadId);

    }
}
