﻿namespace TheCheckoutKata.CheckoutItems
{
    public interface ICheckout
    {
        void Scan(string item);
        int GetTotalPrice();
    }
}
