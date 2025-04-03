using Structural.Proxy.Interfaces;
using Structural.Proxy.Models;
using Structural.Proxy.Repositories;

namespace Structural.Proxy
{
    internal class MangaRepositoryProxy(MangaRepository mangaRepository) : IMangaRepository
    {
        private readonly Dictionary<int, Manga> _mangasCache = [];

        public Manga GetById(int id)
        {
            if (_mangasCache.TryGetValue(id, out var mangaFromCache))
            {
                return mangaFromCache;
            }
            else
            {
                var mangaFromDatabase = mangaRepository.GetById(id)
                    ?? throw new Exception($"Manga with Id {id} not found.");

                _mangasCache.Add(id, mangaFromDatabase);

                return mangaFromDatabase;
            }
        }
    }
}
