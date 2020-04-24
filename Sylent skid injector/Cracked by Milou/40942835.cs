using System;
using System.IO;

// Token: 0x02000024 RID: 36
public class 40942835
{
	// Token: 0x060000EE RID: 238 RVA: 0x001215EC File Offset: 0x000779EC
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

	// Token: 0x060000EF RID: 239 RVA: 0x0012161C File Offset: 0x00077A1C
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

	// Token: 0x060000F0 RID: 240 RVA: 0x00121648 File Offset: 0x00077A48
	public void 4A1E5072()
	{
		this.247F10AC();
		this.28114F14 = null;
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00121658 File Offset: 0x00077A58
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

	// Token: 0x060000F2 RID: 242 RVA: 0x001216B8 File Offset: 0x00077AB8
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

	// Token: 0x060000F3 RID: 243 RVA: 0x00121740 File Offset: 0x00077B40
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

	// Token: 0x060000F4 RID: 244 RVA: 0x00121780 File Offset: 0x00077B80
	public byte 551272AF(uint 42644CB5)
	{
		uint num = this.629400F5 - 42644CB5 - 1U;
		if (num >= this.15EC61A8)
		{
			num += this.15EC61A8;
		}
		return this.6FDA2015[(int)num];
	}

	// Token: 0x040000AF RID: 175
	private byte[] 6FDA2015;

	// Token: 0x040000B0 RID: 176
	private uint 629400F5;

	// Token: 0x040000B1 RID: 177
	private uint 15EC61A8;

	// Token: 0x040000B2 RID: 178
	private uint 0DBD0E10;

	// Token: 0x040000B3 RID: 179
	private Stream 28114F14;

	// Token: 0x040000B4 RID: 180
	private uint 692A62FA = 1U;

	// Token: 0x040000B5 RID: 181
	public uint 7CFE3988;
}
