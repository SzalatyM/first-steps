namespace FirstSteps
{
    public class Number
    {
        int _number;

        public Number( int initialValue)
        {
            _number = initialValue;

        }
        public int GetValue()
        {
            return _number;
        }
        

        //TODO: constructor that takes initial value and pass to the variable

        public void Add(int value)
        {
            _number += value;
        }

        public void Subtract(int value)
        {
            _number = _number - value;
        }

        public void Divide(int value)
        {
            _number = _number / value;
        }

        public void Double()
        {
            _number = _number * 2;
        }

        public void Triple()
        {
            _number = _number * 3;
        }
    }
}