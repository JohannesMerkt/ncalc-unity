using NCalcUnity.Domain;

namespace NCalcUnity.Factories;

public interface ILogicalExpressionFactory
{
    public LogicalExpression Create(string expression, ExpressionOptions options = ExpressionOptions.None);
}