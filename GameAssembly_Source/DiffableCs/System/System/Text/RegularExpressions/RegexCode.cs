namespace System.Text.RegularExpressions;

internal sealed class RegexCode
{
	internal const int Onerep = 0; //Field offset: 0x0
	internal const int Nullcount = 26; //Field offset: 0x0
	internal const int Setcount = 27; //Field offset: 0x0
	internal const int Lazybranchcount = 29; //Field offset: 0x0
	internal const int Nullmark = 30; //Field offset: 0x0
	internal const int Setmark = 31; //Field offset: 0x0
	internal const int Capturemark = 32; //Field offset: 0x0
	internal const int Getmark = 33; //Field offset: 0x0
	internal const int Setjump = 34; //Field offset: 0x0
	internal const int Backjump = 35; //Field offset: 0x0
	internal const int Forejump = 36; //Field offset: 0x0
	internal const int Testref = 37; //Field offset: 0x0
	internal const int Goto = 38; //Field offset: 0x0
	internal const int Prune = 39; //Field offset: 0x0
	internal const int Stop = 40; //Field offset: 0x0
	internal const int ECMABoundary = 41; //Field offset: 0x0
	internal const int NonECMABoundary = 42; //Field offset: 0x0
	internal const int Mask = 63; //Field offset: 0x0
	internal const int Rtl = 64; //Field offset: 0x0
	internal const int Back = 128; //Field offset: 0x0
	internal const int Back2 = 256; //Field offset: 0x0
	internal const int Ci = 512; //Field offset: 0x0
	internal const int Lazybranchmark = 25; //Field offset: 0x0
	internal const int Branchmark = 24; //Field offset: 0x0
	internal const int Branchcount = 28; //Field offset: 0x0
	internal const int Nothing = 22; //Field offset: 0x0
	internal const int Notonerep = 1; //Field offset: 0x0
	internal const int Setrep = 2; //Field offset: 0x0
	internal const int Oneloop = 3; //Field offset: 0x0
	internal const int Notoneloop = 4; //Field offset: 0x0
	internal const int Setloop = 5; //Field offset: 0x0
	internal const int Onelazy = 6; //Field offset: 0x0
	internal const int Notonelazy = 7; //Field offset: 0x0
	internal const int Lazybranch = 23; //Field offset: 0x0
	internal const int One = 9; //Field offset: 0x0
	internal const int Notone = 10; //Field offset: 0x0
	internal const int Set = 11; //Field offset: 0x0
	internal const int Setlazy = 8; //Field offset: 0x0
	internal const int Ref = 13; //Field offset: 0x0
	internal const int Multi = 12; //Field offset: 0x0
	internal const int EndZ = 20; //Field offset: 0x0
	internal const int Start = 19; //Field offset: 0x0
	internal const int Beginning = 18; //Field offset: 0x0
	internal const int End = 21; //Field offset: 0x0
	internal const int Boundary = 16; //Field offset: 0x0
	internal const int Eol = 15; //Field offset: 0x0
	internal const int Bol = 14; //Field offset: 0x0
	internal const int Nonboundary = 17; //Field offset: 0x0
	internal Int32[] _codes; //Field offset: 0x10
	internal String[] _strings; //Field offset: 0x18
	internal int _trackcount; //Field offset: 0x20
	internal Hashtable _caps; //Field offset: 0x28
	internal int _capsize; //Field offset: 0x30
	internal RegexPrefix _fcPrefix; //Field offset: 0x38
	internal RegexBoyerMoore _bmPrefix; //Field offset: 0x40
	internal int _anchors; //Field offset: 0x48
	internal bool _rightToLeft; //Field offset: 0x4C

	internal RegexCode(Int32[] codes, List<String> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, RegexPrefix fcPrefix, int anchors, bool rightToLeft) { }

	internal static bool OpcodeBacktracks(int Op) { }

}

