﻿namespace api.Dtos.ProductCategory
{
    public class ProductCategoryQueryDTO
    {
        public string? Name { get; set; } = string.Empty;
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 12;
    }
}
