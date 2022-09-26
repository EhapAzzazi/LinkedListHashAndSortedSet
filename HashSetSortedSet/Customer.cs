namespace HashSetSortedSet
{
    class Customer : IComparable<Customer>
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public override int GetHashCode()
        {
            var hash = 7;
            hash = (hash * 13) + Name.GetHashCode();
            hash = (hash * 13) + Telephone.GetHashCode();
            return hash;
        }
        public override bool Equals(object? obj)
        {
            var customer = obj as Customer;
            if (customer is null) return false;

            return this.Telephone.Equals(customer.Telephone) && this.Name.Equals(customer.Name);
        }
        public override string ToString()
        {
            return $"[{Name}] -- [{Telephone}]";
        }

        public int CompareTo(Customer? other)
        {
            if (other is null) return -1;
            if (other.Equals(this)) return 0;
            // or we can use if (object.ReferenceEquals(this, other); return 0;
            return this.Name.CompareTo(other.Name);
        }
    }
}