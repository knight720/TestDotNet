using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extras.DynamicProxy;

namespace Autofac_AOP
{
    class Program
    {
        private ContainerBuilder _builder;
        private IContainer _container;

        static void Main(string[] args)
        {
            // Reference
            // http://autofaccn.readthedocs.io/en/latest/advanced/interceptors.html#create-interceptors

            var p = new Program();
            
            p.Run();

            // Success
            p.Register2();
            p.Run2();

            // Fail
            //p.Register3();
            //p.Run3();


            Console.ReadLine();

        }

        private void Run()
        {
            var c = new ClassA();
            c.MethodOne();
        }

        private void Run2()
        {
            var c = this._container.Resolve<IClass>();
            c.MethodOne();
        }

        private void Run3()
        {
            var c = this._container.Resolve<ClassA>();
            c.MethodOne();
        }

        private void Register2()
        {
            this._builder = new ContainerBuilder();

            this._builder.RegisterType<ClassA>()
                   .As<IClass>()
                   .EnableInterfaceInterceptors();

            this._builder.Register(c => new DataCache());

            this._container = this._builder.Build();
        }

        private void Register3()
        {
            this._builder = new ContainerBuilder();

            this._builder.RegisterType<ClassA>()
                .EnableClassInterceptors();

            this._builder.Register(c => new DataCache());

            this._container = this._builder.Build();
        }
    }
}
