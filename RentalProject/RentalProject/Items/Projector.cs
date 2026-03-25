namespace RentalProject.Items;

public class Projector : Item {
    private double lampMaxHeat;
    private double maxZoom;

    public Projector(double lampMaxHeat, double maxZoom) : base("projector") {
        this.lampMaxHeat = lampMaxHeat;
        this.maxZoom = maxZoom;
    }
}