using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhipAttack : MonoBehaviour
{


    Collider2D triggerBox;

    private void Start()
    {
        triggerBox = GetComponent<Collider2D>();
    }


    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Vector2 attackDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            attackDirection.Normalize();
            if(attackDirection == new Vector2(1,0) || attackDirection == new Vector2(-1, 0))
            {
                //Center left and right
            }
            else if(attackDirection == new Vector2(1,1) || attackDirection == new Vector2(-1, 1))
            {
                //Up left and right
            }
            else if(attackDirection == new Vector2(1, -1) || attackDirection == new Vector2(-1, -1))
            {
                //Down left and right
            }
            else if(attackDirection == new Vector2(0, 1))
            {
                //Straight up
            }
            else if(attackDirection == new Vector2(0, -1))
            {
                //Straight down
            }
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            ActivateTriggerBox();
        }
    }

    public void ActivateTriggerBox()
    {
        triggerBox.enabled = true;
        StartCoroutine(TriggerBoxTimer());
    }

    IEnumerator TriggerBoxTimer()
    {
        yield return new WaitForSeconds(0.1f);
        triggerBox.enabled = false;
    }

}
