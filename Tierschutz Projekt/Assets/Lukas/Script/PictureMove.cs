using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class PictureMove : MonoBehaviour
{
    Vector2 Firstposition = new Vector2(-226, 132);
    Vector2 Secondposition = new Vector2(289, 132);
    Vector2 Thirdposition = new Vector2();
    Vector2 Fourthposition = new Vector2();
    bool start = true;
    public void MouseDownEvent()
    {
        Debug.Log("test");
        if (start)
        {
            gameObject.transform.position = Firstposition;
            start = false;
        }
        else if (gameObject.transform.position.x == Firstposition.x)
        {
            gameObject.transform.position = Secondposition;
        }
        
        
        

    }


}
