using UnityEngine;
using UnityEngine.SceneManagement;

public class firstScen : MonoBehaviour
{
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Scens();
        }
    }
    public void Scens()
    {
        SceneManager.LoadScene("Stage1"); 
    }
}
