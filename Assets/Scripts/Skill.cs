using UnityEngine;

public enum SkillType { Single, Cone, Linear, Area } // ��ų ����
public enum Attribute { Water, Fire, Electric, Dark } // ĳ���� �Ӽ�

public class Skill : MonoBehaviour
{
    public SkillType skillType; // ��ų ����
    public Attribute attribute; // ĳ���� �Ӽ�
    public float damage; // ��ų ������
    public int penetration; // ���� Ƚ��
    public float range; // ��ų ���� (Cone, Area ��ų�� ���)

    private Rigidbody2D rigid;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Init(SkillType skillType, Attribute attribute, float damage, int penetration, Vector3 direction, float range = 0f)
    {
        this.skillType = skillType;
        this.attribute = attribute;
        this.damage = damage;
        this.penetration = penetration;
        this.range = range;

        SetSkillColor();

        if (penetration >= 0)
        {
            rigid.velocity = direction.normalized * 15f;
        }
    }

    private void SetSkillColor()
    {
        // �Ӽ��� ���� ��ų ���� ����
        Color color = attribute switch
        {
            Attribute.Water => Color.blue,
            Attribute.Fire => Color.red,
            Attribute.Electric => Color.yellow,
            Attribute.Dark => Color.black,
            _ => Color.white,
        };
        spriteRenderer.color = color;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Enemy") || penetration == -100) return;

        penetration--;
        if (penetration < 0)
        {
            rigid.velocity = Vector2.zero;
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Area") || penetration == -100) return;

        gameObject.SetActive(false);
    }
}



