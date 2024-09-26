namespace _2bränsleanvändningProject
{
    public class Fordon
    {
        public int miltal;
        public int bränsleVolym;

        public virtual int CalculateFuelEfficiensy()
        {
            return bränsleVolym / miltal;
        }
    }

    public class ElectricCar : Fordon
    {
        public int batteri;
        
        public override int CalculateFuelEfficiensy()
        {
            return bränsleVolym / miltal + batteri;
        }
    }
}
