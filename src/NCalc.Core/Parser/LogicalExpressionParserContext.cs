using Parlot;
using Parlot.Fluent;

namespace NCalcUnity.Parser;

public sealed class LogicalExpressionParserContext(string text, ExpressionOptions options)
    : ParseContext(new Scanner(text))
{
    public ExpressionOptions Options { get; } = options;
}