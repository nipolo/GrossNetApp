using GrossNetApp.Sellary.Services;
using GrossNetApp.Sellary.Taxes;
using Autofac;

namespace GrossNetApp.Sellary
{
    public class SellaryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SellaryService>().As<ISellaryService>();
            builder.RegisterType<IncomeTax>().As<ITaxRule>();
            builder.RegisterType<SocialContributionsTax>().As<ITaxRule>();
        }
    }
}
