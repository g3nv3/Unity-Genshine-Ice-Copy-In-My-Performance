
using UnityEngine;

public class Ice : MonoBehaviour
{
    [SerializeField] private float _lifeTime;
    private float startLifeTime;
    [SerializeField] private Animator _animator;
    [SerializeField] private Collider _collider;

    private void Start()
    {
        startLifeTime = _lifeTime;
    }
    private void Update()
    {
        _lifeTime -= Time.deltaTime;
        if (_lifeTime < startLifeTime / 4f)
            _animator.SetTrigger("Destroy");
        if (_lifeTime <= 0)
            Destroy(gameObject);
    }

    private void Spawn()
    {
        _collider.enabled = true;
    }

    private void Destroy()
    {
        _collider.enabled = false;
    }
}
