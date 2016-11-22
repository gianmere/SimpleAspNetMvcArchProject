using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Autofac;
using SimpleAspNetMvcArchProject.Data;

namespace SimpleAspNetMvcArchProject.Modules
{
    

    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
         
            builder.RegisterType(typeof(SampleArchContext)).As(typeof(IContext)).InstancePerLifetimeScope();                 

        }

    }
}