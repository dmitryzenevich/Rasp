using System;

namespace Store
{
    public class Good : IEquatable<Good>
    {
        private readonly string _name;

        public Good(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException(nameof(name));
            
            _name = name;
        }

        public bool Equals(Good other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _name == other._name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Good)obj);
        }

        public override int GetHashCode()
        {
            return (_name != null ? _name.GetHashCode() : 0);
        }
    }
}