using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Exception
{
    public class ExceptionLogAspect : MethodInterception
    {

        /*protected override void OnException(IInvocation invocation, System.Exception e)
        {
            throw new System.Exception(e.Message);
        }*/
        protected override void OnException(IInvocation invocation, System.Exception e)
        {
            base.OnException(invocation, e);
        }
    }
}
