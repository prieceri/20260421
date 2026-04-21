using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Image _timerbar;
    
    public void UpdateTimer(float Timer, float ChangeTime)
    {
        _timerbar.fillAmount = Timer / ChangeTime;
    }
 }
