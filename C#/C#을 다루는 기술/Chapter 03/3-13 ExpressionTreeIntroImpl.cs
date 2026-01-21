// 두 정숫값을 더하는 표현식 트리를 생성하는 코드를 직접 작성한 예

ParameterExpression xParameter = Expression.Parameter(typeof(int), "x");
ParameterExpression yParameter = Expression.Parameter(typeof(int), "y");
Expression body = Expression.Add(xParameter, yParameter);
ParameterExpression[] parameter = new[] { xParameter, yParameter };

Expression<Func<int, int, int>> adder = 
    Expression.Lambda<Func<int, int, int>>(body, parameters);
Console.WriteLine(adder);