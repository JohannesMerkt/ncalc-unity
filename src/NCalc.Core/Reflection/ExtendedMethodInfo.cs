using System.Reflection;
using LinqExpression = System.Linq.Expressions.Expression;

namespace NCalcUnity.Reflection;

public sealed class ExtendedMethodInfo
{
    public required MethodInfo MethodInfo { get; init; }
    public required LinqExpression[] PreparedArguments { get; init; }
    public int Score { get; init; }
}