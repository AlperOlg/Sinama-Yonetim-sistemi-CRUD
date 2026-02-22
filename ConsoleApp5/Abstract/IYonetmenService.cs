using ConsoleApp5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Abstract
{
    public interface IYonetmenService : IEntityRepository<Yonetmen>
    {
        Task UpdateDirectorWithIDAsync(int yonetmenID, string? yonetmenAdi = null, string? yonetmenSoyadi = null, int? yonetmenYasi = null);
    }
}
