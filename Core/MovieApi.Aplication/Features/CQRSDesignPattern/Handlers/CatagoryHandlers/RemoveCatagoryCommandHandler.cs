using MovieApi.Aplication.Features.CQRSDesignPattern.Commands.CatagoryCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.CQRSDesignPattern.Handlers.CatagoryHandlers
{
    // bu handler silme islemi icin kullanilacak ve CQRS patternine uygun olarak tasarlanacak 
    public class RemoveCatagoryCommandHandler
    {
        public readonly MovieContext _context; // MovieContext veritabanı bağlamını temsil eder
        public RemoveCatagoryCommandHandler(MovieContext context) //standart constructor
        {
            _context = context; // Bağlamı sınıfın özel alanına atar
        }

        public async Task Hanlder(RemoveCatagoryCommand command)
        {
            var value = await _context.Categories.FindAsync(command.CatagoryId); 
            // Komuttan gelen kategori id sini kullanarak silme islemi yapar
            _context.Categories.Remove(value);
            await _context.SaveChangesAsync(); // Değişiklikleri veritabanına kaydeder
        }
    }
}
