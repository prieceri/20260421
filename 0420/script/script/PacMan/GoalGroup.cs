using UnityEngine;

public class GoalGroup : MonoBehaviour
{
    [SerializeField] Timer _timerbar;
    [SerializeField] GameObject[] _goals; // 골인지점들 Inspector에서 배치
    [SerializeField] float _changeTime; // 랜덤 시간 설정
    [SerializeField] Animator _currentGoalAnim;
    private int _currentIndex = -1;     // 비활성화
    private float _timer = 0f;          // 타이머


    public float ChangeTime => _changeTime;
    public float Timer => _timer;

    void Start()
    {
        // 처음엔 전부 비활성화
        foreach (var goal in _goals)
            goal.SetActive(false);
        
        ActivateRandomGoal();
    }

    void Update()
    {
        _timer += Time.deltaTime;
        if (_currentGoalAnim != null)
        {
            float ratio = _timer / _changeTime;  // 0(방금 활성화) → 1(사라지기 직전)
            _currentGoalAnim.SetFloat("FadeRatio", ratio);
        }

        if (_timer >= _changeTime)
        {
            ActivateRandomGoal(); // N초 후 자동 변경
        }
        _timerbar.UpdateTimer(_timer, _changeTime);
    }

    public void ActivateRandomGoal()
    {
        _timer = 0f;

        // 현재 골인지점 비활성화
        if (_currentIndex >= 0)
            _goals[_currentIndex].SetActive(false);

        // 현재랑 다른 인덱스 뽑기
        int newIndex;
        do
        {
            newIndex = Random.Range(0, _goals.Length);
        } while (newIndex == _currentIndex); // 같은 곳 연속 방지

        _currentIndex = newIndex;
        _goals[_currentIndex].SetActive(true);
        // ★ 추가: 새로 활성화된 골인지점의 Animator 가져오기
        _currentGoalAnim = _goals[_currentIndex]
                           .GetComponentInChildren<Animator>();

        // ★ 추가: 새로 활성화될 때 비율 0으로 리셋
        if (_currentGoalAnim != null)
            _currentGoalAnim.SetFloat("FadeRatio", 0f);
    }
}
