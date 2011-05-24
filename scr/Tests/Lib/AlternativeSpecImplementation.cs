using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using NUnit.Framework;
using Seedworks.Tests.Lib.Persistance;

namespace Seedworks.Tests.Lib
{
    public class Specification<T>
    {
        public Specification(params Expression<Func<T, object>>[] expressions)
        {
            foreach (var expression in expressions)
            {
                var ubody = (UnaryExpression)expression.Body;
                var body = ubody.Operand as MemberExpression;
                var name = body.Member.Name;
                var type = ubody.Operand.Type;
                
                Console.WriteLine(expression.Body);
                Console.WriteLine(name);
                Console.WriteLine(ubody.Operand.Type);
            }
            
        }
    }

    [TestFixture]
    public class AlternativeSpecImplementation
    {
        ///A LINQ Provider for Specifications would be nice: http://msdn.microsoft.com/en-us/vcsharp/ee672195

        [Test]
        public void Foo()
        {
            var foo = new Specification<SampleEntity>(x => x.DateCreated);
        }


    }
}
