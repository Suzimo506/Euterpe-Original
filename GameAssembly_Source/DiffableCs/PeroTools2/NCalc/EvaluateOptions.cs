namespace NCalc;

[Flags]
public enum EvaluateOptions
{
	None = 1,
	IgnoreCase = 2,
	NoCache = 4,
	IterateParameters = 8,
	RoundAwayFromZero = 16,
	MatchStringsWithIgnoreCase = 32,
	MatchStringsOrdinal = 64,
	OverflowProtection = 128,
	BooleanCalculation = 256,
	UseDoubleForAbsFunction = 512,
	AllowNullParameter = 1024,
}

