using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenSound : MonoBehaviour
{
    [SerializeField] AudioSource _aduo;
    [SerializeField] GameObject _sound;
    [SerializeField] GameObject _noSound;

    private void Start()
    {
        _aduo = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) == true)
        {
            Debug.Log("음악실행");
            _aduo.Play();
            _sound.SetActive(true);
            _noSound.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.N) == true)
        {
            if (_aduo.isPlaying == true)
            {
                Debug.Log("일시정지");
                _aduo.Pause();
                _sound.SetActive(false);
                _noSound.SetActive(true);
            }
            else
            {
                Debug.Log("풀림");
                _aduo.UnPause();
                _sound.SetActive(true);
                _noSound.SetActive(false);

            };
        }
    }
}
