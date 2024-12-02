using UnityEngine;

[System.Serializable]
public class SkillData
{
    public SkillType skillType;         // ��ų ����
    public string skillName;           // ��ų �̸�
    public Attribute attribute;        // �Ӽ�
    public float baseDamage;           // �⺻ ������
    public float range;                // �⺻ ���� (����, ���� ��)
    public int basePenetration;        // �⺻ ���� Ƚ��
    public float cooldown;             // �⺻ ��Ÿ��
    public UpgradeOptions upgradeOptions; // ���׷��̵� �ɼ�
}

// ��ų ���׷��̵� �ɼ�
[System.Serializable]
public class UpgradeOptions
{
    public bool canUpgradeDamage;      // ������ ���׷��̵� ���� ����
    public bool canUpgradeRange;       // ���� ���׷��̵� ���� ����
    public bool canUpgradeCooldown;    // ��Ÿ�� ���׷��̵� ���� ����
    public bool canUpgradeProjectileCount; // ����ü ���� ���� ���� ����
}

