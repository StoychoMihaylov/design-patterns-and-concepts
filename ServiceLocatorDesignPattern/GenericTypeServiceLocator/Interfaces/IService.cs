namespace ServiceLocatorDesignPattern.GenericTypeServiceLocator.Interfaces
{
    public interface IService
    {
        T GetService<T>();
    }
}
