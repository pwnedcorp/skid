using System;
using System.IO;

// Token: 0x02000020 RID: 32
public class 083914F5
{
	// Token: 0x060000DC RID: 220 RVA: 0x00120BB4 File Offset: 0x00076FB4
	public 083914F5()
	{
		this.17EC7C79 = uint.MaxValue;
		int num = 0;
		while ((long)num < 4L)
		{
			this.41130D02[num] = new 64F81A12(6);
			num++;
		}
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00120CAC File Offset: 0x000770AC
	private void 2A95132D(uint 15F51D82)
	{
		if (this.17EC7C79 != 15F51D82)
		{
			this.17EC7C79 = 15F51D82;
			this.643279DB = Math.Max(this.17EC7C79, 1U);
			uint 5EFD3E = Math.Max(this.643279DB, 4096U);
			this.390F4758.42664386(5EFD3E);
		}
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00120CFC File Offset: 0x000770FC
	private void 062B6B50(int 038C18CC, int 0AA14951)
	{
		if (038C18CC > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (0AA14951 > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		this.6A5218BD.54623839(038C18CC, 0AA14951);
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00120D30 File Offset: 0x00077130
	private void 74391862(int 15E406B8)
	{
		if (15E406B8 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = 1U << 15E406B8;
		this.6C4D5EAB.53380EA3(num);
		this.433E60EE.53380EA3(num);
		this.6B9372C5 = num - 1U;
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x00120D78 File Offset: 0x00077178
	private void 77691F3B(Stream 1F470866, Stream 18D71789)
	{
		this.7BFC3F82.08571A2D(1F470866);
		this.390F4758.483A7C52(18D71789, false);
		for (uint num = 0U; num < 12U; num += 1U)
		{
			for (uint num2 = 0U; num2 <= this.6B9372C5; num2 += 1U)
			{
				uint num3 = (num << 4) + num2;
				this.10CB48D6[(int)num3].18DB1CFC();
				this.7CD3487F[(int)num3].18DB1CFC();
			}
			this.5EB65DFF[(int)num].18DB1CFC();
			this.6C956DEE[(int)num].18DB1CFC();
			this.2B441511[(int)num].18DB1CFC();
			this.0071596D[(int)num].18DB1CFC();
		}
		this.6A5218BD.658B4002();
		for (uint num = 0U; num < 4U; num += 1U)
		{
			this.41130D02[(int)num].5AF00DC0();
		}
		for (uint num = 0U; num < 114U; num += 1U)
		{
			this.6EE70410[(int)num].18DB1CFC();
		}
		this.6C4D5EAB.6CF27FC1();
		this.433E60EE.6CF27FC1();
		this.30395441.5AF00DC0();
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00120EA8 File Offset: 0x000772A8
	public void 22C10A2D(Stream 1111728E, Stream 170E7518, long 450970FB)
	{
		this.77691F3B(1111728E, 170E7518);
		1F6C3896.35373901 <<EMPTY_NAME>> = default(1F6C3896.35373901);
		<<EMPTY_NAME>>.5FA72997();
		uint num = 0U;
		uint num2 = 0U;
		uint num3 = 0U;
		uint num4 = 0U;
		ulong num5 = 0UL;
		if (num5 < (ulong)450970FB)
		{
			if (this.10CB48D6[(int)((int)<<EMPTY_NAME>>.56FC76CC << 4)].65A0660C(this.7BFC3F82) != 0U)
			{
				throw new InvalidDataException("IsMatchDecoders");
			}
			<<EMPTY_NAME>>.564F2404();
			byte 3B477DC = this.6A5218BD.7ADB5B62(this.7BFC3F82, 0U, 0);
			this.390F4758.2C6F17F0(3B477DC);
			num5 += 1UL;
		}
		while (num5 < (ulong)450970FB)
		{
			uint num6 = (uint)num5 & this.6B9372C5;
			if (this.10CB48D6[(int)((<<EMPTY_NAME>>.56FC76CC << 4) + num6)].65A0660C(this.7BFC3F82) == 0U)
			{
				byte b = this.390F4758.551272AF(0U);
				byte 3B477DC2;
				if (!<<EMPTY_NAME>>.520959D7())
				{
					3B477DC2 = this.6A5218BD.05B65A73(this.7BFC3F82, (uint)num5, b, this.390F4758.551272AF(num));
				}
				else
				{
					3B477DC2 = this.6A5218BD.7ADB5B62(this.7BFC3F82, (uint)num5, b);
				}
				this.390F4758.2C6F17F0(3B477DC2);
				<<EMPTY_NAME>>.564F2404();
				num5 += 1UL;
			}
			else
			{
				uint num8;
				if (this.5EB65DFF[(int)<<EMPTY_NAME>>.56FC76CC].65A0660C(this.7BFC3F82) == 1U)
				{
					if (this.6C956DEE[(int)<<EMPTY_NAME>>.56FC76CC].65A0660C(this.7BFC3F82) == 0U)
					{
						if (this.7CD3487F[(int)((<<EMPTY_NAME>>.56FC76CC << 4) + num6)].65A0660C(this.7BFC3F82) == 0U)
						{
							<<EMPTY_NAME>>.78166F67();
							this.390F4758.2C6F17F0(this.390F4758.551272AF(num));
							num5 += 1UL;
							continue;
						}
					}
					else
					{
						uint num7;
						if (this.2B441511[(int)<<EMPTY_NAME>>.56FC76CC].65A0660C(this.7BFC3F82) == 0U)
						{
							num7 = num2;
						}
						else
						{
							if (this.0071596D[(int)<<EMPTY_NAME>>.56FC76CC].65A0660C(this.7BFC3F82) == 0U)
							{
								num7 = num3;
							}
							else
							{
								num7 = num4;
								num4 = num3;
							}
							num3 = num2;
						}
						num2 = num;
						num = num7;
					}
					num8 = this.433E60EE.5FCD512C(this.7BFC3F82, num6) + 2U;
					<<EMPTY_NAME>>.2A9F25E7();
				}
				else
				{
					num4 = num3;
					num3 = num2;
					num2 = num;
					num8 = 2U + this.6C4D5EAB.5FCD512C(this.7BFC3F82, num6);
					<<EMPTY_NAME>>.24FB72C1();
					uint num9 = this.41130D02[(int)1F6C3896.1DA45349(num8)].13426E55(this.7BFC3F82);
					if (num9 >= 4U)
					{
						int num10 = (int)((num9 >> 1) - 1U);
						num = (2U | (num9 & 1U)) << num10;
						if (num9 < 14U)
						{
							num += 64F81A12.0A303C15(this.6EE70410, num - num9 - 1U, this.7BFC3F82, num10);
						}
						else
						{
							num += this.7BFC3F82.1CCE1CC9(num10 - 4) << 4;
							num += this.30395441.0A042130(this.7BFC3F82);
						}
					}
					else
					{
						num = num9;
					}
				}
				if ((ulong)num >= (ulong)this.390F4758.7CFE3988 + num5 || num >= this.643279DB)
				{
					if (num != 4294967295U)
					{
						throw new InvalidDataException("rep0");
					}
					break;
				}
				else
				{
					this.390F4758.7AD43943(num, num8);
					num5 += (ulong)num8;
				}
			}
		}
		this.390F4758.247F10AC();
		this.390F4758.4A1E5072();
		this.7BFC3F82.5CB33FFA();
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x0012123C File Offset: 0x0007763C
	public void 15252AFA(byte[] 4C0247C9)
	{
		if (4C0247C9.Length < 5)
		{
			throw new ArgumentException("properties.Length < 5");
		}
		int 0AA = (int)(4C0247C9[0] % 9);
		byte b = 4C0247C9[0] / 9;
		int 038C18CC = (int)(b % 5);
		int num = (int)(b / 5);
		if (num > 4)
		{
			throw new ArgumentException("pb > Base.kNumPosStatesBitsMax");
		}
		uint num2 = 0U;
		for (int i = 0; i < 4; i++)
		{
			num2 += (uint)((uint)4C0247C9[1 + i] << i * 8);
		}
		this.2A95132D(num2);
		this.062B6B50(038C18CC, 0AA);
		this.74391862(num);
	}

	// Token: 0x04000092 RID: 146
	private uint 718C11E9 = 1U;

	// Token: 0x04000093 RID: 147
	private readonly 40942835 390F4758 = new 40942835();

	// Token: 0x04000094 RID: 148
	private readonly 2AD331A9 7BFC3F82 = new 2AD331A9();

	// Token: 0x04000095 RID: 149
	private readonly 1F4B036F[] 10CB48D6 = new 1F4B036F[192];

	// Token: 0x04000096 RID: 150
	private readonly 1F4B036F[] 5EB65DFF = new 1F4B036F[12];

	// Token: 0x04000097 RID: 151
	private readonly 1F4B036F[] 6C956DEE = new 1F4B036F[12];

	// Token: 0x04000098 RID: 152
	private readonly 1F4B036F[] 2B441511 = new 1F4B036F[12];

	// Token: 0x04000099 RID: 153
	private readonly 1F4B036F[] 0071596D = new 1F4B036F[12];

	// Token: 0x0400009A RID: 154
	private readonly 1F4B036F[] 7CD3487F = new 1F4B036F[192];

	// Token: 0x0400009B RID: 155
	private readonly 64F81A12[] 41130D02 = new 64F81A12[4];

	// Token: 0x0400009C RID: 156
	private readonly 1F4B036F[] 6EE70410 = new 1F4B036F[114];

	// Token: 0x0400009D RID: 157
	private 64F81A12 30395441 = new 64F81A12(4);

	// Token: 0x0400009E RID: 158
	private readonly 083914F5.12D048D8 6C4D5EAB = new 083914F5.12D048D8();

	// Token: 0x0400009F RID: 159
	private readonly 083914F5.12D048D8 433E60EE = new 083914F5.12D048D8();

	// Token: 0x040000A0 RID: 160
	private readonly 083914F5.1FA43559 6A5218BD = new 083914F5.1FA43559();

	// Token: 0x040000A1 RID: 161
	private uint 17EC7C79;

	// Token: 0x040000A2 RID: 162
	private uint 643279DB;

	// Token: 0x040000A3 RID: 163
	private uint 6B9372C5;

	// Token: 0x02000048 RID: 72
	private class 12D048D8
	{
		// Token: 0x0600027A RID: 634 RVA: 0x00126730 File Offset: 0x0007CB30
		public void 53380EA3(uint 77B84688)
		{
			for (uint num = this.7FBA53FC; num < 77B84688; num += 1U)
			{
				this.78055009[(int)num] = new 64F81A12(3);
				this.5E583BC6[(int)num] = new 64F81A12(3);
			}
			this.7FBA53FC = 77B84688;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00126780 File Offset: 0x0007CB80
		public void 6CF27FC1()
		{
			this.4AF33DD0.18DB1CFC();
			for (uint num = 0U; num < this.7FBA53FC; num += 1U)
			{
				this.78055009[(int)num].5AF00DC0();
				this.5E583BC6[(int)num].5AF00DC0();
			}
			this.0A095F60.18DB1CFC();
			this.68193C3A.5AF00DC0();
		}

		// Token: 0x0600027C RID: 636 RVA: 0x001267E8 File Offset: 0x0007CBE8
		public uint 5FCD512C(2AD331A9 3B6F7EA1, uint 3D8B5CC0)
		{
			if (this.4AF33DD0.65A0660C(3B6F7EA1) == 0U)
			{
				return this.78055009[(int)3D8B5CC0].13426E55(3B6F7EA1);
			}
			uint num = 8U;
			if (this.0A095F60.65A0660C(3B6F7EA1) == 0U)
			{
				num += this.5E583BC6[(int)3D8B5CC0].13426E55(3B6F7EA1);
			}
			else
			{
				num += 8U;
				num += this.68193C3A.13426E55(3B6F7EA1);
			}
			return num;
		}

		// Token: 0x040000EE RID: 238
		private 1F4B036F 4AF33DD0;

		// Token: 0x040000EF RID: 239
		private 1F4B036F 0A095F60;

		// Token: 0x040000F0 RID: 240
		private readonly 64F81A12[] 78055009 = new 64F81A12[16];

		// Token: 0x040000F1 RID: 241
		private readonly 64F81A12[] 5E583BC6 = new 64F81A12[16];

		// Token: 0x040000F2 RID: 242
		private 64F81A12 68193C3A = new 64F81A12(8);

		// Token: 0x040000F3 RID: 243
		private uint 7FBA53FC;
	}

	// Token: 0x02000049 RID: 73
	private class 1FA43559
	{
		// Token: 0x0600027E RID: 638 RVA: 0x0012688C File Offset: 0x0007CC8C
		public void 54623839(int 7ABC3153, int 2E6C5EF2)
		{
			if (this.38D04756 != null && this.1324760A == 2E6C5EF2 && this.351A508F == 7ABC3153)
			{
				return;
			}
			this.351A508F = 7ABC3153;
			this.046E658B = (1U << 7ABC3153) - 1U;
			this.1324760A = 2E6C5EF2;
			uint num = 1U << this.1324760A + this.351A508F;
			this.38D04756 = new 083914F5.1FA43559.6837504A[num];
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.38D04756[(int)num2].67CD0A81();
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0012691C File Offset: 0x0007CD1C
		public void 658B4002()
		{
			uint num = 1U << this.1324760A + this.351A508F;
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.38D04756[(int)num2].1D5D0FD6();
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00126960 File Offset: 0x0007CD60
		private uint 028719AB(uint 76A011C8, byte 3FE40443)
		{
			return ((76A011C8 & this.046E658B) << this.1324760A) + (uint)(3FE40443 >> 8 - this.1324760A);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00126984 File Offset: 0x0007CD84
		public byte 7ADB5B62(2AD331A9 22C03D6C, uint 202E6008, byte 26C94386)
		{
			return this.38D04756[(int)this.028719AB(202E6008, 26C94386)].237222F7(22C03D6C);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x001269A0 File Offset: 0x0007CDA0
		public byte 05B65A73(2AD331A9 4E812D6A, uint 66D27720, byte 13D20B5B, byte 58923F68)
		{
			return this.38D04756[(int)this.028719AB(66D27720, 13D20B5B)].43105DB9(4E812D6A, 58923F68);
		}

		// Token: 0x040000F4 RID: 244
		private uint 21A5701E = 1U;

		// Token: 0x040000F5 RID: 245
		private 083914F5.1FA43559.6837504A[] 38D04756;

		// Token: 0x040000F6 RID: 246
		private int 1324760A;

		// Token: 0x040000F7 RID: 247
		private int 351A508F;

		// Token: 0x040000F8 RID: 248
		private uint 046E658B;

		// Token: 0x0200004A RID: 74
		private struct 6837504A
		{
			// Token: 0x06000284 RID: 644 RVA: 0x001269D0 File Offset: 0x0007CDD0
			public void 67CD0A81()
			{
				this.4BB33C10 = new 1F4B036F[768];
			}

			// Token: 0x06000285 RID: 645 RVA: 0x001269E4 File Offset: 0x0007CDE4
			public void 1D5D0FD6()
			{
				for (int i = 0; i < 768; i++)
				{
					this.4BB33C10[i].18DB1CFC();
				}
			}

			// Token: 0x06000286 RID: 646 RVA: 0x00126A18 File Offset: 0x0007CE18
			public byte 237222F7(2AD331A9 580E188D)
			{
				uint num = 1U;
				do
				{
					num = (num << 1 | this.4BB33C10[(int)num].65A0660C(580E188D));
				}
				while (num < 256U);
				return (byte)num;
			}

			// Token: 0x06000287 RID: 647 RVA: 0x00126A4C File Offset: 0x0007CE4C
			public byte 43105DB9(2AD331A9 5D497E5C, byte 077A388F)
			{
				uint num = 1U;
				for (;;)
				{
					uint num2 = (uint)(077A388F >> 7 & 1);
					077A388F = (byte)(077A388F << 1);
					uint num3 = this.4BB33C10[(int)((1U + num2 << 8) + num)].65A0660C(5D497E5C);
					num = (num << 1 | num3);
					if (num2 != num3)
					{
						break;
					}
					if (num >= 256U)
					{
						goto IL_6B;
					}
				}
				while (num < 256U)
				{
					num = (num << 1 | this.4BB33C10[(int)num].65A0660C(5D497E5C));
				}
				IL_6B:
				return (byte)num;
			}

			// Token: 0x040000F9 RID: 249
			private 1F4B036F[] 4BB33C10;
		}
	}
}
