namespace DynamicArray
{
    public class DynamicArray
    {
        private int[] _array;
        private int _capacity;
        private int _elementsNumber;

        public DynamicArray(int capacity)
        {
            _array = new int[capacity];
            _capacity = capacity;
            _elementsNumber = 0;
        }

        public int Get(int i)
        {
            var result = _array[i];
            return result;
        }

        public void Set(int i, int n)
        {
            _array[i] = n;
        }

        public void PushBack(int n)
        {
            if (_elementsNumber == _capacity)
            {
                Resize();
            }
            _array[_elementsNumber] = n;
            _elementsNumber++;
        }

        public int PopBack()
        {
            _elementsNumber--;
            var lastValue = _array[_elementsNumber];
            var shortenedArr = new int[_elementsNumber];

            for (int i = 0; i < _elementsNumber; i++)
            {
                shortenedArr[i] = _array[i];
            }

            _array = shortenedArr;

            return lastValue;
        }

        private void Resize()
        {
            _capacity *= 2;
            var extendedArr = new int[_capacity];
            for (int i = 0; i < _elementsNumber; i++)
                extendedArr[i] = _array[i];

            _array = extendedArr;
        }

        public int GetSize()
        {
            return _elementsNumber;
        }

        public int GetCapacity()
        {
            return _capacity;
        }
    }
}
