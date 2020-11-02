public class Player
{
    public enum controlledBy
    {
        HUMAN,
        AI,
        NOONE
    }
    public controlledBy controller;
    public int totalFuel;
    public Player(controlledBy _controller)
    {
        controller = _controller;
    }
}