namespace PizzaStore
{
    public class Order
    {
        #region Instance fields
        public double _total;
        int deliveryCost = 40;
        public string _name;
        double tax = 1.25;
        double _totalPrice;
        Pizza _pizza;
        Customer _customer;

        
        
        
        #endregion

        #region Constructor
        public Order(Pizza pizza, Customer customer)
        {
            
            _pizza = pizza;
            _customer = customer;

            _totalPrice = CalculateTotalPrice();
        }

        #endregion


        #region Properties
        public string Name

        { get; set; }

        public Pizza pizza
        {
         get { return _pizza; }
            
        private set { _pizza = value; }
        
        
        }
        public Customer customer
        {
            get { return _customer; }
            private set { _customer = value; }
        }

        public double totalPrice
        { get { return _totalPrice; } }
           
        
      
        
     




        #endregion
        #region Methods
        double CalculateTotalPrice()
        {
           double totalPrice = (pizza.Price + deliveryCost) * tax;
            return totalPrice;
        }

        public override string ToString()
        {
            return $"Pris for levering: {deliveryCost} - {pizza.ToString()} - {customer.ToString()} - {totalPrice}";
        }

        #endregion



        /// <summary>
        /// Type of pizza;
        /// </summary>





        /// Customer name

    }
}
