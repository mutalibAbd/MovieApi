using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Aplication.Features.CQRSDesignPattern.Queries.CatagoryQueries
{
    public class GetCatagoryByIdQuery
    {
        public int CatagoryId { get; set; }
        public GetCatagoryByIdQuery(int catagoryId)
        {
            CatagoryId = catagoryId;
        }

        

    }
}
