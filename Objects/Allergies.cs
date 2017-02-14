using System.Collections.Generic;
using System;

namespace AllergyIdentifier.Objects
{
    public class Allergies
    {
        private int _score;
        private List<string> _allergies = new List<string> {};
        private Dictionary<int, string> _allergyDictionary = new Dictionary<int, string>()
        {
            {1, "eggs"},
            {2, "peanuts"},
            {4, "shellfish"},
            {8, "strawberries"},
            {16, "tomatoes"},
            {32, "chocolate"},
            {64, "pollen"},
            {128, "cats"}
        };
        private int[] _allergyValues = new int[] {1, 2, 4, 8, 16, 32, 64, 128};

        public Allergies(int newScore)
        {
            _score = newScore;
        }

        public void CalcAllergies()
        {
            var tempScore = _score;

            for(var index = (_allergyDictionary.Count - 1); index >= 0; index--)
            {
                if(tempScore >= _allergyValues[index])
                {
                    _allergies.Add(_allergyDictionary[_allergyValues[index]]);
                    tempScore -= _allergyValues[index];
                }
            }
        }

        public List<string> GetAllergyList()
        {
            return _allergies;
        }
    }
}
