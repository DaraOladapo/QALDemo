namespace CarsRevisited
{
    class Weather
    {
        public double TempInDegC { get; set; }
        public double TempInDegF => TempInDegC * 1.8 + 32;
    }
}
