using UnityEngine;

public class AttackFactory
{
    public AttackFactory(MonoBehaviour behavior)
    {
    }

    public void Attack()
    {
        if (SimpleAttack())
            return;
    }

    private bool SimpleAttack()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {

        }

        return false;
    }
}