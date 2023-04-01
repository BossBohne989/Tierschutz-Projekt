using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PictureMove : MonoBehaviour
{
    Vector2 Firstpicturesmall = new Vector2(4.5f, 0);
    Vector2 Secondpicturesmall = new Vector2(-4.5f, 0);

    Vector2 smallLeftup = new Vector2(-4, 2.5f);
    Vector2 smallleftdown = new Vector2(-4, -2.5f);

    Vector2 smallrightup = new Vector2(4.05f, 2.5f);
    Vector2 smallrightdown = new Vector2(4.05f,-2.5f);


    Vector2 Firstpicturebig = new Vector2(4.5f, 0);
    Vector2 Secondpicturebig = new Vector2(-4.5f, 0);

    Vector2 bigLeftup = new Vector2(-2.65f, 2.5f);
    Vector2 bigleftdown = new Vector2(-2.65f, -2.5f);

    Vector2 bigrightup = new Vector2(2.7f, 2.5f);
    Vector2 bigrightdown = new Vector2(2.7f, -2.5f);

    public Picturedatabase picturedatabase = new Picturedatabase();
    GameObject newPicture;
    bool mouseindonw = false;
    float speed = 1f;
    private void Awake()
    {
        picturedatabase = FindObjectOfType<Picturedatabase>();
        createPicture();
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseindonw = true;
        }
        if (mouseindonw)
        {
            movePicture();
            mouseindonw = false;
        }
    }

    bool small, startpicone = true;
    int count = 1;
    string name;
    int startcount = 1;

    void createPicture()
    {
        int i = 0;
        foreach (Picture picture in picturedatabase.pictureList)
        {
            GameObject newPicture = new GameObject(picture.name);
            newPicture.name = picture.name; // Set the name of the GameObject to the name of the picture
            SpriteRenderer sr = newPicture.AddComponent<SpriteRenderer>();
            newPicture.AddComponent<Picturestartposition>();
            sr.sprite = picture.image;
            if (picture.small)
                newPicture.tag = "small";
            else
                newPicture.tag = "big";
            // Set the position of the GameObject based on the size and position of the picture
            newPicture.transform.position = picture.small ? smallLeftup : bigLeftup;
            i++;
        }
        /*
        for (int i = 0; i < picturedatabase.pictureList.Count; i++)
        {
            Picture picture = picturedatabase.Getimage("Picture" + count);
            newPicture = new GameObject(picture.name);
            SpriteRenderer sr = newPicture.AddComponent<SpriteRenderer>();
            newPicture.AddComponent<Picturestartposition>();
            sr.sprite = picture.image;
            small = picture.small;
            if (picture.small)
                newPicture.tag = "small";
            else
                newPicture.tag = "big";
            name = picture.name;
            //GameObject parentObject = GameObject.Find("Canvas");
            //newPicture.transform.SetParent(parentObject.transform);
            count++;
        }*/
    }

    void movePicture()
    {
        GameObject picture = GameObject.Find("Picture" + startcount);
        if (picture != null)
        {
            if (startpicone)
            {
                startpicone = false;
                if (picture.tag == "small")
                    picture.transform.position = Vector2.MoveTowards(picture.transform.position, Firstpicturesmall, speed * Time.deltaTime);
                else
                    picture.transform.position = Vector2.MoveTowards(picture.transform.position, Firstpicturebig, speed * Time.deltaTime);
            }
            else if (!startpicone)
            {
                Debug.Log("second");
                if (picture.tag == "small")
                    picture.transform.position = Vector2.MoveTowards(picture.transform.position, Secondpicturesmall, speed * Time.deltaTime);
                else
                    picture.transform.position = Vector2.MoveTowards(picture.transform.position, Secondpicturebig, speed * Time.deltaTime);
            }
        }
        startcount++;
        /*
        GameObject newPicture = GameObject.Find("Picture"+startcount); 
        if (newPicture != null)
        {
            if (startpicone)
            {
                startpicone = false;
                if (newPicture.tag == "small")
                    newPicture.transform.position = Vector2.MoveTowards(newPicture.transform.position, Firstpicturesmall, speed * Time.deltaTime);
                else
                    newPicture.transform.position = Vector2.MoveTowards(newPicture.transform.position, Firstpicturebig, speed * Time.deltaTime);
            }
            else if (!startpicone)
            {
                Debug.Log("second");
                if (newPicture.tag == "small")
                    newPicture.transform.position = Vector2.MoveTowards(newPicture.transform.position, Secondpicturesmall, speed * Time.deltaTime);
                else
                    newPicture.transform.position = Vector2.MoveTowards(newPicture.transform.position, Secondpicturebig, speed * Time.deltaTime);
            }
        }
        startcount++;
    }*/

    }
}
