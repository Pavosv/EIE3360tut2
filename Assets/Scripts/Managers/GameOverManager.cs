using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Text GameOverText;

    //Animator anim;


    void Awake()
    {
        GameOverText.enabled = false;
        //anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            GameOverText.enabled = true;
            //anim.SetTrigger("GameOver");
        }
    }
}
