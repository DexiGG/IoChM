using IoCConteiners.Models;
using IoCConteiners.Resipository;
using IoCConteiners.Resipository.Implementation;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoCNinject.Module
{
    public class NModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepository<>)).To(typeof(SqlRepository<>));
        }
    }
}