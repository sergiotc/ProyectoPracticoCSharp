using System;
using System.Collections.Generic;


namespace appGameCenter
{
    public class Player
    {
        private string nickname;
        public string Nickname
        {
            get { return nickname; }
        }

        private string email;
        public string Email
        {
            get { return email; }
        }

        private Countries country;

        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }

        public Player(string Nickname, string Email, Countries Country)
        {
            this.nickname = Nickname;
            this.email = Email;
            this.country = Country;
        }

        public override bool Equals(object obj)
        {
            if (true)
            {
                Player aux = (Player)obj;
                return this.nickname == aux.nickname;
            }
            else
            {
                return false;
            }
            
           
        }
        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", nickname, email, country);
        }
    }
    
}
