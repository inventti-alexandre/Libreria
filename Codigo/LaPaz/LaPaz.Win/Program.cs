using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.Comun.Validation;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Seguridad;
using LaPaz.Win;
using LaPaz.Win.Forms;
using LaPaz.Win.Forms.Autenticacion;
using LaPaz.Win.Forms.Util;
using LaPaz.Win.Forms.Proveedores;
using LaPaz.Win.Infrastructure.Task;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.NamedScope;
using Telerik.WinControls;
using log4net;

namespace LaPaz.Win
{

    static class Program
    {
        private static IMessageBoxDisplayService MessageBoxDisplayService;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

#if (!DEBUG)
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ApplicationOnThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
#endif

            AutoMapperConfig.Execute();
            MetadataTypesRegister.InstallForThisAssembly();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            using (var kernel = new StandardKernel())
            {
                //Configurar bindings
                DIConfig.Configure(kernel);

                //Set global container.
                Ioc.Container = new NinjectIocContainer(kernel);

                //Config log4net
                log4net.Config.DOMConfigurator.Configure();

                MessageBoxDisplayService = Ioc.Container.Get<IMessageBoxDisplayService>();

                //Create a custom principal with an anonymous identity at startup
                var laPazPrincipal = new LaPazPrincipal();
                AppDomain.CurrentDomain.SetThreadPrincipal(laPazPrincipal);

#if(MOCK_SECURITY)
                MockUser();
#else
                using (var login = kernel.Get<FrmLogin>())
                {
                    var result = login.ShowDialog();

                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                        return;
                    } 
                }
#endif

                RunAfterLoginTasks();

                var mainForm = kernel.Get<FrmPrincipal>();

                Application.Run(mainForm);
            }
        }

        private static void RunAfterLoginTasks()
        {
            if (Thread.CurrentPrincipal.Identity.IsAuthenticated)
            {
                foreach (var task in Ioc.Container.GetAll<IRunAfterLogin>())
                {
                    task.Execute();
                }
            }
        }

        private static void MockUser()
        {
            using (var uow = Ioc.Container.Get<ILaPazUow>())
            {
                var defaultUserId = Guid.Parse("4FB4CAF7-9FD7-4A39-BF85-B60F14C2E7AB");
                var defaultSucursalId = 2;

                //Validate credentials through the authentication service
                Operador user = uow.Operadores.Obtener(o => o.Id == defaultUserId, o => o.Roles,
                                                            o => o.Personal,
                                                            o => o.Personal.Provincia,
                                                            o => o.Personal.Localidad,
                                                            o => o.OperadorSucursals.Select(op => op.Sucursal));

                Sucursal sucursal = uow.Sucursales.Obtener(s => s.Id == defaultSucursalId);

                //Get the current principal object
                LaPazPrincipal laPazPrincipal = Thread.CurrentPrincipal as LaPazPrincipal;
                if (laPazPrincipal == null)
                    throw new ArgumentException("The application's default thread principal must be set to a CustomPrincipal object on startup.");

                //Authenticate the user
                laPazPrincipal.Identity = new LaPazIdentity(user, sucursal);
            }
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            var mensaje = GetGlobalExeptionMessage((Exception)unhandledExceptionEventArgs.ExceptionObject);
            MessageBoxDisplayService.ShowError(mensaje);
            Application.Exit();
        }

        private static string GetGlobalExeptionMessage(Exception ex)
        {
            LogManager.GetLogger("errors").Error(ex);

            var mensaje = string.Format("Ha ocurrido un error.\r\n\n" +
                                        "{0}\r\n\n" +
                                        "por favor contactese con soporte",
                                        ex.Message);

            return mensaje;
        }

        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs threadExceptionEventArgs)
        {
            var mesange = GetGlobalExeptionMessage(threadExceptionEventArgs.Exception);
            MessageBoxDisplayService.ShowError(mesange);
        }
    }
}
