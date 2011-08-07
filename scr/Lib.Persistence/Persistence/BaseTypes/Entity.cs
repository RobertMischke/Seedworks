using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seedworks.Lib.Persistence
{
    /// <remarks>
    /// Based on:
    /// https://github.com/Slesa/Playground/blob/master/src/lib/DataAccess/DataAccess/DomainEntity.cs
    /// </remarks>>
    public class DomainEntity : IEquatable<DomainEntity>, IPersistable, WithDateCreated, WithDateModified
    {
        protected DomainEntity()
        {
        }

        protected DomainEntity(int id)
        {
            Id = id;
        }

        public virtual int Id { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public virtual bool Equals(DomainEntity other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id.Equals(default(int)) ? base.Equals(other) : other.Id.Equals(Id);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as DomainEntity);
        }

        public override int GetHashCode()
        {
            return Id.Equals(default(int)) ? base.GetHashCode() : Id.GetHashCode();
        }

        public static bool operator ==(DomainEntity left, DomainEntity right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DomainEntity left, DomainEntity right)
        {
            return !Equals(left, right);
        }
    }
}
