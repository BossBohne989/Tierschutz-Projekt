using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Picturedatabase : MonoBehaviour
{
    public List<Picture> pictureList = new List<Picture>();
    public void Awake()
    {
        BuildPictureDatabase();
    }
    public Picture Getimage(string objectname)
    {
        return pictureList.Find(pictureList => pictureList.name == objectname);
    }
    
    // false = smallpicture / true = bigpicture

    // small Picture Size X = 1.75f , Y = 1.25f
    // Big Picture Size X = 1.5f , Y 1.25f

    void BuildPictureDatabase()
    {
        // new Picture(id,name,size(true/false),sizex,sizey)
        pictureList = new List<Picture>()
        {
            new Picture(0, "Picture1", true, 1.75f, 1.25f),
            new Picture(1, "Picture2", false,  1.5f, 1.25f),
            new Picture(2, "Picture3", false,  1.5f, 1.25f),
            new Picture(3, "Picture4", true, 1.75f, 1.25f)
        };
    }

}
