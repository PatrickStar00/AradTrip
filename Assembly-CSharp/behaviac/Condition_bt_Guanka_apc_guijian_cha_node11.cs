﻿using System;

namespace behaviac
{
	// Token: 0x02002A3B RID: 10811
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Guanka_apc_guijian_cha_node11 : Condition
	{
		// Token: 0x06013DA2 RID: 81314 RVA: 0x005F27C9 File Offset: 0x005F0BC9
		public Condition_bt_Guanka_apc_guijian_cha_node11()
		{
			this.opl_p0 = BE_Target.Enemy;
			this.opl_p1 = BE_Equal.NotEqual;
			this.opl_p2 = BE_State.DAODI;
		}

		// Token: 0x06013DA3 RID: 81315 RVA: 0x005F27E8 File Offset: 0x005F0BE8
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckState(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400D814 RID: 55316
		private BE_Target opl_p0;

		// Token: 0x0400D815 RID: 55317
		private BE_Equal opl_p1;

		// Token: 0x0400D816 RID: 55318
		private BE_State opl_p2;
	}
}
