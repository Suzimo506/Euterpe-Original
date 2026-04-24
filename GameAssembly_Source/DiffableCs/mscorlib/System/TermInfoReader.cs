namespace System;

internal class TermInfoReader
{
	private short boolSize; //Field offset: 0x10
	private short numSize; //Field offset: 0x12
	private short strOffsets; //Field offset: 0x14
	private Byte[] buffer; //Field offset: 0x18
	private int booleansOffset; //Field offset: 0x20

	public TermInfoReader(string term, string filename) { }

	public TermInfoReader(string term, Byte[] buffer) { }

	public int Get(TermInfoNumbers number) { }

	public string Get(TermInfoStrings tstr) { }

	private short GetInt16(Byte[] buffer, int offset) { }

	private string GetString(Byte[] buffer, int offset) { }

	public Byte[] GetStringBytes(TermInfoStrings tstr) { }

	private Byte[] GetStringBytes(Byte[] buffer, int offset) { }

	private void ReadHeader(Byte[] buffer, ref int position) { }

	private void ReadNames(Byte[] buffer, ref int position) { }

}

