
namespace _5
{
    public class CustomDataStructure<T>
    {
        private const int InitialCapacity = 8;

        protected T[] items;

        public CustomDataStructure()
        {
            this.items = new T[InitialCapacity];
            this.Count = 0;
        }

        public int Count { get; protected set; }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        protected void Resize()
        {
            if (this.items.Length > this.Count)
            {
                return;
            }

            var tempArray = new T[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                tempArray[i] = this.items[i];
            }

            this.items = tempArray;

            //Array.Copy(this.items, 0, tempArray, 0, this.items.Length);
        }
        protected void Shrink()
        {
            if (this.Count >= this.items.Length / 4)
            {
                return;
            }

            var tempArray = new T[this.items.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                tempArray[i] = this.items[i];
            }

            this.items = tempArray;
        }
    }
}
