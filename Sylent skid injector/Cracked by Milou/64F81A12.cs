using System;

// Token: 0x02000023 RID: 35
internal struct 64F81A12
{
	// Token: 0x060000E9 RID: 233 RVA: 0x001214B0 File Offset: 0x000778B0
	public 64F81A12(int 3664536D)
	{
		this.1F5A122A = 3664536D;
		this.0C1501EB = new 1F4B036F[1 << 3664536D];
	}

	// Token: 0x060000EA RID: 234 RVA: 0x001214CC File Offset: 0x000778CC
	public void 5AF00DC0()
	{
		uint num = 1U;
		while ((ulong)num < (ulong)(1L << (this.1F5A122A & 31)))
		{
			this.0C1501EB[(int)num].18DB1CFC();
			num += 1U;
		}
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00121508 File Offset: 0x00077908
	public uint 13426E55(2AD331A9 64A4137E)
	{
		uint num = 1U;
		for (int i = this.1F5A122A; i > 0; i--)
		{
			num = (num << 1) + this.0C1501EB[(int)num].65A0660C(64A4137E);
		}
		return num - (1U << this.1F5A122A);
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00121554 File Offset: 0x00077954
	public uint 0A042130(2AD331A9 4D224492)
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

	// Token: 0x060000ED RID: 237 RVA: 0x001215A4 File Offset: 0x000779A4
	public static uint 0A303C15(1F4B036F[] 4C5C1923, uint 3B0D5E7F, 2AD331A9 32C62B8A, int 0C274680)
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

	// Token: 0x040000AD RID: 173
	private readonly 1F4B036F[] 0C1501EB;

	// Token: 0x040000AE RID: 174
	private readonly int 1F5A122A;
}
