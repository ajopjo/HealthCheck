

using Microsoft.Web.Infrastructure.DynamicModuleHelper;

namespace HealthCheck
{
    public static class PreApplicationStart
    {
        private static bool _startWasCalled;
        public static void Start()
        {
            // Pre application startup configuration goes here
            if (_startWasCalled)
            {
                return;
            }
            _startWasCalled = true;

            DynamicModuleUtility.RegisterModule(typeof(HealthModule));
        }

    }
}
