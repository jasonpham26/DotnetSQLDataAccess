﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                // var output = connection.Query<Person>($"Select * From people where LastName= '{lastName}'").ToList();
                var param = new { LastName = lastName };
                var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", param).ToList();
                return output;
            }


        }

        public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                Person newPerson = new Person
                {
                    FirstName = firstName, 
                    LastName = lastName,
                    EmailAddress = emailAddress,
                    PhoneNumber = phoneNumber
                };

                List<Person> people = new List<Person>();

                people.Add(newPerson);
                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);

            }
        }
    }
}
