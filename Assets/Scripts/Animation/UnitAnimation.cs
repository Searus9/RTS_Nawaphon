using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unit;

public class UnitAnimation : MonoBehaviour
{
    private Animator anim;
    private Unit unit;

    void Start()
    {
        anim = GetComponent<Animator>();
        unit = GetComponent<Unit>();
    }
    private void ChooseAnimation(Unit u)
    {
        anim.SetBool("IsIdle", false);
        anim.SetBool("IsMove", false);
        anim.SetBool("IsAttack", false);

        switch (u.State)
        {
            case UnitState.Idle:
                anim.SetBool("IsIdle", true);
                break;
            case UnitState.Move:
                anim.SetBool("IsMove", true);
                break;
            case UnitState.Attack:
                anim.SetBool("IsAttack", true);
                break;
        }
    }
    void Update()
    {
        ChooseAnimation(unit);
    }
}
