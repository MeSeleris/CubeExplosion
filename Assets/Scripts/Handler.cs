using System;
using UnityEngine;

public class Handler : MonoBehaviour
{
    [SerializeField] private Raycaster _raycaster;

    public event Action<Cube> SpawnCube;
    public event Action<Cube> Explosion;

    private void OnEnable()
    {
        _raycaster.Ray += Control;
    }
    private void OnDisable()
    {
        _raycaster.Ray -= Control;
    }

    private void Control(Cube cube)
    {
        int examinationNum = UnityEngine.Random.Range(0 , cube.ChanceMax);

        if(examinationNum < cube.CurrentChance)
        {
            Explosion?.Invoke(cube);
            SpawnCube?.Invoke(cube);           
        }

        Destroy(cube.gameObject);
    }
}
