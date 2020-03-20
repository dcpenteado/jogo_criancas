using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class CameraController : MonoBehaviour {
	
    public PlayerController player;
    public GameObject rocks1;
    public GameObject rocks2;
    public GameObject rocks3;
    private Vector3 lastPlayerPosition;
    private float distanceToMove;
	
    // Use this for initialization
    void Start () {
        lastPlayerPosition = player.transform.position;
    }
	
    // Update is called once per frame
    void Update () {
        distanceToMove = player.transform.position.x - lastPlayerPosition.x;
        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);
        lastPlayerPosition = player.transform.position;

        //PARALLAX BACKGROUND
        
        if (rocks1.transform.localPosition.x <= -8.88)
        {
            rocks1.transform.localPosition = new Vector3(10.31f, rocks1.transform.localPosition.y, 0);
        }
        else
        {
            rocks1.transform.position = new Vector3(rocks1.transform.position.x - distanceToMove * 0.3f, rocks1.transform.position.y, 0);
        }
        

        //Debug.Log(rocks1.GetComponent<SpriteRenderer>().bounds.size.x);
        
        //rocks2.transform.position = new Vector3(rocks2.transform.position.x - distanceToMove * 0.2f, 0, 0);
        //rocks3.transform.position = new Vector3(rocks3.transform.position.x - distanceToMove * 0.1f, 0, 0);
    }
}