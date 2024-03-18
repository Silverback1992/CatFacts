using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFacts.Domain.Entities
{
    public class CatFactWithPicture
    {
        public int Id { get; set; }
        public string CatFact { get; set; }
        public string CatPicturePath { get; set; }
    }
}
