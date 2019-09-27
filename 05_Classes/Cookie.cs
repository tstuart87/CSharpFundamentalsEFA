﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Cookie
    {

        // 'ctor'-tab-tab to set up the Cookie() constructor
        public Cookie(string name, string ingredient, string size, string direction, string shape, int batchSize)
        {
            Name = name;
            Ingredient = ingredient;
            Size = size;
            Direction = direction;
            Shape = shape;
            BatchSize = batchSize;
        }

        public Cookie()
        {

        }


        // 'prop'-tab-tab to start a new property.
        public string Name { get; set; }
        public string Ingredient { get; set; }
        public string Size { get; set; }
        public string Direction { get; set; }
        public string Shape { get; set; }
        public int BatchSize { get; set; }

        public void SetSize()
        {
            if(Size == "Big")
            {
                BatchSize = 1;
            }
        }
    }
}
