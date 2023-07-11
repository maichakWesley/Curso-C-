namespace Course.Entities
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge;


        public OutsourceEmployee(){

        }

        public OutsourceEmployee(string name, int hours, double valuePorHours, double additionalCharge) : base(name, hours, valuePorHours) {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
    
}