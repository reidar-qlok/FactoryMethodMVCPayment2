namespace FactoryMethodMVCPayment2.Models
{
    public class CreditCardPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            // Här kan du lägga till logik för att bearbeta kreditkortsbetalning
            Console.WriteLine($"Håller på med kreditkorts betalning av: {amount:C}");
        }
    }
}
