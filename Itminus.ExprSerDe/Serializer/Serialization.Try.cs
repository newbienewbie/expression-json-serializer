﻿using System;
using System.Linq.Expressions;

namespace Itminus.ExprSerializer
{
    partial class Serializer
    {
        private bool TryExpression(Expression expr)
        {
            var expression = expr as TryExpression;
            if (expression == null) { return false; }

            throw new NotImplementedException();
        }
    }
}
