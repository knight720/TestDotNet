using System;
using Autofac;
using Autofac.Extras.DynamicProxy;

namespace Autofac_AOP
{
    internal class Program
    {
        private ContainerBuilder _builder;
        private IContainer _container;

        private static void Main(string[] args)
        {
            // Reference
            // http://autofaccn.readthedocs.io/en/latest/advanced/interceptors.html#create-interceptors

            var p = new Program();

            p.Run();

            // Interface
            // Success
            //p.Register2();
            //p.Run2();

            // Class
            // Fail
            //p.Register3();
            //p.Run3();

            // No Interface Attribute on Method Fail
            // Must On Class
            // Method Must Virtual
            p.Register4();
            p.Run4();

            Console.ReadLine();
        }

        private void Run()
        {
            var c = new ClassA();
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

        private void Run2()
        {
            var c = this._container.Resolve<IClass>();
            c.MethodOne();
        }

        private void Register3()
        {
            this._builder = new ContainerBuilder();

            this._builder.RegisterType<ClassA>()
                .EnableClassInterceptors();

            this._builder.Register(c => new DataCache());

            this._container = this._builder.Build();
        }

        private void Run3()
        {
            var c = this._container.Resolve<ClassA>();
            c.MethodOne();
        }

        private void Register4()
        {
            this._builder = new ContainerBuilder();

            this._builder.RegisterType<ClassB>()
                .EnableClassInterceptors();

            this._builder.Register(c => new DataCache());

            this._container = this._builder.Build();
        }

        private void Run4()
        {
            var c = this._container.Resolve<ClassB>();
            c.MethodOne();
            c.MethodTwo();
        }
    }
}