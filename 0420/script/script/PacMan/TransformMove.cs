using UnityEngine;

public class TransformMove : MonoBehaviour
{
    [SerializeField] SpriteRenderer _renderer;
    [SerializeField] float _speed;


    private void Update()
    {
        Mover();
    }

    public void Mover()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        
        transform.Translate(inputX * _speed * Time.deltaTime, 0, 0);
        transform.Translate(0, inputY * _speed * Time.deltaTime, 0);

        if (inputX > 0)
        {
            // 스프라이트 렌더러의 Flip X 값을 false
            _renderer.flipX = false;
        }
        else if (inputX < 0)
        {
            // 스프라이트 렌더러의 Flip X 값을 true
            _renderer.flipX = true;
        }

    }
   

}
