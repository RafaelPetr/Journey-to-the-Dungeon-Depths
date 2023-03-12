using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetType {Single, Multiple, All}

public enum EffectType {Attribute, Immunity, Condition}

public enum DamageType {Physical, Water, Lightning, Fire, Random}

public enum ConditionType {Burn, Poison, Confusion, Paralysis, Freeze, Sleep, Stun, Random}

public enum AttributeType {Hp, Sp, Atk, Mag, PhysicalRes, WaterRes, LightningRes, FireRes, Agi, Luk, Random}

public enum AttributeModifierType {Add, Multiplier, Percent}

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
