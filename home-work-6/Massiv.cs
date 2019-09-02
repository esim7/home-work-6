using System;
namespace home_work_6
{
    public class Massiv
    {
        public int _size { get; set; }
        private int[] _massiv;

        public int this[int i]
        {
            get
            {
                return _massiv[i];
            }
            set
            {
                _massiv[i] = (int)Math.Pow(value, 2);
            }
        }

        public Massiv()
        {
            _size = 1;
            _massiv = new int[_size];
        }

        public Massiv(int size)
        {
            _size = size;
            _massiv = new int[_size];
        }
    }
}
