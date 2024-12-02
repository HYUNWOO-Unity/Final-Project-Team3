using UnityEngine;

public class Scanner : MonoBehaviour
{
    public float scanRange; // Å½»ö ¹üÀ§
    public LayerMask targetLayer; // Å½»ö ´ë»ó ·¹ÀÌ¾î
    public Transform nearestTarget; // °¡Àå °¡±î¿î Å¸°Ù

    private RaycastHit2D[] targets;

    private void FixedUpdate()
    {
        // Å½»ö
        targets = Physics2D.CircleCastAll(transform.position, scanRange, Vector2.zero, 0, targetLayer);
        nearestTarget = GetNearestTarget();
    }

    private Transform GetNearestTarget()
    {
        Transform result = null;
        float minDistance = Mathf.Infinity;

        foreach (RaycastHit2D hit in targets)
        {
            float distance = Vector2.Distance(transform.position, hit.transform.position);

            if (distance < minDistance)
            {
                minDistance = distance;
                result = hit.transform;
            }
        }

        return result;
    }
}
