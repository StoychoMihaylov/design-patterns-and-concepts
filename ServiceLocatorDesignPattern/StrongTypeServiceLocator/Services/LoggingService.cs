namespace ServiceLocatorDesignPattern.StrongTypeServiceLocator.Services
{
    using System;
    using ServiceLocatorDesignPattern.StrongTypeServiceLocator.Interfaces;
 
    public class LoggingService : ILoggingService
    {
        public void ExecuteService()
        {
            Console.WriteLine("Executing Log Service");
        }
    }
}
