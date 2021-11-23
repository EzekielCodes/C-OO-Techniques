class Person
{
    string firstname = "";
    string lastname = "";

    public Person(String firstname, string lastname)
    {
        this.firstname = firstname;
        this.lastname = lastname;   
    }

    public void PrintPersonName()
    {
        Console.WriteLine("Full name " + firstname + " " + lastname);
    }
    static void Main(string[] args)
    {
        Person personobject = new Person("Ezekiel","Akindele");
        personobject.PrintPersonName();
        string age = Console.ReadLine();
        int leeftijd = Convert.ToInt32(age);
        Console.WriteLine("geef uw leeftijd in");
        Console.WriteLine("Age " + leeftijd);
    }
}
    



