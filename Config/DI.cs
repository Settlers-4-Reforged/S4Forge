using DryIoc;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.Config {
    public static class DI {
        public static Container Dependencies { get; } = new Container(rules => rules.WithFuncAndLazyWithoutRegistration());

        public static T Resolve<T>() {
            // This helper method skips the need for a "using DryIoc;" statement in every file that uses this DI method
            return Dependencies.Resolve<T>();
        }

        static DI() {

        }
    }
}
