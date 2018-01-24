﻿using System.Collections.Generic;

namespace ExampleModel.Models
{
    public class ExampleContext
    {
        public List<Car> Cars { get; } = new List<Car>();
        public List<Employee> Employees { get; } = new List<Employee>();
        public List<Business> Businesses { get; } = new List<Business>();
    }
}
