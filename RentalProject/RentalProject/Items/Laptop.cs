namespace RentalProject.Items;

public class Laptop : Item {
    private string screenSize;
    private string osType;

    public Laptop(string screenSize, string osType) : base("laptop") {
        this.screenSize = screenSize;
        this.osType = osType;
    }
}