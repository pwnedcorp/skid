using System;

// Token: 0x02000022 RID: 34
internal struct 1F4B036F
{
	// Token: 0x060000E7 RID: 231 RVA: 0x001213AC File Offset: 0x000777AC
	public void 18DB1CFC()
	{
		this.1CA15064 = 1024U;
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x001213BC File Offset: 0x000777BC
	public uint 65A0660C(2AD331A9 096E564B)
	{
		uint num = (096E564B.00CE4925 >> 11) * this.1CA15064;
		if (096E564B.3A9B4A3B < num)
		{
			096E564B.00CE4925 = num;
			this.1CA15064 += 2048U - this.1CA15064 >> 5;
			if (096E564B.00CE4925 < 16777216U)
			{
				096E564B.3A9B4A3B = (096E564B.3A9B4A3B << 8 | (uint)((byte)096E564B.65061694.ReadByte()));
				096E564B.00CE4925 <<= 8;
			}
			return 0U;
		}
		096E564B.00CE4925 -= num;
		096E564B.3A9B4A3B -= num;
		this.1CA15064 -= this.1CA15064 >> 5;
		if (096E564B.00CE4925 < 16777216U)
		{
			096E564B.3A9B4A3B = (096E564B.3A9B4A3B << 8 | (uint)((byte)096E564B.65061694.ReadByte()));
			096E564B.00CE4925 <<= 8;
		}
		return 1U;
	}

	// Token: 0x040000A9 RID: 169
	private const int 1BDC131E = 11;

	// Token: 0x040000AA RID: 170
	private const uint 3025009E = 2048U;

	// Token: 0x040000AB RID: 171
	private const int 48B8734B = 5;

	// Token: 0x040000AC RID: 172
	private uint 1CA15064;
}
