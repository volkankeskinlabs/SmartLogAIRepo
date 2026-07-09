using System;
class PaymentService
{
    public void ProcessPayment()
    {
        // ... diğer kodlar
        if(discount != null)
        {
            // discount объекті null деуальт болмаен жүгірту
            discount.ApplyDiscount();
        }
        Console.WriteLine("Ödeme işlemleri başarılı bir şekilde gerçekleştirildi")