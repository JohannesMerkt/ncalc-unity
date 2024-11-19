using BenchmarkDotNet.Running;
using NCalcUnity.Benchmarks;

BenchmarkRunner.Run<LogicalExpressionFactoryBenchmark>(null, args);
BenchmarkRunner.Run<SimpleEvaluationBenchmark>(null, args);
BenchmarkRunner.Run<EvaluateVsLambdaBenchmark>(null, args);