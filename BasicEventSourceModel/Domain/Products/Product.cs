using System;
using System.Collections.Generic;
using System.Linq;
using BasicEventSourceModel.Domain.Core;
using BasicEventSourceModel.Domain.Products.Events;

namespace BasicEventSourceModel.Domain.Products
{
    public class Product : Aggregate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public IList<Comment> Comments { get; set; } = new List<Comment>();

        public Product Build(Guid id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;

            @Events.Add(new CreatedProductEvent()
            {
                AggregateId = Id,
                Name = name,
                Price = price
            });

            return this;
        }
        public Product AddComment(string content, string username)
        {
            var comment = new Comment(Guid.NewGuid(), this, content, username);

            Comments.Add(comment);

            @Events.Add(new AddedCommentEvent()
            {
                AggregateId = this.Id,
                Id = comment.Id,
                Content = content,
                UserName = username
            });
            return this;
        }
        public Product ChangePrice(double value)
        {
            Price = value;
            @Events.Add(new ChangedPriceEvent()
            {
                Price = value,
                AggregateId = Id
            });
            return this;
        }


        #region Build Events


        public void BuildEvent(AddedCommentEvent @event)
        {
            Comments.Add(new Comment(@event.Id, this, @event.Content, @event.UserName));
        }

        public void BuildEvent(ChangedPriceEvent @event)
        {
            Price = @event.Price;
        }

        public void BuildEvent(CreatedProductEvent @event)
        {
            Id = @event.AggregateId;
            Name = @event.Name;
            Price = @event.Price;
        }

        #endregion
    }
}