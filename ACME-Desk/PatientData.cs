namespace ACME_Desk
{
    public class PatientData
    {
        public PatientData(
            string name,
            string birthDate,
            string cpf,
            string gender,
            string addressLine,
            string addresNumber,
            string district,
            string city,
            string state,
            string zipCode
            )
        {
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
        }

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
    }
}
