using System;

// Token: 0x02000091 RID: 145
internal struct 1F4B036F__0
{
	// Token: 0x06000504 RID: 1284
	public void 18DB1CFC()
	{
		this.1CA15064 = 1024U;
	}

	// Token: 0x06000505 RID: 1285
	public uint 65A0660C(2AD331A9__0 096E564B)
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

	// Token: 0x040001E7 RID: 487
	private const int 1BDC131E = 11;

	// Token: 0x040001E8 RID: 488
	private const uint 3025009E = 2048U;

	// Token: 0x040001E9 RID: 489
	private const int 48B8734B = 5;

	// Token: 0x040001EA RID: 490
	private uint 1CA15064;
}
