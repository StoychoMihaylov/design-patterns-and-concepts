namespace StrongTypeServiceLocator.ServiceLocatorDesignPattern
{
    using global::ServiceLocatorDesignPattern.StrongTypeServiceLocator.Interfaces;
    using global::ServiceLocatorDesignPattern.StrongTypeServiceLocator.Services;

    public class ServiceLocator
    {
        public static ILoggingService loggingService = null;
        public static ICalculationService calculationService = null;

        //Service locator function returning strong type   
        public static ILoggingService SetLocation(ILoggingService tmpser)
        {
            if (loggingService == null)
            {
                return new LoggingService();
            }

            return loggingService;
        }

        public static ICalculationService SetLocation(ICalculationService tmpser)
        {
            if (calculationService == null)
            {
                return new CalculationService();
            }

            return calculationService;
        }

        //Execute service  
        public static void ExecuteService()
        {
            loggingService.ExecuteService();
        }
    }
}
