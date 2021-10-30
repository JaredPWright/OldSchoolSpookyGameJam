using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BossAttackBehaviors
{
    public class WaitingPattern : MonoBehaviour
    {
        public IEnumerator Wait(Animator animator, BossMain.AttackState state)
        {
            animator.Play("Idle");

            yield return new WaitForSeconds(2.0f);

            state = BossMain.AttackState.Closing;
        }
    }

    public class ClosingPattern : MonoBehaviour
    {
        public void Close(Animator animator, Vector3 moveDirection, Transform bossPos, Transform playerPos)
        {
            animator.Play("Idle");
            
        }
    }
}
