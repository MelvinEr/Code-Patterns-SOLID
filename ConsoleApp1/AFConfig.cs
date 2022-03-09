using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace ConsoleApp1
{
    class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register Main Application
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<PetHandler>().As<IPetHandler>();
            builder.RegisterType<CustomerHandler>().As<ICustomerHandler>();

            builder.RegisterType<ListDB>().As<IListDB>().SingleInstance();

            builder.RegisterType<Customer>();
            builder.RegisterType<Pet>();
            builder.RegisterType<Service>();

            return builder.Build();
        }
    }
}
