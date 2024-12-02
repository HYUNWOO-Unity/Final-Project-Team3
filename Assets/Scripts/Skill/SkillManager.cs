using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public List<SkillData> allSkills; // ��� ��ų ������ ����Ʈ
    public GameObject skillPrefab;   // ��ų ������

    // ��ų ���� �޼���
    public void CreateSkill(SkillData skillData, Vector3 position, Vector3 direction)
    {
        GameObject skillInstance = Instantiate(skillPrefab, position, Quaternion.identity);
        Skill skill = skillInstance.GetComponent<Skill>();

        // SkillData�� ��ų �ʱ�ȭ
        skill.Init(skillData.skillType, skillData.attribute, skillData.baseDamage,
                   skillData.basePenetration, direction, skillData.range);
    }
}

