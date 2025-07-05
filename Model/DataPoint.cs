namespace Model
{
    public struct DataPoint
    {
        public double X { get; }
        public double Y { get; }

        public DataPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
