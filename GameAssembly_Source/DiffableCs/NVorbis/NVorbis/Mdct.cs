namespace NVorbis;

internal class Mdct
{
	private static Dictionary<Int32, Mdct> _setupCache; //Field offset: 0x0
	private int _n; //Field offset: 0x10
	private int _n2; //Field offset: 0x14
	private int _n4; //Field offset: 0x18
	private int _n8; //Field offset: 0x1C
	private int _ld; //Field offset: 0x20
	private Single[] _A; //Field offset: 0x28
	private Single[] _B; //Field offset: 0x30
	private Single[] _C; //Field offset: 0x38
	private UInt16[] _bitrev; //Field offset: 0x40
	private Dictionary<Int32, Single[]> _threadLocalBuffers; //Field offset: 0x48

	private static Mdct() { }

	private Mdct(int n) { }

	private void CalcReverse(Single[] buffer) { }

	private Single[] GetBuffer() { }

	private static Mdct GetSetup(int n) { }

	private void iter_54(Single[] e, int z) { }

	public static void Reverse(Single[] samples, int sampleCount) { }

	private void step3_inner_r_loop(int lim, Single[] e, int d0, int k_off, int k1) { }

	private void step3_inner_s_loop(int n, Single[] e, int i_off, int k_off, int a, int a_off, int k0) { }

	private void step3_inner_s_loop_ld654(int n, Single[] e, int i_off, int base_n) { }

	private void step3_iter0_loop(int n, Single[] e, int i_off, int k_off) { }

}

