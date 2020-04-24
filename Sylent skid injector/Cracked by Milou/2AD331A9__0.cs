using System;
using System.IO;

// Token: 0x02000090 RID: 144
internal class 2AD331A9__0
{
	// Token: 0x06000500 RID: 1280
	public void 08571A2D(Stream 1A1F2838)
	{
		this.65061694 = 1A1F2838;
		this.3A9B4A3B = 0U;
		this.00CE4925 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			this.3A9B4A3B = (this.3A9B4A3B << 8 | (uint)((byte)this.65061694.ReadByte()));
		}
	}

	// Token: 0x06000501 RID: 1281
	public void 5CB33FFA()
	{
		this.65061694 = null;
	}

	// Token: 0x06000502 RID: 1282
	public uint 1CCE1CC9(int 31CB66ED)
	{
		uint num = this.00CE4925;
		uint num2 = this.3A9B4A3B;
		uint num3 = 0U;
		for (int i = 31CB66ED; i > 0; i--)
		{
			num >>= 1;
			uint num4 = num2 - num >> 31;
			num2 -= (num & num4 - 1U);
			num3 = (num3 << 1 | 1U - num4);
			if (num < 16777216U)
			{
				num2 = (num2 << 8 | (uint)((byte)this.65061694.ReadByte()));
				num <<= 8;
			}
		}
		this.00CE4925 = num;
		this.3A9B4A3B = num2;
		return num3;
	}

	// Token: 0x040001E2 RID: 482
	private uint 49A77407 = 1U;

	// Token: 0x040001E3 RID: 483
	public const uint 32745EF3 = 16777216U;

	// Token: 0x040001E4 RID: 484
	public uint 00CE4925;

	// Token: 0x040001E5 RID: 485
	public uint 3A9B4A3B;

	// Token: 0x040001E6 RID: 486
	public Stream 65061694;
}
