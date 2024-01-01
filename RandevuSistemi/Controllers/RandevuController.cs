using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RandevuSistemi.Models;
using RandevuSistemi.Models.Entities;
using System;
using System.Linq;

namespace RandevuSistemi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandevuController : ControllerBase
    {
        private readonly Context context;

        public RandevuController(Context dbContext)
        {
            context = dbContext;
        }

        [HttpGet("BoşRandevuVarMı")]
        public IActionResult BoşRandevuVarMı(int doctorId, DateTime randevuTarihi)
        {
            // Belirli bir doktor ve tarih için randevuları getir
            var randevular = context.Randevular
                .Where(r => r.DoctorId == doctorId && r.RandevuSaati.Date == randevuTarihi.Date)
                .ToList();

            // Eğer randevu yoksa, "Boş randevu var" mesajını döndür
            if (randevular.Count == 0)
            {
                return Ok("Boş randevu var");
            }

            // Eğer randevu varsa, "Boş randevu yok" mesajını döndür
            return Ok("Boş randevu yok");
        }
    }
}
