using DryIoc;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.Config {
    public static class DI {
        public static Container Dependencies { get; } = new Container(rules => rules.WithFuncAndLazyWithoutRegistration());


        static DI() {

        }
    }
}
