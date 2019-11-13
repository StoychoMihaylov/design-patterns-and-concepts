namespace ServiceLocatorDesignPattern
{
    using global::StrongTypeServiceLocator.ServiceLocatorDesignPattern;
    using ServiceLocatorDesignPattern.GenericTypeServiceLocator;
    using ServiceLocatorDesignPattern.GenericTypeServiceLocator.Interfaces;
    using ServiceLocatorDesignPattern.StrongTypeServiceLocator.Interfaces;
    using ServiceLocatorDesignPattern.StrongTypeServiceLocator.Services;

    class StartUp
    {
        static void Main(string[] args)
        {
            // Strong Type Service Locator
            ILoggingService  loggingService = ServiceLocator.SetLocation(new LoggingService());
            loggingService.ExecuteService();

            ICalculationService calculationService = ServiceLocator.SetLocation(new CalculationService());

            var array = new int[] { 14, 45, 43, 43, 3, 4, 1, 98, 39 };
            var sum = calculationService.CalculateSumOfArray(array);
            System.Console.WriteLine($"Sum: {sum}");

            var str = "Hello this is Service Locator Disign Pattern example";
            var reversedStr = calculationService.ReverseString(str);
            System.Console.WriteLine($"Reversed string: {reversedStr}");

            System.Console.WriteLine();
            System.Console.WriteLine("----------------------------------------------------");
            System.Console.WriteLine();

            // Generic Type Service Locator
            GenericServiceLocator genericServiceLocator = new GenericServiceLocator();
            IServiceA aService = genericServiceLocator.GetService<IServiceA>();
            aService.Execute();

            IServiceB bService = genericServiceLocator.GetService<IServiceB>();
            bService.Execute();
        }
    }
}
