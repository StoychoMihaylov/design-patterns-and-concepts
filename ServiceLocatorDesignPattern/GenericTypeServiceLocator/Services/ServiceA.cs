namespace ServiceLocatorDesignPattern.GenericTypeServiceLocator.Services
{
    using System;
    using ServiceLocatorDesignPattern.GenericTypeServiceLocator.Interfaces;

    public class ServiceA : IServiceA
    {
        public void Execute()
        {
            Console.WriteLine("A service called.");
        }
    }
}
