using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] TransformMove _hero;
    [SerializeField] GameObject _canvas;
    [SerializeField] float _speed;

    Vector3 _moveVector;

    private void Update()
    {
        Follow();

    }

    public void Follow()
    {
        // 목표 방향 구하기
        Vector3 dir = (_hero.transform.position - transform.position).normalized;

        _moveVector = dir * _speed;

        //// 목표 방향으로 이동
        transform.Translate(_moveVector * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 플레이어 태그 확인
        if (collision.gameObject.tag == "Player")
        {
            if (_canvas != null)
            {
                _canvas.SetActive(true); // Canvas 활성화
                Time.timeScale = 0;
            }
        }
    }
    

}
