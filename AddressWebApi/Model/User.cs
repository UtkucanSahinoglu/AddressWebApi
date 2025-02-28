﻿using System.Collections.Generic;

namespace AddressWebApi.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
    }
}
