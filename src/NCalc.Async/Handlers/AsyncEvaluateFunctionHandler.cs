namespace NCalcUnity.Handlers;

public delegate ValueTask AsyncEvaluateFunctionHandler(string name, AsyncFunctionArgs args);