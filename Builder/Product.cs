using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Product
    {
        private List<object> _parts;

        public Product()
        {
            _parts = new List<object> { Capacity = 4 };
        }

        public void Add(object part) => _parts.Add(part);

        public void Show()
        {
            StringBuilder productInfo = new StringBuilder();
            for (int i = 0; i < _parts.Count; i++)
            {
                productInfo.Append(_parts[i]);
                if (i < _parts.Count - 1)
                    productInfo.Append(" - ");                
            }
            Console.WriteLine(productInfo);
        }
    }
}
