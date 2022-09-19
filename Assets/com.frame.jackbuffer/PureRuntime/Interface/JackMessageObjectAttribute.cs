using System;

namespace JackBuffer {

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public class JackMessageObjectAttribute : Attribute {

        public JackMessageObjectAttribute() {

        }

    }

}