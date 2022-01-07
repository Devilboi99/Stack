using System;

namespace stack
{
    public class Stack<T>
    {
        private T[] _elements;
        private int _lastSlot;
        private int _totalSlot;

        public int Size => _lastSlot + 1;
        
        public Stack(int capacity)
        {
            _elements = new T[capacity];
            _totalSlot = capacity;
            _lastSlot = 0;
        }

        public Stack()
        {
            _elements = new T[1];
            _totalSlot = 1;
            _lastSlot = 0;
        }

        public void Push(T obj)
        {
            if (_lastSlot >= _totalSlot)
                Expand();
            _elements[_lastSlot++] = obj;
        }

        private void Expand()
        {
            var newElements = new T[ _totalSlot *= 2];
            for (var j = 0; _elements.Length > j; j++)
                newElements[j] = _elements[j];

            _elements = newElements;
        }

        public object Top()
        {
            return _lastSlot == 0 ?
                new ArgumentException("Стек пуст?") :
                _elements[_lastSlot - 1];
        }

        public object Pop()
        { 
            var element = _elements[--_lastSlot];
            _elements[_lastSlot] = default;
            return element;
        }

        public void Clear()
        {
            for (var j = 0; _elements.Length > j; j++)
                _elements[j] = default;
            _lastSlot = 0;
        }
    }
}