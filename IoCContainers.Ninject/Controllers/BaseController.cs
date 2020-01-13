using IoCNinject.Module;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IoCNinject.Controllers
{
    public class BaseController:Controller
    {
        protected IKernel kernel;
        public BaseController()
        {
            kernel = new StandardKernel(new NModule());
        }
    }
}