using Structural.Proxy.Interfaces;
using Structural.Proxy.Models;

namespace Structural.Proxy.Repositories
{
    internal class MangaRepository : IMangaRepository
    {
        private readonly List<Manga> AllMangas = [
            new Manga(1, "Naruto", 8.08f),
            new Manga(2, "One Piece", 9.22f),
            new Manga(3, "Attack on Titan", 8.55f),
            new Manga(4, "Vagabond", 9.27f),
            new Manga(5, "Umineko no Naku Koro ni Chiru - Episode 8: Twilight of the Golden Witch", 8.9f)
        ];

        public Manga GetById(int id)
        {
            // Simulate a delay to mimic a slow data source
            Thread.Sleep(5000);

            return AllMangas.FirstOrDefault(manga => manga.Id == id)!;
        }
    }
}
