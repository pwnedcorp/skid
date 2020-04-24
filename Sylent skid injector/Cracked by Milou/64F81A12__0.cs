using System;

// Token: 0x02000092 RID: 146
internal struct 64F81A12__0
{
	// Token: 0x06000506 RID: 1286
	public 64F81A12__0(int 3664536D)
	{
		this.1F5A122A = 3664536D;
		this.0C1501EB = new 1F4B036F__0[1 << 3664536D];
	}

	// Token: 0x06000507 RID: 1287
	public void 5AF00DC0()
	{
		uint num = 1U;
		while ((ulong)num < (ulong)(1L << (this.1F5A122A & 31)))
		{
			this.0C1501EB[(int)num].18DB1CFC();
			num += 1U;
		}
	}

	// Token: 0x06000508 RID: 1288
	public uint 13426E55(2AD331A9__0 64A4137E)
	{
		uint num = 1U;
		for (int i = this.1F5A122A; i > 0; i--)
		{
			num = (num << 1) + this.0C1501EB[(int)num].65A0660C(64A4137E);
		}
		return num - (1U << this.1F5A122A);
	}

	// Token: 0x06000509 RID: 1289
	public uint 0A042130(2AD331A9__0 4D224492)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < this.1F5A122A; i++)
		{
			uint num3 = this.0C1501EB[(int)num].65A0660C(4D224492);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x0600050A RID: 1290
	public static uint 0A303C15(1F4B036F__0[] 4C5C1923, uint 3B0D5E7F, 2AD331A9__0 32C62B8A, int 0C274680)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < 0C274680; i++)
		{
			uint num3 = 4C5C1923[(int)(3B0D5E7F + num)].65A0660C(32C62B8A);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x040001EB RID: 491
	private readonly 1F4B036F__0[] 0C1501EB;

	// Token: 0x040001EC RID: 492
	private readonly int 1F5A122A;
}
