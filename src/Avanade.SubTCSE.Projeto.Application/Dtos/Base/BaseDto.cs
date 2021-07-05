using System;

namespace Avanade.SubTCSE.Projeto.Application.Dtos.Base
{
    public abstract class BaseDto
    {
        public int Identificador { get; set; }
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
