﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D7.GenericClassNedir_1
{
    public class genericRepository<T> where T:class
    {
        public genericRepository()
        {
            // context : EF DBFirst 
        }

        public virtual List<T> Getir()
        {
            // Gelen T tipini database üzerinden sorgulamak ve elde etmiş olduğum kayıtları generic koleksiyon olarak bir ust katmana dönmek... 
            return null;
        }

        public virtual void yeniKayitEkle(T data)
        {
            // bize gelen T tipi içerisindeki bilgiyi T tipinin işaret etmiş olduğu tabloya ekliyoruz... 
        }
    }
}
