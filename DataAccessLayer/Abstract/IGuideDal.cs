using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGuideDal: IGenericDal<Guide>
    {
        //bu özellikleri IGenericDal<Guide> koduyla miras aldık.
        //void Insert(Guide guide);
        //void Delete(Guide guide);
        //void Update(Guide guide);
        //List<Guide> GetList();
    }
}
