using UnityEngine;

[System.Serializable]
public class SkillData
{
    public SkillType skillType;         // 스킬 유형
    public string skillName;           // 스킬 이름
    public Attribute attribute;        // 속성
    public float baseDamage;           // 기본 데미지
    public float range;                // 기본 범위 (원뿔, 장판 등)
    public int basePenetration;        // 기본 관통 횟수
    public float cooldown;             // 기본 쿨타임
    public UpgradeOptions upgradeOptions; // 업그레이드 옵션
}

// 스킬 업그레이드 옵션
[System.Serializable]
public class UpgradeOptions
{
    public bool canUpgradeDamage;      // 데미지 업그레이드 가능 여부
    public bool canUpgradeRange;       // 범위 업그레이드 가능 여부
    public bool canUpgradeCooldown;    // 쿨타임 업그레이드 가능 여부
    public bool canUpgradeProjectileCount; // 투사체 개수 증가 가능 여부
}

