namespace Model
{
    public class FunctionWithouCoef : IFunction
    {
        public FunctionWithouCoef(string type, double minLimit, double maxLimit) 
        { 
            this.Type = type;
            this.MinLimit = minLimit;
            this.MaxLimit = maxLimit;
            this.Equation = type;
        }
    }
}
