using FactoryMethodMVCPayment2.Models;

namespace FactoryMethodMVCPayment2.Factories
{
    public class CreditCardPaymentCreator : PaymentCreator
    {
        public override PaymentMethod CreatePaymentMethod()
        {
            return new CreditCardPayment();
        }
    }
}
