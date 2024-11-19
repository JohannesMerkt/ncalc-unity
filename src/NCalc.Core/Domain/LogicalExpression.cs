using System.Diagnostics.Contracts;
using NCalcUnity.Visitors;

namespace NCalcUnity.Domain;

/// <summary>
/// Represents an abstract syntax tree (AST) node for logical expressions.
/// </summary>
public abstract class LogicalExpression
{
    public override string ToString()
    {
        var serializer = new SerializationVisitor();
        return Accept(serializer).TrimEnd(' ');
    }

    [Pure]
    public abstract T Accept<T>(ILogicalExpressionVisitor<T> visitor);
}