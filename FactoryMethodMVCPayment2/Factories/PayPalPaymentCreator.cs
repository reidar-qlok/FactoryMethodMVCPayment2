using FactoryMethodMVCPayment2.Models;

namespace FactoryMethodMVCPayment2.Factories
{
    public class PayPalPaymentCreator : PaymentCreator
    {
        public override PaymentMethod CreatePaymentMethod()
        {
            return new PayPalPayment();
        }
    }
}
