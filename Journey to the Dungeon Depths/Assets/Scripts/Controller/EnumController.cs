using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType {Consumable, Equipment, Key}

public enum TargetType {Single, Multiple, All}

public enum EffectType {Attribute, Damage, Immunity, Condition}

public enum DamageType {Physical, Water, Lightning, Fire, Neutral, Random}

public enum ConditionType {Burn, Poison, Confusion, Paralysis, Freeze, Sleep, Stun, Random}

public enum AttributeType {Hp, Sp, Atk, Mag, Def, MagDef, IceRes, LightningRes, FireRes, Agi, DamageType, Random}

public enum AttributeModifierType {Add, Multiplier, Percent}

public enum AttributeGrowthType {Low, Medium, High}

public enum Difficulty {Easy, Medium, Hard}

public static class EnumController {
    public static int ConvertAttribute(Creature creature, AttributeType type) {
        switch (type) {
            case AttributeType.Hp:
                //return character.GetAttributes().GetHp();
                return 0;
            default:
                return -1;
        }
    }

    public static ConditionEffect ConvertCondition(ConditionEffect condition, ConditionType type) {
        switch (type) { //switch (condition.GetType()) {
            case ConditionType.Poison:
                //return new Poison(condition.duration);
                return null;
            default:
                return null;
        }
    }
}
