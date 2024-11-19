using NCalcUnity.Domain;
using NCalcUnity.Visitors;

namespace NCalcUnity.Services;

/// <inheritdoc cref="IEvaluationService"/>
public class EvaluationService : IEvaluationService
{
    public object? Evaluate(LogicalExpression? expression, ExpressionContext context)
    {
        var visitor = new EvaluationVisitor(context);
        return expression?.Accept(visitor);
    }
}