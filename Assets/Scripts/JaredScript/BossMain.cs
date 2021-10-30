using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BossAttackBehaviors;

public class BossMain : MonoBehaviour
{
    public enum AttackState {Waiting, MagicPulse, LightSwing, HeavySwing, Closing}

    public AttackState attackState;
    public Animator animator;
    public GameObject[] arms;

    public float meleeRangeIncrement = 5.0f;
    public float rangedRangeIncrement = 10.0f;
    public float closeRangeIncrement = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        attackState = AttackState.Waiting;
    }

    // Update is called once per frame
    void Update()
    {
        switch(attackState)
        {
            case AttackState.Waiting :
            {
                //WaitingPattern.Wait(animator, attackState);
                break;
            }
            case AttackState.Closing :
            {
                break;
            }
            case AttackState.LightSwing :
            {
                break;
            }
            case AttackState.HeavySwing :
            {
                break;
            }
            case AttackState.MagicPulse :
            {
                break;
            }
        }
    }
}
