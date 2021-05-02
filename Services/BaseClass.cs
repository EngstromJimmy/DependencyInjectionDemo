using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Services
{
    public class BaseClass : IBaseClass
    {
        public BaseClass()
        {
            Refresh();
        }


        DateTime InternalDate;
        int InternalRandom;
        public DateTime GetDate()
        {
            return InternalDate;
        }

        public int GetInt()
        {
            return InternalRandom;
        }

        public void Refresh()
        {
            Random rnd = new Random();
            InternalDate = DateTime.Now;
            InternalRandom = rnd.Next(1, 1337);
        }
    }
}
