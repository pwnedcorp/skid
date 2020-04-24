using System;

// Token: 0x02000019 RID: 25
public class 497710A2
{
	// Token: 0x06000056 RID: 86 RVA: 0x00112C20 File Offset: 0x00069020
	public 497710A2()
	{
		this.440561FF = 1940661593U;
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00112C34 File Offset: 0x00069034
	public uint 529E3E21(uint 3F6027BE)
	{
		uint num = 3F6027BE ^ this.440561FF;
		this.440561FF = (16D25689.1D82142A(this.440561FF, 7) ^ num);
		return num;
	}

	// Token: 0x04000068 RID: 104
	private uint 440561FF;
}
