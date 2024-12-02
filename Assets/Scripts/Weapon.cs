using System;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public SkillType currentSkillType; // 현재 장착된 스킬 타입
    public Attribute currentAttribute; // 현재 캐릭터 속성
    public float damage = 10f;
    public int count = 1;
    public float speed = 0.5f;
    public float range = 5f;

//    private float timer;
//    private Player player;

//    private void Awake()
//    {
//        player = GameManager.Instance.player;
//    }

//    private void Update()
//    {
//        timer += Time.deltaTime;

//        if (timer > speed)
//        {
//            timer = 0f;
//            Fire();
//        }
//    }

//    public void Init(SkillType skillType, Attribute attribute)
//    {
//        currentSkillType = skillType;
//        currentAttribute = attribute;
//    }

//    public void UpgradeSkill(float additionalDamage, float cooldownReduction, float rangeIncrease, int projectileIncrease)
//    {
//        damage += additionalDamage;
//        speed -= cooldownReduction;
//        range += rangeIncrease;
//        count += projectileIncrease;

//        if (speed < 0.1f) speed = 0.1f; // 최소 쿨타임 제한
//    }

//    private void Fire()
//    {
//        if (!player.scanner.nearestTarget) return;

//        Vector3 targetPos = player.scanner.nearestTarget.position;
//        Vector3 direction = (targetPos - transform.position).normalized;

//        for (int i = 0; i < count; i++)
//        {
//            Transform bullet = GameManager.Instance.pool.Get((int)currentSkillType).transform;
//            bullet.position = transform.position;

//            switch (currentSkillType)
//            {
//                case SkillType.Single:
//                    bullet.GetComponent<Skill>().Init(currentSkillType, currentAttribute, damage, 1, direction);
//                    break;

//                case SkillType.Cone:
//                    float angle = i * (range / count) - (range / 2);
//                    Vector3 rotatedDirection = Quaternion.Euler(0, 0, angle) * direction;
//                    bullet.GetComponent<Skill>().Init(currentSkillType, currentAttribute, damage, 1, rotatedDirection);
//                    break;

//                case SkillType.Linear:
//                    bullet.GetComponent<Skill>().Init(currentSkillType, currentAttribute, damage, 1, direction);
//                    break;

//                case SkillType.Area:
//                    bullet.GetComponent<Skill>().Init(currentSkillType, currentAttribute, damage, 0, Vector3.zero, range);
//                    break;
//            }
//        }
//    }
}
