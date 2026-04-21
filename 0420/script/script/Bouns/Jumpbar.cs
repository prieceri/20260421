using UnityEngine;
using UnityEngine.UI;

public class Jumpbar : MonoBehaviour
{
    [SerializeField] Image _bar;

    public void UpdateJP(float timer, float cooltimer)
    {
        _bar.fillAmount = timer / cooltimer;
    }
}
