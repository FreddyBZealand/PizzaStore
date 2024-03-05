namespace PizzaStore
{
    public class Pizza
    {

       

      
        #region Instance fields 

        public string _name;
        public int _price;


        #endregion
        #region Constructor
        public Pizza(string name, int price)
        {
       

            _name = name;
            _price = price; 
            

        }
        #endregion
        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
      
            
        #endregion
        #region Methods
        

        
   
       
        public override string ToString()
        {
            return $"name: {Name} - price: {Price}";
        }
        #endregion
    }









}
