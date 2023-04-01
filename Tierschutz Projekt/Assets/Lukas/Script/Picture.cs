using UnityEngine;

public class Picture : MonoBehaviour
{
    public int id;
    public string name;
    public Sprite image;
    public bool small;
    public float sizex;
    public float sizey;

    public Picture(int id, string name, bool small, float sizex,float sizey)
    {
        this.id = id;
        this.name = name;
        this.image = Resources.Load<Sprite>("images/" + name);
        this.small = small;
        this.sizex = sizex;
        this.sizey = sizey;
    }

    public Picture(Picture picture) {
        this.id = picture.id;
        this.name = picture.name;
        this.image = picture.image;
        this.small = picture.small;
        this.sizex = picture.sizex;
        this.sizey = picture.sizey;
    }

}
