using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CSVLoader
{
    internal static class CSVConvertor
    {
        public static string[] outputCSV(ObservableCollection<Person> persons, string seperator)
        {
            // +1 because we need to include the headers
            string[] tempArr = new string[persons.Count + 1];
            tempArr[0] = "Vorname{seperator}NachName{seperator}Email{seperator}Birthday{seperator}ID";
            for (int count = 0; count < persons.Count; count++)
            {
                tempArr[count + 1] = $"{persons[count].Name} {seperator} {persons[count].LastName} {seperator} " +
                    $"{persons[count].Email} {seperator} {persons[count].Birthday} {seperator} {persons[count].ID}";
            }
            return tempArr;
        }

        public static ObservableCollection<Person> ImportCSV(string[] importText, string seperator)
        {
            ObservableCollection<Person> tempList = new ObservableCollection<Person>();
            if (importText.Length > 1)
            {
                for (int count = 1;count < importText.Length; count++) 
                {
                    // Max;Muster;mm@gmail.com;01.01.2020;123
                    string[] tempString = importText[count].Split(seperator);
                    if (tempString.Length != 5)
                    {
                        throw new FormatException("CSV is in the wrong format or empty");
                    }

                    Person tempPerson = new Person();
                    tempPerson.Name = tempString[0];
                    tempPerson.LastName = tempString[1];
                    tempPerson.Email = tempString[2];
                    tempPerson.Birthday = DateTime.Parse(tempString[3]);
                    int test;
                    int.TryParse(tempString[4], out test);
                    tempPerson.ID = test;

                    tempList.Add(tempPerson);
                }

               
            }
            return tempList;
        }
    }
}
