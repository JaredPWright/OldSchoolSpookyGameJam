using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    [SerializeField] Vector2 normalCheck = new Vector2(0.0f, -1.0f);

    void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (ContactPoint2D contact in collision.contacts)
        {
            if (contact.normal.y == normalCheck.y)
            {
                PlayerController.grounded = true;
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        PlayerController.grounded = false;
    }
}
