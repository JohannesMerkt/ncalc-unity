﻿using NCalcUnity.Domain;

namespace NCalcUnity.Factories;

public interface IAsyncExpressionFactory
{
    public AsyncExpression Create(
        string expression,
        AsyncExpressionContext? expressionContext = null);

    public AsyncExpression Create(
        LogicalExpression logicalExpression,
        AsyncExpressionContext? expressionContext = null);
}