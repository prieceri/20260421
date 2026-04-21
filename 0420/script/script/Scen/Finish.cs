using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 플레이어 태그 확인
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("clear");
        }
    }
    
}