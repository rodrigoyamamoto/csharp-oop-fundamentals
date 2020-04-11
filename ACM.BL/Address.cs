﻿namespace ACM.BL
{
    public class Address : EntityBase
    {
        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public override bool Validate()
        {
            var isValid = true;

            if (PostalCode == null)
                isValid = false;

            return isValid;
        }
    }
}
