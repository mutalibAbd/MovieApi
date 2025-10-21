using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.CQRSDesignPattern.Commands.CatagoryCommands
{
    public class RemoveCatagoryCommand
    {
        public RemoveCatagoryCommand(int catagoryId)
        {
            CatagoryId = catagoryId;
        }

        public int CatagoryId { get; set; }

    }
}
