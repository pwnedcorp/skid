using System;
using System.Runtime.InteropServices;

// Token: 0x02000018 RID: 24
public class 39747AB1
{
	// Token: 0x06000054 RID: 84 RVA: 0x00112B58 File Offset: 0x00068F58
	public 39747AB1()
	{
		if (39747AB1.74392380 == null)
		{
			39747AB1.74392380 = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ 3988292384U);
					}
					else
					{
						num >>= 1;
					}
				}
				39747AB1.74392380[i] = num;
			}
		}
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00112BD4 File Offset: 0x00068FD4
	public uint 4CBD73BA(IntPtr 4C0F2D1E, uint 15FB18B7)
	{
		uint num = 0U;
		int num2 = 0;
		while ((long)num2 < (long)((ulong)15FB18B7))
		{
			num = (39747AB1.74392380[(int)(((uint)Marshal.ReadByte(new IntPtr(4C0F2D1E.ToInt64() + (long)num2)) ^ num) & 255U)] ^ num >> 8);
			num2++;
		}
		return ~num;
	}

	// Token: 0x04000067 RID: 103
	private static uint[] 74392380;
}
