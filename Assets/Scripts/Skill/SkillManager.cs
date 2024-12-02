using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public List<SkillData> allSkills; // 모든 스킬 데이터 리스트
    public GameObject skillPrefab;   // 스킬 프리팹

    // 스킬 생성 메서드
    public void CreateSkill(SkillData skillData, Vector3 position, Vector3 direction)
    {
        GameObject skillInstance = Instantiate(skillPrefab, position, Quaternion.identity);
        Skill skill = skillInstance.GetComponent<Skill>();

        // SkillData로 스킬 초기화
        skill.Init(skillData.skillType, skillData.attribute, skillData.baseDamage,
                   skillData.basePenetration, direction, skillData.range);
    }
}

