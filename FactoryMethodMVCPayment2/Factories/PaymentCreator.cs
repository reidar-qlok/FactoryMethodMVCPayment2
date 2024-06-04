using FactoryMethodMVCPayment2.Models;

namespace FactoryMethodMVCPayment2.Factories
{
    public abstract class PaymentCreator
    {
        public abstract PaymentMethod CreatePaymentMethod();

        public void ProcessPayment(decimal amount)
        {
            PaymentMethod paymentMethod = CreatePaymentMethod();
            paymentMethod.ProcessPayment(amount);
        }
    }
}
