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
        transform.position = player.transform.position+offset; // new vector caameranýn oyun alanýný rahat görebilmesi için. offset yerine "new Vector3(0, 6, -14)" de olabilir.

    }
}
