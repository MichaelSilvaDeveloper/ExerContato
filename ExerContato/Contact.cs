namespace ExerContato
{
    public class Contact
    {
        public Contact(string name, int telephone, int age, string gender)
        {
            Name = name;
            Telephone = telephone;
            Age = age;
            Gender = gender;
        }

        public Contact() {}

        public string Name { get; set; }

        public int Telephone { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public override string ToString()
        {
            return "Contact: " + "\n" + "Name: " + Name + "\n" + "Telephone: " + Telephone + "\n" + "Age: " + Age + "\n" + "Gender: " + Gender;
        }
    }
}