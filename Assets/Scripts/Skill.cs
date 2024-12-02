using UnityEngine;

public enum SkillType { Single, Cone, Linear, Area } // 스킬 유형
public enum Attribute { Water, Fire, Electric, Dark } // 캐릭터 속성

public class Skill : MonoBehaviour
{
    public SkillType skillType; // 스킬 유형
    public Attribute attribute; // 캐릭터 속성
    public float damage; // 스킬 데미지
    public int penetration; // 관통 횟수
    public float range; // 스킬 범위 (Cone, Area 스킬에 사용)

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
        // 속성에 따라 스킬 색상 설정
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



