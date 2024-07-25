using Unity.VisualScripting;

public class Character
{
    public int vie;
    public int mental;
    public int romance;

    public int force = 0;
    public Character(int vie = 100)
    {
        this.vie = vie;
    
    }

    public int Mental { get => mental; set => mental = value; }
    public int Romance { get => romance; set => romance = value; }
    public int Vie { get => vie; set => vie = value; }

}