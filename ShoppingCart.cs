namespace ShoppingCart
{
    class ShoppingCart
    {
        static void Main()
        {
            Dictionary<string, double> prices = new Dictionary<string, double>
        {
            { "Laptop", 999.99 },
            { "Mouse", 25.50 },
            { "Keyboard", 45.75 }
        };
            Dictionary<string, int> cart = new Dictionary<string, int>();

            // Add items to cart
            AddToCart(cart, "Laptop");
            AddToCart(cart, "Mouse");
            AddToCart(cart, "Mouse"); // Adding second mouse

            // Display cart and total
            double total = 0;
            Console.WriteLine("Cart Summary:");

            foreach (var item in cart)
            {
                double subtotal = prices[item.Key] * item.Value;
                Console.WriteLine($"{item.Key} x {item.Value} = ${subtotal:F2}");
                total += subtotal;
            }
            Console.WriteLine($"Total: ${total:F2}");
        }
        static void AddToCart(Dictionary<string, int> cart, string item)
        {
            if (cart.ContainsKey(item))
                cart[item]++;
            else
                cart[item] = 1;
        }
    }
}
