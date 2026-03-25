namespace RentalProject.Items;

public abstract class Item {
    private static int id = 0;
    private string identifier { get; }
    private string name { get; }
    private bool available = true;

    protected Item(string name) {
        identifier = name + id;
        this.name = name;
    }
}