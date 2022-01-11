using System;

namespace stack
{
    public class Stack<T>
    {
        private T[] _elements;
        private int _freeSlot;
        private int _totalSlot;

        public int Size => _freeSlot ;
        
        public Stack(int capacity)
        {
            _elements = new T[capacity];
            _totalSlot = capacity;
            _freeSlot = 0;
        }

        public Stack()
        {
            _elements = new T[4];
            _totalSlot = 4;
            _freeSlot = 0;
        }

        public void Push(T obj)
        {
            if (_freeSlot >= _totalSlot)
                Expand();
            _elements[_freeSlot++] = obj;
        }

        private void Expand()
        {
            var newElements = new T[_totalSlot *= 2];
            for (var j = 0; _elements.Length > j; j++)
                newElements[j] = _elements[j];

            _elements = newElements;
        }

        public object Top()
        {
            return _freeSlot == 0 ? 
                new ArgumentException("Стек пуст") :
                _elements[_freeSlot - 1];
        }

        public object Pop()
        {
            if (_freeSlot == 0) 
                return new ArgumentException("Стек пуст");
            var element = _elements[--_freeSlot];
            _elements[_freeSlot] = default;
            return element;
        }

        public void Clear()
        {
            for (var j = 0; _elements.Length > j; j++)
                _elements[j] = default;
            _freeSlot = 0;
        }
    }
}