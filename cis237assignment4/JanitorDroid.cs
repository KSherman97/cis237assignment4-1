﻿// Kyle Sherman
// Assignment 4
// Due 3/20/17

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    //Class that inherits from the Utility class
    class JanitorDroid : UtilityDroid, IDroid
    {
        //Some protected variables that can be accessed in derived classes
        protected bool hasTrashCompactor;
        protected bool hasVacuum;

        //Constuctor that takes lots of parameters to create the droid. The base constructor is used to do some of the work
        public JanitorDroid(string Material, string Model, string Color,
            bool HasToolbox, bool HasComputerConnection, bool HasArm, bool HasTrashCompactor, bool HasVacuum) :
            base(Material, Model, Color, HasToolbox, HasComputerConnection, HasArm)
        {
            //Assign the values that the base constructor is not taking care of.
            this.hasTrashCompactor = HasTrashCompactor;
            this.hasVacuum = HasVacuum;
        }

        //Override the CalculateCostOfOptions method.
        //Use the base class implementation of the method, and tack on the cost of the new options
        protected override decimal CalculateCostOfOptions()
        {
            decimal optionsCost = 0;

            optionsCost += base.CalculateCostOfOptions();

            if (hasTrashCompactor)
            {
                optionsCost += COST_PER_OPTION;
            }

            if (hasVacuum)
            {
                optionsCost += COST_PER_OPTION;
            }


            

            return optionsCost;
        }

        //Overridden method to calculate the total cost. This method uses the base cost from the parent droid class,
        //and the cost of the options of this class to create the total cost.
        public override void CalculateTotalCost()
        {
            this.CalculateBaseCost();

            this.totalCost = this.baseCost + this.CalculateCostOfOptions();
            //TotalCost = this.totalCost;
        }

        //Overridden ToString that uses the base ToString method, and appends the missing information.
        public override string ToString()
        {
            return base.ToString() +
                "Has Trash Compactor: " + this.hasTrashCompactor + Environment.NewLine +
                "Has Vacuum: " + this.hasVacuum + Environment.NewLine;
        }

        // compare to override. Required since we referenced the icomparable
        //public override int CompareTo(Droid thatDroid)
        //{
        //    return base.CompareTo(thatDroid);
        //}
    }
}
