#nullable enable

using Microsoft.Extensions.DependencyInjection;
using NCalcUnity.DependencyInjection;

namespace NCalcUnity.Cache.Configuration;

public static class NCalcServiceBuilderExtensions
{
    /// <summary>
    /// Replaces NCalc default cache with Microsoft.Extensions.MemoryCache.
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="configureOptions">The options of the cache.</param>
    /// <returns></returns>
    public static NCalcServiceBuilder WithMemoryCache(this NCalcServiceBuilder builder, Action<LogicalExpressionMemoryCacheOptions>? configureOptions = null)
    {
        if (configureOptions != null)
            builder.Services.Configure(configureOptions);
        else
            builder.Services.AddOptions<LogicalExpressionMemoryCacheOptions>();

        builder.WithCache<LogicalExpressionMemoryCache>();
        return builder;
    }
}