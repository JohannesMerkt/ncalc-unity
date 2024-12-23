﻿using NCalcUnity.Factories;
using NCalcUnity.Tests.Fixtures;
using NCalcUnity.Tests.TestData;

namespace NCalcUnity.Tests;

[Trait("Category", "Plugins")]
public class AntlrTests(FactoriesWithAntlrFixture fixture) : IClassFixture<FactoriesWithAntlrFixture>
{
    private IExpressionFactory ExpressionFactory { get; } = fixture.ExpressionFactory;

    [Theory]
    [ClassData(typeof(EvaluationTestData))]
    public void Expression_Should_Evaluate(string expression, object expected)
    {
        Assert.Equal(expected, ExpressionFactory.Create(expression, ExpressionOptions.NoCache).Evaluate());
    }

    [Theory]
    [ClassData(typeof(ValuesTestData))]
    public void Should_Parse_Values(string expressionString, object expectedValue)
    {
        var expression = ExpressionFactory.Create(expressionString, ExpressionOptions.NoCache);
        var result = expression.Evaluate();

        if (expectedValue is double expectedDouble)
        {
            Assert.Equal(expectedDouble, (double)result, precision: 15);
        }
        else
        {
            Assert.Equal(expectedValue, result);
        }
    }
}