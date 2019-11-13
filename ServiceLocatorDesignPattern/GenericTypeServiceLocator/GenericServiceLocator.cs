namespace ServiceLocatorDesignPattern.GenericTypeServiceLocator
{
    using System;
    using System.Collections.Generic;
    using ServiceLocatorDesignPattern.GenericTypeServiceLocator.Interfaces;
    using ServiceLocatorDesignPattern.GenericTypeServiceLocator.Services;

    public class GenericServiceLocator : IService
    {
        public Dictionary<object, object> serviceContainer = null;

        public GenericServiceLocator()
        {
            serviceContainer = new Dictionary<object, object>();
            serviceContainer.Add(typeof(IServiceA), new ServiceA());
            serviceContainer.Add(typeof(IServiceB), new ServiceB());
        }

        public T GetService<T>()
        {
            try
            {
                return (T)serviceContainer[typeof(T)];
            }
            catch (Exception exp)
            {

                throw new NotImplementedException("Service not available.");
            }
        }
    }
}
