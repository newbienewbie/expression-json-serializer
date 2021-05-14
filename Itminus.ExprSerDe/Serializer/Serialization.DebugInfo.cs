using System;
using System.Linq.Expressions;

namespace Itminus.ExprSerializer
{
    partial class Serializer
    {
        private bool DebugInfoExpression(Expression expr)
        {
            var expression = expr as ConditionalExpression;
            if (expression == null) { return false; }

            throw new NotImplementedException();
        }
    }
}
