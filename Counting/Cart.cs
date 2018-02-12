﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   public class Cart<T>:ICountable
    {
        List<T> Items = new List<T>();

        public void Add(T item)
        {
            Items.Add(item);
        }

        public void Add(IEnumerable<T> items)
        {
            this.Items.AddRange(items);
        }

        public int Count()
        {
            return Items.Count();
        }
    }
}
