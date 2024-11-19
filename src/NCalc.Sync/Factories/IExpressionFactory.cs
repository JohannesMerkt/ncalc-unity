using NCalcUnity.Domain;

namespace NCalcUnity.Factories;

public interface IExpressionFactory
{
    public Expression Create(
        string expression,
        ExpressionContext? expressionContext = null);

    public Expression Create(
        LogicalExpression logicalExpression,
        ExpressionContext? expressionContext = null);
}