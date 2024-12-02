using UnityEngine;

public class Scanner : MonoBehaviour
{
    public float scanRange; // Ž�� ����
    public LayerMask targetLayer; // Ž�� ��� ���̾�
    public Transform nearestTarget; // ���� ����� Ÿ��

    private RaycastHit2D[] targets;

    private void FixedUpdate()
    {
        // Ž��
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
