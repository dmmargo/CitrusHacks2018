using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}


/*using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    //public int scoreVal = instance.getScoreVal;
    private static string scoreTag = "score";
    public int currentScore = 0;
    public GameObject txt;
    private static object other;
    public int final;

    //int a = PlayerPrefs.GetInt("highscore");

    void start()
    {
        currentScore = 0;
        txt.GetComponent<UnityEngine.UI.Text>().text = currentScore.ToString();
    }
    
    private void Update()
    {
        print("final" +currentScore);
    }
    /*
    public void addToScore(int scores)
    {
        currentScore = scores;
    }*/
/*
void GroupNumber0()
{
    //Talk too WallSection. and set NumberOfWalls to 10

    GameObject.Find("highest score").GetComponent<hittingtarget>().setScore(1);
}

}*/

