namespace GenericBox
{
    public class Box<T>
    {
        private T property;

        public void SetValue(T newProperty)
        {
            property = newProperty;
        }

        public T GetValue()
        {
            return property;
        }
    }
}