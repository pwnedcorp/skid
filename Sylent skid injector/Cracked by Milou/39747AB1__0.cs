using System;
using System.Runtime.InteropServices;

// Token: 0x02000061 RID: 97
public class 39747AB1__0
{
	// Token: 0x060002DF RID: 735
	public 39747AB1__0()
	{
		if (39747AB1__0.74392380 == null)
		{
			39747AB1__0.74392380 = new uint[256];
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
				39747AB1__0.74392380[i] = num;
			}
		}
	}

	// Token: 0x060002E0 RID: 736
	public uint 4CBD73BA(IntPtr 4C0F2D1E, uint 15FB18B7)
	{
		uint num = 0U;
		int num2 = 0;
		while ((long)num2 < (long)((ulong)15FB18B7))
		{
			num = (39747AB1__0.74392380[(int)(((uint)Marshal.ReadByte(new IntPtr(4C0F2D1E.ToInt64() + (long)num2)) ^ num) & 255U)] ^ num >> 8);
			num2++;
		}
		return ~num;
	}

	// Token: 0x04000161 RID: 353
	private static uint[] 74392380;
}
