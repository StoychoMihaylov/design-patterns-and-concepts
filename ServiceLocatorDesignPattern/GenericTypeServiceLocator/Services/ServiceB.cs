namespace ServiceLocatorDesignPattern.GenericTypeServiceLocator.Services
{
    using System;
    using ServiceLocatorDesignPattern.GenericTypeServiceLocator.Interfaces;

    public class ServiceB : IServiceB
    {
        public void Execute()
        {
            Console.WriteLine("B service called.");
        }
    }
}
