﻿using System.Collections;
using System.Collections.Generic;

namespace SportsStore.Models.ViewsModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public string CurrentCategory { get; set; }

    }
}
