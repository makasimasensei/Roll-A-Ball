using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public int score = 0;
    public Text scoreText;
    public Text victoryText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis ("Vertical");
        Debug.Log(h);
        rb.AddForce(new Vector3(h, 0, v));
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Food"))
        {
            Destroy(collision.gameObject);
            score++;
            scoreText.text = "·ÖÊý£º" + score;
            if(score == 7)
            {
                victoryText.text = "Ê¤Àû";
            }
        }
    }
}
