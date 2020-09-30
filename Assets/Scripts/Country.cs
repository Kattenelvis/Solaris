public class Country
{
    public enum controlledBy
    {
        HUMAN,
        AI,
        NOONE
    }
    controlledBy controller;
    public int totalFuel;
    public Country(controlledBy _controller)
    {
        controller = _controller;
    }
}