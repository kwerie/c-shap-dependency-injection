﻿using Module2.AfterDI.Source;
using Module2.AfterDI.Target;

namespace Module2.AfterDI;
public class ProductImporter
{
    private readonly IProductSource _productSource;
    private readonly IProductTarget _productTarget;

    public ProductImporter(IProductSource productSource, IProductTarget productTarget)
    {
        _productSource = productSource;
        _productTarget = productTarget;
    }

    public void Run()
    {
        _productSource.Open();
        _productTarget.Open();

        while (_productSource.hasMoreProducts())
        {
            var product = _productSource.GetNextProduct();
            _productTarget.AddProduct(product);
        }

        _productSource.Close();
        _productTarget.Close();
    }
}