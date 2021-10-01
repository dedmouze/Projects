using UnityEngine;

public class TargetPoint : MonoBehaviour
{
    private const int _enemyLayerMask = 1 << 6;

    private static readonly Collider[] _buffer = new Collider[100];
    
    public static int BufferedCount { get; private set; }
    public Enemy Enemy { get; private set; }
    public Vector3 Position => transform.position;
    public static TargetPoint RandomBuffered => GetBuffered(Random.Range(0, BufferedCount));
    
    public static bool FillBuffer (Vector3 position, float range) 
    {
        Vector3 top = position;
        top.y += 3f;
        BufferedCount = Physics.OverlapCapsuleNonAlloc(
            position, top, range, _buffer, _enemyLayerMask
        );
        return BufferedCount > 0;
    }
    public static TargetPoint GetBuffered (int index) 
    {
        var target = _buffer[index].GetComponent<TargetPoint>();
        Debug.Assert(target != null, "Targeted non-enemy!", _buffer[0]);
        return target;
    }

    private void Awake()
    {
        Enemy = transform.root.GetComponent<Enemy>();
        Debug.Assert(Enemy != null, "Target point without Enemy root!", this);
        Debug.Assert(
            GetComponent<SphereCollider>() != null, 
            "Target point without sphere collider!", this
            );  
        Debug.Assert(gameObject.layer == 6, "Target point on wrong layer!", this);
    }
}
