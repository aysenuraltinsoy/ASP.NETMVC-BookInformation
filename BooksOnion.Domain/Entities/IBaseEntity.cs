using BooksOnion.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksOnion.Domain.Entities
{
    public interface IBaseEntity
    {
        DateTime CreatedDate { get; set; }
        DateTime? UpdatedDate { get; set;}
        DateTime? DeletedDate { get; set; }
        Status  Status { get; set; }
    }
}
