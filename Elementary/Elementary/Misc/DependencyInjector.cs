﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace Elementary
{
    public static class DependencyInjector
    {
        private static readonly List<object> dependencies = new List<object>();

        /// <summary>
        /// Registers an object to the dependency injector.
        /// Any object instance containing an OnInject() method will get its corresponding parameters type injected with any matching object of said type.
        /// </summary>
        /// <seealso cref="Inject(object,bool)"/>
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
        /// <param name="baseType">Should we inject at the base type of the object?</param>
        /// <returns>A boolean stating if the injection was successful</returns>
        public static bool Inject(this object o, bool baseType = false)
        {
            Type type = o.GetType();

            if (baseType)
                type = type.BaseType;

            if (type != null)
            {
                MethodInfo methodInfo = type.GetMethod("OnInject", BindingFlags.Instance | BindingFlags.NonPublic);

                if (methodInfo == null) return false;

                List<object> toInject = new List<object>();
                ParameterInfo[] parameters = methodInfo.GetParameters();

                if (parameters.Length <= 0) return false;

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
            }
            return true;
        }
    }
}
