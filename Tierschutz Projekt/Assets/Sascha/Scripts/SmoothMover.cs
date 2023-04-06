using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMover : MonoBehaviour
{
    [SerializeField] private Transform start;
    [SerializeField] private Transform startUp;
    [SerializeField] private Transform startDown;
    [SerializeField] private Transform middle;
    [SerializeField] private Transform leftUp;
    [SerializeField] private Transform left;
    [SerializeField] private Transform leftDown;
    [SerializeField] private Transform rightUp;
    [SerializeField] private Transform right;
    [SerializeField] private Transform rightDown;

    public bool move;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = start.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            move = true; 
            Debug.Log("move true");
        }

        if (move == true){
        transform.position = Vector2.Lerp(transform.position, middle.position, Time.deltaTime);
        //if (middle.position - transform.position <= 0.01f){
        //    transform.position = middle.position;
        //}
        }
    }

}
