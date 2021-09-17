using System;

namespace WpfApplicationCOCOMO
{
    public static class Calculate
    {
        //Розрахунок показника "трудоємність"
        public static double GetLabor(double[] _arrayType, double _quantity) =>
            _arrayType[0] * (Math.Pow(_quantity, _arrayType[1]));

        //Розрахунок показника "тривалість"
        public static double GetTime(double[] _arrayType, double _quantity) => 
            _arrayType[2] * (Math.Pow(GetLabor(_arrayType, _quantity), _arrayType[3]));

        //Розрахунок показника "розробники"
        public static double GetChel(double[] _arrayType, double _quantity) =>
            GetLabor(_arrayType, _quantity) / GetTime(_arrayType, _quantity);
    }
}
