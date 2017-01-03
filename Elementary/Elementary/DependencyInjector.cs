using System;
using System.Collections.Generic;
using System.Reflection;

namespace Elementary
{
    public static class DependencyInjector
    {
        static List<object> dependencies = new List<object>();

        /// <summary>
        /// Registers an object to the dependency injector.
        /// Any object instance containing an OnInject() method will get its corresponding parameters type injected with any matching object of said type.
        /// </summary>
        /// <seealso cref="Inject(object)"/>
        /// <param name="o">The instance of the object to add to the dependency injector</param>
        public static void Register(object o)
        {
            if (!dependencies.Contains(o))
                dependencies.Add(o);
        }

        /// <summary>
        /// Injects to the object instance any dependencies in the dependency injector via calling OnInject() on said object with the appropriate supplied types.
        /// </summary>
        /// <seealso cref="Register(object)"/>
        /// <param name="o">The instance of the object to inject all dependencies to</param>
        /// <returns>A boolean stating if the injection was successful</returns>
        public static bool Inject(this object o)
        {
            MethodInfo methodInfo = o.GetType().GetMethod("OnInject", BindingFlags.Instance | BindingFlags.NonPublic);

            if (methodInfo == null) return false;

            List<object> toInject = new List<object>();
            ParameterInfo[] parameters = methodInfo.GetParameters();

            if (parameters == null || parameters.Length <= 0) return false;

            foreach (ParameterInfo paramInfo in parameters)
            {
                Type paramType = paramInfo.ParameterType;
                foreach (object d in dependencies)
                {
                    if (d.GetType() == paramType && !toInject.ContainsType(d.GetType()))
                        toInject.Add(d);
                }
            }

            if (parameters.Length != toInject.Count)
                return false;

            methodInfo.Invoke(o, toInject.ToArray());
            return true;
        }
    }
}
