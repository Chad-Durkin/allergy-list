using Xunit;
using System;
using System.Collections.Generic;
using AllergyIdentifier.Objects;

namespace AllergyIdentifierTest
{
    public class AllergyIdentifierTest
    {
        [Fact]
        public void CheckIfTheFunctionInputsTheCorrespondingAllergyIntoTheListBasedOnThe_Score()
        {
            //Arrange
            int allergyScore = 130;
            List<string> checkAllergy = new List<string> {"cats", "peanuts"};
            //Act
            Allergies newAllergy = new Allergies(allergyScore);
            newAllergy.CalcAllergies();
            //Asset
            Assert.Equal(checkAllergy[1], newAllergy.GetAllergyList()[1]);
        }
    }
}
