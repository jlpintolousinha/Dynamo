﻿using System;

namespace Dynamo.TestInfrastructure
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    internal class MutationTestAttribute : Attribute
    {
        private string caption;

        public MutationTestAttribute(string caption)
        {
            this.caption = caption;
        }

        public virtual string Caption
        {
            get { return caption; }
        }
    }
}
