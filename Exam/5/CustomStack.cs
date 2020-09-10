using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    public class CustomStack<T> : CustomDataStructure<T>, IEnumerable<T>
    {
        public void Push(T element)
        {
            this.Resize();
            this.items[this.Count] = element;
            this.Count++;
        }
        public T Pop()
        {
            this.ThrowWhenEmpty();
            var element = this.items[this.Count - 1];
            this.items[this.Count - 1] = default;
            this.Count--;
            this.Shrink();
            return element;
        }
        public T Peek()
        {
            this.ThrowWhenEmpty();
            return this.items[this.Count - 1];
        }
        public void Clear()
        {
            this.items = null;
            this.Count = 0;
        }
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            for (int i = this.Count - 1; i >= 0; i--)
            {
                stringBuilder.Append($"{this.items[i]}, ");
            }

            return stringBuilder.ToString().TrimEnd(',', ' ');
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.items[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private void ThrowWhenEmpty()
        {
            if (this.Count == 0)
            {
                throw new Exception("Stack is empty");
            }
        }
    }
}
