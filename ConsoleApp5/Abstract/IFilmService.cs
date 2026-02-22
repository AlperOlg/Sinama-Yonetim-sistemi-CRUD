using ConsoleApp5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Abstract
{
    public interface IFilmService : IEntityRepository<Film>
    {
        Task<ICollection<Film>> GetFilmWithDirectorIDAsync(int ID);
        Task UpdateFilmWithIDAsync(int filmID, int yonetmenID ,string filmAd = null, DateTime? cikisTarih = null);
    }
}
