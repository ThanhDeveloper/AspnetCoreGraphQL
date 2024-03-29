﻿using SuperHeroApi.Models;

namespace SuperHeroApi.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) =>
            context.Superheroes;
        public IQueryable<Movie> GetMovies([Service] ApplicationDbContext context) =>
            context.Movies;
    }
}
