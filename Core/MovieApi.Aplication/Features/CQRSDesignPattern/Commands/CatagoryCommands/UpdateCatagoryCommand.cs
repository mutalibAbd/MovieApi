using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.CQRSDesignPattern.Commands.CatagoryCommands
{
    public class UpdateCatagoryCommand
    {
        public int CatagoryId { get; set; }

        public string CatagoryName { get; set; }
    }
}
