using System;
using System.Linq.Expressions;

namespace Itminus.ExprSerializer
{
    partial class Serializer
    {
        private bool DynamicExpression(Expression expr)
        {
            var expression = expr as DynamicExpression;
            if (expression == null) { return false; }

            throw new NotImplementedException();
        }
    }
}
