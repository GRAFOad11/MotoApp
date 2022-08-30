
namespace MotoApp
{
    internal class BasicStack
    {
        private readonly double[] _items;
        private int _currentIndex = -1;
        public BasicStack() => _items = new double[10];
        public int Count => _currentIndex + 1;
        public void Push(double items) => _items[++_currentIndex] = items;
        public double Pop() => _items[_currentIndex--];
    }
}
