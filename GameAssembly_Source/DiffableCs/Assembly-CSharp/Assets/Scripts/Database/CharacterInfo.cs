namespace Assets.Scripts.Database;

public class CharacterInfo : BaseDataObject
{
	public string characterName; //Field offset: 0x20
	public string cosName; //Field offset: 0x28
	public string description; //Field offset: 0x30
	public string defaultHP; //Field offset: 0x38
	public string skillName; //Field offset: 0x40
	public string skill; //Field offset: 0x48
	public string chipName; //Field offset: 0x50
	public string chipDescription; //Field offset: 0x58
	public string cv; //Field offset: 0x60
	public int chipAmount; //Field offset: 0x68
	public string chipImage; //Field offset: 0x70
	public string mainShow; //Field offset: 0x78
	public string battleShow; //Field offset: 0x80
	public string feverShow; //Field offset: 0x88
	public string atkFxGreat; //Field offset: 0x90
	public string atkFxPerfect; //Field offset: 0x98
	public string atkFxCrit; //Field offset: 0xA0
	public string victoryShow; //Field offset: 0xA8
	public string failShow; //Field offset: 0xB0
	public string bgm; //Field offset: 0xB8
	public int unlockType; //Field offset: 0xC0
	public int unlockCount; //Field offset: 0xC4
	public string rarity; //Field offset: 0xC8
	public bool free; //Field offset: 0xD0
	public bool hide; //Field offset: 0xD1
	public int order; //Field offset: 0xD4
	public List<RoleSkin> skins; //Field offset: 0xD8
	public List<Expression> expressions; //Field offset: 0xE0
	public List<Expression> reviewExpressions; //Field offset: 0xE8
	public List<Expression> catExpressions; //Field offset: 0xF0

	public CharacterInfo() { }

	public List<Expression> GetExpression(bool isCat = false) { }

	public RoleSkin GetSkin(int skinIndex) { }

	private void SetExpression(List<Expression> expr, List<List`1<String>> localExpr) { }

}

