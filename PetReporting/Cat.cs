using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeExcercise
{
    public class Cat:IPet
    {
        private string firstName;
        private string lastName;
        private DateTime joinedPractice;
        private int numberofVisits;
        private double costperVisit;
        public int? numberOfLives;
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public DateTime JoinedPractice
        {
            get
            {
                return this.joinedPractice;
            }
            set
            {
                this.joinedPractice = value;
            }
        }
        public int NumberOfVisits
        {
            get
            {
                return this.numberofVisits;
            }
            set
            {
                this.numberofVisits = value;
            }
        }
        public double CostPerVisit
        {
            get
            {
                return this.costperVisit;
            }
            set
            {
                this.costperVisit = value;
            }
        }

    }
}
