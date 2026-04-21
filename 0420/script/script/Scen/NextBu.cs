using UnityEngine;
using UnityEngine.SceneManagement;

public class NextBu : MonoBehaviour
{
    public static int currentStage = 1;  // �� �ٲ� ������
    public static int maxStage = 3;  // �� �������� ��

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
            GoNextStage();
    }

    // Ż�ⱸ ���� �� ȣ��
    public static void StageClear()
    {
        SceneManager.LoadScene("clear");
    }

    // ClearScene���� �����̽��� ������ ȣ��
    public static void GoNextStage()
    {
        if (currentStage < maxStage)
        {
            currentStage++;
            PlayerPrefs.SetInt("Stage", currentStage); // ����
            SceneManager.LoadScene("Stage" + currentStage);
        }
        else
        {
            // 3������������ ���� Ŭ���� �� Ÿ��Ʋ��
            currentStage = 1;
           // PlayerPrefs.SetInt("Stage", currentStage); // ����
            SceneManager.LoadScene("Finish");
        }
    }
}