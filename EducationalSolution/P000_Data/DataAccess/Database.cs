using System.Collections.Generic;

using P000_Data.DataModel;

namespace P000_Data.DataAccess
{
    public static class Database
    {
        #region GetPersons

        public static List<Person> GetPersons()
        {
            List<Person> staff = new List<Person>
            {
                new Person
                {
                    Name = "Linus Torvalds",
                    Profession = Profession.Development,
                    Children =
                    {
                        new Person
                        {
                            Name = "Hercule Poirot",
                            Profession = Profession.Policeman,
                            Children =
                            {
                                new Person
                                {
                                    Name = "Lady Mallowan",
                                    Profession = Profession.Writer
                                }
                            }
                        },
                        new Person
                        {
                            Name = "Sherlock Holmes",
                            Profession = Profession.Policeman,
                            Children =
                            {
                                new Person
                                {
                                    Name = "Dr. Watson",
                                    Profession = Profession.Doctor
                                }
                            }
                        },
                    }
                },
                new Person
                {
                    Name = "James Parsons",
                    Profession = Profession.Actor,
                    Children =
                    {
                        new Person
                        {
                            Name = "Sheldon Cooper",
                            Profession = Profession.Scientist,
                            Children =
                            {
                                new Person
                                {
                                    Name = "Amy Farrah Fowler",
                                    Profession = Profession.Scientist,
                                }
                            }
                        },
                        new Person
                        {
                            Name = "Leonard Hofstadter",
                            Profession = Profession.Scientist,
                            Children =
                            {
                                new Person
                                {
                                    Name = "Stuart David Bloom",
                                    Profession = Profession.Seller,
                                }
                            }
                        }
                    }
                },
                new Person
                {
                    Name = "Kaley Cuoco",
                    Profession = Profession.Actor,
                    Children =
                    {
                        new Person
                        {
                            Name = "Penny",
                            Profession = Profession.Seller,
                        }
                    }
                },
            };

            return staff;
        }

        #endregion // GetPersons
    }
}
