//using UnityEngine;

//public class SkillManager : MonoBehaviour
//{
//    public Weapon weapon;

//    public void LevelUp()
//    {
//        // 레벨업 시 3가지 선택지 중 무작위 제공
//        SkillType[] availableSkills = { SkillType.Cone, SkillType.Linear, SkillType.Area };
//        SkillType selectedSkill = availableSkills[Random.Range(0, availableSkills.Length)];

//        if (weapon.currentSkillType == SkillType.Single)
//        {
//            // 새로운 스킬 획득
//            weapon.Init(selectedSkill, weapon.currentAttribute);
//        }
//        else
//        {
//            // 기존 스킬 업그레이드
//            weapon.UpgradeSkill(5f, 0.1f, 2f, 1); // 데미지 증가, 쿨타임 감소, 범위 증가, 투사체 추가
//        }
//    }
//}

