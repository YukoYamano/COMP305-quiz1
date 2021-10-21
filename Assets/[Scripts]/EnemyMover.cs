using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    private Vector3 targetPosition;

    //6~1

    // Start is called before the first frame update
    void Start()
    {
       targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 10.0f + targetPosition.y, targetPosition.z);
    }

  
}
