using UnityEngine;

public class Apple : Fruit
{
    public override void Eat()
    {
        Debug.Log($"Eat the {name} heal {healHealth}");
    }

    public override void Throw()
    {
        Debug.Log($"Throw the {name} heal enemy {healHealth}");
    }
}
