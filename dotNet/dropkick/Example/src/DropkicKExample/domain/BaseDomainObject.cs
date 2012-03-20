namespace DropkicKExample.domain
{
    public abstract class BaseDomainObject<T> : IDomainObject
    {
        public T Id { get; set; }

        public int? GetKeyAsInteger()
        {
            int? returnValue = null;
            int tempValue = 0;
            bool isValueType = false;
            if (Id.GetType().IsValueType) isValueType = true;

            if (isValueType)
            {
                int.TryParse(Id.ToString(), out tempValue);
            }
            else
            {
                if (Id != null) int.TryParse(Id.ToString(), out tempValue);
            }

            if (tempValue != 0)
            {
                returnValue = tempValue;
            }

            return returnValue;
        }

        /// <summary>
        /// Sets the properties before insert. This is only called when this item is first being created
        /// </summary>
        public virtual void SetInitialInsertProperties()
        {
        }  
        
        /// <summary>
        /// Sets the properties before update. This is called every time this item is saved
        /// </summary>
        public virtual void SetUpdateProperties()
        {
        }
    }
}