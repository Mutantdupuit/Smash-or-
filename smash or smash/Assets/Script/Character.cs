using Unity.VisualScripting;

public class Character
{
    int vie;
    int mental;
    int romance;
    int degat;

    public Character(int vie = 100)
    {
        this.vie = vie;
    }

    public int Mental { get => mental; set => mental = mental-value; }
    public int Romance { get => romance; set => romance = romance+value; }
    public int Vie { get => vie; set => vie = vie-value; }
    public int Degat { get => degat; set => degat = degat - value; }

}