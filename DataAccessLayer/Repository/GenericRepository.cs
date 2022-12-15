using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    //Generic yapı için aşağıdaki metotu yazarız, impelant ederiz.
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            //throw new NotImplementedException();

            using var c = new Context();
            c.Remove(t);
            c.SaveChanges(); //bu satırı yazmaksak, silme işlemini uygular, ama veri tabanına yansımaz.
        }

        public T GetByID(int id)
        {
            //throw new NotImplementedException();

            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            //throw new NotImplementedException();

            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            // throw new NotImplementedException();

            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            //throw new NotImplementedException();

            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
