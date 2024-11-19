using System.Reflection;

namespace NCalcUnity.Helpers;

public readonly struct MathMethodInfo
{
    public required MethodInfo MethodInfo { get; init; }
    public required int ArgumentCount { get; init; }
    public required bool DecimalSupport { get; init; }
}