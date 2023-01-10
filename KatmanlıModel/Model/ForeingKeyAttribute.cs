using System;

namespace KatmanlıModel.Model
{
    internal class ForeingKeyAttribute : Attribute
    {
        private string v;

        public ForeingKeyAttribute(string v)
        {
            this.v = v;
        }
    }
}