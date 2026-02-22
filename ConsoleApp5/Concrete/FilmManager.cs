using ConsoleApp5.Abstract;
using ConsoleApp5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Concrete
{
    public class FilmManager : EntityRepository<SinamaDbContext, Film>, IFilmService
    {
        private readonly SinamaDbContext _context;
        public FilmManager(SinamaDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<ICollection<Film>> GetFilmWithDirectorIDAsync(int ID)
        {
            ICollection<Film>? films = await _context.Filmler.Include(f => f.Yonetmen).Where(f => f.Yonetmen.ID == ID).ToListAsync();
            if (films.Count <= 0) { throw new ArgumentNullException(); }
            return films;
        }
        public async Task UpdateFilmWithIDAsync(int filmID,int yonetmenID ,string filmAd = null, DateTime? cikisTarih = null)
        {
            if (filmID == 0) { throw new ArgumentNullException("ID girişi zorunlu"); }
            Film? film = await _context.Filmler.FindAsync(filmID);
            if (film == null) throw new KeyNotFoundException("Film bulunamadı");
            if (!string.IsNullOrWhiteSpace(filmAd))
                film.Name = filmAd;
            if (yonetmenID <= 0)
                film.YonetmenID = yonetmenID;
            if (cikisTarih != null)
                film.ReleaseDate = cikisTarih.Value;
            await _context.SaveChangesAsync();
        }
    }
}
