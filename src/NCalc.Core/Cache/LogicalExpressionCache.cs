using Microsoft.Extensions.Logging;
using NCalcUnity.Domain;
using NCalcUnity.Logging;

namespace NCalcUnity.Cache;

public sealed class LogicalExpressionCache(ILogger<LogicalExpressionCache> logger) : ILogicalExpressionCache
{
    private readonly ConcurrentDictionary<string, WeakReference<LogicalExpression>> _compiledExpressions = new();

    private static LogicalExpressionCache? _instance;

    public static LogicalExpressionCache GetInstance()
    {
        return _instance ??= new LogicalExpressionCache(DefaultLoggerFactory.Value.CreateLogger<LogicalExpressionCache>());
    }

    public bool TryGetValue(string expression, out LogicalExpression? logicalExpression)
    {
        logicalExpression = null;

        if (!_compiledExpressions.TryGetValue(expression, out var wr))
            return false;
        if (!wr.TryGetTarget(out logicalExpression))
            return false;

        logger.LogRetrievedFromCache(expression);

        return true;
    }

    public void Set(string expression, LogicalExpression logicalExpression)
    {
        _compiledExpressions[expression] = new WeakReference<LogicalExpression>(logicalExpression);
        ClearCache();
        logger.LogAddedToCache(expression);
    }

    private void ClearCache()
    {
        foreach (var kvp in _compiledExpressions)
        {
            if (kvp.Value.TryGetTarget(out _))
                continue;

            if (_compiledExpressions.TryRemove(kvp.Key, out _))
            {
                logger.LogRemovedFromCache(kvp.Key);
            }
        }
    }
}
