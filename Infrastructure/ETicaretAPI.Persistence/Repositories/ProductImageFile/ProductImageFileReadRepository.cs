﻿using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F = ETicaretAPI.Domain.Entities.Table_Hierarchy;

namespace ETicaretAPI.Persistence.Repositories
{
    public class ProductImageFileReadRepository : ReadRepository<F::ProductImageFile>, IProductImageFileReadRepository
    {
        public ProductImageFileReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
