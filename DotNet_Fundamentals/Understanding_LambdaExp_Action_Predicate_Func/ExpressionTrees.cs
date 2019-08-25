using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_LambdaExp_Action_Predicate_Func
{
    class ExpressionTrees
    {
        static void Main(string[] args)
        {
            //Expression tress
            //(10 + 20) - (5 + 3)

            //10 + 20
            BinaryExpression b1 = Expression.MakeBinary(ExpressionType.Add,
                                                        Expression.Constant(10),
                                                        Expression.Constant(20));

            //5 + 3
            BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Add,
                                                        Expression.Constant(5),
                                                        Expression.Constant(3));

            //(10 + 20) - (5 + 3)
            BinaryExpression b3 = Expression.MakeBinary(ExpressionType.Subtract,
                                                        b1,
                                                        b2);

            //this expression will create a delegate by parsing the expression tree
            int result = Expression.Lambda<Func<int>>(b3).Compile()();
        }
    }
}
