using System.Collections;
using UnityEngine;

public class IceController : MonoBehaviour
{
    [SerializeField] private Transform _spawnTransform;
    [SerializeField] private float _yOffset;
    [SerializeField] private GameObject _iceObject;
    [SerializeField] private Collider _iceCollider;
    private bool spawned = false;
    public void SpawnIce()
    {
        if (!spawned)
            StartCoroutine("Ice");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Water"))
            Instantiate(_iceObject, new Vector3(_spawnTransform.position.x, _yOffset, _spawnTransform.position.z), transform.rotation);

    }
    private IEnumerator Ice()
    {
        _iceCollider.enabled = true;
        spawned = true;
        yield return new WaitForSeconds(0.2f);
        _iceCollider.enabled = false;
        spawned = false;
    }
}
