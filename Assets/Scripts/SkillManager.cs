//using UnityEngine;

//public class SkillManager : MonoBehaviour
//{
//    public Weapon weapon;

//    public void LevelUp()
//    {
//        // ������ �� 3���� ������ �� ������ ����
//        SkillType[] availableSkills = { SkillType.Cone, SkillType.Linear, SkillType.Area };
//        SkillType selectedSkill = availableSkills[Random.Range(0, availableSkills.Length)];

//        if (weapon.currentSkillType == SkillType.Single)
//        {
//            // ���ο� ��ų ȹ��
//            weapon.Init(selectedSkill, weapon.currentAttribute);
//        }
//        else
//        {
//            // ���� ��ų ���׷��̵�
//            weapon.UpgradeSkill(5f, 0.1f, 2f, 1); // ������ ����, ��Ÿ�� ����, ���� ����, ����ü �߰�
//        }
//    }
//}

