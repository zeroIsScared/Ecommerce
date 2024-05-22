

namespace Ecommerce.Application.Exceptions
{
    public class EntityNotFoundException : EntityException
    {
        public EntityNotFoundException(Type entityType) : base($"Entity of type {entityType.Name} not found")
        {
            ErrorCodeType = EntityErrorCode.EntityNotFound;
        }

        public EntityNotFoundException(Type entityType, long id) : base($"Entity of type {entityType.Name} with id: {id} not found")
        {
        }

        public static EntityNotFoundException OfType<T>(long withId)
        {
            return new EntityNotFoundException(typeof(T), withId);
        }

        public static EntityNotFoundException OfType<T>()
        {
            return new EntityNotFoundException(typeof(T));
        }
    }
}
