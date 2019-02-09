using Autofac;

namespace ConsoleApp1
{
    public class MainService
    {
        private ILifetimeScope _lifetimeScope;

        public MainService(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public void Run()
        {
            var subAService = _lifetimeScope.Resolve<SubAService>();
            Locator.Register(_lifetimeScope.Resolve<Client>());
            subAService.Run();
        }
    }
}