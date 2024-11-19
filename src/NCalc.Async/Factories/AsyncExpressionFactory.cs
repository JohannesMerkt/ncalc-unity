using NCalcUnity.Cache;
using NCalcUnity.Domain;
using NCalcUnity.Services;

namespace NCalcUnity.Factories;

/// <summary>
/// Default <see cref="IAsyncExpressionFactory"/> implementation.
/// </summary>
public sealed class AsyncExpressionFactory(
    ILogicalExpressionFactory logicalExpressionFactory,
    ILogicalExpressionCache cache,
    IAsyncEvaluationService evaluationService
) : IAsyncExpressionFactory
{
    public AsyncExpression Create(string expression, AsyncExpressionContext? expressionContext = null)
    {
        return new AsyncExpression(expression, expressionContext ?? new(), logicalExpressionFactory, cache, evaluationService);
    }

    public AsyncExpression Create(LogicalExpression logicalExpression, AsyncExpressionContext? expressionContext = null)
    {
        return new AsyncExpression(logicalExpression, expressionContext ?? new(), logicalExpressionFactory, cache, evaluationService);
    }
}