using NCalcUnity.Domain;

namespace NCalcUnity.Services;

/// <summary>
/// Service used to asynchronous evaluate the result of a <see cref="LogicalExpression"/>
/// </summary>
public interface IAsyncEvaluationService
{
    ValueTask<object?> EvaluateAsync(LogicalExpression expression, AsyncExpressionContext context);
}