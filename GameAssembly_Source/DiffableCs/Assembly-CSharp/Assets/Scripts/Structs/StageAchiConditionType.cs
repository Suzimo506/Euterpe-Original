namespace Assets.Scripts.Structs;

[Flags]
internal enum StageAchiConditionType
{
	None = 0,
	Punch = 1,
	Score = 2,
	Judge = 4,
	Evaluate = 8,
	Fever = 16,
	Hurt = 32,
	Combo = 64,
	Count = 7,
}

