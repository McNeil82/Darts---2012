namespace Darts_2012.Poco
{
    public class Throw
    {
        public int Value { get; set; }
        public int Multiplier { get; set; }

        public override string ToString()
        {
            var throwString = "";
            if (Value == 25)
            {
                if (Multiplier == 2)
                {
                    throwString += "D";
                }
                throwString += "B";

                return throwString;
            }
            
            if (Multiplier == 2)
            {
                throwString += "D";
            }
            else if (Multiplier == 3)
            {
                throwString += "T";
            }

            throwString += Value.ToString();

            return throwString;
        }
    }
}
