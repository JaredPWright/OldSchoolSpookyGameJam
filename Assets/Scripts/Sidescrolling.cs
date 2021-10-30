using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace Sidescrolling
{
    public class Movement : MonoBehaviour
    {
        private Rigidbody2D playerRigidbody;

        //Getting Input through these booleans
        [SerializeField] bool[] movementBools = {false, false, false};

        void Start()
        {
            playerRigidbody = GetComponent<Rigidbody2D>();
        }

        
    }
}