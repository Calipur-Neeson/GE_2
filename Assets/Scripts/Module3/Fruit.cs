using UnityEngine;

public abstract class Fruit : MonoBehaviour
{
    public string name;
    public int healHealth;

    public abstract void Eat();

    public abstract void Throw();
}
