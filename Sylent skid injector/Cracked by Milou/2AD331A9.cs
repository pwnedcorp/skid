using System;
using System.IO;

// Token: 0x02000021 RID: 33
internal class 2AD331A9
{
	// Token: 0x060000E3 RID: 227 RVA: 0x001212C4 File Offset: 0x000776C4
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

	// Token: 0x060000E4 RID: 228 RVA: 0x00121314 File Offset: 0x00077714
	public void 5CB33FFA()
	{
		this.65061694 = null;
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00121320 File Offset: 0x00077720
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

	// Token: 0x040000A4 RID: 164
	private uint 49A77407 = 1U;

	// Token: 0x040000A5 RID: 165
	public const uint 32745EF3 = 16777216U;

	// Token: 0x040000A6 RID: 166
	public uint 00CE4925;

	// Token: 0x040000A7 RID: 167
	public uint 3A9B4A3B;

	// Token: 0x040000A8 RID: 168
	public Stream 65061694;
}
