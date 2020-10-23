public class Country
{
    public enum controlledBy
    {
        HUMAN,
        AI,
        NOONE
    }
    public controlledBy controller;
    public int totalFuel;
    public Country(controlledBy _controller)
    {
        controller = _controller;
    }
}