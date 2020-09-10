
using System;

namespace _1
{
    public class TRational
    {
        //Can use auto props for Number
        private int _number;
        private int _denom;
        private bool _isPositive;

        public TRational(int number, int denom)
        {
            this._isPositive = number * denom >= 0 ? true : false;
            this.Number = Math.Abs(number);
            this.Denom = Math.Abs(denom);
        }
        public int Number 
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }

        public int Denom
        {
            get
            {
                return this._denom;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denom cannot be 0!");
                }

                this._denom = value;
            }
        }

        public bool IsPositive => this._isPositive;

        public void Reduce()
        {
            int divisor = GCD(this._number, this._denom);
            this._number = this._number / divisor;
            this._denom = this._denom / divisor;
        }
        private int GCD(int a, int b)
        { 
            if (a * b == 0)
            {
                return 1;
            }
            else
            {
                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
                return a;
            }
        }
    }
}
