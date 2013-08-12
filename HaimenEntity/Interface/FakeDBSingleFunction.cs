using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaimenEntity.Interface
{
    public class FakeDBSingleFunction<T> : IDBSingleFunction<T> where T : new()
    {
        public bool Verify()
        {
            throw new NotImplementedException();
        }

        public List<KeyValuePair<string, dynamic>> GetFieldsAndValues()
        {
            throw new NotImplementedException();
        }

        public string GetTableName(Type t)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Insert()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }

        public List<T> Find(string where = "")
        {
            throw new NotImplementedException();
        }

        public List<T> Query(string where = "")
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Destory()
        {
            throw new NotImplementedException();
        }

        public T CreateByID(long id)
        {
            throw new NotImplementedException();
        }
    }
}
