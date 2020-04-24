using System;

// Token: 0x0200008A RID: 138
internal abstract class 1F6C3896__0
{
	// Token: 0x060004E3 RID: 1251
	public static uint 1DA45349(uint 609C57CD)
	{
		609C57CD -= 2U;
		if (609C57CD < 4U)
		{
			return 609C57CD;
		}
		return 3U;
	}

	// Token: 0x060004E4 RID: 1252
	protected 1F6C3896__0()
	{
		uint num = 2076644517U;
		do
		{
			num *= 1861359567U;
			base..ctor();
		}
		while (num + 288425562U == 0U);
	}

	// Token: 0x040001B3 RID: 435
	public const uint 56EA24F4 = 12U;

	// Token: 0x040001B4 RID: 436
	public const int 2C63065F = 6;

	// Token: 0x040001B5 RID: 437
	private const int 18BC6D24 = 2;

	// Token: 0x040001B6 RID: 438
	public const uint 48207E81 = 4U;

	// Token: 0x040001B7 RID: 439
	public const uint 558B3156 = 2U;

	// Token: 0x040001B8 RID: 440
	public const int 4CEB383A = 4;

	// Token: 0x040001B9 RID: 441
	public const uint 1B542563 = 4U;

	// Token: 0x040001BA RID: 442
	public const uint 45CC5EC4 = 14U;

	// Token: 0x040001BB RID: 443
	public const uint 43756C02 = 128U;

	// Token: 0x040001BC RID: 444
	public const int 7E2A3535 = 4;

	// Token: 0x040001BD RID: 445
	public const uint 54BF408F = 16U;

	// Token: 0x040001BE RID: 446
	public const int 14862E5F = 3;

	// Token: 0x040001BF RID: 447
	public const int 4BCC6E0B = 3;

	// Token: 0x040001C0 RID: 448
	public const int 25693BF4 = 8;

	// Token: 0x040001C1 RID: 449
	public const uint 3D933763 = 8U;

	// Token: 0x040001C2 RID: 450
	public const uint 229A18EE = 8U;

	// Token: 0x0200008B RID: 139
	public struct 35373901
	{
		// Token: 0x060004E5 RID: 1253
		public void 5FA72997()
		{
			this.56FC76CC = 0U;
		}

		// Token: 0x060004E6 RID: 1254
		public void 564F2404()
		{
			if (this.56FC76CC < 4U)
			{
				this.56FC76CC = 0U;
				return;
			}
			if (this.56FC76CC < 10U)
			{
				this.56FC76CC -= 3U;
				return;
			}
			this.56FC76CC -= 6U;
		}

		// Token: 0x060004E7 RID: 1255
		public void 24FB72C1()
		{
			this.56FC76CC = ((this.56FC76CC < 7U) ? 7U : 10U);
		}

		// Token: 0x060004E8 RID: 1256
		public void 2A9F25E7()
		{
			this.56FC76CC = ((this.56FC76CC < 7U) ? 8U : 11U);
		}

		// Token: 0x060004E9 RID: 1257
		public void 78166F67()
		{
			this.56FC76CC = ((this.56FC76CC < 7U) ? 9U : 11U);
		}

		// Token: 0x060004EA RID: 1258
		public bool 520959D7()
		{
			return this.56FC76CC < 7U;
		}

		// Token: 0x040001C3 RID: 451
		public uint 56FC76CC;
	}
}
