public class Player
{
    public enum controlledBy
    {
        HUMAN,
        AI,
        NOONE
    }
    public controlledBy controller;
    Region[] regionsControlled;
    //Each nation gets its own tag so one can look it up in a table or whatever.
    //It's used by paradox interactive.
    public string tag;
    public string name { get; }
    public int totalFuel;
    public Player(controlledBy controller, string name)
    {
        this.controller = controller;
        this.name = name;
    }
}