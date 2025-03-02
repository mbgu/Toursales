﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDestinationDal: IGenericDal<Destination>
    {
        //bu özellikleri IGenericDal<Destination> koduyla miras aldık.
        //void Insert(Destination destination);
        //void Delete(Destination destination);
        //void Update(Destination destination);
        //List<Destination> GetList();
    }
}
