using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjectionDemo.Pages
{
    public class DIModel : PageModel
    {

        public SingeltonClass Singelton;
        public TransientClass Transient;
        public ScopedClass Scoped;
        public DIModel(SingeltonClass singelton,TransientClass transient,ScopedClass scoped)
        {
            Singelton = singelton;
            Transient = transient;
            Scoped = scoped;
        }
        public void OnGet()
        {
        }
    }
}
