using System;

namespace BasicEventSourceModel.Domain.Products
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public string Content { get; set; }
        public string User { get; set; }

        public Comment(Guid id, Product product, string content, string user)
        {
            Id = id;
            Product = product;
            Content = content;
            User = user;
        }
    }
}
