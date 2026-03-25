namespace RentalProject.Items;

public class Camera : Item {
    private string resolution;
    private bool wireless;

    public Camera(string resolution, bool wireless) : base("camera") {
        this.resolution = resolution;
        this.wireless = wireless;
    }
}