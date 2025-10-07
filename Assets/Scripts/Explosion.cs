using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private Handler _handler;
    [SerializeField] private float _explosionRadius;
    [SerializeField] private float _explosionForce;

    private void OnEnable()
    {
        _handler.Explosion += Explode;
    }

    private void OnDisable()
    {
        _handler.Explosion -= Explode;
    }

    private void OnMouseUpAsButton()
    {
        Explode();
        Destroy(gameObject);
    }

    private void Explode()
    {
        foreach (Rigidbody hit in GetExplodadbleObjects())
            hit.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
    }

    private List<Rigidbody> GetExplodadbleObjects()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, _explosionRadius);

        List<Rigidbody> cubes = new();

        foreach (Collider hit in hits)
        {
            if(hit.attachedRigidbody != null)
                cubes.Add(hit.attachedRigidbody);
        }

        return cubes;

    }
}
