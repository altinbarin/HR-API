using Autofac;
using Autofac.Extras.DynamicProxy;
using AutoMapper;
using Business.Abstract;
using Business.AutoMapper.EmployeeProfile;
using Business.AutoMapper.FirmProfile;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterType<EmployeeManager>().As<IEmployeeService>().SingleInstance();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>().SingleInstance();


            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<VocationLeaveRequestManager>().As<IVocationLeaveRequestService>().SingleInstance();
            builder.RegisterType<EfVocationRequestDal>().As<IVocationRequestDal>().SingleInstance();

            builder.RegisterType<SpendingRequestManager>().As<ISpendingRequestService>().SingleInstance();
            builder.RegisterType<EfSpendingRequestDal>().As<ISpendingRequestDal>().SingleInstance();


            builder.RegisterType<AdvanceRequestManager>().As<IAdvanceRequestService>().SingleInstance();
            builder.RegisterType<EfAdvanceRequestDal>().As<IAdvanceRequestDal>().SingleInstance();

            builder.RegisterType<FirmManager>().As<IFirmService>().SingleInstance();
            builder.RegisterType<EfFirmDal>().As<IFirmDal>().SingleInstance();

            builder.RegisterType<RequestApprovalStatusManager>().As<IRequestApprovalStatusService>().SingleInstance();
            builder.RegisterType<EfRequestApprovalStatusDal>().As<IRequestApprovalStatusDal>().SingleInstance();
            


            builder.Register(context => new MapperConfiguration(cfg =>
            {               
                cfg.AddProfile(new EmployeeProfile()
                    );
                cfg.AddProfile(new FirmProfile()
                    );
            })).AsSelf().SingleInstance();

            builder.Register(context => context.Resolve<MapperConfiguration>().CreateMapper())
                .As<IMapper>()
                .InstancePerLifetimeScope();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
