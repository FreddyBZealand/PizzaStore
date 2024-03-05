using System.Diagnostics;

namespace PizzaStore
{
    public class Customer
    {
        #region Instance fields

        public string _name;
        public string _email;
        public int _phone;



        #endregion

        #region Constructor
        public Customer(string name, string email, int phone)
        {
            _name = name;
            _email = email;
            _phone = phone;


        }

        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
        }
        public string Email
        {
            get { return _email; }
        }
        public int Phone
        {
            get { return _phone; }
        }


        #endregion

        #region Methods
        public override string ToString()
        {
            return $"name: {Name} - email: {Email} - phone {Phone}";
        }


        #endregion



    }
}

