using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    public class CustomList<T> : CustomDataStructure<T>, IEnumerable<T>
    {
        public T this[int index]
        {
            get
            {
                this.ValidateIndex(index);
                return this.items[index];
            }
            set
            {
                this.ValidateIndex(index);
                this.items[index] = value;
            }
        }

        public void Add(T element)
        {
            this.Resize();

            items[Count] = element;
            Count++;
        }
        public void InsertAt(int index, T element)
        {
            this.Resize();
            this.ValidateIndex(index);
            this.Count++;
            this.ShiftToRight(index);
            this.items[index] = element;
        }
        public T RemoveAt(int index)
        {
            this.ValidateIndex(index);

            var removedItem = this.items[index];

            this.ShiftToLeft(index);
            this.Count--;
            this.Shrink();

            return removedItem;
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            this.ValidateIndex(firstIndex);
            this.ValidateIndex(secondIndex);
            var tmp = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = tmp;
        }
        public int Find(T element)
        {
            for (int index = 0; index < this.Count; index++)
            {
                if (this.items[index].Equals(element))
                {
                    return index;
                }
            }
            return -1;
        }
        public void Reverse()
        {
            for (int i = 0; i < this.Count / 2; i++)
            {
                this.Swap(i, this.Count - i - 1);
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                stringBuilder.Append($"{this.items[i]}, ");
            }

            return stringBuilder.ToString().TrimEnd(',', ' ');
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.items[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void ShiftToLeft(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }

            this.items[this.Count - 1] = default;

        }
        private void ShiftToRight(int index)
        {
            for (int i = this.Count - 1; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }
        }
        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
