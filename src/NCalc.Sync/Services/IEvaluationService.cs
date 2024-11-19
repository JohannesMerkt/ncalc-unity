using NCalcUnity.Domain;

namespace NCalcUnity.Services;

/// <summary>
/// Service used to evaluate the result of a <see cref="LogicalExpression"/>
/// </summary>
public interface IEvaluationService
{
    object? Evaluate(LogicalExpression? expression, ExpressionContext context);
}