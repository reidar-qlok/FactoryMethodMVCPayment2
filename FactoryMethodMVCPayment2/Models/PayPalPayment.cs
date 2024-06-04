namespace FactoryMethodMVCPayment2.Models
{
    public class PayPalPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            // Här kan du lägga till logik för att bearbeta PayPal-betalning
            Console.WriteLine($"Håller på med paypal betalning av: {amount:C}");
        }
    }
}
