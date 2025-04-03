using Structural.Proxy.Models;

namespace Structural.Proxy.Interfaces
{
    internal interface IMangaRepository
    {
        Manga GetById(int id);
    }
}
