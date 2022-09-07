using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F = ETicaretAPI.Domain.Entities.Table_Hierarchy;

namespace ETicaretAPI.Application.Repositories
{
    public interface IFileReadRepository: IReadRepository<F.File>

    {
    }
}
