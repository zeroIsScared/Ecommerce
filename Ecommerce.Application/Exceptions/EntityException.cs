using Ecommerce.Application.Extentions;
using System.ComponentModel;

namespace Ecommerce.Application.Exceptions
{
    public enum EntityErrorCode
    {
        [Description("ENTITY_NOT_FOUND")]
        EntityNotFound
    }

    public class EntityException : ApplicationException
    {
        protected EntityException(string message) : base(message)
        {
        }

        protected EntityErrorCode ErrorCodeType { get; set; }
        public string ErrorCode => ErrorCodeType.GetDescription()!;
    }
}