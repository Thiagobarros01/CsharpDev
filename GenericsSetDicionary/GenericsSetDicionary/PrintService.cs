﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSetDicionary {
     class PrintService<T> {

        private T[] _values = new T[10];

        private int _count = 0;


        public void AddValue(T value) {
            if (_count == 10) {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public T firs() {
            if (_count == 0) {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print() {
            Console.WriteLine("[");
            foreach (T value in _values) {
                Console.Write(value);
            }
            Console.WriteLine("]");
        }


    }
}
