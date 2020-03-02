namespace real_estate
{
    public abstract class real_estate
    {
        protected decimal price;
        public real_estate(decimal price)
        {
            this.price = price;
        }
        public abstract decimal get_commission();
        public decimal get_price()
        {
            return price + get_commission();
        }
    }
    public class House : real_estate
    {
        public House(decimal price) : base(price) { }
        public override decimal get_commission()
        {
            if (price < 250000m)
                return price * 0.05m;
            else if (price < 500000m)
                return price * 0.08m;
            else return price * 0.1m;
        }

    }
    public class Flat : real_estate
    {
        public Flat(decimal price) : base(price) { }
        public override decimal get_commission()
        {
            return price * 0.1m;
        }
    }

    public class Studio_Flat : real_estate
    {
        public Studio_Flat(decimal price) : base(price) { }
        public override decimal get_commission()
        {
            return price * 0.1m + 1500m;
        }

    }
}