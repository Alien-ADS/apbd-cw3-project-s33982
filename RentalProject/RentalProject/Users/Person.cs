using RentalProject.Items;

namespace RentalProject.Users;

public abstract class Person {
    private static int id = 0;
    private string identifier { get; }
    private string name;
    private string surname;
    private string type;
    private int maxActiveRent;
    private Item[] rentList;

    protected Person(string name, string surname, string type, int maxActiveRent) {
        this.name = name;
        this.surname = surname;
        this.type = type;
        this.maxActiveRent = maxActiveRent;
        rentList = new Item[maxActiveRent];
    }

}