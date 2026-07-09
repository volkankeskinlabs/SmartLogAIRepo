using System;

namespace PaymentProcessor
{
    public class PaymentService
    {
        public void ProcessPayment(Discount discount)
        {
            if (discount != null)
            {
                discount.ApplyDiscount();
            }
            else
            {
                Console.WriteLine("Discount nesnesi boş olamaz.");
            }
            Console.WriteLine("Ödeme işlemleri başarılı bir şekilde gerçekleştirildi");
        }
    }

    public class Discount
    {
        public void ApplyDiscount()
        {
            // ... discount.apply işlemleri
        }
    }
}