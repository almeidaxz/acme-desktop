using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ACME_Desk
{
    public class Patients
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string BirthDate { get; private set; }
        public string Cpf { get; private set; }
        public string Gender { get; private set; }
        public string AddressLine { get; private set; }
        public string AddresNumber { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
        public bool Active { get; private set; }
        public Patients(
            int id,
            string name,
            string birthDate,
            string cpf,
            string gender,
            string addressLine,
            string addresNumber,
            string district,
            string city,
            string state,
            string zipCode,
            bool active
            )
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Cpf = cpf;
            Gender = gender;
            AddressLine = addressLine;
            AddresNumber = addresNumber;
            District = district;
            City = city;
            State = state;
            ZipCode = zipCode;
            Active = active;
        }

        public static IEnumerable<Patients> GetList()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"http://localhost:5158/");

            var response = client.GetAsync($"patients/list").Result;
            if (!response.IsSuccessStatusCode) return null;

            var patients = response.Content.ReadAsAsync<IEnumerable<Patients>>().Result;

            return patients;
        }
    }
}
