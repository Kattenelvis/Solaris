public class Country
{
    public enum controlledBy
    {
        HUMAN,
        AI,
        NOONE
    }
    controlledBy controller;
    public Country(controlledBy _controller)
    {
        controller = _controller;
    }
}