using Autofac;

namespace ConsoleApp1
{
    public class SubAService
    {
        private ILifetimeScope _lifetimeScope;
        private SubBService _subBService;

        public SubAService(ILifetimeScope lifetimeScope, SubBService subBService)
        {
            _lifetimeScope = lifetimeScope;
            _subBService = subBService;
            Locator.Register(_lifetimeScope.Resolve<Client>());
        }

        internal void Run()
        {
            Locator.GetInstance();
            _subBService.Run();
        }
    }
}