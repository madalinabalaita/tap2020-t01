using System;
using System.Collections.Generic;
using System.Text;


public class Imobile
{
    String type;//=casa,apartament,garsoniere
    Decimal price;
    Decimal corectionPriceByCompany;  //=corectia adusa de companie pretului propus de vanzator pentru a vinede mai repede si mai eficient imobilul.
    Int16 commission;
    public Imobile(String type, Decimal price, Decimal corectionPriceByCompany, Int16 commission)
    {
        this.type = type;
        this.price = price;
        this.corectionPriceByCompany = corectionPriceByCompany;
        this.commission = commission;
    }
    public String Type
    {
        get { return type; }
        private set { type = value; }
    }
    public Decimal Price
    {
        get { return price; }
        set { price = value; }
    }
    public Decimal CorectionPriceByComapany
    {
        get { return corectionPriceByCompany; }
        set { corectionPriceByCompany = value; }
    }
    public Int16 Commission
    {
        get { return commission; }

    }


}

