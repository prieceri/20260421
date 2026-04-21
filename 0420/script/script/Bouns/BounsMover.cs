using UnityEngine;
using UnityEngine.UI;


public class BounsMover : MonoBehaviour
{
    [Header("----- ÄÄÆ÷³ÍÆ® -----")]
    [SerializeField] Rigidbody2D _rigid;
    [SerializeField] Jumpbar _view;



    [Header("----- ½ºÅÝ -----")]
    [SerializeField] float _power;      // Á¡ÇÁ Èû
    [SerializeField] float _cooltime;   // Á¡ÇÁ ÄðÅ¸ÀÓ
    [SerializeField] float _duration;   // Áö¼Ó½Ã°£
    [SerializeField] float _timer;      // Å¸ÀÌ¸Ó

    public float CoolTime => _cooltime;
    public float Timer => _timer;

    private void Initialize(Jumpbar view)
    {
        view = _view;
    }


    private void Start()
    {
        _timer = _cooltime;
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer < _cooltime)
            _view?.UpdateJP(_timer, _cooltime);

        HandleBous();
    }
    
    public void HandleBous()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (_timer >= _cooltime)
            {
                _timer = 0;
                Jump();
            }
        }
    }

    public void Jump()
    {
        _rigid.AddForceY(_power, ForceMode2D.Impulse);

    }
}

