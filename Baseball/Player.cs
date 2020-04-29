using System;

namespace Baseball
{
    public class Player
    {
        public string firstName { get; set; }
        readonly string name = null;
        private Team currentTeam;

        public string Name
        {
            get
            {
                return null;
            }
            set
            {
                //TODO: Don't know why that thing does not work well?
                // this.name = name;
            }
        }

        public Team CurrentTeam
        {
            get
            {
                return currentTeam;
            }
            set
            {
                currentTeam = value;
            }
        }

        public override string ToString()
        {
            return "\nPlayer [name=" + Name + ", firstName=" + firstName + ", currentTeam="
                    + CurrentTeam + ", position=" + position + "]";
        }

        public override int GetHashCode()
        {
            int prime = 31, result = 1;
            result = prime * result + this.firstName.GetHashCode();
            return result;
        }

        public override bool Equals(Object obj)
        {
            if (this == obj)
                return true;
            if (obj == null)
                return false;
            if (GetType() != obj.GetType())
                return false;
            Player other = (Player)obj;
            if (firstName == null)
            {
                if (other.firstName != null)
                    return false;
            }
            else if (firstName == other.firstName)
                return true;
            return false;
        }

        string position;
        public string GetPosition()
        {
            return position;
        }

        public void SetPosition(string position)
        {
            this.position = position;
        }
    }
}
