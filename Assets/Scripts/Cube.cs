using UnityEngine;

public class Cube : MonoBehaviour
{
    [field: SerializeField] public int ChanceMax {  get; private set; }
    [field: SerializeField] public int CurrentChance { get; private set; }
    [field: SerializeField] public int ReductionFactor { get; private set; }

    public Rigidbody Rigidbody {  get; private set; }

    private void Awake()
    {
        Rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    public void DivideChance()
    {
        CurrentChance /= Mathf.Max(1, CurrentChance / ReductionFactor);
    }

    public void SetChildChance (int parentChance)
    {
        CurrentChance = Mathf.Max(1, parentChance / ReductionFactor);
    }
}
