using System;
using System.IO;

// Token: 0x02000093 RID: 147
public class 40942835__0
{
	// Token: 0x0600050B RID: 1291
	public void 42664386(uint 5EFD3E12)
	{
		if (this.15EC61A8 != 5EFD3E12)
		{
			this.6FDA2015 = new byte[5EFD3E12];
		}
		this.15EC61A8 = 5EFD3E12;
		this.629400F5 = 0U;
		this.0DBD0E10 = 0U;
	}

	// Token: 0x0600050C RID: 1292
	public void 483A7C52(Stream 1A8B26EB, bool 2F991291)
	{
		this.4A1E5072();
		this.28114F14 = 1A8B26EB;
		if (!2F991291)
		{
			this.0DBD0E10 = 0U;
			this.629400F5 = 0U;
			this.7CFE3988 = 0U;
		}
	}

	// Token: 0x0600050D RID: 1293
	public void 4A1E5072()
	{
		this.247F10AC();
		this.28114F14 = null;
	}

	// Token: 0x0600050E RID: 1294
	public void 247F10AC()
	{
		uint num = this.629400F5 - this.0DBD0E10;
		if (num == 0U)
		{
			return;
		}
		this.28114F14.Write(this.6FDA2015, (int)this.0DBD0E10, (int)num);
		if (this.629400F5 >= this.15EC61A8)
		{
			this.629400F5 = 0U;
		}
		this.0DBD0E10 = this.629400F5;
	}

	// Token: 0x0600050F RID: 1295
	public void 7AD43943(uint 1F501210, uint 010567FC)
	{
		uint num = this.629400F5 - 1F501210 - 1U;
		if (num >= this.15EC61A8)
		{
			num += this.15EC61A8;
		}
		while (010567FC > 0U)
		{
			if (num >= this.15EC61A8)
			{
				num = 0U;
			}
			byte[] array = this.6FDA2015;
			uint num2 = this.629400F5;
			this.629400F5 = num2 + 1U;
			array[(int)num2] = this.6FDA2015[(int)num++];
			if (this.629400F5 >= this.15EC61A8)
			{
				this.247F10AC();
			}
			010567FC -= 1U;
		}
	}

	// Token: 0x06000510 RID: 1296
	public void 2C6F17F0(byte 3B477DC3)
	{
		byte[] array = this.6FDA2015;
		uint num = this.629400F5;
		this.629400F5 = num + 1U;
		array[(int)num] = 3B477DC3;
		if (this.629400F5 >= this.15EC61A8)
		{
			this.247F10AC();
		}
	}

	// Token: 0x06000511 RID: 1297
	public byte 551272AF(uint 42644CB5)
	{
		uint num = this.629400F5 - 42644CB5 - 1U;
		if (num >= this.15EC61A8)
		{
			num += this.15EC61A8;
		}
		return this.6FDA2015[(int)num];
	}

	// Token: 0x040001ED RID: 493
	private byte[] 6FDA2015;

	// Token: 0x040001EE RID: 494
	private uint 629400F5;

	// Token: 0x040001EF RID: 495
	private uint 15EC61A8;

	// Token: 0x040001F0 RID: 496
	private uint 0DBD0E10;

	// Token: 0x040001F1 RID: 497
	private Stream 28114F14;

	// Token: 0x040001F2 RID: 498
	private uint 692A62FA = 1U;

	// Token: 0x040001F3 RID: 499
	public uint 7CFE3988;
}
