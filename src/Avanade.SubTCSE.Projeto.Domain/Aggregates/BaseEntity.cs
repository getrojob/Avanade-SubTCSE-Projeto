using System;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates
{
    public record BaseEntity<Tid>
    {
        public Tid Id { get; set; }

        private DateTime _createAt;
        public DateTime CreateAt
        {
            get { return _createAt; }
            set { _createAt = value == null ? DateTime.UtcNow : value; }
        }

        private DateTime _updateAt;
        public DateTime UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = value; }
        }
    }
}
