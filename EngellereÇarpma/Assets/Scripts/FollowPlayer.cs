using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -14);

  


    void Start()
    {
       
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position+offset; // new vector caameran�n oyun alan�n� rahat g�rebilmesi i�in. offset yerine "new Vector3(0, 6, -14)" de olabilir.

    }
}
