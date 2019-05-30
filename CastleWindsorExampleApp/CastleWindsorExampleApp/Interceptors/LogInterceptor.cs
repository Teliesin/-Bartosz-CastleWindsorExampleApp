using Castle.DynamicProxy;
using System;

namespace CastleWindsorExampleApp.Interceptors
{
    public class LogInterceptor : IInterceptor
    {
        public void Intercept(
            IInvocation invocation)
        {
            Console.WriteLine(invocation.Method.Name);
            DateTime before = DateTime.Now;
            if(1==2) invocation.Proceed();
            DateTime after = DateTime.Now;
            var time = after - before;
            Console.WriteLine(time);
        }
    }
}