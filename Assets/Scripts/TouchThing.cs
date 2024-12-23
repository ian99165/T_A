using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TouchThing : MonoBehaviour
{
    public Transform player;
    public Image questionImage;
    public Sprite[] questionSprites;
    public int currentQuestion;
    public int correctAnswer;

    void Start()
    {
        RandomizeQuestion();
    }

    void RandomizeQuestion()
    {
        currentQuestion = Random.Range(1, 7);
        questionImage.sprite = questionSprites[currentQuestion - 1];

        switch (currentQuestion)
        {
            case 1:
            case 2:
                correctAnswer = 1;
                break;
            case 3:
            case 4:
                correctAnswer = 2;
                break;
            case 5:
            case 6:
                correctAnswer = 3;
                break;
            default:
                correctAnswer = 1;
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (currentQuestion)
        {
            case 1:
            case 2:
                if (collision.gameObject.CompareTag("A"))
                {
                    SceneManager.LoadScene("S2");
                    Debug.Log(collision.gameObject.name);
                }
                else if (collision.gameObject.CompareTag("B") || collision.gameObject.CompareTag("C"))
                {
                    player.position = new Vector3(0, -2.7f, 0);
                }
                break;
            case 3:
            case 4:
                if (collision.gameObject.CompareTag("B"))
                {
                    SceneManager.LoadScene("S2");
                    Debug.Log(collision.gameObject.name);
                }
                else if (collision.gameObject.CompareTag("A") || collision.gameObject.CompareTag("C"))
                {
                    player.position = new Vector3(0, -2.7f, 0);
                }
                break;
            case 5:
            case 6:
                if (collision.gameObject.CompareTag("C"))
                {
                    SceneManager.LoadScene("S2");
                    Debug.Log(collision.gameObject.name);
                }
                else if (collision.gameObject.CompareTag("A") || collision.gameObject.CompareTag("B"))
                {
                    player.position = new Vector3(0, -2.7f, 0);
                }
                break;
        }
    }
}
