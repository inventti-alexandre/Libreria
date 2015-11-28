using System;
using Entidades.Migracion;
using Framework.Comun.Utility;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Datos.Repositorio;
using LaPaz.Seguridad;
using LaPaz.Seguridad.Interfaces;
using LaPaz.Win.Factory;
using LaPaz.Win.Helpers;
using LaPaz.Win.Infrastructure.Task;
using Ninject;
using Ninject.Activation;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.NamedScope;

namespace LaPaz.Win
{
    public class DIConfig
    {
        public static void Configure(StandardKernel kernel)
        {
            kernel.Bind(x => x.FromAssembliesMatching("LaPaz.*")
                                 .SelectAllClasses()
                                 .BindAllInterfaces()
                                 .Configure(c => c.InCallScope()));

            kernel.Bind(x => x.FromThisAssembly()
                                 .SelectAllInterfaces()
                                 .EndingWith("Factory")
                                 .BindToFactory()
                                 .Configure(c => c.InSingletonScope()));

            kernel.Bind(x => x.FromThisAssembly()
                                 .SelectAllInterfaces()
                                 .Including<IRunAfterLogin>()
                                 .BindAllInterfaces()
                                 .Configure(c => c.InSingletonScope()));

            kernel.Bind<IIocContainer>().To<NinjectIocContainer>().InSingletonScope();
            kernel.Bind<IClock>().To<Clock>().InSingletonScope();
            kernel.Bind<IMessageBoxDisplayService>().To<MessageBoxDisplayService>().InSingletonScope();

            //Custom Factories
            kernel.Rebind<ICajaMovientoFactory>().To<CajaMovimientoFactory>();

            //Overide defaults bindings.
            kernel.Unbind<ILaPazContext>();
            kernel.Bind<ILaPazContext>().To<LaPazContext>().InSingletonScope();

            kernel.Unbind<IFormRegistry>();
            kernel.Bind<IFormRegistry>().To<FormRegistry>().InSingletonScope();

            kernel.Unbind<IEncryptionService>();
            kernel.Bind<IEncryptionService>().To<EncryptionService>().InSingletonScope();

            kernel.Bind<IRepository<TituloStockMigracion>>().To<EFRepository<TituloStockMigracion>>()
                  .WithConstructorArgument("dbContext", (p) =>
                                                          {
                                                              var dbContext = new MigracionLaPazEntities();

                                                              // Do NOT enable proxied entities, else serialization fails
                                                              dbContext.Configuration.ProxyCreationEnabled = false;

                                                              // Load navigation properties explicitly (avoid serialization trouble)
                                                              dbContext.Configuration.LazyLoadingEnabled = false;

                                                              // Because Web API will perform validation, we don't need/want EF to do so
                                                              dbContext.Configuration.ValidateOnSaveEnabled = false;

                                                              return dbContext;
                                                          });
        }
    }

    //public class ShareProvider : IProvider<ILaPazUow>
    //{
    //    public object Create(IContext context)
    //    {
    //        var isDisposed = LaPazUow != null && LaPazUow.IsDisposed;

    //        if (isDisposed)
    //            LaPazUow = null;
            
    //        if (LaPazUow == null)
    //        {
    //            LaPazUow = context.Kernel.Get<ILaPazUow>();
    //        }

    //        return LaPazUow;
    //    }

    //    public Type Type
    //    {
    //        get { return typeof(ILaPazUow); }
    //    }

    //    public ILaPazUow LaPazUow { get; set; }
    //}   
}
