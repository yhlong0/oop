namespace ACM.BL
{
    public class Customer
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (string.IsNullOrWhiteSpace(FirstName))
                {
                    fullName = LastName;
                }
                else if (string.IsNullOrWhiteSpace(LastName))
                {
                    fullName = FirstName;
                }
                else
                {
                    fullName = LastName + "," + FirstName;
                }
                return fullName;
            }

        }
    }
}
