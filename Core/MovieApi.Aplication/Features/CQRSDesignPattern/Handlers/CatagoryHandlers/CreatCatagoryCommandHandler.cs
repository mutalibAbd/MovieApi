using System;
using System.Collections.Generic;
using MovieApi.Persistence.Context;
using MovieApi.Domain.Entites;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApi.Aplication.Features.CQRSDesignPattern.Commands.CatagoryCommands;
// bu classin amaci catagory olusturmak 
namespace MovieApi.Aplication.Features.CQRSDesignPattern.Handlers.CatagoryHandlers
{
    public class CreatCatagoryCommandHandler
    {
        private readonly MovieContext _context; // MovieContext veritabanı bağlamını temsil eder

        public CreatCatagoryCommandHandler(MovieContext context)//standart constructor
        {
            _context = context; // Bağlamı sınıfın özel alanına atar
        }

        public async void Handle (AddCatagoryCommand command) // Catagory ekleme işlemini gerçekleştirir
        {
            _context.Categories.Add(new Catagory
            {
                CatagoryName = command.CatagoryName // Komuttan gelen kategori adını kullanarak yeni bir kategori oluşturur
            });
            await _context.SaveChangesAsync(); // Değişiklikleri veritabanına kaydeder
        }
        
    }
}
