using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            FirstScene();
        }
    }
    public void FirstScene()
    {
        SceneManager.LoadScene("Frist"); 
    }
    
}