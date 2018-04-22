using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class score : MonoBehaviour
{

    //public float speed;
    //public int count;
    public Text countText;
    public Text winText;

    //private Rigidbody rb;
    private int count;

    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
    }



    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Bullet(Clone)")
        {
            //float translation = Time.deltaTime * 1000;
            Destroy(other.gameObject);
            //scoreVal++;
            //GetComponent<score>().addToScore = scoreVal;
            //print("current score value: " + scoreVal);
            count = count + 1;
            SetCountText();
            print("hello");   
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 2)
        {
            winText.text = "You Win!";
            print("wins");
        }
    }
}


