using System;

namespace DependencyInjectionDemo.Services
{
    public interface IBaseClass
    {
        DateTime GetDate();
        int GetInt();
        void Refresh();
    }
}