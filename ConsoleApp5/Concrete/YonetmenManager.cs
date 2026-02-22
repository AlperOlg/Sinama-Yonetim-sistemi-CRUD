using ConsoleApp5.Abstract;
using ConsoleApp5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Concrete
{
    public class YonetmenManager : EntityRepository<SinamaDbContext, Yonetmen>, IYonetmenService
    {
        private readonly SinamaDbContext _context;
        public YonetmenManager(SinamaDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task UpdateDirectorWithIDAsync(int yonetmenID, string? yonetmenAdi = null, string? yonetmenSoyadi = null, int? yonetmenYasi = null)
        {
            if (yonetmenID <= 0) { throw new Exception("Yönetmen IDsi 0dan büyük olmalı"); }
            Yonetmen? yonetmen= await _context.Yonetmenler.FindAsync(yonetmenID);
            if (yonetmen == null) { throw new Exception("Yönetmen bulunamadı"); }
            if (!string.IsNullOrWhiteSpace(yonetmenAdi))
                yonetmen.Name = yonetmenAdi;
            if (!string.IsNullOrWhiteSpace(yonetmenSoyadi))
                yonetmen.Surname = yonetmenSoyadi;
            if (yonetmenYasi != null)
                yonetmen.Age = (int)yonetmenYasi;
            await _context.SaveChangesAsync();
        }
    }
}
