using System;
using BasicEventSourceModel.Domain.Products;

namespace BasicEventSourceModel
{
    class Program
    {
        static void Main(string[] args)
        {

            var p = new Product().Build(Guid.NewGuid(), "kinik", 501)
            .AddComment("Post 1", "sinan.baran")
            .AddComment("Post 2", "sinan.baran")
            .ChangePrice(128);



            var @events = p.Events;
            //creating Product from @events
            var newP = new Product();
            newP.ApplyEvents(@events);


        }
    }
}
