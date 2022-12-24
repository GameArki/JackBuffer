using System;

namespace GameArki.BufferIOExtra {

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public class JackMessageObjectAttribute : Attribute {

        public JackMessageObjectAttribute() {

        }

    }

}