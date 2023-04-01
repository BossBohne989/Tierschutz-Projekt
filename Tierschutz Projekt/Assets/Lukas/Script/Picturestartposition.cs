using UnityEngine;

public class Picturestartposition : MonoBehaviour
{
    Vector2 Firstpicturesmall = new Vector2(4.5f, 0);
    Vector2 Secondpicturesmall = new Vector2(-4.5f, 0);

    Vector2 Firstpicturebig = new Vector2(4.5f, 0);
    Vector2 Secondpicturebig = new Vector2(-4.5f, 0);

    float speed = 0.1f;
    private void Start()
    {
        if (gameObject.name == "Picture1" || gameObject.name == "Picture2")
            gameObject.transform.position = new Vector3(12, 0, 0);
        else
            gameObject.transform.position = new Vector3(12, -2.5f, 0);
    }

    public void firstpicsmall()
    {
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, Firstpicturesmall, speed * Time.deltaTime);
    }
    public void secondpicsmall()
    {

    }
    public void firstpicbig()
    {

    }
    public void secondpicbig()
    {

    }
}
