using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    [SerializeField] GameObject player;
    private Vector3 offset = new Vector3(0, 4, -8f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player != null) { 
        
            transform.position = player.transform.position + offset;
        }
        
    }
}
