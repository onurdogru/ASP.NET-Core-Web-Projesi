using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        //2) Ek işlemler
        IAboutDal  _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }




        //1) Implement işlemleri
        public void TAdd(About t)
        {
            //throw new NotImplementedException();

            _aboutDal.Insert(t);

        }

        public void TDelete(About t)
        {
            //throw new NotImplementedException();
            _aboutDal.Delete(t);
        }

        public About TGetByID(int id)
        {
            //throw new NotImplementedException();
            return _aboutDal.GetByID(id);


        }

        public List<About> TGetList()
        {
          //  throw new NotImplementedException();
          return _aboutDal.GetList();
        }

        public void TUpdate(About t)
        {
            //throw new NotImplementedException();
            //void oldugu için return'e ihtiyaç duymayız.
             _aboutDal.Update(t);
            //
        }
    }
}
