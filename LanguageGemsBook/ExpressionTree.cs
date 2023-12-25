using System.Linq.Expressions;

namespace LanguageGemsBook;

// 식을 트리로 표현한 자료 구조
// 실행가능한 상태가 아닌 "데이터"상태이므로 실행을 위해선 컴파일 과정 필요
// 컴파일러나 인터프리터 제작에 응용
public class ExpressionTree
{
    public void method()
    {
        Expression const1 = Expression.Constant(1); // 상수1
        Expression const2 = Expression.Constant(2); // 상수2

        Expression leftExp = Expression.Multiply(const1, const2); // 곱 연산

        Expression param1 = Expression.Parameter(typeof(int)); // x를 위한 변수
        Expression param2 = Expression.Parameter(typeof(int)); // y를 위한 변수

        Expression rightExp = Expression.Subtract(param1, param2); // 빼기 연산

        Expression exp = Expression.Add(leftExp, rightExp); // 곱 연산 + 빼기 연산

        Expression<Func<int, int, int>> expression =
            Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(
                exp, new ParameterExpression[]
                {
                    (ParameterExpression)param1,
                    (ParameterExpression)param2
                });

        Func<int, int, int> func = expression.Compile();
        func(7, 8);
    }
}