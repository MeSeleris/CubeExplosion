using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private Handler _handler;
    [SerializeField] private float _explosionRadius;
    [SerializeField] private float _explosionForce;
    //[SerializeField] private ParticleSystem _effect;

    private void OnEnable()
    {
        _handler.SpawnCube += Explode;
    }

    private void OnDisable()
    {
        _handler.SpawnCube -= Explode;
    }

    private void Explode(Cube cube)
    {
        cube.Rigidbody.AddExplosionForce(_explosionForce, cube.transform.position, _explosionRadius);
        //Instantiate(_effect, transform.position, transform.rotation);
    }
}
